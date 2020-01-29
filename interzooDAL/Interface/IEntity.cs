using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interzooDAL.Interface
{
    public interface IEntity<TKey>
        where TKey : struct
    {
        TKey Id { get; }
    }
}
