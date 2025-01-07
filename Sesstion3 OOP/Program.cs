using Sesstion3_OOP.Operator_Overload;
using System.ComponentModel;

namespace Sesstion3_OOP
{
    internal class Program
    {
        static int sumnum(int x, int y)
        {
            return x + y;
        }
        static double sumnum(double x, double y)
        {
            return x + y;
        }
        static int sumnum(int x,int y,int z)
        {
            return x + y + z;
        }
        static void Main(string[] args)
        {
            #region Function Overloading
            dynamic obj = sumnum(1, 2);
            Console.WriteLine(obj);
            #endregion

            #region Operator Overload
            //Operator Overload must be a non-private class member function
            Complex c1 = new Complex() { real = 1, imaginary = 2 };
            Complex c2 = new Complex() { real = 3, imaginary = 4 };
            Complex c3 = default; //null

            c3 = c1 + c2;
            c2 += c1;
            Console.WriteLine(c3);
            ///
            c1++;
            Console.WriteLine(c1);
            ///
            if (c1 > c2) Console.WriteLine($"c1 is bigger than c2");
            else Console.WriteLine($"c1 is not bigger than c2");
            ///
            Complex c4 = new Complex() { real = 1,imaginary = 2 };
            int y = (int)c4;
            Console.WriteLine(y);
            ///
            User user = new User()
            {
                Id = 12345,
                FullName = "Ahmed Ali",
                Email = "example@gmail.com",
                Password = "12345678",
                SecuirityStmp = Guid.NewGuid()
            };
            //mapping
            UserViewModel userviewmodel = (UserViewModel) user;
            #endregion
        }
    }
}
