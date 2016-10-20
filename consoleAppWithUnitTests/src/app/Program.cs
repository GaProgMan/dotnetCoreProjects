using static System.Console;
using Library;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Basic use of the Thing class Get method
            var thing = new Thing();
            WriteLine($"The answer is {thing.Get(19, 23)}");
        }
    }
}
