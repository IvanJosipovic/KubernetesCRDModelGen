using Humanizer;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Security;
using System.Text;

namespace KubernetesCRDModelGen.Base;

internal static class CodeGenerationUtilities
{
    private static readonly object CacheLock = new();
    private static readonly Dictionary<(string Name, bool Namespace), string?> CleanIdentifierCache = new();
    private static readonly Dictionary<string, SyntaxTriviaList> SummaryTriviaCache = new(StringComparer.Ordinal);
    private static readonly Dictionary<string, TypeSyntax> TypeSyntaxCache = new(StringComparer.Ordinal);
    private static readonly HashSet<char> InvalidFileNameCharacters = [.. Path.GetInvalidFileNameChars()];

    internal static string? CleanIdentifier(string name, bool @namespace = false)
    {
        if (string.IsNullOrEmpty(name))
        {
            return null;
        }

        var cacheKey = (name, @namespace);
        lock (CacheLock)
        {
            if (CleanIdentifierCache.TryGetValue(cacheKey, out var cached))
            {
                return cached;
            }
        }

        name = name.Trim();
        if (!@namespace)
        {
            name = name.Dehumanize();
        }

        if (string.IsNullOrEmpty(name))
        {
            return null;
        }

        var sb = new StringBuilder(name.Length + 1);
        if (!SyntaxFacts.IsIdentifierStartCharacter(name[0]))
        {
            sb.Append('_');
        }

        foreach (var ch in name)
        {
            if (SyntaxFacts.IsIdentifierPartCharacter(ch) || (@namespace && ch == '.'))
            {
                sb.Append(ch);
            }
        }

        var result = sb.ToString();
        if (SyntaxFacts.GetKeywordKind(result) != SyntaxKind.None)
        {
            result = '@' + result;
        }

        if (@namespace)
        {
            var namespaceBuilder = new StringBuilder(result.Length + 4);
            var start = 0;
            for (var i = 0; i <= result.Length; i++)
            {
                if (i == result.Length || result[i] == '.')
                {
                    if (namespaceBuilder.Length > 0)
                    {
                        namespaceBuilder.Append('.');
                    }

                    var chunk = result.Substring(start, i - start);
                    if (SyntaxFacts.GetKeywordKind(chunk) != SyntaxKind.None)
                    {
                        namespaceBuilder.Append('@');
                    }

                    namespaceBuilder.Append(chunk);
                    start = i + 1;
                }
            }

            result = namespaceBuilder.ToString();
        }

        lock (CacheLock)
        {
            CleanIdentifierCache[cacheKey] = result;
        }

        return result;
    }

    internal static SyntaxTriviaList CreateSummaryTrivia(string? text)
    {
        var normalizedText = text?.Replace("\r\n", "\n").Replace('\r', '\n') ?? string.Empty;
        lock (CacheLock)
        {
            if (SummaryTriviaCache.TryGetValue(normalizedText, out var cached))
            {
                return cached;
            }
        }

        SyntaxTriviaList trivia;
        if (!normalizedText.Contains('\n'))
        {
            trivia = SyntaxFactory.ParseLeadingTrivia($"/// <summary>{SecurityElement.Escape(normalizedText) ?? string.Empty}</summary>{Environment.NewLine}");
        }
        else
        {
            var builder = new StringBuilder(normalizedText.Length + 32);
            builder.Append("/// <summary>").Append(Environment.NewLine);

            var lineStart = 0;
            for (var i = 0; i <= normalizedText.Length; i++)
            {
                if (i == normalizedText.Length || normalizedText[i] == '\n')
                {
                    var line = normalizedText.Substring(lineStart, i - lineStart);
                    builder.Append("/// ").Append(SecurityElement.Escape(line) ?? string.Empty).Append(Environment.NewLine);
                    lineStart = i + 1;
                }
            }

            builder.Append("/// </summary>").Append(Environment.NewLine);
            trivia = SyntaxFactory.ParseLeadingTrivia(builder.ToString());
        }

        lock (CacheLock)
        {
            SummaryTriviaCache[normalizedText] = trivia;
        }

        return trivia;
    }

    internal static TypeSyntax GetTypeSyntax(string typeName)
    {
        lock (CacheLock)
        {
            if (TypeSyntaxCache.TryGetValue(typeName, out var cached))
            {
                return cached;
            }
        }

        var parsed = SyntaxFactory.ParseTypeName(typeName);
        lock (CacheLock)
        {
            TypeSyntaxCache[typeName] = parsed;
        }

        return parsed;
    }

    internal static string RemoveIllegalFileNameCharacters(string fileName)
    {
        if (string.IsNullOrEmpty(fileName))
        {
            throw new ArgumentException("File name cannot be null or empty", nameof(fileName));
        }

        var builder = new StringBuilder(fileName.Length);
        for (var i = 0; i < fileName.Length; i++)
        {
            var ch = fileName[i];
            if (!InvalidFileNameCharacters.Contains(ch))
            {
                builder.Append(ch);
            }
        }

        return builder.ToString();
    }
}
