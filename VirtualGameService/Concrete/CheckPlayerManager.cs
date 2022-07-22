using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VirtualGameService.Abstracts;
using VirtualGameService.Adapters;
using VirtualGameService.Entities;

namespace VirtualGameService.Concrete
{
    internal class CheckPlayerManager : IPlayerCheckService
    {
        public bool CheckIfRealPlayer(Player player)
        {
            return true;
        }
    }
}
