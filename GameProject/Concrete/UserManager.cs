using GameProject.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    public class UserManager: BaseOperationManager
    {
        
        IUserValidationService _userValidateService;

        List<string> UserNameList = new List<string>();

        public UserManager(IUserValidationService userValidateService)
        {
            _userValidateService = userValidateService;
        }

        public override void Register(User user)
        {
            if(_userValidateService.Validate(user))
            {
                UserNameList.Add(user.FirstName);
                Console.WriteLine(user.Id + " nolu üye kayıt olmuştur.");

                Console.WriteLine("Güncel Kullanıcı Listesi aşağıdaki gibidir.");
                foreach (var userNameList in UserNameList)
                {
                    Console.WriteLine(Environment.NewLine + userNameList);
                }
            }
            else
            {
                Console.WriteLine("Üye Mernis sistemine tanımlı değildir, bu sebeple eklenememiştir.");
            }
            
        }


        public override void Update(User user, string newName)
        {
            

            if (_userValidateService.Validate(user))
            {
                if (UserNameList.Contains(user.FirstName))
                    Console.WriteLine(user.Id + " nolu ve " + user.FirstName + " isimli üyenin bilgileri " 
                      + newName +  " ile değiştirilerek güncellenmiştir.");

                      user.FirstName = newName;
                
            }
            else
            {
                Console.WriteLine("Üye Mernis sistemine tanımlı değildir, bu sebeple güncellenememiştir.");
            }

            }

                public override void Remove(User user)
        {
            if (_userValidateService.Validate(user))
            {
                UserNameList.Remove(user.FirstName);
                Console.WriteLine(user.Id + " nolu üye kaydı silinmiştir.");
            }
            else
            {
                Console.WriteLine("Üye Mernis sistemine tanımlı değildir, bu sebeple silinememiştir.");
            }
        }


    }
}
