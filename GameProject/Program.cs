using GameProject.Concrete;
using GameProject.Entity;
using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {



            UyeKaydı();
            Console.WriteLine("------------------");
            KampanyaKaydı();
            Console.WriteLine("------------------");
            SatışYap();



        }

        private static void SatışYap()
        {
            User member = new User();
            member.Id = 2;
            member.FirstName = "Ali";
            member.LastName = "Yılmaz";

            Campaign campaign = new Campaign();
            campaign.Id = 1;
            campaign.CampaignName = "Şok Şok Şok, Çok Ucuz";

            Game game = new Game();
            game.Id = 1;
            game.GameName = "GTA 5";
            game.Price = 15;
            game.Version = 5;

            OrderManager orderManager = new OrderManager();
            orderManager.Sell(member,campaign,game);
        }

        public static void KampanyaKaydı()
        {
          

            Campaign campaign = new Campaign();
            campaign.Id = 1;
            campaign.CampaignName = "Şok Ucuz Kampanya";

            CampaignManager campaignManager = new CampaignManager();
            campaignManager.Update(campaign);
            campaignManager.Remove(campaign);
            campaignManager.Remove(campaign);
        }
        public static void UyeKaydı()
        {

            User user = new User();
            User user2 = new User();

            user.Id = 1;
            user.FirstName = "Hasan";
            user.LastName = "Öz";
            user.IdentityNumber = 123456789;
            user.BirthOfYear = "1980";
            user.Abc = "Ali";

            user2.Id = 2;
            user2.FirstName = "Ali";
            user2.LastName = "Öz";
            user2.IdentityNumber = 123456789;
            user2.BirthOfYear = "2000";
            user2.Abc = "Veli";

            UserManager memberManager = new UserManager(new UserValidationManager());
            memberManager.Register(user);
            memberManager.Register(user2);
            memberManager.Update(user,user.Abc);
            memberManager.Remove(user);

            
        }
    }

        
    }

