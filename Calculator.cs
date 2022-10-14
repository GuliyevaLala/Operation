using System;
using System.Collections.Generic;
using System.Text;

namespace Operations
{
    class Calculator
    {
		public static void CalculatorMethod()
		{
			Console.WriteLine("Please enter the first number");
			int first = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Please choose the operation + , - , * ,  / for calculate this example");
			string operation = Console.ReadLine();
			Console.WriteLine("Please enter the second number");
			int second = Convert.ToInt32(Console.ReadLine());

			switch (operation)
			{
				case "+":
					Console.WriteLine("The result is : {0}", first + second);
					break;
				case "-":
					Console.WriteLine("The result is : {0}", first - second);
					break;
				case "*":
					Console.WriteLine("The result is : {0}", first * second);
					break;
				case "/":
					Console.WriteLine("The result is : {0}", first / second);
					break;
				default:
					Console.WriteLine("Opps..Something went wrong. Please enter valid operation to calculate this example");
					break;

			}



			//if (operation == "+")
			//{
			//	Console.WriteLine("Answer: {0}", first + second);
			//}
			//if (operation == "-")
			//{
			//	Console.WriteLine("Answer: {0}", first - second);
			//}
			//if (operation == "*")
			//{
			//	Console.WriteLine("Answer: {0}", first * second);
			//}
			//if (operation == "/")
			//{
			//	Console.WriteLine("Answer: {0}", first / second);
			//}
			//try catch istifadə etmək istəyərdim hər bir yarana biləcək case-ə görə(


		}

	}
}
