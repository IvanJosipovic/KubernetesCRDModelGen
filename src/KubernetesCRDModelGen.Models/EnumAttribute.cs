using System;

namespace KubernetesCRDModelGen.Models;

[AttributeUsage(AttributeTargets.Property)]
public class EnumAttribute : Attribute
{
    /// <summary>
    /// Enum options
    /// </summary>
    public readonly string[] Options;

    public EnumAttribute(string[] options)
    {
        Options = options;
    }
}