using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using interzooDAL.Interface;
using System.Security.Cryptography;

namespace interzooDAL.Models
{
    public partial class AnimalParent : IEntity<int>
    {
        private int _idAnimalParent;
        private string _firstName;
        private string _lastName;
        private string _email;
        private int _phone;
        private DateTime _birthday;
        private string _photo;
        private string _password;
        public int Id
        {
            get
            {
                return _idAnimalParent;
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

        public string Photo
        {
            get
            {
                return _photo;
            }

            set
            {
                _photo = value;
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
                if (_password == null) throw new InvalidOperationException("Please enter a password");
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
