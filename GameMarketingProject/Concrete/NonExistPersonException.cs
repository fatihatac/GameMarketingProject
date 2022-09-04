using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameMarketingProject.Concrete
{
    public class NonExistPersonException:Exception
    {
        public NonExistPersonException(string message):base(message)
        {

        }
    }
}
