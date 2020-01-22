using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using interzooDAL.Interface;

namespace interzooDAL.Models
{
    public partial class ZookeeperFood: IEntity<int>
    {
        private int _idZookeeper;
        private int _idFood;

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

        public int IdFood
        {
            get
            {
                return _idFood;
            }

            set
            {
                _idFood = value;
            }
        }
    }
}
