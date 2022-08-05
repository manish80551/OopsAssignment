using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    interface ExampleBank
    {
        void show();
    }
    interface Sbi
    {
        void display();
    }

    interface Citi
    {
        void display(int num);
    }

    class BankFactory : ExampleBank, Sbi, Citi
    {
        public void show()
        {
            Console.WriteLine("Its Example Bank");
        }

        public void display()
        {
            Console.WriteLine("Its SBI Bank");
        }
        public void display(int num)
        {
            Console.WriteLine("Its Citi Bank");
        }
    }

    class BankTester
    {
      /*  public static void Main(string[] args)  
        {
            BankFactory bankFactory = new BankFactory();
            bankFactory.show();
            bankFactory.display();
            bankFactory.display(1);
            
        }*/  
       
        

    }
}
