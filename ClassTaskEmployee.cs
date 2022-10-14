using System;
using System.Collections.Generic;
using System.Text;

namespace Operations {
    class ClassTaskEmployee {
public string name;
        public string surname;
        public int age;
        public string address;
        public bool isMarried;

        public ClassTaskEmployee() : this("Lana", "Del Rey", 29)
        {
            Console.WriteLine("Hii");
        }

        public ClassTaskEmployee(int number)
        {
            Console.WriteLine(number);
        }

        public ClassTaskEmployee(string empName, string empSurname, int empAge) : this(56)
        {
            name = empName;
            surname = empSurname;
            age = empAge;
            Console.WriteLine(name + " " + surname + " " + age);
        }

        public ClassTaskEmployee(string empAdress) : this()
        {
            address = empAdress;
            Console.WriteLine(address);
        }

        public ClassTaskEmployee(bool married) : this("Miami")
        {
            isMarried = married;
            Console.WriteLine(isMarried);
        }

        //public string FullName()
        //{
        //    return name + " " + surname;
        //}

        //public string FullData()
        //{
        //    return $"{FullName()} {age}";
        //}

        //public void FullName()
        //{
        //    Console.WriteLine("Lana Del Rey");
        //}

    }
}
