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
    public class CashCenterRepository : BaseRepository<CashCenter>, ICashCenterRepository
    {
        private readonly CCPerformDB _dbcontext;

        public CashCenterRepository(CCPerformDB dbcontext) : base(dbcontext)
        {
            _dbcontext = dbcontext;
        }
    }
}
