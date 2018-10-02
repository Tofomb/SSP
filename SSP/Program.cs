using System;

namespace SSP
{
    class Program
    {
        static void Main(string[] args)
        {
            int AIPoint = 0;
            int UPoint = 0;

            do
            {

                Console.WriteLine("Sten Sax Påse");
                PickAThing pt = new PickAThing();
                Play pl = new Play();
                int U = pt.UpickAThing();
                int AI = pt.AIPickAthing();
                int win = pl.playing(U, AI);
                
                if (win == 1)
                {
                    AIPoint++;
                    Console.WriteLine("point:AI");
                }
                else if (win == 2)
                {
                    UPoint++;
                    Console.WriteLine("point:U");
                }
                else
                {
                    Console.WriteLine("point:None");
                }

            } while (UPoint < 3 && AIPoint < 3);

            if (UPoint == 3)
            {
                Console.WriteLine("U win");

            }
            else{
                Console.WriteLine("AI win");
            }
            Console.ReadKey();
        }
    }
    public class PickAThing
    {
        public int AIPickAthing()
        {
            Random rnd = new Random();
            int val = rnd.Next(1, 4);

            return val;
        }
        public int UpickAThing()
        {
            int val = 0;
            string x = Console.ReadLine();
            if (x.ToLower() == "sten" || x == "1")
            {
                val = 1;
            }
            else if (x.ToLower() == "sax" || x == "2")
            {
                val = 2;
            }
            else if (x.ToLower() == "påse" || x == "3")
            {
                val = 3;
            }
            

            return val;
        }
    }
    public class Play{
        public int playing(int U, int AI) {
            if (AI == 1)
            {
                Console.WriteLine("AI:Sten");
            }
            else if (AI == 2)
            {
                Console.WriteLine("AI:Sax");
            }
            else if (AI == 3)
            {
                Console.WriteLine("AI:Påse");
            }

            if (AI == U)
            {
                return 0;
            }
            else if ((AI==1 && U==2)||(AI==2&&U==3)||(AI==3&&U==1)||(U==0))
            {
                return 1;
            }
            
            else { return 2; }

            return 0;
        }
    } 
}
   
