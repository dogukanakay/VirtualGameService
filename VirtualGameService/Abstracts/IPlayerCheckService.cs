using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VirtualGameService.Entities;
namespace VirtualGameService.Abstracts
{
    internal interface IPlayerCheckService
    {
        public bool CheckIfRealPlayer(Player player);
    }
}
