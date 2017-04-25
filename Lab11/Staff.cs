using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11
{
    class Staff: Person
    {
        private string school;
        private double pay;

        public string Stschool
        {
            get
            {
                return school;
            }

            set
            {
                school = value;
            }
        }

        public double Stpay
        {
            get
            {
                return pay;
            }

            set
            {
                pay = value;
            }
        }
        public Staff(string nameInput, string addressInput, string schoolInput, double payInput)
        {
            PName = nameInput; 
            PAddress = addressInput;
            school = schoolInput;
            pay = payInput;

        }
        public Staff()
        {
            PName = "";
            PAddress = "";
            school = "";
            pay = 10000.02;

        }
        public string getSchool()
        {
            return school;
        }
        public void setSchool(string input)
        {
            school = input;
        }
        public double getPay()
        {
            return pay;
        }
        public void setPay(double input)
        {
            pay = input;
        }
        public override void toString()
        {
            Console.WriteLine("Staff: " + PName + ", " + PAddress + ", " + school + ", " + pay);
        }

    }
}
