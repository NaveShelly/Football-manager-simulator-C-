using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LigatAhall
{
  public  class Coach : Worker
    {
        private string TeamName;
        private bool PastPlayer;
        private int NumOfChampions;
        public Coach(string x,string y,string z,int d,string j,bool h,int k):base(x,y,z,d)
        {
            TeamName=j;
            PastPlayer=h;
            NumOfChampions=k;
        }
        public Coach(Coach x):base(x)
        {
            TeamName = x.TeamName;
            PastPlayer = x.PastPlayer;
            NumOfChampions = x.NumOfChampions;
        }
        public override bool TopPerson()
        {
            if (NumOfChampions > 2)
            {
                return true;
            }
            else
                return false;
        }
        public override double salary()
        {
            return 4500 + 200 * GetCarrierTime() + 500 * NumOfChampions;
        }
        public override void Print()
        {
            base.Print();
            Console.WriteLine("TopPerson:"+TopPerson());
            Console.WriteLine("Team Name:" + TeamName);
            Console.WriteLine("Past Player:"+PastPlayer);
            Console.WriteLine("Num Of Champions:" + NumOfChampions);
        }
    }
}
