using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VirtualGameService.Abstracts;

namespace VirtualGameService.Entities
{
    internal class Player: BaseEntities
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime Birthday { get; set; }
        public string NationalityId { get; set; }

    }
}
