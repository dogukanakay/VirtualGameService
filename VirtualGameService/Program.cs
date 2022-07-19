using System;
using VirtualGameService.Abstracts;
using VirtualGameService.Entities;


namespace VirtualGameService
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Player player1 = new Player();
            player1.Id = 134;
            player1.Name = "Dood";


            Service playerService = new PlayerService();
            playerService.Add(player1);
                
        }
    }
}
