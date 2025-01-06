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
            #region Overloading
            dynamic obj = sumnum(1, 2);
            Console.WriteLine(obj);
            #endregion
        }
    }
}
