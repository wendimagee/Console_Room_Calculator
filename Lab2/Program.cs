using System;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Length: ");
            string string1 = Console.ReadLine();
            float length = float.Parse(string1);

            Console.Write("Enter Width: ");
            string string2 = Console.ReadLine();
            float width = float.Parse(string2);

            Console.Write("Enter Height: ");
            string string3 = Console.ReadLine();
            float height = float.Parse(string3);

            float area = length * width;
            Console.WriteLine("The area is " + area);


        }
    }
}
