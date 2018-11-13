using System;
using Contracts.Classic;

namespace Contracts
{
    public interface IRepositoryWrapper
    {
        ICCreatureTemplateRepo CreatureTemplateRepository { get; }
    }
}
