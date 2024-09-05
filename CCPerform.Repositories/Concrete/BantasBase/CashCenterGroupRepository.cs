using CCPerform.DataAccess;
using CCPerform.Entity.BantasBase;
using CCPerform.Repositories.Abstract.BantasBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCPerform.Repositories.Concrete.BantasBase
{
    public class CashCenterGroupRepository : BaseRepository<CashCenterGroup>, ICashCenterGroupRepository
    {
        private readonly CCPerformDB _dbcontext;

        public CashCenterGroupRepository(CCPerformDB dbcontext) : base(dbcontext)
        {
            _dbcontext = dbcontext;
        }
    }
}
