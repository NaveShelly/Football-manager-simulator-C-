using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LigatAhall
{
  public  class Footballer : Worker
    {
        private string TeamName;
        private int NumOfGoal;
        private int NumOfGames;
        private string Position;
        public void addGoal()
        {
            NumOfGoal++;
        }
        public float Statistics()
        {
            return NumOfGoal / NumOfGames;
        }
        public override double salary()
        {
            return 6500 + (Statistics() / 100) * 2000;
        }
        public override bool TopPerson()
        {
            if (Statistics() > 0.75)
                return true;
            else return false;
        }
        public Footballer(Footballer x):base(x)
        {
            TeamName = x.TeamName;
            NumOfGoal = x.NumOfGoal;
            NumOfGames = x.NumOfGames;
            Position = x.Position;
            NumOfGames = 10;
        }
        public Footballer(string x, string y, string z, int d, string h, string j, int g, int b) : base(x, y, z, d)
        {
            TeamName = h;
            Position = j;
            NumOfGames = g;
            NumOfGoal = b;
        }
        public void AddGoal(bool x)
        {
            if(x==true)
            {
                NumOfGoal++;
            }
        }
        public override void Print()
        {
            base.Print();
            Console.WriteLine("Team Name:" + TeamName);
            Console.WriteLine("Position:" + Position);
            Console.WriteLine("Num Of Games:" + NumOfGames);
            Console.WriteLine("Num Of Goals:" + NumOfGoal);
            Console.WriteLine("Top Player:" + TopPerson());

        }
    }
}
