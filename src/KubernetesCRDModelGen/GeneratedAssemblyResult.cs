using Microsoft.CodeAnalysis;
using System.Reflection;
using System.Runtime.Loader;
using System.Xml;

namespace KubernetesCRDModelGen;

/// <summary>
/// Represents the result of generating an assembly from a CRD.
/// </summary>
public sealed class GeneratedAssemblyResult
{
    /// <summary>
    /// Initializes a new instance of the <see cref="GeneratedAssemblyResult"/> class.
    /// </summary>
    /// <param name="assembly">The generated assembly, when generation succeeds.</param>
    /// <param name="xmlDocumentation">The generated XML documentation, when generation succeeds.</param>
    /// <param name="diagnostics">The diagnostics produced during generation.</param>
    /// <param name="unloadHandle">The unload handle for the generated assembly load context.</param>
    /// <param name="exception">The exception produced during generation, when one occurs.</param>
    public GeneratedAssemblyResult(
        Assembly? assembly,
        XmlDocument? xmlDocumentation,
        IReadOnlyList<GeneratedAssemblyDiagnostic> diagnostics,
        GeneratedAssemblyUnloadHandle? unloadHandle,
        Exception? exception = null)
    {
        Assembly = assembly;
        XmlDocumentation = xmlDocumentation;
        Diagnostics = diagnostics;
        UnloadHandle = unloadHandle;
        Exception = exception;
    }

    /// <summary>
    /// Gets the generated assembly.
    /// </summary>
    public Assembly? Assembly { get; }

    /// <summary>
    /// Gets the generated XML documentation.
    /// </summary>
    public XmlDocument? XmlDocumentation { get; }

    /// <summary>
    /// Gets the diagnostics produced during generation.
    /// </summary>
    public IReadOnlyList<GeneratedAssemblyDiagnostic> Diagnostics { get; }

    /// <summary>
    /// Gets the unload handle for the generated assembly load context.
    /// </summary>
    public GeneratedAssemblyUnloadHandle? UnloadHandle { get; }

    /// <summary>
    /// Gets the exception produced during generation, when one occurs.
    /// </summary>
    public Exception? Exception { get; }

    /// <summary>
    /// Gets a value indicating whether generation succeeded.
    /// </summary>
    public bool Success => Assembly is not null && XmlDocumentation is not null && Diagnostics.All(x => x.Severity != GeneratedAssemblyDiagnosticSeverity.Error);

    /// <summary>
    /// Deconstructs the result into the generated assembly and XML documentation.
    /// </summary>
    /// <param name="assembly">The generated assembly.</param>
    /// <param name="xmlDocumentation">The generated XML documentation.</param>
    public void Deconstruct(out Assembly? assembly, out XmlDocument? xmlDocumentation)
    {
        assembly = Assembly;
        xmlDocumentation = XmlDocumentation;
    }
}

/// <summary>
/// Represents a structured diagnostic produced during assembly generation.
/// </summary>
public sealed class GeneratedAssemblyDiagnostic
{
    internal const string ExceptionDiagnosticId = "KCRDGEN001";
    internal const string OpenApiSchemaDiagnosticId = "KCRDGEN002";
    internal const string IntegerFormatDiagnosticId = "KCRDGEN003";

    /// <summary>
    /// Initializes a new instance of the <see cref="GeneratedAssemblyDiagnostic"/> class.
    /// </summary>
    /// <param name="id">The diagnostic identifier.</param>
    /// <param name="message">The diagnostic message.</param>
    /// <param name="severity">The diagnostic severity.</param>
    /// <param name="isWarningAsError">Whether the diagnostic is treated as an error.</param>
    /// <param name="filePath">The file path associated with the diagnostic.</param>
    /// <param name="line">The 1-based line number associated with the diagnostic.</param>
    /// <param name="column">The 1-based column number associated with the diagnostic.</param>
    public GeneratedAssemblyDiagnostic(
        string id,
        string message,
        GeneratedAssemblyDiagnosticSeverity severity,
        bool isWarningAsError = false,
        string? filePath = null,
        int? line = null,
        int? column = null)
    {
        Id = id;
        Message = message;
        Severity = severity;
        IsWarningAsError = isWarningAsError;
        FilePath = filePath;
        Line = line;
        Column = column;
    }

    /// <summary>
    /// Gets the diagnostic identifier.
    /// </summary>
    public string Id { get; }

    /// <summary>
    /// Gets the diagnostic message.
    /// </summary>
    public string Message { get; }

    /// <summary>
    /// Gets the diagnostic severity.
    /// </summary>
    public GeneratedAssemblyDiagnosticSeverity Severity { get; }

    /// <summary>
    /// Gets a value indicating whether the diagnostic is treated as an error.
    /// </summary>
    public bool IsWarningAsError { get; }

    /// <summary>
    /// Gets the file path associated with the diagnostic.
    /// </summary>
    public string? FilePath { get; }

    /// <summary>
    /// Gets the 1-based line number associated with the diagnostic.
    /// </summary>
    public int? Line { get; }

    /// <summary>
    /// Gets the 1-based column number associated with the diagnostic.
    /// </summary>
    public int? Column { get; }

    internal static GeneratedAssemblyDiagnostic FromRoslynDiagnostic(Diagnostic diagnostic)
    {
        string? filePath = null;
        int? line = null;
        int? column = null;

        if (diagnostic.Location != Location.None && diagnostic.Location.IsInSource)
        {
            var span = diagnostic.Location.GetLineSpan();
            filePath = string.IsNullOrWhiteSpace(span.Path) ? null : span.Path;
            line = span.StartLinePosition.Line + 1;
            column = span.StartLinePosition.Character + 1;
        }

        return new GeneratedAssemblyDiagnostic(
            diagnostic.Id,
            diagnostic.GetMessage(),
            FromRoslynSeverity(diagnostic.Severity),
            diagnostic.IsWarningAsError,
            filePath,
            line,
            column);
    }

    internal static GeneratedAssemblyDiagnostic FromException(Exception exception)
        => new(
            ExceptionDiagnosticId,
            exception.Message,
            GeneratedAssemblyDiagnosticSeverity.Error);

    internal static GeneratedAssemblyDiagnostic Create(
        string id,
        string message,
        GeneratedAssemblyDiagnosticSeverity severity,
        bool isWarningAsError = false,
        string? filePath = null,
        int? line = null,
        int? column = null)
        => new(
            id,
            message,
            severity,
            isWarningAsError,
            filePath,
            line,
            column);

    private static GeneratedAssemblyDiagnosticSeverity FromRoslynSeverity(DiagnosticSeverity severity)
        => severity switch
        {
            DiagnosticSeverity.Hidden => GeneratedAssemblyDiagnosticSeverity.Hidden,
            DiagnosticSeverity.Info => GeneratedAssemblyDiagnosticSeverity.Info,
            DiagnosticSeverity.Warning => GeneratedAssemblyDiagnosticSeverity.Warning,
            DiagnosticSeverity.Error => GeneratedAssemblyDiagnosticSeverity.Error,
            _ => throw new ArgumentOutOfRangeException(nameof(severity), severity, "Unsupported diagnostic severity.")
        };
}

/// <summary>
/// Specifies the severity of an assembly generation diagnostic.
/// </summary>
public enum GeneratedAssemblyDiagnosticSeverity
{
    /// <summary>
    /// The diagnostic is hidden.
    /// </summary>
    Hidden = 0,

    /// <summary>
    /// The diagnostic is informational.
    /// </summary>
    Info = 1,

    /// <summary>
    /// The diagnostic is a warning.
    /// </summary>
    Warning = 2,

    /// <summary>
    /// The diagnostic is an error.
    /// </summary>
    Error = 3,
}

/// <summary>
/// Provides control over unloading a generated assembly load context.
/// </summary>
public sealed class GeneratedAssemblyUnloadHandle : IDisposable
{
    private AssemblyLoadContext? assemblyLoadContext;

    internal GeneratedAssemblyUnloadHandle(AssemblyLoadContext assemblyLoadContext)
    {
        this.assemblyLoadContext = assemblyLoadContext;
    }

    /// <summary>
    /// Gets a value indicating whether the load context has been unloaded.
    /// </summary>
    public bool IsUnloaded => assemblyLoadContext is null;

    /// <summary>
    /// Unloads the generated assembly load context.
    /// </summary>
    public void Unload()
    {
        var loadContext = Interlocked.Exchange(ref assemblyLoadContext, null);
        loadContext?.Unload();
    }

    /// <inheritdoc/>
    public void Dispose()
    {
        Unload();
        GC.SuppressFinalize(this);
    }
}
