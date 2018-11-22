using wowapi.Contracts.Classic;
using wowapi.Contracts.Dbc;

namespace wowapi.Contracts.Classic
{
    public interface ICRepositoryWrapper
    {
        ICCreatureTemplateRepo CreatureTemplatesRepo { get; }
        ICCreatuteRepo CreaturesRepo { get; }
        ICItemTemplateRepo ItemTemplateRepo { get; }
    }
}
