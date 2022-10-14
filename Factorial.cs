using System;
using System.Collections.Generic;
using System.Text;

namespace Operations {
    class Factorial {

        //public int number;
        //public int factorial;

        //public Factorial()
        //{

        //}
        //public Factorial(int number, int fact)
        //{
        //    this.number = number;
        //    this.factorial = fact;       
        //    }
        //}


        public static void CalcFactorial()
        {
            int i, number, factorial;
            Console.WriteLine("Please enter the number which is you want to learn factorial");
            number = Convert.ToInt32(Console.ReadLine());
            factorial=number;

            if (number < 0)
            {
                Console.WriteLine("Negative numbers has not factorial result");
            }
            else if (number <= 1)
            {
                Console.WriteLine("{0}! {1}", number, factorial);
            }
            else
            {
                for (i = number - 1; i >= 1; i--)
                {
                    factorial = factorial * i;
                }
                Console.WriteLine("\nFactorial of Given Number is: " + factorial);
                Console.ReadLine();
            }

        }


    }
}
