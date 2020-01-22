using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using interzooDAL.Interface;

namespace interzooDAL.Models
{
    public partial class Health: IEntity<int>
    {
        private int _idHealth;
        private string _status;
        private string _illness;
        private string _medicine;
        private DateTime _startDate;
        private DateTime _endDate;

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

        public string Status
        {
            get
            {
                return _status;
            }

            set
            {
                _status = value;
            }
        }

        public string Illness
        {
            get
            {
                return _illness;
            }

            set
            {
                _illness = value;
            }
        }

        public string Medicine
        {
            get
            {
                return _medicine;
            }

            set
            {
                _medicine = value;
            }
        }

        public DateTime StartDate
        {
            get
            {
                return _startDate;
            }

            set
            {
                _startDate = value;
            }
        }

        public DateTime EndDate
        {
            get
            {
                return _endDate;
            }

            set
            {
                _endDate = value;
            }
        }
    }
}
