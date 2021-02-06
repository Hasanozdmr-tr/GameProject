using GameProject.Abstract;
using GameProject.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    public class OrderManager:IOrderService
    {
        
        public void Sell(User user, Campaign campaign, Game game)
        {
            Console.WriteLine(user.Id + " nolu , " + user.FirstName + " isimli" + " oyuncu " 
                + campaign.CampaignName +  " isimli kampanyamızdan faydalanarak " 
                + game.GameName + " oyununu " + game.Price + " TL'ye " +
                " satın alarak işlemini tamamlamıştır. " +
                "Teşekkür Ederiz.");
        }
    }
}
