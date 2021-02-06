using GameProject.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    public class UserValidationManager : IUserValidationService
    {
        public bool Validate(User user)
        {
            if(user.IdentityNumber==123456789 && user.FirstName=="Hasan" && user.LastName=="Öz"
                && user.BirthOfYear=="1980" ||
                user.IdentityNumber == 123456789 && user.FirstName == "Ali" && user.LastName == "Öz"
                && user.BirthOfYear == "2000"

                )
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
