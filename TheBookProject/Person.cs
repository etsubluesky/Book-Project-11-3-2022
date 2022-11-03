using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheBookProject
{
    internal class Person
    {

        private static int nextNumber = 1;

        private int empId;
        private string name;


        public Person(string name)
        {
            empId = nextNumber++;
            this.name = name;
        }

        public int GetEmpID()
        {
            return empId;
        }

        public string GetName()
        {
            return name;
        }

        public static int GetNextNumber()
        {
            return nextNumber;
        }
    }
}
