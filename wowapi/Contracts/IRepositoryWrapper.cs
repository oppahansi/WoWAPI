using wowapi.Contracts.Classic;

namespace wowapi.Contracts
{
    public interface IRepositoryWrapper
    {
        ICCreatureTemplateRepo CreatureTemplatesRepo { get; }
        ICCreatuteRepo CreaturesRepo { get; }
    }
}
