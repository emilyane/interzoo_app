using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using interzooDAL.Interface;

namespace interzooDAL.Models
{
    public partial class ZookeeperDomain: IEntity<int>
    {
        private int _idZookeeper;
        private int _idDomain;

        public int IdZookeeper
        {
            get
            {
                return _idZookeeper;
            }

            set
            {
                _idZookeeper = value;
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
