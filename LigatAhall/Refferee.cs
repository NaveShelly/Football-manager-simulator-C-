using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LigatAhall
{
   public class Refferee : Worker
    {
        private int NumOfGames;
        private int NumOfMistakes;
        static int MaximumMistakes;
        public Refferee(string x,string y,string z,int u,int d,int h):base(x,y,z,u)
        {
            NumOfGames = d;
            NumOfMistakes = h;
        }
        public string getFname()
        {
            return getFirstName();
        }
        public string getLname()
        {
            return getLastName();
        }
        public override bool TopPerson()
        {
            if (MaximumMistakes / NumOfMistakes < 0.5)
                return true;
            else return false;   
        }
        public override double salary()
        {
            if (NumOfMistakes == MaximumMistakes)
                return 4500 + 30 * NumOfGames-500;
            else
                return 4500 + 30 * NumOfGames - 500;
        }
        public void addMistakes(int x)
        {
            NumOfMistakes += x;
        }
        public override void Print()
        {
            base.Print();
            Console.WriteLine("Num of Mistakes:" + NumOfMistakes);
            Console.WriteLine("Num of Games:" + NumOfGames);
        }
        public void addGame()
        {
            NumOfGames++;
        }
    }
    
}
