using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {

            Person1 p11 = new Person1("John", "63412895");
            Person1 p21 = new Person1("Jack", "63412895");
            Console.WriteLine(p11.Equals(p21));
            Console.WriteLine(Object.Equals(p11, p21));

            Person p1 = new Person { Name = "Jay", Age = 25 };
            Person p2 = p1;
            Person p3 = new Person { Name = "Jay", Age = 25 };

            var people = new List<Person> { p1, p3 };

            Console.WriteLine(p1.Equals(p3));

            Console.WriteLine(people.Distinct().Count());
            Console.WriteLine("Hello World!");
        }
    }

    public class Person : IEquatable<Person>
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public bool Equals(Person other)
        {
            if (ReferenceEquals(other, null))
                return false;

            if (ReferenceEquals(this, other))
                return true;

            return Name.Equals(other.Name) && Age.Equals(other.Age);
        }

        public override int GetHashCode()
        {
            int hashName = Name == null ? 0 : Name.GetHashCode();
            int hashAge = Age.GetHashCode();

            return hashName ^ hashAge;
        }
    }

    class Employee : IEquatable<Employee>
    {
        public Employee(int employeeId)
        {
            this.EmployeeId = employeeId;
        }

        public override bool Equals(object obj)
        {
            Employee other = (Employee)obj;
            return Equals(other); // Using the generic version
        }

        public int EmployeeId { get; private set; }

        public bool Equals(Employee other)
        {
            return other.EmployeeId == this.EmployeeId;
        }
    }
}
