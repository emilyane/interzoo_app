using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using interzooDAL.Interface;

namespace interzooDAL.Models
{
    public partial class AnimalParentAdoption : IEntity<int>
    {
        private int _idAnimalParent;
        private int _idAdoption;

        public int IdAnimalParent
        {
            get
            {
                return _idAnimalParent;
            }

            set
            {
                _idAnimalParent = value;
            }
        }

        public int IdAdoption
        {
            get
            {
                return _idAdoption;
            }

            set
            {
                _idAdoption = value;
            }
        }
    }
}
