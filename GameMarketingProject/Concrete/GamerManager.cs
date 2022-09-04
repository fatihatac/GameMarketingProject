using GameMarketingProject.Abstract;
using GameMarketingProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameMarketingProject.Concrete
{
    public class GamerManager : IManagerRepository<Gamer>
    {
        IGamerCheckService _gamerCheckService;
        public GamerManager(IGamerCheckService gamerCheckService)
        {
            _gamerCheckService = gamerCheckService;
        }

        public void Add(Gamer entity)
        {
            if (_gamerCheckService.CheckIfRealPerson(entity))
            {
                Console.WriteLine("Oyuncu eklendi : " + entity.FirstName);
            }
            else
            {
                throw new NonExistPersonException("Öyle biri yok ki");
            }
            
        }

        public void Delete(Gamer entity)
        {
            Console.WriteLine("Oyuncu silindi : " + entity.FirstName);
        }

        public void Update(Gamer entity)
        {
            Console.WriteLine("Oyuncu güncellendi : " + entity.FirstName);
        }
    }
}
