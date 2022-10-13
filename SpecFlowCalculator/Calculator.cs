using System;

namespace SpecFlowCalculator
{
    public class Calculator
    {
        public int FirstNumber { get; set; }
        public int SecondNumber { get; set; }

        public int Add()
        {
            return FirstNumber + SecondNumber;
        }

        public int AddNum(int num)
        {
            FirstNumber = FirstNumber + num;
            return FirstNumber;
        }

        public int Subtract()
        {
            return FirstNumber - SecondNumber;
        }

        public int SubtractNum(int num)
        {
            FirstNumber = FirstNumber - num;
            return FirstNumber;
        }

        public int Multiply()
        {
            return FirstNumber * SecondNumber;
        }

        public int MultiplyNum(int num)
        {
            FirstNumber = FirstNumber * num;
            return FirstNumber;
        }

        public int Divide()
        {
            return FirstNumber / SecondNumber;
        }

        public int DivideNum(int num)
        {
            FirstNumber = FirstNumber / num;
            return FirstNumber;
        }

        public int ModuloNum(int num)
        {
            FirstNumber = FirstNumber % num;
            return FirstNumber;
        }

    }
}
