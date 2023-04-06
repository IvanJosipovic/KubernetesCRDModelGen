using System.Collections.Generic;

namespace KubernetesCRDModelGen.Names
{
    public interface INameConverterRegistry : IDictionary<string, string>
    {
        string Convert(string name);
    }
}
