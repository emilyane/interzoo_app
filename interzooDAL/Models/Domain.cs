using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using interzooDAL.Interface;

namespace interzooDAL.Models
{
    public partial class Domain: IEntity<int>
    {
        private int _idDomain;
        private bool _europe;
        private bool _savannah;
        private bool _everglades;
        private bool _water;

        public int IdDomain
        {
            get
            {
                return _idDomain;
            }

            set
            {
                _idDomain = value;
            }
        }

        public bool Europe
        {
            get
            {
                return _europe;
            }

            set
            {
                _europe = value;
            }
        }

        public bool Savannah
        {
            get
            {
                return _savannah;
            }

            set
            {
                _savannah = value;
            }
        }

        public bool Everglades
        {
            get
            {
                return _everglades;
            }

            set
            {
                _everglades = value;
            }
        }

        public bool Water
        {
            get
            {
                return _water;
            }

            set
            {
                _water = value;
            }
        }
    }
}
