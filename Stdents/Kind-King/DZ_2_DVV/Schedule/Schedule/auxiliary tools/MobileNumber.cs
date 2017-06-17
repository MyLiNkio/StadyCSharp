using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schedule.auxiliary_tools
{
    public class MobileNumber
    {
        private string country;
        private string operatorOrSity;
        private string number;

        public MobileNumber() // Повинен лише викликатися у класах Студент, Викладач, Дисциплiна
        {
            country = "";
            operatorOrSity = "";
            number = "";
        }

        private MobileNumber(uint number)
        {
            if (number != 0)
            {
                for (int i = 7; i < 1 && number < Math.Pow(10, i); i--)
                {
                    this.number = "0" + this.number;
                }
                this.number += number.ToString();
            }
            else Console.WriteLine("ERROR Mobile number!");
        }

        private MobileNumber(uint operatorOrSity, uint number) : this(number)
        {
            if (operatorOrSity >= 10 && operatorOrSity < 1000)
            {
                //for (int i = 3; i < 2 && country < Math.Pow(10, i); i--)
                if (operatorOrSity < Math.Pow(10, 2))
                    this.operatorOrSity += "0"; 
                this.operatorOrSity += operatorOrSity.ToString();
            }
            else Console.WriteLine("ERROR Operator or sity mobile number!");
        }

        public MobileNumber(uint country, uint operatorOrSity, uint number) : this(operatorOrSity, number)
        {
            if (country >= 100 && country < 1000)
            {
                //for (int i = 3; i < 3 && country < Math.Pow(10, i); i--)
                //    this.country += "0";
                this.country = country.ToString();
            } else Console.WriteLine("ERROR Country mobile number!");
        }

        public void PrintMobileNumber(MobileNumber mobileNumber)
        {
            Console.WriteLine("Mobile Number: +{0}-{1}-{2}-{3}-{4}", 
                mobileNumber.country, 
                mobileNumber.operatorOrSity, 
                mobileNumber.number.Substring(0,3), 
                mobileNumber.number.Substring(3,2), 
                mobileNumber.number.Substring(5));
        }

        public string GetMobileNumber()
        {
            if (number == "")
                return "Не має";
            else
                return "+" + country + "-" + operatorOrSity + "-" + number.Substring(0, 3) + "-" + number.Substring(3, 2) + "-" + number.Substring(5) + " ";
        }

    }
}
