using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    internal class RunTime
    {
        public void display()
        {
            Console.WriteLine("1st Class Method");   
                
        }
    }
    class RunTime2 : RunTime
    {
       public  void display()
        {
            Console.WriteLine("Overidden By 2nd class Method");
        }
    }

   /* class RunTimeTester
   *//* {
        public static void Main(string[] ar)
        {
            RunTime2 run=new RunTime2();
            run.display();
        }
    }*/
}
