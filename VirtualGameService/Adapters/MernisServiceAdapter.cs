using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VirtualGameService.Entities;
using VirtualGameService.Abstracts;
using ServiceReference1;

namespace VirtualGameService.Adapters
{
    internal class MernisServiceAdapter : IPlayerCheckService
    {
        public bool CheckIfRealPlayer(Player player)
        {

            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
            return client.TCKimlikNoDogrulaAsync(Convert.ToInt64(player.NationalityId), player.Name.ToUpper(), player.Surname.ToUpper(),player.Birthday.Year).Result.Body.TCKimlikNoDogrulaResult;
            



        }
    }
}
