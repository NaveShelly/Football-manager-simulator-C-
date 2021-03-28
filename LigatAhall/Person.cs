using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LigatAhall
{
     abstract public class Person
    {
        private string id;
        private string FirstName;
        private string Lastname;
      public Person(string x, string y, string z)
        {
            //Console.WriteLine("Person Created");
            FirstName = x;
            Lastname = y;
            id = z;
        }
        public string getFirstNamex()
        {
            return FirstName;
        }
        public string getLastNamex()
        {
            return Lastname;
        }
        public string getidx()
        {
            return id;
        }
        ~Person()
        {
            Console.WriteLine("Person Deleted");
        }
        virtual public void Print()
        {
            Console.WriteLine("First Name:" + FirstName);
            Console.WriteLine("Last Name:" + Lastname);
            Console.WriteLine("ID:" + id);
        }
        abstract public bool TopPerson();
        public Person(Person x)
        {
            id=x.id;
            FirstName=x.FirstName;
            Lastname=x.Lastname;
    }


    }
}
