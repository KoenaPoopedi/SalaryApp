using System;

namespace SalaryApp;

class SalaryApp
{

    public static void Main(string[] args)
    {
        //declearing variables
        int HoursWorked;
        double RateOfPay;
        double Salary;
        string EmployeeName;
        try
        {

            //looping the system to continuously calculate the salary
            while (true)
            {
                
            Appstart:
            //prompting user to enter their name;
            Console.WriteLine("Please Enter your name:");
            EmployeeName = Console.ReadLine();

            //prompting the user to enter their rate of pay
            Console.WriteLine("Enter your rate:");

            //converting user input into a double digit
            RateOfPay = Convert.ToDouble(Console.ReadLine());

            //prompting user to enter the hours they have worked.
            Console.WriteLine("Enter hours worked:");

            //converting user input into an integer digit
            HoursWorked = Convert.ToInt32(Convert.ToDouble(Console.ReadLine()));
               
                //app termination
                if (HoursWorked == -1 || RateOfPay == -1 || EmployeeName == "-1")
                {
                    Console.WriteLine("Thank you for using the Salary App");
                    break;
                }
                else if (HoursWorked <= 0)
                {
                    Console.WriteLine("You havent been to work this month!!");
                    goto Appstart;
                }
                else if (HoursWorked >= 90)
                {
                    Console.WriteLine("You need to take a leave, overtime exedeed!!!!");
                    goto Appstart;
                }
                else
                {
                    Salary = RateOfPay * HoursWorked;
                    Console.WriteLine("Employee Name is:" + EmployeeName + "salary is:" + Salary);
                    goto Appstart;

                }
            }
        }
        catch (Exception e)
        {
            //exeption message
            Console.WriteLine("Please Enter a valid entry!!!!");
            e.ToString();
        }
    } 
}
    

