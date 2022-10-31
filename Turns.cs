using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpLabs
{
    class Turns
    {
        private int roundnumber = 1;
        private int Toss1;
        private int Toss2; 
        private int Toss3;
        private int RoundTotal;
        
        public int RoundNumber { get { return roundnumber; } set { roundnumber = value; } }
        public Turns(int toss1, int toss2, int toss3)
        {
            Toss1 = toss1;
            Toss2 = toss2;
            Toss3 = toss3;
            RoundTotal = RoundTotal + toss1 + toss2 + toss3;
            

            
        }

        public void Get_Score()
        {
            Console.WriteLine("Player:");
            Console.WriteLine("RoundNumber:{0}", RoundNumber);

            Console.WriteLine("Your First Toss:{0}", Toss1);
            Console.WriteLine("Your Second Toss:{0}", Toss2);
            Console.WriteLine("Your Third Toss:{0}", Toss3);
            Console.WriteLine("Your Total round score was:{0}", RoundTotal);


        }
        
    }


    
}
