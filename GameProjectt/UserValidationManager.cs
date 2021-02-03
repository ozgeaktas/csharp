using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectt
{
    class UserValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if(gamer.BirthYear==1985 && gamer.FirstName=="Özge" && gamer.LastName=="Aktaş"&& gamer.IdentityNumber == 12345)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
