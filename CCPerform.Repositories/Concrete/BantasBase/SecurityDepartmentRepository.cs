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
    public class SecurityDepartmentRepository : BaseRepository<SecurityDepartment>, ISecurityDepartmentRepository
    {
        private readonly CCPerformDB _dbcontext;

        public SecurityDepartmentRepository(CCPerformDB dbcontext) : base(dbcontext)
        {
            _dbcontext = dbcontext;
        }
    }
}
