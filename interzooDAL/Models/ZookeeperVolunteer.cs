using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using interzooDAL.Interface;

namespace interzooDAL.Models
{
    public partial class ZookeeperVolunteer: IEntity<int>    
    {
        private int _idVolunteer;
        private int _idZookeeper;

        public int IdVolunteer
        {
            get
            {
                return _idVolunteer;
            }

            set
            {
                _idVolunteer = value;
            }
        }

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
    }
}
