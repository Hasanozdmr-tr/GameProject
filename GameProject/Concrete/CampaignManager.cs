using GameProject.Abstract;
using GameProject.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    public class CampaignManager : ICampaignService
    {
       
        public void Register(Campaign campaign)
        {
            Console.WriteLine(campaign.Id + " nolu kampanya kayıt olmuştur.");
        }

        public void Remove(Campaign campaign)
        {
            Console.WriteLine(campaign.Id + " nolu kampanya silinmiştir.");
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine(campaign.Id + " nolu kampanya güncellenmiştir.");
        }
    }

}
