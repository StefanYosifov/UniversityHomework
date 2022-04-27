using System;

namespace OOP3_Homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Triangle triangle=new Triangle();
            triangle.setSides();
            triangle.checkForIntegrity();
            Console.WriteLine(triangle.calculateArea());
        }
    }
}
