using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using interzooDAL.Interface;

namespace interzooDAL.Models
{
    public partial class VeterinarianSpeciality: IEntity<int>
    {
        private int _idVeterinarian;
        private int _idCategoryAnimal;

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
    }
}
