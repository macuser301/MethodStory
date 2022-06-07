using System;

namespace MethodStory
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            string userName = Console.ReadLine();

            Console.WriteLine("What is your favorite color?");
            string favoriteColor = Console.ReadLine();

            Console.WriteLine("What is your favorite band?");
            string favoriteBand = Console.ReadLine();


            Console.WriteLine("What is your favorite big animal?");
            string favoriteAnimal = Console.ReadLine();


            Console.WriteLine($"Hello {userName} I see your favorite color is {favoriteColor} and your favorite band is {favoriteBand} and your favorite animal is a {favoriteAnimal}");
            Console.WriteLine($"{favoriteBand} is very talented.");
            Console.WriteLine($" But, {userName} a {favoriteAnimal} would eat to much and cost to much to own.");

            Console.WriteLine("Name a smaller animal you would rather have?");
            string smallerAnimal = Console.ReadLine();

            Console.WriteLine($"Yes {userName} I think a {smallerAnimal} would be more benificial...");

            Console.WriteLine($"Now {userName} lets take a little quiz.Give me a number to add");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Give me another number to add.");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Give me a third number to add.");
            int num10 = int.Parse(Console.ReadLine());

            int sum = Sum(num1, num2, num10);
            Console.WriteLine($"With the sum of your 3 numbers the answer is {sum} ");

            Console.WriteLine($"Now {userName} Give me a different number.");
            int num3 = int.Parse(Console.ReadLine());

            Console.WriteLine("Give me a number to multiply to this one.");
            int num4 = int.Parse(Console.ReadLine());

            int product = Multiply(num3, num4);
            Console.WriteLine($"The product of your 2 numbers is {product}");

            Console.WriteLine("Give me another number.");
            int num5 = int.Parse(Console.ReadLine());

            Console.WriteLine("Give me another number to devide.");
            int num6 = int.Parse(Console.ReadLine());

            int devide = divide(num5, num6);
            Console.WriteLine($"{userName} the answer to your problem is {devide}.");

            Console.WriteLine($"Congratulations {userName} you passed my quiz.");

        }

        public static int Multiply(int num3, int num4)
        {
            return num3 * num4;
        }

        public static int divide(int num5, int num6)
        {

            return num5 / num6;
        }

        //public static int Exponent(int num, int exponent)
        //{
        //    return (int)Math.Pow(num, exponent);
        //}

        //public static void SayHello ()
        //{
        //    Console.WriteLine("Hello");
        //}

        public static int Sum(params int[] list)
        {
            int sum = 0;

            for(int i = 0; i < list.Length; i++)
            { 
                   sum = sum + list[i];
            }
            
            return sum;
        }
    }
}
