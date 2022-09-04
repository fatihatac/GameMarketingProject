using GameMarketingProject.Abstract;
using GameMarketingProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameMarketingProject.Concrete
{
    public class ProductManager : IManagerRepository<Product>
    {
        public void Add(Product entity)
        {
            Console.WriteLine("Ürün eklendi : " + entity.ProductName);
        }

        public void Delete(Product entity)
        {
            Console.WriteLine("Ürün silindi : " + entity.ProductName);
        }

        public void Update(Product entity)
        {
            Console.WriteLine("Ürün güncellendi : " + entity.ProductName);
        }
    }
}
