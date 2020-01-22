using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using interzooDAL.Interface;

namespace interzooDAL.Models
{
    public partial class DomainSpace: IEntity<int>
    {
        private int _idSpace;
        private int _idDomain;

        public int IdSpace
        {
            get
            {
                return _idSpace;
            }

            set
            {
                _idSpace = value;
            }
        }

        public int IdDomain
        {
            get
            {
                return _idDomain;
            }

            set
            {
                _idDomain = value;
            }
        }
    }
}
