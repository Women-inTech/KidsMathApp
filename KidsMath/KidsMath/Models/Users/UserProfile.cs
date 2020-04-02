using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KidsMath.Models.Users
{
    /// <summary>
    /// Class to manage the Profile of the User
    /// </summary>
    public  class UserProfile
    {
        private string _firstName;
        private string _lastName;
        private string _login;
     
        private object _avatar;  // crear objetos ,para estos dos
        private object _theme;


        //TODO:: Considerar los administradores del sistemas, considerar que el userProfile debe tener datos validos
     

        public string FirstName
        {
            get 
            {
                return _firstName;
            }

            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException();
                }

                _firstName = value;
            }
        }

        public string LastName
        {
            get;
            set;
        }

        public string Login
        {
            get;
            set;
        }


        //TODO ::  Avatar y Theme seran objetos
        public Object Avatar
        {
            get;
            set;
        }

        public Object Theme
        {
            get;
            set;
        }

    
    }
}
