using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VirtualGameService.Abstracts;

namespace VirtualGameService.Entities
{
    internal class Campaign: BaseEntities
    {
        public string Name { get; set; }
        public int DiscountRate { get; set; }

    }
}
