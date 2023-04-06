namespace KubernetesCRDModelGen.Enrichment
{
    public interface IEnricher<TTarget> : IEnricher
    {
        TTarget Enrich(TTarget target);
    }
}
