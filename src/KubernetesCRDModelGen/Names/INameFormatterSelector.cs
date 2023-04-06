namespace KubernetesCRDModelGen.Names
{
    public interface INameFormatterSelector
    {
        public INameFormatter GetFormatter(NameKind nameKind);
    }
}
