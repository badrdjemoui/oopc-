using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritancePolymorphism
{
    class Duck : Animal
    {

        public Duck(string name)
            : base(name)
        {
            Console.WriteLine("- Duck(string)");
        }


        public new void Move()
        {
            Console.WriteLine("Duck Move..");
        }
    }
}