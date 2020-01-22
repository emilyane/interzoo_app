using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using interzooDAL.Interface;

namespace interzooDAL.Models
{
    public partial class VeterinarianHealth: IEntity<int>
    {
        private int _idHealth;
        private int _idVeterinarian;

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
