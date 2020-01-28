using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterzoodDAL.Infra
{
    public struct CompositeKey<T, U>
    {
        public T PK1;

        public U PK2;
    }

    public struct CompositeKey<T, U, V>
    {
        public T PK1;
        public U PK2;
        public V PK3;
    }
    
}
