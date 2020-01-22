using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using interzooDAL.Interface;

namespace interzooDAL.Models
{
    public partial class AnimalVeterinarian : IEntity<int>
    {
        private int _idAnimal;
        private int _idVeterinarian;

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

        public int IdVeterinarian
        {
            get
            {
                return _idVeterinarian;
            }

            set
            {
                _idVeterinarian = value;
            }
        }
    }
}
