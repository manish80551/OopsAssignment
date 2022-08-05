using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    internal class CompileTime
    {
       public  void show()
        {
            Console.WriteLine("1st Method");
        }
       public void show(int a)
        {
            Console.WriteLine("2nd Method ");
        }

        
    }
    class CompileTimeTester : CompileTime
    {
     /*  public static void Main(string[] ar)
        {
            CompileTimeTester tester = new CompileTimeTester();
            tester.show();
            tester.show(1);
        }*/
        
    }
}
