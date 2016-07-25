using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_7_1_Delegates
{
    public class Calculator
    {
        public static int Add(int x, int y)
        { return x + y; }
        public static int Multiple(int x, int y)
        { return x * y; }
        public static int Divide(int x, int y)
        { return x / y; }
        public static int Substraction(int x, int y)
        { return x - y; }
        public static int ReturnZero(int x, int y)
        { return 0; }
    }
}
