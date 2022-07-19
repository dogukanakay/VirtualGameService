using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VirtualGameService.Entities;

namespace VirtualGameService.Abstracts
{
    internal class CampaignsService : Service
    {
        public override void Add(BaseEntities entities)
        {
            Console.WriteLine(entities.Id + " ID " + "Campaign added.");
        }

        public override void Delete(BaseEntities entities)
        {
            Console.WriteLine(entities.Id + " ID " + "Campaign deleted.");
        }

        public override void Update(BaseEntities entities)
        {
            Console.WriteLine(entities.Id + " ID " + "Campaign updated.");
        }
    }
}
