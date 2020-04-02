using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KidsMath.Models.Users
{
    public class User
    {
        private UserProfile _profile;

        // TODO :: crear getters setters

        /// <summary>
        /// Valida que el login y password sean correctos
        /// </summary>
        /// <param name="credentials">Es password encriptado del usuario</param>
        /// <returns></returns>
        public bool ValidateCredentials(string credentials)
        {
            return true;
        }

        public void LoadProfile()
        {
            
        }

        public void SaveProfile()
        {

        }
    }
}
