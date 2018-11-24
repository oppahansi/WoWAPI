namespace wowapi.Contracts.Dbc
{
    public interface IDbcRepositoryWrapper
    {
         IItemSetRepo ItemSetRepo { get; }
         IItemDisplayInfoRepo ItemDisplayInfoRepo { get; }
    }
}