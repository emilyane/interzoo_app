using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using interzooDAL.Interface;

namespace interzooDAL.Models
{
    public partial class ZookeeperVet: IEntity<int>
    {
        private int _idZookeeper;
        private int _idVet;

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

        public int IdVet
        {
            get
            {
                return _idVet;
            }

            set
            {
                _idVet = value;
            }
        }
    }
}
