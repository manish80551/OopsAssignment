using Basic_of_Oops;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_of_Oops
{
   public class Employee_Details
    {
        int emp_id;
        string emp_name;
        double salary;
        string address;
        double contact_num;
        string blood_group;
        string bank_name;
        double account_num;
        string gender;


        public void employee_Info(int emp_id,string emp_name,double salary,string address,double contact_num, string blood_group, string bank_name, double account_num, string gender)
        {
            this.emp_id = emp_id;
            this.emp_name = emp_name;
            this.salary = salary;
            this.address = address;
            this.contact_num = con tact_num;
            this.blood_group = blood_group;
            this.bank_name = bank_name;
            this.account_num = account_num;
            this.gender = gender;

        }

        public void get_Details()
        {
            Console.WriteLine("Name of the employee is : {0}", emp_name);
            Console.WriteLine("Id number of the Employee : {0}", emp_id);
            Console.WriteLine("Employee Salary is : {0}", salary);
            Console.WriteLine("Employee Adress is : {0}", address);
            Console.WriteLine("Employee Contact number is : {0}", contact_num);
            Console.WriteLine("Employee BloodGroup is : "+blood_group);
            Console.WriteLine("Employee Bank is :" + bank_name);
            Console.WriteLine("Employee Bank Account Number :" + account_num);
            Console.WriteLine("Employee Gender is:" + gender);

        }
    } 
    
}

class Employee_Tester
{/*
    static void Main(string[] ar)
    
    {
        Employee_Details details = new Employee_Details();
        details.employee_Info(123, "Sagar", 7854699, "Belgum", 7894645,"O +ve","State Bank of India",84125963,"male");
        details.get_Details();
        Console.ReadLine();

    }
*/
}
