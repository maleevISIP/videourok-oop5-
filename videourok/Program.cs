using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace videourok
{
    
        class Person
        {
            private string _firstName;
            private string _lastName;

            public Person()
            {
                _firstName = "Tom";
            }

            public Person(string name, string surname)
            {
                _firstName = name;
                _lastName = surname;
            }

            public string FirstName
            {
                get { return _firstName; }
                set { _firstName = value; }
            }

            public string LastName
            {
                get { return _lastName; }
                set { _lastName = value; }
            }

            public void Display()
            {
                Console.WriteLine(FirstName + " " + LastName);
            }
        }

        class Employee : Person
        {
            private string _company;

            public Employee(string name, string surname, string company) : base(name, surname)
            {
                Company = company;
            }

            public string Company
            {
                get { return _company; }
                set { _company = value; }
            }

        }

        class Program
        {
            static void Main(string[] args)
            {
                Person person = new Person("Малевич", "Егорка");
                Employee employee = new Employee("Малеев", "Квадрат", "МойМир Майлру");

                person.Display();
                employee.Display();

                Console.ReadKey();
            }
        }
    }
