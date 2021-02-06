using GameProject.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Abstract
{
    public interface ICampaignService
    {
        void Register(Campaign campaign);
        void Update(Campaign campaign);
        void Remove(Campaign campaign);

    }
}
