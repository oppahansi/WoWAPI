using System;
using Contracts.Classic;

namespace Contracts
{
    public interface IRepositoryWrapper
    {
        ICCreatureTemplateRepo CreatureTemplatesRepo { get; }
        ICCreatuteRepo CreaturesRepo { get; }
    }
}
