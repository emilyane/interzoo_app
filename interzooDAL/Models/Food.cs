using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using interzooDAL.Interface;

namespace interzooDAL.Models
{
    public partial class Food : IEntity<int>
    {
        private int _idFood;
        private string _name;
        private string _species;
        private int _idAnimal;

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

        public string Name
        {
            get
            {
                return _name;
            }

            set
            {
                _name = value;
            }
        }

        public string Species
        {
            get
            {
                return _species;
            }

            set
            {
                _species = value;
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
