using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace CsharpLabs
{
    class Player

    {

        int toss1;

        int toss2;

        int toss3;

        int TotalScore;





        List<Turns> turns = new List<Turns>();

        public Player(string Name)
        {
            this.name = Name;
            
            
        }
        string name;
        public string Name { get { return name; } set {} }

        public int Score 
        {
            get
            {
                return TotalScore;
            }
            set
            {
                TotalScore = value;
            }
        }


        public override string ToString()
        {
          
            
            return Name;
        }

        public int Calculatepoints()
        {
            

            Console.WriteLine("Calculating Points for the Current Round");

            Console.WriteLine("-----------------------------------------------------");

            

            foreach (var index in turns)
            {

                TotalScore += index.Roundtotal; // ska lyfta rundans värde från get_score och addera till lokala variabeln TotalScore

                if (Score > 301)

                {
                   //  Console.WriteLine("The Round Number is:{0}", index.RoundNumber);
                   //  Console.WriteLine("The Sum of Your round are: {0}", index.Roundtotal);


                    

                    Console.WriteLine("The winner is: {0}", name);
                    Console.WriteLine("The total sum of ALL your rounds are: {0}", Score);
                    Print_Turns();

                    
                    
                }

                else
                {
                    Console.WriteLine("Score Calculated and no winner yet.");
                }

            }
            return TotalScore;
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

                Console.WriteLine("---------------------------------");

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
                Console.WriteLine("---------------------------------");   

            }

            

                Console.ReadKey();
        }

        public void Print_Turns()
        {
            foreach (var turn in turns) // bör vara något som loopar på en specifik "player" inte på alla turns.
            {
                Console.WriteLine("The round belongs to:{0}", Name);
                Console.WriteLine("RoundNumber:{0}", turn.RoundNumber);

                Console.WriteLine("Your First Toss:{0}", turn.toss1);
                Console.WriteLine("Your Second Toss:{0}", turn.toss2);
                Console.WriteLine("Your Third Toss:{0}", turn.toss3);
                Console.WriteLine("Your Total round score was:{0}", turn.Roundtotal);

            }
        }
    }

    
}
