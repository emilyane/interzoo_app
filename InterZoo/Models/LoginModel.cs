using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using interzooDAL.Models;

namespace InterZoo.Models
{
    public class LoginModel
    {
        
            private string _email, _password, _role;

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
}

