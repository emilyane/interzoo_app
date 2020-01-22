using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using interzooDAL.Interface;

namespace interzooDAL.Models
{
    public partial class AnimalHealth: IEntity<int>
    {

        private int _idHealth;
        private int _idAnimal;

        public int IdHealth
        {
            get
            {
                return _idHealth;
            }

            set
            {
                _idHealth = value;
            }
        }

        public int IdAnimal
        {
            get
            {
                return _idAnimal;
            }

            set
            {
                _idAnimal = value;
            }
        }
     

    }
}
