using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LigatAhall
{
 public class Team
    {
        private string TeamName;
        private string Stadium;
        private Footballer[] Footballers;
        private int NumOfPlayers;
        private Coach Coachs;
        private Manager Managers;
        private bool Managersx;
        public void addGoal(int i)
        {
            Footballers[i].addGoal();
        }
        public string GetFootballerFName(int i)
        {
            return Footballers[i].getFirstName();
        }
        public string GetFootballerLName(int i)
        {
            return Footballers[i].getLastName();
        }
        public string getTeamName()
        {
            return TeamName;
        }
        public int getNumOfPlayers()
        {
            return NumOfPlayers;
        }
        public Team()
        {
            Managersx = false;
        }
        public Coach GetCoach()
        {
            return Coachs;
        }
        public Manager GetManager()
        {
            return Managers;
        }
        public void SetStadium(string x)
        {
            Stadium = x;
        }
        public void setCoachs(string x,string y,string z,int d,string h,int k)
        {
            Coachs = new Coach(x,y,z,d,h,true,k);
        }
        public void AddPlayer(Footballer x)
        {
            Footballer[] temp = new Footballer[NumOfPlayers];
            for(int i=0;i<NumOfPlayers;i++)
            {
                temp[i] = Footballers[i];
            }
            NumOfPlayers++;
            Footballers = new Footballer[NumOfPlayers];
            for(int i=0;i<NumOfPlayers-1;i++)
            {
                Footballers[i] = temp[i];
            }
            Footballers[NumOfPlayers - 1] = x;
        }
        public void addManager(Manager x)
        {
            if(Managersx==false)
            {
                Managersx = true;
                Managers = x;
                Console.WriteLine("Manager has been added");
            }
            else
            {
                Console.WriteLine("The Team Had Manager");
            }
        }
        public Footballer GetPlayer(int x)
        {
            return Footballers[x];
        }
        public void Print()
        {
            Console.WriteLine("The Stadium Name is:"+Stadium);
            Console.WriteLine("The Team Name is:" + TeamName);
            Console.WriteLine("The Footballers list are");
            for(int i=0;i<NumOfPlayers;i++)
            {
                Footballers[i].Print();
            }
            Console.WriteLine("The Coach details is is:");
            Coachs.Print();
            if (Managersx == true)
            {
                Console.WriteLine("The Manager is :");
                Managers.Print();
            }
        }
        public void SetTeamName(string x)
        {
            TeamName = x;
        }
    }
}
