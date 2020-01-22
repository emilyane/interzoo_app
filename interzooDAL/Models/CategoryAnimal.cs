using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using interzooDAL.Interface;

namespace interzooDAL.Models
{
    public partial class CategoryAnimal: IEntity<int>
    {
        private int _idCategoryAnimal;
        private bool _mammal;
        private bool _bird;
        private bool _reptile;
        private bool _amphibian;
        private bool _fish;
        private int _idAnimal;

        public int IdCategoryAnimal
        {
            get
            {
                return _idCategoryAnimal;
            }

            set
            {
                _idCategoryAnimal = value;
            }
        }

        public bool Mammal
        {
            get
            {
                return _mammal;
            }

            set
            {
                _mammal = value;
            }
        }

        public bool Bird
        {
            get
            {
                return _bird;
            }

            set
            {
                _bird = value;
            }
        }

        public bool Reptile
        {
            get
            {
                return _reptile;
            }

            set
            {
                _reptile = value;
            }
        }

        public bool Amphibian
        {
            get
            {
                return _amphibian;
            }

            set
            {
                _amphibian = value;
            }
        }

        public bool Fish
        {
            get
            {
                return _fish;
            }

            set
            {
                _fish = value;
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
