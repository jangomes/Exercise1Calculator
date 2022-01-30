using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1Calculator
{
    public class Calculator
    {
      
        private int option;
        public int Option
        {
            get { return this.option; }
            set { this.option = value; }
        }

        private double n1;
        public double N1
        {
            get { return this.n1; }
            set { this.n1 = value; }
        }

        private double n2;
        public double N2
        {
            get { return this.n2; }
            set { this.n2 = value; }
        }

        


        public void cal()
        {       
                        if (option == 1)
                        {
                            Console.WriteLine("The sum of the number: " + n1 + "+" + n2 + " = " + (n1 + n2));
                        }
                        else if (option == 2)
                        {
                            Console.WriteLine("The subtraction of the number: " + n1 + "-" + n2 + " = " + (n1 - n2));
                        }
                        else if (option == 3)
                        {
                            Console.WriteLine("The multiplication of the number: " + n1 + "*" + n2 + " = " + (n1 * n2));
                        }
                        else if (option == 4)
                        {
                            Console.WriteLine("The division of the number: " + n1 + "/" + n2 + " = " + (n1 / n2));
                        }
                        else
                        {
                            Console.WriteLine("Sorry, an error occurred. Try again!");
                        }
                        
                    }
              
            }

        }
    


