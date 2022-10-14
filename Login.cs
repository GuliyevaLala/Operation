using System;
using System.Collections.Generic;
using System.Text;

namespace Operations {
    class Login {
        public static void CheckLogin()
        {
            Return:Console.WriteLine("Please enter your username");
            string username = Console.ReadLine();
            Console.WriteLine("Please enter your password");
            string password = Console.ReadLine();

            if (username == "cavid123" && password == "Cavid1993")
            {
                Console.WriteLine("Wellcome to your Account");
            }
            else
            {
                Console.WriteLine("Opps!!! Are you trying to hack someonelse's profile???");
                goto Return;

            }
        }
    }
}
