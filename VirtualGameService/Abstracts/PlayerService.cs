using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VirtualGameService.Entities;

namespace VirtualGameService.Abstracts
{
    internal class PlayerService : Service
    {
        IPlayerCheckService _playerCheckService;
        public PlayerService(IPlayerCheckService playerCheckService)
        {
            _playerCheckService = playerCheckService;
        }   

        public override void Add(BaseEntities entities)
        {
            if (_playerCheckService.CheckIfRealPlayer((Player)entities))
            {
                Console.WriteLine(entities.Id + " ID " + "Player added.");
            }
            else
            {
                Console.WriteLine("The entered information did not match.");
            }
            
        }
        public override void Delete(BaseEntities entities)
        {
            Console.WriteLine(entities.Id + " ID " + "Player deleted.");
        }
        public override void Update(BaseEntities entities)
        {
            Console.WriteLine(entities.Id + " ID " + "Player updated.");
        }
    }
}
