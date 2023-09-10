namespace VariablesExercise
{
    public class Program
    { 
        int number = 33;
        char letter = 'a';
        bool isCoderQuestionmark = false;
        double longerNumber = 3513516845321;
        decimal numberWithDot = 32.03m;

        /*
            When these are in "CLASS" you NEED to add "static"
            to the data type. because it is NOT in the scope of the main.
                    
                    string dogName = "Ralph";
                    int dogAge = 10;
        */
        



        static void Main(string[] args)
        {
         /*
            When these are in main you do not need to add "static"
            to the data type. because it is in the scope of the main.

                         string dogName = "Ralph";
                         int dogAge = 10;

         */

         /*
            Showed me a different concept of this being in main
            not sure what the point of this particular example was.
              
                         if (dogAge == 18)
                         {
                         Console.WriteLine(dogName);
                         }
         */

            Console.WriteLine("Hello, World!");
            Console.WriteLine($"My dog's name is {dogName}, He is {dogAge} years old");
        }
    }
}

