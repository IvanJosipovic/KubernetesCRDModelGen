namespace KubernetesCRDModelGen.Base;

internal sealed class GeneratedCompilationUnitModel
{
    public GeneratedCompilationUnitModel(string namespaceName, string group, IReadOnlyList<GeneratedTypeModel> types)
    {
        NamespaceName = namespaceName;
        Group = group;
        Types = types;
    }

    public string NamespaceName { get; }

    public string Group { get; }

    public IReadOnlyList<GeneratedTypeModel> Types { get; }
}

internal abstract class GeneratedTypeModel
{
    protected GeneratedTypeModel(string name, string? summary)
    {
        Name = name;
        Summary = summary;
    }

    public string Name { get; }

    public string? Summary { get; }
}

internal sealed class GeneratedClassModel : GeneratedTypeModel
{
    public GeneratedClassModel(
        string name,
        string? summary,
        bool isKubernetesEntity,
        IReadOnlyList<string> baseTypes,
        IReadOnlyList<GeneratedFieldModel> fields,
        IReadOnlyList<GeneratedPropertyModel> properties) : base(name, summary)
    {
        IsKubernetesEntity = isKubernetesEntity;
        BaseTypes = baseTypes;
        Fields = fields;
        Properties = properties;
    }

    public bool IsKubernetesEntity { get; }

    public IReadOnlyList<string> BaseTypes { get; }

    public IReadOnlyList<GeneratedFieldModel> Fields { get; }

    public IReadOnlyList<GeneratedPropertyModel> Properties { get; }
}

internal sealed class GeneratedEnumModel : GeneratedTypeModel
{
    public GeneratedEnumModel(string name, string? summary, IReadOnlyList<GeneratedEnumMemberModel> members) : base(name, summary)
    {
        Members = members;
    }

    public IReadOnlyList<GeneratedEnumMemberModel> Members { get; }
}

internal sealed class GeneratedFieldModel
{
    public GeneratedFieldModel(string name, string typeName, string value)
    {
        Name = name;
        TypeName = typeName;
        Value = value;
    }

    public string Name { get; }

    public string TypeName { get; }

    public string Value { get; }
}

internal sealed class GeneratedPropertyModel
{
    public GeneratedPropertyModel(
        string name,
        string jsonName,
        string typeName,
        string? summary,
        bool isNullable = true,
        string? defaultValue = null,
        bool isRequired = false,
        bool isExtensionData = false)
    {
        Name = name;
        JsonName = jsonName;
        TypeName = typeName;
        Summary = summary;
        IsNullable = isNullable;
        DefaultValue = defaultValue;
        IsRequired = isRequired;
        IsExtensionData = isExtensionData;
    }

    public string Name { get; }

    public string JsonName { get; }

    public string TypeName { get; }

    public string? Summary { get; }

    public bool IsNullable { get; }

    public string? DefaultValue { get; }

    public bool IsRequired { get; }

    public bool IsExtensionData { get; }
}

internal sealed class GeneratedEnumMemberModel
{
    public GeneratedEnumMemberModel(string name, string value, string? summary)
    {
        Name = name;
        Value = value;
        Summary = summary;
    }

    public string Name { get; }

    public string Value { get; }

    public string? Summary { get; }
}
