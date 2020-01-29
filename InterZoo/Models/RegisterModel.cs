using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace InterZoo.Models
{
    public class RegisterModel
    {
        private string _firstName;
        private string _lastName;
        private string _email;
        private int _phone;
        private DateTime _birthday;
        private string _photo;
        private string _password;
        private string _passConfirmation;
        private string _role;

        [Required]
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
        
        [Required]
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

        [Required]
        [DataType(DataType.EmailAddress)]
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
        [Required]
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
        [Required]
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
        [Required]
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
        [Compare("Password", ErrorMessage = "Password does not match")]  
        public string PassConfirmation
        {
            get
            {
                return _passConfirmation;
            }

            set
            {
                _passConfirmation = value;
            }
        }

        [Required(ErrorMessage = "You must be a Volunteer, Veterinarian, Zookeeper, or an Animal Parent.")]
        public string Role
        {
            get
            {
                return _role;
            }

            set
            {
                _role = value;
            }
        }
    }
}