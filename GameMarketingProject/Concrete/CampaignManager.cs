using GameMarketingProject.Abstract;
using GameMarketingProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameMarketingProject.Concrete
{
    public class CampaignManager : IManagerRepository<Campaign>
    {
        public void Add(Campaign entity)
        {
            Console.WriteLine("Kampyanya eklendi : " +entity.CampaignName);
        }

        public void Delete(Campaign entity)
        {
            Console.WriteLine("Kampyanya silindi : " + entity.CampaignName);
        }

        public void Update(Campaign entity)
        {
            Console.WriteLine("Kampyanya güncellendi : " + entity.CampaignName);
        }
    }
}
