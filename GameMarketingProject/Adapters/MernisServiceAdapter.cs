using GameMarketingProject.Abstract;
using GameMarketingProject.Entities;
using ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameMarketingProject.Adapters
{
    public class MernisServiceAdapter : IGamerCheckService
    {
        public bool CheckIfRealPerson(Gamer gamer)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
            var result = client.TCKimlikNoDogrulaAsync(Convert.ToInt64(gamer.NationalId),gamer.FirstName.ToUpper(),gamer.Lastname.ToUpper(),gamer.BirthTime.Year).GetAwaiter().GetResult();
            return result.Body.TCKimlikNoDogrulaResult;
        }
    }
}
