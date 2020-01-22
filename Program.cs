using System;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Grand Circus’ Room Detail Generator!");
            string UserChoice;

            do
            {


                double Length, Width;
                double area, perimeter;


                Console.WriteLine("Enter Length");
                Length = double.Parse(Console.ReadLine());

                Console.WriteLine("Enter Width");
                Width = double.Parse(Console.ReadLine());

                area = Length *= Width;
                perimeter = (Length += Width) + (Length += Width);

                Console.WriteLine("The area is " + area);
                Console.WriteLine("The perimeter is " + perimeter);

                Console.WriteLine("Continue? Yes or No");
                UserChoice =
                Console.ReadLine();

      

            } while (UserChoice == "yes");

            
        }
    }
}
