using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using interzooDAL.Interface;

namespace interzooDAL.Models
{
   public partial class Space: IEntity<int>
    {
        private int _idSpace;
        private bool _cage;
        private bool _aquarium;
        private bool _outdoors;

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

        public bool Cage
        {
            get
            {
                return _cage;
            }

            set
            {
                _cage = value;
            }
        }

        public bool Aquarium
        {
            get
            {
                return _aquarium;
            }

            set
            {
                _aquarium = value;
            }
        }

        public bool Outdoors
        {
            get
            {
                return _outdoors;
            }

            set
            {
                _outdoors = value;
            }
        }
    }
}
