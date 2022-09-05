using GameMarketingProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameMarketingProject.Abstract
{
    public interface ISaleService
    {
        public void SellGame(Gamer gamer, Product product);
        public void SellByCampaign(Gamer gamer, Product product, Campaign campaign);
    }
}
