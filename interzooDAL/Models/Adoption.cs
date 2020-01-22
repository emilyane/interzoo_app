using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using interzooDAL.Interface;

namespace interzooDAL.Models
{
    public partial class Adoption : IEntity<int>
    {
        private int _idAdoption;
        private string _animalName;
        private int _monthlyDonation;
        private int _yearlyDonation;
        private bool _vip;
        private bool _student;
        private bool _family;

        public int IdAdoption
        {
            get
            {
                return _idAdoption;
            }

       
        }
        //I had to take out set because ??? but IEntity can be set to int or string and in this case it was set to int and was not happy with how I was getting and setting the id
        public string AnimalName
        {
            get
            {
                return _animalName;
            }

            set
            {
                _animalName = value;
            }
        }

        public int MonthlyDonation
        {
            get
            {
                return _monthlyDonation;
            }

            set
            {
                _monthlyDonation = value;
            }
        }

        public int YearlyDonation
        {
            get
            {
                return _yearlyDonation;
            }

            set
            {
                _yearlyDonation = value;
            }
        }

        public bool Vip
        {
            get
            {
                return _vip;
            }

            set
            {
                _vip = value;
            }
        }

        public bool Student
        {
            get
            {
                return _student;
            }

            set
            {
                _student = value;
            }
        }

        public bool Family
        {
            get
            {
                return _family;
            }

            set
            {
                _family = value;
            }
        }
    }
}
