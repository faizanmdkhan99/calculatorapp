using System;
using calculateapp;
namespace calculatorapp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the numbers");
            int x=Convert.ToInt32(Console.ReadLine());
            int y=Convert.ToInt32(Console.ReadLine());
            calculate obj=new calculate();
            obj.add(x,y);
            obj.subtract(x,y);
            obj.product(x,y);
            obj.divide(x,y);

        }
    }
}
