using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LigatAhall
{
    abstract public class Worker : Person
    {
        private int TimeOfCarrer;
        public Worker(string x,string y,string z,int u):base(x,y,z)
        {
            TimeOfCarrer = u;
        }
        public Worker(Worker x):base(x)
        {
            TimeOfCarrer = x.TimeOfCarrer;
        }
        public string getFirstName()
        {
            return getFirstNamex();
        }
        public string getLastName()
        {
            return getLastNamex();
        }
        ~Worker()
        {
            Console.WriteLine("Worker Deleted");
        }
        public override abstract bool TopPerson();
        public abstract double salary();
        public override void Print()
        {
            base.Print();
            Console.WriteLine("TimeOfCarrier" + TimeOfCarrer);
            Console.WriteLine("Salary is :" + salary());
        }
        public string getid()
        {
            return getidx();
        }
        public int GetCarrierTime()
        {
            return TimeOfCarrer;
        }
    }
}
