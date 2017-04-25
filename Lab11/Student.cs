using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11
{
    class Student: Person
    {
        private string program;
        private int year;
        private double fee;

        public string Sprogram
        {
            get
            {
                return program;
            }

            set
            {
                program = value;
            }
        }

        public int Syear
        {
            get
            {
                return year;
            }

            set
            {
                year = value;
            }
        }

        public double Sfee
        {
            get
            {
                return fee;
            }

            set
            {
                fee = value;
            }
        }
        public Student(string nameInput, string addressInput, string programInput, int yearInput, double feeinput)
        {
            PName = nameInput; // property from base class, not the variable
            PAddress = addressInput;
            program = programInput;
            year = yearInput;
            fee = feeinput;
        }
        public Student()
        {
            PName = "";
            PAddress = "";
            program = "--";
            year = 1990;
            fee = 20000.02;
        }
        public string getProgram()
        {
            return program;
        }
        public void setProgram(string input)
        {
            program = input;
        }
        public int getYear()
        {
            return year;
        }
        public void setYear(int input)
        {
            year = input;
        }
        public double getFee()
        {
            return fee;
        }
        public void setFee(double input)
        {
            fee = input;
        }
        public override void toString()
        {
            Console.WriteLine("Student: " + PName + ", " + PAddress + ", " + Sprogram + ", " + Syear + ", " + Sfee);

        }
    }
}
