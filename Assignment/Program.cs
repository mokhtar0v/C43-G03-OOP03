using Assignment.Part1;
using Assignment.Part2;
using System;
namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Part1
            #region Question1
            Calculator c = new Calculator();
            Console.WriteLine($"{c.sum(1, 2)}, {c.sum(1, 2, 3)}, {c.sum(1.1, 2.2)}");
            #endregion

            #region Question2
            Rectangle rect1 = new Rectangle();
            Rectangle rect2 = new Rectangle(4, 5);
            Rectangle rect3 = new Rectangle(5);
            #endregion

            #region Question3
            Complex c1 = new Complex() { real = 2, imaginary = 5 };
            Complex c2 = new Complex() { real = 3, imaginary = 7 };
            Complex c3 = c1 + c2;
            Complex c4 = c2 - c3;
            Console.WriteLine($"{c3}, {c4}");
            #endregion

            #region Question4
            Employee emp = new Employee();
            emp.Work();
            Manager manager = new Manager();
            manager.Work();
            #endregion

            #region Question5
            BaseClass bs = new BaseClass();
            bs.DisplayMessage();
            DerivedClass1 derived1 = new DerivedClass1();
            derived1.DisplayMessage();
            DerivedClass2 derived2 = new DerivedClass2();
            derived2.DisplayMessage();
            #endregion

            #endregion

            #region Part2
            Duration D1 = new Duration(1, 10, 15);
            Console.WriteLine(D1);
            Duration D2 = new Duration(3600);
            Console.WriteLine(D2);
            Duration D3 = new Duration(7800);
            Console.WriteLine(D3);
            Duration D4 = new Duration(666);
            Console.WriteLine(D4);
            Console.WriteLine(D2+D1);
            Console.WriteLine(D1+7800);
            Console.WriteLine(666+D2);
            Console.WriteLine(++D3);
            Console.WriteLine(--D4);
            Console.WriteLine(D3 - D4);
            if (D1 > D2) Console.WriteLine("D1 is bigger");
            if (D4 <= D3) Console.WriteLine("True");
            if (D1) Console.WriteLine("True");
            DateTime obj = (DateTime)D1;
            #endregion

        }

    }
}
