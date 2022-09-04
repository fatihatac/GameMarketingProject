using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameMarketingProject.Abstract;

namespace GameMarketingProject.Entities
{
    public class Campaign : IEntity
    {
        public int Id { get; set; }
        public string CampaignName { get; set; }
        public int Discount { get; set; }
    }
}
