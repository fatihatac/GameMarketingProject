using GameMarketingProject.Abstract;
using GameMarketingProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameMarketingProject.Concrete
{
    public class SalesManager : ISaleService
    {
        public void SellGame(Gamer gamer, Product product)
        {
            Console.WriteLine("{0} oyunu {1} oyuncusuna başarıyla satıldı. Fiyatı {2} ", product.ProductName, gamer.FirstName, product.Price);
        }

        public void SellByCampaign(Gamer gamer, Product product, Campaign campaign)
        {
            double discount = (product.Price) / 100 * campaign.Discount;
            product.Price = product.Price - discount;
            Console.WriteLine("{0} oyuncusu {1} oyununu {2}kampanyası ile satın aldı. Fiyatı : {3}", gamer.FirstName, product.ProductName, campaign.CampaignName, product.Price);
        }
    }
}
