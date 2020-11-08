using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InlamningsUppgift1
{
    class Program
    {
        static void Main(string[] args)
        {


            int x;
            int y;
            int z;
            string opera1;
            string opera2;
            int answer; 

            Console.Write("Enter first term: ");
            x = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter second term: ");
            y = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter thirth term: ");
            z = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter first operator: ");
            opera1 = Console.ReadLine();

            Console.Write("Enter second operator: ");
            opera2 = Console.ReadLine();

            if (opera1 == "+" && opera2 == "+")
            {
                answer = x + y + z;
            } 
            else if (opera1 == "+" && opera2 == "-")
            {
                answer = x + y - z;
            }
            else if (opera1 == "+" && opera2 == "*")
            {
                answer = z * y + x;
            }
            else if (opera1 == "+" && opera2 == "/")
            {
                answer = z / y + x;
            }
            else
            {
                answer = 0;
            }


            Console.WriteLine(x.ToString() + " " + opera1 + " " + y.ToString() + opera2 + " " + z.ToString() + " = " + answer.ToString());





            //switch (opera1)
            //{
            //    case "+":

            //        answer = x + y;
            //        break;

            //    case "-":
            //        answer = x - y;
            //        break;

            //    case "*":
            //        answer = x * y;
            //        break;

            //    case "/":
            //        answer = x / y;
            //        break;

            //    default:
            //        answer = 0;
            //        break;


            //}


            //Console.WriteLine(x.ToString() + " " + opera1 + " " + y.ToString() + " = " + answer.ToString());

            Console.ReadLine();






            //Console.WriteLine("we are on github!");

        }
    }
}
