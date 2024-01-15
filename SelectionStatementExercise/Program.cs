namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            var r = new Random();
            var favNumber = r.Next(1, 1000);

            Console.WriteLine("Try and guess my favorite number!");
            var userInput = int.Parse(Console.ReadLine());



            if (favNumber > userInput)
            {
                Console.WriteLine("Too Low");

            }
           
            
            else if (favNumber < userInput)
            {
                Console.WriteLine("Too high");

            }


            else 
            {

                Console.WriteLine("Correct!");
            }
        }
    }
}
