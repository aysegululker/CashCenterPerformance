using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCPerform.Core.Abstract
{
    public interface IBaseEntity<T>
    {
        T ID { get; set; }
    }
}
