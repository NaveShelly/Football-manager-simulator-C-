using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace LigatAhall
{
    [Serializable()]
  public class Leugatahall/*:ISerializable*/
    {
        
        public Team[] Teams;
        public Worker[] Workers;
        public int NumofWorkers;
        public Refferee[] Refferees;
        public int ReffereeNum;
        public void addgoal(string x,string y,string z)
        {
            if (z == "Arsenal")
            {
                for (int i = 0; i < Teams[i].getNumOfPlayers(); i++)
                {

                    if (Teams[0].GetFootballerFName(i) == x && Teams[i].GetFootballerFName(i) == y)
                    {
                        Teams[0].addGoal(i);
                    }

                }
            }
            if (z == "Chelsea")
            {
                for (int i = 0; i < Teams[i].getNumOfPlayers(); i++)
                {

                    if (Teams[1].GetFootballerFName(i) == x && Teams[i].GetFootballerFName(i) == y)
                    {
                        Teams[1].addGoal(i);
                    }

                }
            }
            if (z == "Totenham")
            {
                for (int i = 0; i < Teams[i].getNumOfPlayers(); i++)
                {

                    if (Teams[2].GetFootballerFName(i) == x && Teams[i].GetFootballerFName(i) == y)
                    {
                        Teams[2].addGoal(i);
                    }

                }
            }
            if (z == "Liverpool")
            {
                for (int i = 0; i < Teams[i].getNumOfPlayers(); i++)
                {

                    if (Teams[3].GetFootballerFName(i) == x && Teams[i].GetFootballerFName(i) == y)
                    {
                        Teams[3].addGoal(i);
                    }

                }
            }
            if (z == "Man City")
            {
                for (int i = 0; i < Teams[i].getNumOfPlayers(); i++)
                {

                    if (Teams[4].GetFootballerFName(i) == x && Teams[i].GetFootballerFName(i) == y)
                    {
                        Teams[4].addGoal(i);
                    }

                }
            }

        }
        
        public Leugatahall()
        {
            
            ReffereeNum = 4;
            Refferees = new Refferee[4];
            for(int i=0;i<ReffereeNum;i++)
            {
                Refferees[i] = new Refferee("try","try","try",5,3,5);
            }
            Random random = new Random();
            NumofWorkers = 10;
            Teams = new Team[5];
            for(int i=0;i<5;i++)
            {
                Teams[i] = new Team();
            }
            Teams[0].SetTeamName("Arsenal");
            Teams[1].SetTeamName("Chelsea");
            Teams[2].SetTeamName("Totenham");
            Teams[3].SetTeamName("Liverpool");
            Teams[4].SetTeamName("Man City");
            for (int i = 0; i < 5; i++)
            {
                if (i == 0)
                {
                    Teams[i].SetStadium("Emirats");
                    for (int j = 0; j < 15; j++)
                    {
                        if (j >= 0 && j < 2)
                        {

                            string a;
                            string patha = Path.GetRandomFileName();
                            patha = patha.Replace(".", ""); // Remove period.
                            a = patha.Substring(0, 8);
                            string b;
                            string pathb = Path.GetRandomFileName();
                            pathb = pathb.Replace(".", ""); // Remove period.
                            b = pathb.Substring(0, 8);
                            string c;
                            string pathc = Path.GetRandomFileName();
                            pathc = pathc.Replace(".", ""); // Remove period.
                            c = pathb.Substring(0, 8);
                            Footballer x = new Footballer(a, b, c, random.Next(0, 26), "Arsenal", "GoalKeeper", random.Next(0, 38), random.Next(0, 32));
                            Teams[i].AddPlayer(x);
                            NumofWorkers++;
                        }
                        if (j >= 2 && j < 5)
                        {
                            string a;
                            string patha = Path.GetRandomFileName();
                            patha = patha.Replace(".", ""); // Remove period.
                            a = patha.Substring(0, 8);
                            string b;
                            string pathb = Path.GetRandomFileName();
                            pathb = pathb.Replace(".", ""); // Remove period.
                            b = pathb.Substring(0, 8);
                            string c;
                            string pathc = Path.GetRandomFileName();
                            pathc = pathc.Replace(".", ""); // Remove period.
                            c = pathb.Substring(0, 8);
                            Footballer x = new Footballer(a, b, c, random.Next(0, 26), "Arsenal", "Striker", random.Next(0, 38), random.Next(0, 32));
                            Teams[i].AddPlayer(x);
                            NumofWorkers++;
                        }
                        if (j >= 5 && j < 9)
                        {
                            string a;
                            string patha = Path.GetRandomFileName();
                            patha = patha.Replace(".", ""); // Remove period.
                            a = patha.Substring(0, 8);
                            string b;
                            string pathb = Path.GetRandomFileName();
                            pathb = pathb.Replace(".", ""); // Remove period.
                            b = pathb.Substring(0, 8);
                            string c;
                            string pathc = Path.GetRandomFileName();
                            pathc = pathc.Replace(".", ""); // Remove period.
                            c = pathb.Substring(0, 8);
                            Footballer x = new Footballer(a, b, c, random.Next(0, 26), "Arsenal", "midelfield", random.Next(0, 38), random.Next(0, 32));
                            Teams[i].AddPlayer(x);
                            NumofWorkers++;
                        }
                        if (j >= 9 && j < 12)
                        {
                            string a;
                            string patha = Path.GetRandomFileName();
                            patha = patha.Replace(".", ""); // Remove period.
                            a = patha.Substring(0, 8);
                            string b;
                            string pathb = Path.GetRandomFileName();
                            pathb = pathb.Replace(".", ""); // Remove period.
                            b = pathb.Substring(0, 8);
                            string c;
                            string pathc = Path.GetRandomFileName();
                            pathc = pathc.Replace(".", ""); // Remove period.
                            c = pathb.Substring(0, 8);
                            Footballer x = new Footballer(a, b, c, random.Next(0, 26), "Arsenal", "FullBack", random.Next(0, 38), random.Next(0, 32));
                            Teams[i].AddPlayer(x);
                            NumofWorkers++;
                        }
                        if (j >= 12 && j < 15)
                        {
                            string a;
                            string patha = Path.GetRandomFileName();
                            patha = patha.Replace(".", ""); // Remove period.
                            a = patha.Substring(0, 8);
                            string b;
                            string pathb = Path.GetRandomFileName();
                            pathb = pathb.Replace(".", ""); // Remove period.
                            b = pathb.Substring(0, 8);
                            string c;
                            string pathc = Path.GetRandomFileName();
                            pathc = pathc.Replace(".", ""); // Remove period.
                            c = pathb.Substring(0, 8);
                            Footballer x = new Footballer(a, b, c, random.Next(0, 26), "Arsenal", "Defender", random.Next(0, 38), random.Next(0, 32));
                            Teams[i].AddPlayer(x);
                            NumofWorkers++;
                        }
                        string g;
                        string pathg = Path.GetRandomFileName();
                        pathg = pathg.Replace(".", ""); // Remove period.
                        g = pathg.Substring(0, 8);
                        string h;
                        string pathh = Path.GetRandomFileName();
                        pathh = pathh.Replace(".", ""); // Remove period.
                        h = pathh.Substring(0, 8);
                        string k;
                        string pathk = Path.GetRandomFileName();
                        pathk = pathk.Replace(".", ""); // Remove period.
                        k = pathk.Substring(0, 8);
                        Teams[i].setCoachs(g, h, k, random.Next(0, 9999999), "Arsenal", random.Next(0, 20));
                        Manager T = new Manager("Emery", "Yoram", "3214123", 14);
                        Teams[i].addManager(T);
                    }
                }
                if (i == 1)
                {
                    Teams[i].SetStadium("Stamford bridge");
                    for (int j = 0; j < 15; j++)
                    {
                        if (j >= 0 && j < 2)
                        {
                            string a;
                            string patha = Path.GetRandomFileName();
                            patha = patha.Replace(".", ""); // Remove period.
                            a = patha.Substring(0, 8);
                            string b;
                            string pathb = Path.GetRandomFileName();
                            pathb = pathb.Replace(".", ""); // Remove period.
                            b = pathb.Substring(0, 8);
                            string c;
                            string pathc = Path.GetRandomFileName();
                            pathc = pathc.Replace(".", ""); // Remove period.
                            c = pathb.Substring(0, 8);
                            Footballer x = new Footballer(a, b, c, random.Next(0, 26), "Chelsea", "GoalKeeper", random.Next(0, 38), random.Next(0, 32));
                            Teams[i].AddPlayer(x);
                            NumofWorkers++;
                        }
                        if (j >= 2 && j < 5)
                        {
                            string a;
                            string patha = Path.GetRandomFileName();
                            patha = patha.Replace(".", ""); // Remove period.
                            a = patha.Substring(0, 8);
                            string b;
                            string pathb = Path.GetRandomFileName();
                            pathb = pathb.Replace(".", ""); // Remove period.
                            b = pathb.Substring(0, 8);
                            string c;
                            string pathc = Path.GetRandomFileName();
                            pathc = pathc.Replace(".", ""); // Remove period.
                            c = pathb.Substring(0, 8);
                            Footballer x = new Footballer(a, b, c, random.Next(0, 26), "Chelsea", "Striker", random.Next(0, 38), random.Next(0, 32));
                            Teams[i].AddPlayer(x);
                            NumofWorkers++;
                        }
                        if (j >= 5 && j < 9)
                        {
                            string a;
                            string patha = Path.GetRandomFileName();
                            patha = patha.Replace(".", ""); // Remove period.
                            a = patha.Substring(0, 8);
                            string b;
                            string pathb = Path.GetRandomFileName();
                            pathb = pathb.Replace(".", ""); // Remove period.
                            b = pathb.Substring(0, 8);
                            string c;
                            string pathc = Path.GetRandomFileName();
                            pathc = pathc.Replace(".", ""); // Remove period.
                            c = pathb.Substring(0, 8);
                            Footballer x = new Footballer(a, b, c, random.Next(0, 26), "Chelsea", "midelfield", random.Next(0, 38), random.Next(0, 32));
                            Teams[i].AddPlayer(x);
                            NumofWorkers++;
                        }
                        if (j >= 9 && j < 12)
                        {
                            string a;
                            string patha = Path.GetRandomFileName();
                            patha = patha.Replace(".", ""); // Remove period.
                            a = patha.Substring(0, 8);
                            string b;
                            string pathb = Path.GetRandomFileName();
                            pathb = pathb.Replace(".", ""); // Remove period.
                            b = pathb.Substring(0, 8);
                            string c;
                            string pathc = Path.GetRandomFileName();
                            pathc = pathc.Replace(".", ""); // Remove period.
                            c = pathb.Substring(0, 8);
                            Footballer x = new Footballer(a, b, c, random.Next(0, 26), "Chelsea", "FullBack", random.Next(0, 38), random.Next(0, 32));
                            Teams[i].AddPlayer(x);
                            NumofWorkers++;
                        }
                        if (j >= 12 && j < 15)
                        {
                            string a;
                            string patha = Path.GetRandomFileName();
                            patha = patha.Replace(".", ""); // Remove period.
                            a = patha.Substring(0, 8);
                            string b;
                            string pathb = Path.GetRandomFileName();
                            pathb = pathb.Replace(".", ""); // Remove period.
                            b = pathb.Substring(0, 8);
                            string c;
                            string pathc = Path.GetRandomFileName();
                            pathc = pathc.Replace(".", ""); // Remove period.
                            c = pathb.Substring(0, 8);
                            Footballer x = new Footballer(a, b, c, random.Next(0, 26), "Chelsea", "Defender", random.Next(0, 38), random.Next(0, 32));
                            Teams[i].AddPlayer(x);
                            NumofWorkers++;
                        }
                        string g;
                        string pathg = Path.GetRandomFileName();
                        pathg = pathg.Replace(".", ""); // Remove period.
                        g = pathg.Substring(0, 8);
                        string h;
                        string pathh = Path.GetRandomFileName();
                        pathh = pathh.Replace(".", ""); // Remove period.
                        h = pathh.Substring(0, 8);
                        string k;
                        string pathk = Path.GetRandomFileName();
                        pathk = pathk.Replace(".", ""); // Remove period.
                        k = pathk.Substring(0, 8);
                        Teams[i].setCoachs(g, h, k, random.Next(0, 9999999), "Chelsea", random.Next(0, 20));
                        Manager T = new Manager("Frank", "Lampard", "3214123", 14);
                        Teams[i].addManager(T);
                    }
                }
                if (i == 2)
                {
                    Teams[i].SetStadium("Wembley");
                    for (int j = 0; j < 15; j++)
                    {
                        if (j >= 0 && j < 2)
                        {
                            string a;
                            string patha = Path.GetRandomFileName();
                            patha = patha.Replace(".", ""); // Remove period.
                            a = patha.Substring(0, 8);
                            string b;
                            string pathb = Path.GetRandomFileName();
                            pathb = pathb.Replace(".", ""); // Remove period.
                            b = pathb.Substring(0, 8);
                            string c;
                            string pathc = Path.GetRandomFileName();
                            pathc = pathc.Replace(".", ""); // Remove period.
                            c = pathb.Substring(0, 8);
                            Footballer x = new Footballer(a, b, c, random.Next(0, 26), "Totenham", "GoalKeeper", random.Next(0, 38), random.Next(0, 32));
                            Teams[i].AddPlayer(x);
                            NumofWorkers++;
                        }
                        if (j >= 2 && j < 5)
                        {
                            string a;
                            string patha = Path.GetRandomFileName();
                            patha = patha.Replace(".", ""); // Remove period.
                            a = patha.Substring(0, 8);
                            string b;
                            string pathb = Path.GetRandomFileName();
                            pathb = pathb.Replace(".", ""); // Remove period.
                            b = pathb.Substring(0, 8);
                            string c;
                            string pathc = Path.GetRandomFileName();
                            pathc = pathc.Replace(".", ""); // Remove period.
                            c = pathb.Substring(0, 8);
                            Footballer x = new Footballer(a, b, c, random.Next(0, 26), "Totenham", "Striker", random.Next(0, 38), random.Next(0, 32));
                            Teams[i].AddPlayer(x);
                            NumofWorkers++;
                        }
                        if (j >= 5 && j < 9)
                        {
                            string a;
                            string patha = Path.GetRandomFileName();
                            patha = patha.Replace(".", ""); // Remove period.
                            a = patha.Substring(0, 8);
                            string b;
                            string pathb = Path.GetRandomFileName();
                            pathb = pathb.Replace(".", ""); // Remove period.
                            b = pathb.Substring(0, 8);
                            string c;
                            string pathc = Path.GetRandomFileName();
                            pathc = pathc.Replace(".", ""); // Remove period.
                            c = pathb.Substring(0, 8);
                            Footballer x = new Footballer(a, b, c, random.Next(0, 26), "Totenham", "midelfield", random.Next(0, 38), random.Next(0, 32));
                            Teams[i].AddPlayer(x);
                            NumofWorkers++;
                        }
                        if (j >= 9 && j < 12)
                        {
                            string a;
                            string patha = Path.GetRandomFileName();
                            patha = patha.Replace(".", ""); // Remove period.
                            a = patha.Substring(0, 8);
                            string b;
                            string pathb = Path.GetRandomFileName();
                            pathb = pathb.Replace(".", ""); // Remove period.
                            b = pathb.Substring(0, 8);
                            string c;
                            string pathc = Path.GetRandomFileName();
                            pathc = pathc.Replace(".", ""); // Remove period.
                            c = pathb.Substring(0, 8);
                            Footballer x = new Footballer(a, b, c, random.Next(0, 26), "Totenham", "FullBack", random.Next(0, 38), random.Next(0, 32));
                            Teams[i].AddPlayer(x);
                            NumofWorkers++;
                        }
                        if (j >= 12 && j < 15)
                        {
                            string a;
                            string patha = Path.GetRandomFileName();
                            patha = patha.Replace(".", ""); // Remove period.
                            a = patha.Substring(0, 8);
                            string b;
                            string pathb = Path.GetRandomFileName();
                            pathb = pathb.Replace(".", ""); // Remove period.
                            b = pathb.Substring(0, 8);
                            string c;
                            string pathc = Path.GetRandomFileName();
                            pathc = pathc.Replace(".", ""); // Remove period.
                            c = pathb.Substring(0, 8);
                            Footballer x = new Footballer(a, b, c, random.Next(0, 26), "Totenham", "Defender", random.Next(0, 38), random.Next(0, 32));
                            Teams[i].AddPlayer(x);
                            NumofWorkers++;
                        }
                        string g;
                        string pathg = Path.GetRandomFileName();
                        pathg = pathg.Replace(".", ""); // Remove period.
                        g = pathg.Substring(0, 8);
                        string h;
                        string pathh = Path.GetRandomFileName();
                        pathh = pathh.Replace(".", ""); // Remove period.
                        h = pathh.Substring(0, 8);
                        string k;
                        string pathk = Path.GetRandomFileName();
                        pathk = pathk.Replace(".", ""); // Remove period.
                        k = pathk.Substring(0, 8);
                        Teams[i].setCoachs(g, h, k, random.Next(0, 9999999), "Totenham", random.Next(0, 20));
                        Manager T = new Manager("Maroun", "Fatocheni", "3214123", 14);
                        Teams[i].addManager(T);
                    }
                }
                if (i == 3)
                {
                    Teams[i].SetStadium("Man City");
                    for (int j = 0; j < 15; j++)
                    {
                        if (j >= 0 && j < 2)
                        {
                            string a;
                            string patha = Path.GetRandomFileName();
                            patha = patha.Replace(".", ""); // Remove period.
                            a = patha.Substring(0, 8);
                            string b;
                            string pathb = Path.GetRandomFileName();
                            pathb = pathb.Replace(".", ""); // Remove period.
                            b = pathb.Substring(0, 8);
                            string c;
                            string pathc = Path.GetRandomFileName();
                            pathc = pathc.Replace(".", ""); // Remove period.
                            c = pathb.Substring(0, 8);
                            Footballer x = new Footballer(a, b, c, random.Next(0, 26), "Liverpool", "GoalKeeper", random.Next(0, 38), random.Next(0, 32));
                            Teams[i].AddPlayer(x);
                            NumofWorkers++;
                        }
                        if (j >= 2 && j < 5)
                        {
                            string a;
                            string patha = Path.GetRandomFileName();
                            patha = patha.Replace(".", ""); // Remove period.
                            a = patha.Substring(0, 8);
                            string b;
                            string pathb = Path.GetRandomFileName();
                            pathb = pathb.Replace(".", ""); // Remove period.
                            b = pathb.Substring(0, 8);
                            string c;
                            string pathc = Path.GetRandomFileName();
                            pathc = pathc.Replace(".", ""); // Remove period.
                            c = pathb.Substring(0, 8);
                            Footballer x = new Footballer(a, b, c, random.Next(0, 26), "Liverpool", "Striker", random.Next(0, 38), random.Next(0, 32));
                            Teams[i].AddPlayer(x);
                            NumofWorkers++;
                        }
                        if (j >= 5 && j < 9)
                        {
                            string a;
                            string patha = Path.GetRandomFileName();
                            patha = patha.Replace(".", ""); // Remove period.
                            a = patha.Substring(0, 8);
                            string b;
                            string pathb = Path.GetRandomFileName();
                            pathb = pathb.Replace(".", ""); // Remove period.
                            b = pathb.Substring(0, 8);
                            string c;
                            string pathc = Path.GetRandomFileName();
                            pathc = pathc.Replace(".", ""); // Remove period.
                            c = pathb.Substring(0, 8);
                            Footballer x = new Footballer(a, b, c, random.Next(0, 26), "Liverpool", "midelfield", random.Next(0, 38), random.Next(0, 32));
                            Teams[i].AddPlayer(x);
                            NumofWorkers++;
                        }
                        if (j >= 9 && j < 12)
                        {
                            string a;
                            string patha = Path.GetRandomFileName();
                            patha = patha.Replace(".", ""); // Remove period.
                            a = patha.Substring(0, 8);
                            string b;
                            string pathb = Path.GetRandomFileName();
                            pathb = pathb.Replace(".", ""); // Remove period.
                            b = pathb.Substring(0, 8);
                            string c;
                            string pathc = Path.GetRandomFileName();
                            pathc = pathc.Replace(".", ""); // Remove period.
                            c = pathb.Substring(0, 8);
                            Footballer x = new Footballer(a, b, c, random.Next(0, 26), "Liverpool", "FullBack", random.Next(0, 38), random.Next(0, 32));
                            Teams[i].AddPlayer(x);
                            NumofWorkers++;
                        }
                        if (j >= 12 && j < 15)
                        {
                            string a;
                            string patha = Path.GetRandomFileName();
                            patha = patha.Replace(".", ""); // Remove period.
                            a = patha.Substring(0, 8);
                            string b;
                            string pathb = Path.GetRandomFileName();
                            pathb = pathb.Replace(".", ""); // Remove period.
                            b = pathb.Substring(0, 8);
                            string c;
                            string pathc = Path.GetRandomFileName();
                            pathc = pathc.Replace(".", ""); // Remove period.
                            c = pathb.Substring(0, 8);
                            Footballer x = new Footballer(a, b, c, random.Next(0, 26), "Liverpool", "Defender", random.Next(0, 38), random.Next(0, 32));
                            Teams[i].AddPlayer(x);
                            NumofWorkers++;
                        }
                        string g;
                        string pathg = Path.GetRandomFileName();
                        pathg = pathg.Replace(".", ""); // Remove period.
                        g = pathg.Substring(0, 8);
                        string h;
                        string pathh = Path.GetRandomFileName();
                        pathh = pathh.Replace(".", ""); // Remove period.
                        h = pathh.Substring(0, 8);
                        string k;
                        string pathk = Path.GetRandomFileName();
                        pathk = pathk.Replace(".", ""); // Remove period.
                        k = pathk.Substring(0, 8);
                        Teams[i].setCoachs(g, h, k, random.Next(0, 9999999), "Liverpool", random.Next(0, 20));
                        Manager T = new Manager("Jorgen", "Klopp", "3214123", 14);
                        Teams[i].addManager(T);
                    }
                }
                                if(i==4)
                                {
                                    Teams[i].SetStadium("Eitahad");
                                    for (int j = 0; j < 15; j++)
                                    {
                                        if (j >= 0 && j < 2)
                                        {
                                            string a;
                                            string patha = Path.GetRandomFileName();
                                            patha = patha.Replace(".", ""); // Remove period.
                                            a = patha.Substring(0, 8);
                                            string b;
                                            string pathb = Path.GetRandomFileName();
                                            pathb = pathb.Replace(".", ""); // Remove period.
                                            b = pathb.Substring(0, 8);
                                            string c;
                                            string pathc = Path.GetRandomFileName();
                                            pathc = pathc.Replace(".", ""); // Remove period.
                                            c = pathb.Substring(0, 8);
                                            Footballer x = new Footballer(a, b, c, random.Next(0, 26), "Man City", "GoalKeeper", random.Next(0, 38), random.Next(0, 32));
                                            Teams[i].AddPlayer(x);
                                            NumofWorkers++;
                                        }
                                        if (j >= 2 && j < 5)
                                        {
                                            string a;
                                            string patha = Path.GetRandomFileName();
                                            patha = patha.Replace(".", ""); // Remove period.
                                            a = patha.Substring(0, 8);
                                            string b;
                                            string pathb = Path.GetRandomFileName();
                                            pathb = pathb.Replace(".", ""); // Remove period.
                                            b = pathb.Substring(0, 8);
                                            string c;
                                            string pathc = Path.GetRandomFileName();
                                            pathc = pathc.Replace(".", ""); // Remove period.
                                            c = pathb.Substring(0, 8);
                                            Footballer x = new Footballer(a, b, c, random.Next(0, 26), "Man City", "Striker", random.Next(0, 38), random.Next(0, 32));
                                            Teams[i].AddPlayer(x);
                                            NumofWorkers++;
                                        }
                                        if (j >= 5 && j < 9)
                                        {
                                            string a;
                                            string patha = Path.GetRandomFileName();
                                            patha = patha.Replace(".", ""); // Remove period.
                                            a = patha.Substring(0, 8);
                                            string b;
                                            string pathb = Path.GetRandomFileName();
                                            pathb = pathb.Replace(".", ""); // Remove period.
                                            b = pathb.Substring(0, 8);
                                            string c;
                                            string pathc = Path.GetRandomFileName();
                                            pathc = pathc.Replace(".", ""); // Remove period.
                                            c = pathb.Substring(0, 8);
                                            Footballer x = new Footballer(a, b, c, random.Next(0, 26), "Man City", "midelfield", random.Next(0, 38), random.Next(0, 32));
                                            Teams[i].AddPlayer(x);
                                            NumofWorkers++;
                                        }
                                        if (j >= 9 && j < 12)
                                        {
                                            string a;
                                            string patha = Path.GetRandomFileName();
                                            patha = patha.Replace(".", ""); // Remove period.
                                            a = patha.Substring(0, 8);
                                            string b;
                                            string pathb = Path.GetRandomFileName();
                                            pathb = pathb.Replace(".", ""); // Remove period.
                                            b = pathb.Substring(0, 8);
                                            string c;
                                            string pathc = Path.GetRandomFileName();
                                            pathc = pathc.Replace(".", ""); // Remove period.
                                            c = pathb.Substring(0, 8);
                                            Footballer x = new Footballer(a, b, c, random.Next(0, 26), "Man City", "FullBack", random.Next(0, 38), random.Next(0, 32));
                                            Teams[i].AddPlayer(x);
                                            NumofWorkers++;
                                        }
                                        if (j >= 12 && j < 15)
                                        {
                                            string a;
                                            string patha = Path.GetRandomFileName();
                                            patha = patha.Replace(".", ""); // Remove period.
                                            a = patha.Substring(0, 8);
                                            string b;
                                            string pathb = Path.GetRandomFileName();
                                            pathb = pathb.Replace(".", ""); // Remove period.
                                            b = pathb.Substring(0, 8);
                                            string c;
                                            string pathc = Path.GetRandomFileName();
                                            pathc = pathc.Replace(".", ""); // Remove period.
                                            c = pathb.Substring(0, 8);
                                            Footballer x = new Footballer(a, b, c, random.Next(0, 26), "Man City", "Defender", random.Next(0, 38), random.Next(0, 32));
                                            Teams[i].AddPlayer(x);
                                            NumofWorkers++;
                                        }
                                        string g;
                                        string pathg = Path.GetRandomFileName();
                                        pathg = pathg.Replace(".", ""); // Remove period.
                                        g = pathg.Substring(0, 8);
                                        string h;
                                        string pathh = Path.GetRandomFileName();
                                        pathh = pathh.Replace(".", ""); // Remove period.
                                        h = pathh.Substring(0, 8);
                                        string k;
                                        string pathk = Path.GetRandomFileName();
                                        pathk = pathk.Replace(".", ""); // Remove period.
                                        k = pathk.Substring(0, 8);
                                        Teams[i].setCoachs(g, h, k, random.Next(0, 9999999), "Man City", random.Next(0, 20));
                                        Manager T = new Manager("Pep", "Guardiola", "3214123", 14);
                                        Teams[i].addManager(T);
                                    }
                                }
            }
            MakerTTi();
        }
        public void MakerTTi()
        {
            int v = 0;
            Workers = new Worker[NumofWorkers];
            for(int i=0;i<5;i++)
            {
                Workers[v] = new Coach(Teams[i].GetCoach());
                v++;
            }
            for (int i = 0; i < 5; i++)
            {
                Workers[v] = new Manager(Teams[i].GetManager());
                v++;
            }
            for (int i=0;i<15;i++)
            {
                Workers[v] = new Footballer(Teams[0].GetPlayer(i));
                v++;
            }
            for (int i = 0; i < 15; i++)
            {
                Workers[v] = new Footballer(Teams[1].GetPlayer(i));
                v++;
            }
            for (int i = 0; i < 15; i++)
            {
                Workers[v] = new Footballer(Teams[2].GetPlayer(i));
                v++;
            }
            for (int i = 0; i < 15; i++)
            {
                Workers[v] = new Footballer(Teams[3].GetPlayer(i));
                v++;
            }
            for (int i = 0; i < 15; i++)
            {
                Workers[v] = new Footballer(Teams[4].GetPlayer(i));
                v++;
            }
        }

        //public void GetObjectData(SerializationInfo info, StreamingContext context)
        //{
        //    info.AddValue()
        //    throw new NotImplementedException();
        //}
    }
}
