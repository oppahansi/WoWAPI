using System;
using Contracts;
using Contracts.Classic;
using Entities;

namespace Repository.Classic
{
    public class CRepositoryWrapper : IRepositoryWrapper
    {
        private CRepositoryContext _repoContext;

        private ICCreatureTemplateRepo _creatureTemplatesRepo;
        public ICCreatureTemplateRepo CreatureTemplatesRepo
        {
            get
            {
                if (_creatureTemplatesRepo == null)
                {
                    _creatureTemplatesRepo = new CCreatureTemplateRepo(_repoContext);
                }

                return _creatureTemplatesRepo;
            }
        }

        private ICCreatuteRepo _creaturesRepo;
        public ICCreatuteRepo CreaturesRepo
        {
            get
            {
                if (_creaturesRepo == null)
                {
                    _creaturesRepo = new CCreatureRepo(_repoContext);
                }

                return _creaturesRepo;
            }
        }


        public CRepositoryWrapper(CRepositoryContext repositoryContext)
        {
            _repoContext = repositoryContext;
        }
    }
}
