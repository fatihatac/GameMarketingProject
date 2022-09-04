using GameMarketingProject.Abstract;
using GameMarketingProject.Adapters;
using GameMarketingProject.Concrete;
using GameMarketingProject.Entities;
using System;

namespace GameMarketingProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //oyuncu eklenmesi ve kontrol sistemi sonucu hata alınması 
            IManagerRepository<Gamer> gamerManager = new GamerManager(new MernisServiceAdapter());
            Gamer gamer1 = new Gamer()
            {
                 Id = 1, 
                NationalId = "28816736258", 
                FirstName = "Fatih", Lastname = "Ataç", 
                BirthTime = new DateTime(2001, 10, 16) 
            };

            Product product1 = new Product()
            {
                Id = 1,
                Price = 250,
                ProductName = "Cyberpunk 2077 "
            };
            Campaign campaign1 = new Campaign()
            {
                Id = 1,
                CampaignName = "Ön sipariş kampanyası ",
                Discount = 10
            };


            try
            {
                gamerManager.Add(gamer1);
            }
            catch (NonExistPersonException exception)
            {

                Console.WriteLine(exception.Message);
            }

            //oyun eklenmesi
            IManagerRepository<Product> productManager = new ProductManager();
            productManager.Add(product1);

            //kampanya eklenmesi
            IManagerRepository<Campaign> campaignManager = new CampaignManager();
            campaignManager.Add(campaign1);

            SalesManager salesManager = new SalesManager();
            salesManager.SellGame(gamer1,product1);
            salesManager.SellByCampaign(gamer1,product1,campaign1);

        }
    }
}
