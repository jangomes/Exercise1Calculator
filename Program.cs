using System;

namespace Exercise1Calculator
{
    class Program
    {
        static void Main(string[] args)
        {

            bool finished = false;

            do
            {
                Calculator p = new Calculator();


            Console.WriteLine("Welcome to the Calculator");

            Console.WriteLine("\nPlease insert your first number: ");
            p.N1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("\nPlease insert your second number: ");
            p.N2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\nWrite one number of your option \n\n1 - Sum \n2 - Subtract \n3 - Multiply \n4 - Division \n");
            p.Option = Convert.ToInt32(Console.ReadLine());
            p.cal();

                
                Console.Write("restart (y/n)");
            char c = char.Parse(Console.ReadLine());
                
                Console.Clear();
                if (c == 'y')
            {
                finished = false;
            }
            else
            {
                finished = true;
            }
        } while (!finished);

        }

    }
}
