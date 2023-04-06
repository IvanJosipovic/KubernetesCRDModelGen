using System.Diagnostics.CodeAnalysis;

namespace KubernetesCRDModelGen.Names
{
    public interface INameFormatter
    {
        //[return: NotNullIfNotNull("name")]
        string? Format(string? name);
    }
}
