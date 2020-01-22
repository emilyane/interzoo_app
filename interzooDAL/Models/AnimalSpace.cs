using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using interzooDAL.Interface;

namespace interzooDAL.Models
{
    public partial class AnimalSpace : IEntity<int>
    {
        private int _idAnimal;
        private int _idSpace;

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

        
    }
}
