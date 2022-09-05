using GameMarketingProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameMarketingProject.Abstract
{
    public interface IProductService : IManagerRepository<Product>
    {
    }
}
