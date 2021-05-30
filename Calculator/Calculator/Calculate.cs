using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
   abstract class Calculate
    {
        public abstract void Multiplication(double ValueOne,double ValueTwo);
        public abstract void Division(double ValueOne, double ValueTwo);
    }
    class Result : Calculate 
    {
        public override void Multiplication(double ValueOne, double ValueTwo)
        {
            Console.WriteLine("Multiplication result is"+ ValueOne * ValueTwo);
        }
        public override void Division(double ValueOne, double ValueTwo)
        {
            Console.WriteLine("Division result is" + ValueOne / ValueTwo);
        }
    }
}
