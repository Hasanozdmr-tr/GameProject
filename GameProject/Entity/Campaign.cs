using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Entity
{
    public class Campaign : IEntity
    {
        public int Id { get; set; }

        public string Abc { get; set; }

        public string CampaignName { get; set; }
        public string CampaignDetail { get; set; }

        public int CampaignYear { get; set; }
    }
}
