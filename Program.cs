namespace MethodsExercise
{
    public class Program
    {
        static void Main(string[] args)
        {

            Story();

            int addNum = Add(2, 2);
            Console.WriteLine(addNum);

            int subNum = Subtract(2,2);
            Console.WriteLine(subNum);

            int divNum = Divide(4,2);
            Console.WriteLine(divNum);

            int mulNum = Multiply(5,5);
            Console.WriteLine(mulNum);

            int result = Sum(5,5,4,3,6,5,8,7,15,15);
            Console.WriteLine(result);


        }

        public static int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        public static int Subtract(int num1, int num2)
        {
            return num1 - num2;
        }

        public static int Divide(int num1, int num2)
        {
            return num1 / num2;
        }

        public static int Multiply(int num1, int num2)
        {
            return num1 * num2;
        }

        public static int Sum(params int[] numbers) 
        {
            int sum = 0;
            foreach (int number in numbers) 
            {
                sum += number;
            }
            return sum;
        }

        public static void Story() 
        {
            Console.WriteLine("What is your name?");
            string userName = Console.ReadLine();
            Console.WriteLine("What is your favorite color?");
            string userFavColor = Console.ReadLine();
            Console.WriteLine("What is your favorite animal?");
            string userFavAnimal = Console.ReadLine();
            Console.WriteLine("What is your favorite band?");
            string userFavBand = Console.ReadLine();

            Console.WriteLine($"Hello {userName}, my name is talkbot. ");
            Thread.Sleep(1000);
            Console.WriteLine("........");
            Thread.Sleep(1000);
            Console.WriteLine("........");
            Thread.Sleep(1000);
            Console.WriteLine("........");
            Thread.Sleep(1000);

            Console.WriteLine($" Thats cool to see your favorite color is {userFavColor}. My favorite color is chromium dust grey. You dont have it here.");
            Thread.Sleep(1000);
            Console.WriteLine("........");
            Thread.Sleep(1000);
            Console.WriteLine("........");
            Thread.Sleep(1000);
            Console.WriteLine("........");
            Thread.Sleep(1000);

            Console.WriteLine($"Your favorite animal is a {userFavAnimal}? Thats awesome, i enjoy those as well. ");
            Thread.Sleep(1000);
            Console.WriteLine("........");
            Thread.Sleep(1000);
            Console.WriteLine("........");
            Thread.Sleep(1000);
            Console.WriteLine("........");
            Thread.Sleep(1000);

            Console.WriteLine($"Your favorite band is {userFavBand}? Nice.. i prefer heavier music. Thanks for the chat! ");

            Console.ReadKey();
        }
    }
}
