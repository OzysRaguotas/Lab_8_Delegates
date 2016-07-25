using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_7_1_Delegates
{ public delegate int MyDelegate(int x, int y);
    

    
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter x");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter y");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter action");
            string action = Console.ReadLine();

            CalcClass MyClass = new CalcClass(action);
            MyDelegate MyDel = MyClass.RetRes();
            int res = MyDel(x,y);
            Console.WriteLine("Result: {0}", res);
            Console.ReadLine();
        }
    }
}
