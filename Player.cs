using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpLabs
{
     class Player

    {
        public Player(string Name)
        {
            this.name = Name;

            
        }
        string name;
        public string Name { get { return name; } }





        List<Turns> turns = new List<Turns>();

        public override string ToString()
        {
            return Name;
        }

        public void Calculatepoints()
        {

        }

        public void Add_turn()
        {
            Console.WriteLine("Put in your first number");
            int toss1;
            int.TryParse(Console.ReadLine(), out toss1);


            Console.WriteLine("Put in your second number");
            int toss2;
            int.TryParse(Console.ReadLine(), out toss2);

            Console.WriteLine("Put in your third number");
            int toss3;
            int.TryParse(Console.ReadLine(), out toss3);


            
            turns.Add(new Turns(toss1, toss2, toss3));
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
