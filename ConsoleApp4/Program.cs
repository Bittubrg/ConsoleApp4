using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstnum;
            int secondnum;
            string operation;
            int answer;
            Console.WriteLine("Welcome to my calcutor");
            Console.ReadLine();
            Console.WriteLine("Enter First Num");
            firstnum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Now Enter Second Num");
            secondnum = Convert.ToInt32(Console.ReadLine());
           
            Console.WriteLine("OK Now Enter Opertion (x, /, +, -, ) ");
            operation = Console.ReadLine();
            if (operation == "x")
            {
            answer = firstnum * secondnum;
            Console.WriteLine(firstnum + "x" + secondnum + "=" + answer);
            Console.ReadLine();
            }
            else if (operation == "/")
            {
            answer = firstnum / secondnum;
            Console.WriteLine(firstnum + "/" + secondnum + "=" + answer);
            Console.ReadLine();
            }
            else if (operation == "+") 
            {
            answer = firstnum + secondnum;
            Console.WriteLine(firstnum + " + " + secondnum + " = " + answer);
            Console.ReadLine();
            }
            else if (operation == "-")
             {
             answer = firstnum - secondnum;
            Console.WriteLine(firstnum + " - " + secondnum + " = " + answer);
            Console.ReadLine();
            }
            else
            {
            Console.WriteLine("Sorry that is not correct ! Please Try Again!");     
            Console.ReadLine();
            }

        }
    }
}
