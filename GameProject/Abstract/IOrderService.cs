using GameProject.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Abstract
{
    public interface IOrderService
    {
        public void Sell(User user, Campaign campaign, Game game);
    }
}
