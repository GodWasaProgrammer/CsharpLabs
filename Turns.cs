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
        

        public int toss1
        {
            get { return Toss1; }

        }

        public int toss2
        {
            get {return Toss2;}
        }

        public int toss3
        {
            get {return Toss3;}
        }
        public int Roundtotal
        {
            get { return RoundTotal; }
        }
        

        public int RoundNumber
        
        { get { return roundnumber; }
            
            set { roundnumber = value; } 
        
        }

        public Turns(int toss1, int toss2, int toss3)
        {
            Toss1 = toss1;
            Toss2 = toss2;
            Toss3 = toss3;
            RoundTotal = toss1 + toss2 + toss3;
            roundnumber++;

            
        }

        public int Get_Score()
        {

            return RoundTotal;  


        }
        
    }


    
}
