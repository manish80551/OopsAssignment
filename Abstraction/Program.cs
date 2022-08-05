using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    interface I1
    {
        void show();
    }
    interface I2
    {
        void display();
    }

    class Tester : I1, I2
    {
       public void show(){
            Console.WriteLine("First Interface");
        }
        public void display()
        {
            Console.WriteLine("Second Interface");
        }
    } 

    class FactoryTester
    {
       /* public static void Main(string[] ar)
        {
            Tester t = new Tester();
            t.show();
            t.display();
             Console.ReadLine();

        }*/
    }
}

