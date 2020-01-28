using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using interzooDAL.Interface;

namespace interzooDAL.Models
{
    public partial class Member : IEntity<int>
    {
        private int idMembre;
        private int _idVeterinarian;
        private int idZookeeper;
        private int idAnimalParent;
        private int idVolunteer;
        private bool isAdmin;

        public int IdMembre
        {
            get
            {
                return idMembre;
            }

            set
            {
                idMembre = value;
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

        public int IdZookeeper
        {
            get
            {
                return idZookeeper;
            }

            set
            {
                idZookeeper = value;
            }
        }

        public int IdAnimalParent
        {
            get
            {
                return idAnimalParent;
            }

            set
            {
                idAnimalParent = value;
            }
        }

        public int IdVolunteer
        {
            get
            {
                return idVolunteer;
            }

            set
            {
                idVolunteer = value;
            }
        }

        public bool IsAdmin
        {
            get
            {
                return isAdmin;
            }

            set
            {
                isAdmin = value;
            }
        }
    }


}
