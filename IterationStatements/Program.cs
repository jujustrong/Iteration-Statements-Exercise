using System.Threading.Channels;

namespace IterationStatements
{
    public class Program
    {
        //LukeWarm Section: Create methods below
        //Write a method that will print to the console all numbers 1000 through - 1000
        public static void NumPrinter()
        {
            for (int i = 1000; i <= 1000 && i >= -1000; i--) {Console.WriteLine(i);}
        }
        //Write a method that will print to the console numbers 3 through 999 by 3 each time
        public static void ByThree()
        {
            for (int i = 3; i >= 3 && i <= 999; i+=3) {Console.WriteLine(i);}
        }
        //Write a method to accept two integers as parameters and check whether they are equal or not
        public static string EqualNums(int num1, int num2)
        {
            Console.WriteLine("Let's see if those two numbers are equal...");
            Thread.Sleep(1000);
            return num1 == num2 ? "nums are equal" : "nums are NOT equal";
            // if (num1 == num2) {return $"nums are equal";} else{return "$nums are not equal";}
        }
        //Write a method to check whether a given number is even or odd
        public static string EvenOrOdd()
        {
            Console.Write("Enter a number to see if it is even or odd: ");
            var userInput = Convert.ToInt32(Console.ReadLine());
            return userInput % 2 == 0 ? $"{userInput} is even" : $"{userInput} is odd";
        }
        //Write a method to check whether a given number is positive or negative
        public static string PosNeg()
        {
            Console.Write("Enter a number to see if it is positive or negative: ");
            var userInput = Convert.ToInt32(Console.ReadLine());
            if (userInput >= 0)
            {
                return $"{userInput} is positive.";
            }
            else
            {
                return $"{userInput} is negative.";
            }
        }
        //Write a method to read the age of a candidate and determine whether they can vote.
        //Hint: Use Parse or the safer TryParse() for an extra challenge
        //Parse()
        //TryParse()
        public static string OldEnough()
        {
            Console.WriteLine("Welcome to the Voting Age Verifier");
            Thread.Sleep(1000);
            Console.Write("Please enter your age: ");
            var userAge = int.TryParse(Console.ReadLine(), out var age);
            Thread.Sleep(1000);
            return age < 18 ? $"Sorry you have {18-age} more year(s) left until you are eligible!" : "Go Vote!";
        }
        //Heating Up Section:
        //Write a method to check if an integer(from the user) is in the range -10 to 10
        public static void InRange()
        {
            Console.Write("Please enter a number: ");
            int.TryParse(Console.ReadLine(), out var num);
            Console.WriteLine("Let's see if that is in the range...");
            Thread.Sleep(1000);

            if (-10 <= num && num <= 10)
            {
                Console.WriteLine($"Nice! {num} is in the range!");
            }
            else
            {
                Console.WriteLine("It looks like that number is out of the range...");
            }
        }
        //Write a method to display the multiplication table(from 1 to 12) of a given integer

        public static void TimesTable()
        {
            Console.Write("Enter a number to see it's multiplication table: ");
            var number = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("{0} x {1} = {2}", i, number, i * number);   //using string formatting to make the table look cleaner
            }
        }
        //Call the methods to test them in the Main method below
        static void Main(string[] args)
        {
            // NumPrinter();
            
            // ByThree();
            
            // var isEqual = EqualNums(10, 10);
            // Console.WriteLine(isEqual);

            // var isEven = EvenOrOdd();
            // Console.WriteLine(isEven);

            // var isPos = PosNeg();
            // Console.WriteLine(isPos);

            // var canVote = OldEnough();
            // Console.WriteLine(canVote);
            
            // InRange();
            
            // TimesTable();
        }
    }
}
