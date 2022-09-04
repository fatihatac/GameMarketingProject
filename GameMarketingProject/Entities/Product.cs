using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameMarketingProject.Abstract;

namespace GameMarketingProject.Entities
{
    public class Product : IEntity
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public double Price { get; set; }
    }
}
