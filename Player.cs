using System;
using System.Collections.Generic;

namespace CsharpLabs
{
    class Player

    {
        public Player(string Name)
        {
            this.name = Name;

            
        }
        string name;
        public string Name { get { return name; } set {} }

        

        int toss1;

        int toss2;

        int toss3;

        int TotalScore;

        List<Turns> turns = new List<Turns>();

        public override string ToString()
        {
          
            
            return Name;
        }

        public void Calculatepoints()
        {
            
            

            foreach (var index in turns)
            {
                int RoundNumber = 1;
                Console.WriteLine("Current Round is:{0}", RoundNumber);
                RoundNumber++;
                index.Get_Score();
                

            }
        }

        public void Add_turn()
        {

            
            if(name == "PC" || name == "")
            {
                

                var ComputerThrowRandom = new Random();
                
                toss1 = ComputerThrowRandom.Next(0, 20);
                
                Console.WriteLine("PC tosses his first throw{0}", toss1);
                
                toss2 = ComputerThrowRandom.Next(0,20);
                
                Console.WriteLine("PC tosses his second throw{0}", toss2);
                
                toss3 = ComputerThrowRandom.Next(0,20);

                Console.WriteLine("PC tosses his third throw{0}", toss3);

                turns.Add(new Turns(toss1, toss2, toss3));

                Console.ReadKey();

            }
                else
            { 
            Console.WriteLine("Put in your first number");
            
            int.TryParse(Console.ReadLine(), out toss1);


            Console.WriteLine("Put in your second number");
          
            int.TryParse(Console.ReadLine(), out toss2);

            Console.WriteLine("Put in your third number");
            
            int.TryParse(Console.ReadLine(), out toss3);


            
            turns.Add(new Turns(toss1, toss2, toss3));

            }

            Calculatepoints();
            Console.ReadKey();
        }

        public void Print_Turns()
        {
            foreach (var turn in turns)
            {
                Console.WriteLine(turn.ToString());

            }
        }
    }

    
}
