using System;
using System.Collections.Generic;

namespace KubernetesCRDModelGen;

public class DynamicType
{
    public string Name { get; set; }

    public string? Implements { get; set; }

    public string? Description { get; set; }

    public bool AddUsing { get; set; }

    public List<string> Constant { get; set; } = new List<string>();

    public List<DynamicProperty> Fields { get; set; } = new List<DynamicProperty>();

    public List<string> Attributes { get; set; } = new List<string>();

    public override string ToString()
    {
        string result = "";
        if (AddUsing)
        {
            result += "using System;\n";
            result += "using System.Runtime;\n";
            result += "using k8s;\n";
            result += "using k8s.Models;\n";
            result += "using System.ComponentModel;\n";
        }

        foreach (var attribute in Attributes)
            result += attribute + "\n";

        if (Description != null)
        {
            result += "/// <summary>\n";

            var rows = Description.Split(new string[] { "\r\n", "\r", "\n" }, StringSplitOptions.None);

            foreach (var row in rows)
            {
                result += $"/// {row}\n";
            }

            result += "/// </summary>\n";
        }

        result += "public class " + Name + (Implements != null ? ": " + Implements : "");
        result += "\n{\n";

        foreach (var constant in Constant)
            result += constant + "\n";

        foreach (var dynamicField in Fields)
            result += dynamicField;

        result += "}";

        return result;
    }
}

public class DynamicProperty
{
    public DynamicProperty(string name, string fType, bool nullable = false, string? description = null)
    {
        Name = name;
        FType = fType;
        Nullable = nullable;
        Description = description;
    }

    public string Name { get; set; }

    public string FType { get; set; }

    public bool Nullable { get; set; }

    public string? Description { get; set; }

    public override string ToString()
    {
        string output = "";

        if (Description != null)
        {
            output += "/// <summary>\n";

            var rows = Description.Split(new string[] { "\r\n", "\r", "\n" }, StringSplitOptions.None);

            foreach (var row in rows)
            {
                output += $"/// {row}\n";
            }

            output += "/// </summary>\n";
        }

        return output + "public " + FType + (Nullable ? "?" : "") + " " + Name + " {get; set;}\n";
    }
}
