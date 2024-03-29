﻿using System;
using VirtualGameService.Abstracts;
using VirtualGameService.Entities;
using VirtualGameService.Concrete;
using ServiceReference1;
using VirtualGameService.Adapters;



namespace VirtualGameService
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Player player1 = new Player();
            player1.Id = 134;
            player1.Name = "Doğukan";
            player1.Surname = "Akay";
            player1.Birthday = new  DateTime(199, 2, 3);
            player1.NationalityId = "189115931421";
            Game game1 = new Game();
            game1.Id = 5;
            game1.Price = 30;
            Campaign campaign1 = new Campaign();
            campaign1.Id = 777;
            campaign1.DiscountRate = 50;

            Sale sale1 = new Sale();
            sale1.Id = 2552;
            sale1.GameId=game1.Id;
            sale1.CampaignId = campaign1.Id;
            sale1.CustomerId = player1.Id;
            sale1.TotalPaid = game1.Price - game1.Price * campaign1.DiscountRate / 100;


            Service playerService = new PlayerService( new MernisServiceAdapter() );
            playerService.Add(player1);
            Service saleService = new SaleService();
            saleService.Add(sale1);


                
        }
    }
}
