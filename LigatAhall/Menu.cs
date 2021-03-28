using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LigatAhall
{
    public partial class Menu : Form
    {
        private Leugatahall MyLeague;
        public Menu()
        {
            InitializeComponent();
            MyLeague = new Leugatahall();
        }
        public void addLeague(Leugatahall x)
        {
            MyLeague = x;
        }
        private void label1_Click(object sender, EventArgs e)
        {
                                                                               
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string x;
            Console.WriteLine("Enter Id For Print Worker Deatils");
            x = Console.ReadLine();
            for(int i=0;i<MyLeague.NumofWorkers;i++)
            {
                if(x==MyLeague.Workers[i].getid())
                {
                    MyLeague.Workers[i].Print();
                }
            }
            return;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string x, y, z, j="0";
            string h="0";
            string m, n, k;
            int d, g, b;
            Console.WriteLine("Enter First Name");
            x = Console.ReadLine();
            Console.WriteLine("Enter Last Name");
            y = Console.ReadLine();
            Console.WriteLine("Enter id");
            z = Console.ReadLine();
            Console.WriteLine("Enter Carrier Time");
            m = Console.ReadLine();
            d = Int32.Parse(m);
            while (h != "Arsenal" && h != "Totenham" && h != "Chelsea" && h != "Man City" && h != "Liverpool")
            {
                Console.WriteLine("Enter Correct Team Name");
                h = Console.ReadLine();
            }
            while (j != "Striker" && j != "Defender" && j != "Goal Keeper" && j != "Full Back" && j != "MidelFielder")
            {
                Console.WriteLine("Enter Position ");
                j = Console.ReadLine();
            }
            Console.WriteLine("Enter Num of Goals");
            n = Console.ReadLine();
            g = Int32.Parse(n);
            Console.WriteLine("Enter Num Of Games");
            k = Console.ReadLine();
            b = Int32.Parse(k);
            Footballer T = new Footballer(x, y, z, d,h, j, g, b);
            if (h == "Arsenal")
            {
                MyLeague.Teams[0].AddPlayer(T);
            }
            if (h == "Chelsea")
            {
                MyLeague.Teams[1].AddPlayer(T);
            }
            if (h == "Totenham")
            {
                MyLeague.Teams[2].AddPlayer(T);
            }
            if (h == "Liverpool")
            {
                MyLeague.Teams[3].AddPlayer(T);
            }
            if (h == "Man City")
            {
                MyLeague.Teams[4].AddPlayer(T);
            }
            Console.WriteLine("Footballer Added you can back to the menu");
            return;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < MyLeague.NumofWorkers; i++)
            {
                if (MyLeague.Workers[i].TopPerson() == true)
                {
                    MyLeague.Workers[i].Print();
                }
            }
            return;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            double salary=MyLeague.Workers[0].salary();
            int s;
            for(int i=0;i<MyLeague.NumofWorkers;i++)
            {
                if (MyLeague.Workers[i].salary()<salary&&MyLeague.Workers[i].GetType()==typeof(Footballer))
                {
                    s = i;
                    salary = MyLeague.Workers[i].salary();
                }
            }
            Console.WriteLine("The Lowest Salary is :"+salary);
            return;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string x, y, z;
            int u,d,h;
            Console.WriteLine("Enter Refferee First Name");
            x=Console.ReadLine();
            Console.WriteLine("Enter Refferee Last Name");
            y = Console.ReadLine();
            Console.WriteLine("Enter Refferee id");
            z = Console.ReadLine();
            Console.WriteLine("Enter Refferee Carrier Time");
            string m, n, k;
            m = Console.ReadLine();
            u = Int32.Parse(m);
            Console.WriteLine("Enter Refferee Num Of Games");
            n = Console.ReadLine();
            d = Int32.Parse(n);
            Console.WriteLine("Enter Refferee Num Of mistakes");
            k = Console.ReadLine();
            h = Int32.Parse(k);
            Refferee NewRefferee = new Refferee(x, y, z, u, d, h);
            Refferee[] temp;
            temp = new Refferee[MyLeague.ReffereeNum+1];
            for(int i=0;i<MyLeague.ReffereeNum;i++)
            {
                temp[i] = MyLeague.Refferees[i];
            }
            MyLeague.ReffereeNum++;
            MyLeague.Refferees = new Refferee[MyLeague.ReffereeNum];
            temp[MyLeague.ReffereeNum-1] = NewRefferee;
            for(int i=0;i< MyLeague.ReffereeNum;i++)
            {
                MyLeague.Refferees[i] = temp[i];
            }
            Console.WriteLine("Refferee Added you can back to the menu");
            return;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Enter Team Name For Print Team Details");
            string h;
            h=Console.ReadLine();
            if (h == "Arsenal")
            {
                MyLeague.Teams[0].Print();
            }
            if (h == "Chelsea")
            {
                MyLeague.Teams[1].Print();
            }
            if (h == "Totenham")
            {
                MyLeague.Teams[2].Print();
            }
            if (h == "Liverpool")
            {
                MyLeague.Teams[3].Print();
            }
            if (h == "Man City")
            {
                MyLeague.Teams[4].Print();
            }
            Console.WriteLine("Team printed you can back to the menu");
            return;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string x,y;
            Console.WriteLine("Enter Refferee First Name to Print his Details");
            x = Console.ReadLine();
            Console.WriteLine("Enter Refferee Last Name to Print his Details");
            y = Console.ReadLine();
            int flag = 0;
            for (int i=0;i<MyLeague.ReffereeNum;i++ )
            {
                if(MyLeague.Refferees[i].getFname()==x&& MyLeague.Refferees[i].getLname() == y)
                {
                    MyLeague.Refferees[i].Print();
                    flag = 1;
                }
            }
            if(flag == 0)
            {
                Console.WriteLine("Refferee not exist");
            }
            return;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string x, y, z;
            Console.WriteLine("Enter First Name");
            x = Console.ReadLine();
            Console.WriteLine("Enter Last Name");
            y = Console.ReadLine();
            Console.WriteLine("Enter id ");
            z = Console.ReadLine();
            MyLeague.addgoal(x,y,z);
            return;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string k;
            int h;
            Console.WriteLine("Enter Refferee Num Of mistakes");
            k = Console.ReadLine();
            h = Int32.Parse(k);
            string b;
            Console.WriteLine("Enter Refferee id");
            b = Console.ReadLine();
            for (int i = 0; i < 4; i++)
            {
                if (b == MyLeague.Refferees[i].getid())
                    MyLeague.Refferees[i].addMistakes(h);
            }
            return;
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }
    }
}
