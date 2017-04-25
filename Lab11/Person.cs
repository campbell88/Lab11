using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11
{
    class Person
    {
        private string Name;
        private string Address;

        public string PName
        {
            get
            {
                return Name;
            }
           set
            {
                Name = value;
            }

        }

        public string PAddress
        {
            get
            {
                return Address;
            }

            set
            {
                Address = value;
            }
        }

        public Person(string NameInput, string AddressInput)
        {
            Name = NameInput;
            Address = AddressInput;
        }
        public Person() //default constructor
        {
            Name = "--";
            Address = "--";
        }
        public string getName()
        {
            return Name;
        }
        public string getAddress()
        {
            return Address;

        }
        public void setAddress(string input)
        {
            Address = input;
        }

        public virtual void toString()
        {
            Console.WriteLine("Person: " + Name + ", " + Address);

        }
    }
}
