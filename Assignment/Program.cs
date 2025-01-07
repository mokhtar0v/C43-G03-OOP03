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
        }

    }
}
