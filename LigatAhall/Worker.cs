using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LigatAhall
{
   abstract class Worker: Person
    {
        private int TimeOfCarrer;
        public Worker(int x)
        {
            TimeOfCarrer = x;
        }
        ~Worker()
        {
            Console.WriteLine("Worker Deleted");
        }
        public bool TopPerson();

    }
}
