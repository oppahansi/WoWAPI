using System;
using Contracts;
using Contracts.Classic;
using Entities;

namespace Repository.Classic
{
    public class CRepositoryWrapper : IRepositoryWrapper
    {
        private CRepositoryContext _repoContext;
        //private IOwnerRepository _owner;

        private ICCreatureTemplateRepo _creatureTemplatesClassic;

        public ICCreatureTemplateRepo CreatureTemplateRepository
        {
            get
            {
                if (_creatureTemplatesClassic == null)
                {
                    _creatureTemplatesClassic = new CCreatureTemplateRepo(_repoContext);
                }

                return _creatureTemplatesClassic;
            }
        }

        /*
        public IOwnerRepository Owner
        {
            get
            {
                if (_owner == null)
                {
                    _owner = new OwnerRepository(_repoContext);
                }

                return _owner;
            }
        }

        public IAccountRepository Account
        {
            get
            {
                if (_account == null)
                {
                    _account = new AccountRepository(_repoContext);
                }

                return _account;
            }
        }*/

        public CRepositoryWrapper(CRepositoryContext repositoryContext)
        {
            _repoContext = repositoryContext;
        }
    }
}
