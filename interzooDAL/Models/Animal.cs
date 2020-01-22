using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using interzooDAL.Interface;

namespace interzooDAL.Models
{
    public partial class Animal : IEntity<int>
    {
        private int _idAnimal;
        private string _name;
        private string _species;
        private DateTime _birthday;
        private int _idCategoryAnimal;
        private int _idAnimalParent;
        private int _idAdoption;

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

        public DateTime Birthday
        {
            get
            {
                return _birthday;
            }

            set
            {
                _birthday = value;
            }
        }

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

        

        //public int Id
        //{
        //    get
        //    {
        //        return IdAnimal;
        //    }
        //}

        


    }
}
