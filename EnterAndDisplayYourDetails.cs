using System;
    class Program
    {
        static void Main()
        {
            string _name = "", _surname = "", _address = "", _nationality;
            int _age;

            Console.Write("Enter your name: ");
            _name = Console.ReadLine();

            Console.Write("Enter your Surname: ");
            _surname = Console.ReadLine();

            Console.Write("Enter your Age: ");
            _age = int.Parse(Console.ReadLine());

            Console.Write("Enter your Address: ");
            _address = Console.ReadLine();

            Console.Write("Enter your Nationality: ");
            _nationality = Console.ReadLine();
            Console.WriteLine("");

            Console.WriteLine("Name: {0}\nSurname: {1}\nAge: {2}\nAddress: {3}\nNationality: {4}",_name,_surname,_age,_address,_nationality);


          
        }
    }

