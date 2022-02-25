//Caden Gardner
//2-24-2022
//Class file for SpecFlowCalculator
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

        public int Subtract()
        {
            return FirstNumber - SecondNumber;
        }

        public int Multiply()
        {
            return FirstNumber * SecondNumber;
        }

        public int Divide()
        {
            return FirstNumber / SecondNumber;
        }

        //method for chained operations
        //arguments: character for operation, other number for operation
        //parameters: char op, int num
        //returns: int result of operation
        public int Operation(char op, int num)
        {
            if (op == '+')
            {
                return FirstNumber + num;
            }

            else if (op == '-')
            {
                return FirstNumber - num;
            }

            else if (op == '*')
            {
                return FirstNumber * num;
            }

            else if (op == '/')
            {
                return FirstNumber / num;
            }

            else if (op == '%')
            {
                return FirstNumber % num;
            }

            return -1;
        }
    }
}