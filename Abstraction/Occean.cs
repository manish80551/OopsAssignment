using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    internal class Occean
    {
       public void biggest()
        {
            Console.WriteLine("Ocean is Biggest source of Water");
        }
    }
    class Sea : Occean
    {
        public void bigger()
        {
            Console.WriteLine("Sea is second Largest source of Water");
        }
    }

    class River : Sea
    {
        public void Smallest()
        {
            Console.WriteLine("River is the Smallest source of Water");
        }
    } 

    class WaterTester
    {
        public static void Main(string[] ar)
        {
            River tester = new River();
            tester.biggest();
            tester.bigger();
            tester.Smallest();
        }
    }
}
