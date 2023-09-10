namespace VariablesExercise
{
    public class Program
    { 
        int number = 33;
        char letter = 'a';
        bool isCoderQuestionmark = false;
        double longerNumber = 3513516845321;
        decimal numberWithDot = 32.03m;





        static void Main(string[] args)
        {
            string dogName = "Ralph";
            int dogAge = 10;

                if (dogAge == 18)
                {
                    Console.WriteLine(dogName);
                }

            Console.WriteLine("Hello, World!");
            Console.WriteLine($"My dog's name is {dogName}, He is {dogAge} years old");
        }
    }
}

