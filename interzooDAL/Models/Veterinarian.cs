using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using interzooDAL.Interface;
using System.Security.Cryptography;

namespace interzooDAL.Models
{
    public partial class Veterinarian: IEntity<int>
    {
        private int _idVeterinarian;
        private string _firstName;
        private string _lastName;
        private string _email;
        private int _phone;
        private DateTime _birthday;
        private string _password;

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

        public string FirstName
        {
            get
            {
                return _firstName;
            }

            set
            {
                _firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return _lastName;
            }

            set
            {
                _lastName = value;
            }
        }

        public string Email
        {
            get
            {
                return _email;
            }

            set
            {
                _email = value;
            }
        }

        public int Phone
        {
            get
            {
                return _phone;
            }

            set
            {
                _phone = value;
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

        public string Password
        {
            get
            {
                return _password;
            }

            set
            {
                _password = value;
            }
        }

        public string HashMDP
        {
            get
            {
                if (_password == null) throw new InvalidOperationException("Please enter your password");
                using (SHA512 sha512Hash = SHA512.Create())
                {

                    byte[] sourceBytes = Encoding.UTF8.GetBytes(_password);
                    byte[] hashBytes = sha512Hash.ComputeHash(sourceBytes);
                    string hash = BitConverter.ToString(hashBytes).Replace("-", String.Empty);
                    return hash;
                }
            }
        }
    }
}
