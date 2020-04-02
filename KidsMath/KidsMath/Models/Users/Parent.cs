using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KidsMath.Models.Users
{
    public class Parent : User
    {
        private List<User> _children;
  

        public Parent()
        {
            _children = new List<User>();
        }

        public List<User> Children {
            get
            {
                return _children;
            }
        }

    }
}
