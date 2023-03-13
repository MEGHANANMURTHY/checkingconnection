using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace username //Declaring a namespace
{
    public class Program //This is a class with Types (String) and Type members like Method(m_username)
    {
        public string u;
        public void m_username()
        {
            Console.WriteLine("Enter Username");
            u = Console.ReadLine();

        }
    }
}

namespace password //Declaring a namespace
{
   public class Program //This is a class with  Types (String) and Type members like Method(m_username)
    {
        public string p;
        public string p2;
        
        //m_password method takes 2 inputs, and checks the length of the input between a range using While loop
        public void m_password()
        {
            
            Console.WriteLine("Enter a Password");
            p = Console.ReadLine();
            
            while(p.Length < 5 || p.Length >10){
               Console.WriteLine("Please enter a Password between 5 and 10 characters");
                p = Console.ReadLine(); 
            }
            
            Console.WriteLine("Renter the Password");
            p2 = Console.ReadLine();
        }
    }
}
 
namespace ExceptionHandlingDemo
{
    //Creating our own Exception Class by inheriting Exception class
    public class NumberException : Exception
    {
        //Overriding the Message property. Overriding as we need a Custom message for the custom exception
        public override string Message
        {
            get
            {
                return "Divisor Cannot be Zero";
            }
        }
    }
}

public class mainrun
{
    public static void Main()
    {
        username.Program o1 = new username.Program(); //Creating object of the class Program in Namespace username
        password.Program o2 = new password.Program(); //Creating object of the class Program in Namespace password

        o1.m_username(); //Calling the methods m_username
        o2.m_password(); //Calling the methods m_password

        Console.WriteLine(o2.p);

        
        if (o2.p != o2.p2){
            Console.WriteLine("The Passwords do not match");
        }
        
        //Code to demo Exception Handling
        int Number1, Number2, Result;
            try
            {
                Console.WriteLine("Enter First Number:");
                Number1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Second Number:");
                Number2 = int.Parse(Console.ReadLine());
                if (Number2 == 0)
                {
                    ExceptionHandlingDemo.NumberException ONE = new ExceptionHandlingDemo.NumberException();
                    throw ONE;
                    //throw new ExceptionHandlingDemo.NumberException();
                }
                Result = Number1 / Number2;
                Console.WriteLine(Result);
            }
            
            //catch (DivideByZeroException e) {
                //Console.WriteLine("Exception caught: {0}", e);
                
            //}
            //for custom exceptions, the try block can contain any business scenario
            catch (ExceptionHandlingDemo.NumberException one)
            //catch (DivideByZeroException one)
            {
                //Console.WriteLine($"Message: {one.Message}");
                //Console.WriteLine(one);
                Console.WriteLine(one.Message);
            }

    }
}