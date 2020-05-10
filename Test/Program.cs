using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace Test
{

    public class Application
    {

        double x = 2;

        public void Run()
        {
            double x1 = 0;
            int y=1;
            Console.WriteLine("Number to root:");
            string input = Console.ReadLine();
            if (input != null && input != "") 
            y = int.Parse(input);

            int c = 1;
            while(true)
            {
                //Newtons metod formula of square root
                x1 = (x - ((x * x) - y) / (2 * x));
                Console.WriteLine("x" + c + " = " + x1);
                c++;
                if (Math.Abs(x - x1) < 0.00000000000001) 
                    break;
                else
                x = x1;
            }

            Console.WriteLine("Sqrt of " + y + " is:" +x1);
        }
        public Application()
        {
            Run();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Application App = new Application();
        }
    }
}
