using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CalculatorWebAPP
{
    [Serializable]
    public class Calculator
    {
        public double FirstNumber { get; set; }
        public double SecondNumber { get; set; }
        public double Result { get; set; }

        public double Add()
        {
            double result = FirstNumber + SecondNumber;
            return result;
           
        }
        public double Subtract()
        {
            double result = FirstNumber - SecondNumber;
            return result;
        }
        public double Multiple()
        {
            double result = FirstNumber * SecondNumber;
            return result;
        }
        public double Divided()
        {
                double result = FirstNumber / SecondNumber;
                return result;
        }
        public Calculator(double fNumber,double sNumber):this()
        {
            FirstNumber = fNumber;
            SecondNumber = sNumber;
        
        } 
        public Calculator()
        {
            Result = 0;
        }
    }
}