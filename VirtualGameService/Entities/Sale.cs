using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualGameService.Entities
{
    internal class Sale:BaseEntities
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public int GameId { get; set; }
        public int CampaignId { get; set; }
        public int TotalPaid { get; set; }


    }
}
