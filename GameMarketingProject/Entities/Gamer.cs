using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameMarketingProject.Abstract;

namespace GameMarketingProject.Entities
{
    public class Gamer : IEntity
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string Lastname { get; set; }
        public string NationalId { get; set; }
        public DateTime BirthTime { get; set; }
    }
}
