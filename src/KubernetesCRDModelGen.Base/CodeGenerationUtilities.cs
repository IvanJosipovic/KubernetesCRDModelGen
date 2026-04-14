using Humanizer;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using System.Security;
using System.Text;

namespace KubernetesCRDModelGen.Base;

internal static class CodeGenerationUtilities
{
    private static readonly HashSet<char> InvalidFileNameCharacters = [.. Path.GetInvalidFileNameChars()];

    internal static string? CleanIdentifier(string name, bool @namespace = false)
    {
        if (string.IsNullOrEmpty(name))
        {
            return null;
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

        return result;
    }

    internal static SyntaxTriviaList CreateSummaryTrivia(string? text)
    {
        if (string.IsNullOrWhiteSpace(text))
        {
            return default;
        }

        var summaryText = text!;
        var normalizedText = summaryText.Replace("\r\n", "\n").Replace('\r', '\n');

        if (!normalizedText.Contains('\n'))
        {
            return SyntaxFactory.ParseLeadingTrivia($"/// <summary>{SecurityElement.Escape(normalizedText) ?? string.Empty}</summary>{Environment.NewLine}");
        }

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
        return SyntaxFactory.ParseLeadingTrivia(builder.ToString());
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
