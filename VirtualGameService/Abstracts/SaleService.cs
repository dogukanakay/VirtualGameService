using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VirtualGameService.Entities;

namespace VirtualGameService.Abstracts
{
    internal class SaleService : Service
    {
        public override void Add(BaseEntities entities)
        {
            Sale sale = (Sale)entities;
            Console.WriteLine("ID"+sale.GameId+" Game sold to player ID"+ sale.CustomerId+".");
            Console.WriteLine("Total paid = " + sale.TotalPaid); ;
        }

        public override void Delete(BaseEntities entities)
        {
            Sale sale = (Sale)entities;
            Console.WriteLine("ID"+sale.Id+" has been canceled.");
        }

        public override void Update(BaseEntities entities)
        {
            Sale sale = (Sale)entities;
            Console.WriteLine("ID" + sale.Id + " has been updated.");
        }
    }
}
