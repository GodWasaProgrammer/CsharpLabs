﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpLabs
{
     class Game
    {
        List<Player> players = new List<Player>();
        
        public void Playgame()

        {
            Console.WriteLine("Dart Game");
            Console.WriteLine("This game is designed for 3 Players PC/Human");
            do
            {
                Console.WriteLine("Pick your name or leave blank for PC to play instead.");

                
                AddPlayer();

            }while (players.Count < 3);

            foreach(var index in players)
            {
                
                Console.WriteLine("Current Player is:{0}", index.Name);
                Console.WriteLine("-----------------------------------------------");
                index.Add_turn();
                
            }

            
            




        }

        public void AddPlayer()
        {

            players.Add(new Player(Console.ReadLine()));
        }

    }
}
