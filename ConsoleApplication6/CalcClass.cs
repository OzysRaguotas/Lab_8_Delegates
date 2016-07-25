using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_7_1_Delegates
{
    public class CalcClass
    {
        string action { get; set; }

        public CalcClass(string action)
        { this.action = action; }

        public MyDelegate RetRes()
        {
            MyDelegate mdel;
            switch (action)
            {
                case "+":
                    {
                        mdel = Calculator.Add;
                        return mdel;
                    }

                case "*":
                    {
                        mdel = Calculator.Multiple;
                        return mdel;
                    }
                case "-":
                    {
                        mdel = Calculator.Substraction;
                        return mdel;
                    }

                case "/":
                    {
                        mdel = Calculator.Divide;
                        return mdel;
                    }

                default:
                    {
                        mdel = Calculator.ReturnZero;
                        return mdel;
                    }
            }
        }
    }
}
