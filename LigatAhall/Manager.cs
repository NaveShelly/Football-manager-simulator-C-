using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LigatAhall
{
   public class Manager:Worker
    {
        public Manager(string x,string y,string z,int u):base(x,y,z,u)
        {

        }
        public Manager(Manager x) : base(x)
        {

        }
        public override double salary()
        {
            return 4500 * 3 + GetCarrierTime() * 500;
        }
        public override bool TopPerson()
        {
            if (GetCarrierTime() > 4)
                return true;
            else
                return false;
        }
    }
}
