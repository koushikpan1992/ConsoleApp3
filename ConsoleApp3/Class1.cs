using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class Class1
    {
    }

    public class Person1
    {
        private string idNumber;
        private string personName;

        public Person1(string name, string id)
        {
            this.personName = name;
            this.idNumber = id;
        }

        public override bool Equals(Object obj)
        {
            Person1 personObj = obj as Person1;
            if (personObj == null)
                return false;
            else
                return idNumber.Equals(personObj.idNumber);
        }

        public override int GetHashCode()
        {
            return this.idNumber.GetHashCode();
        }
    }
}
