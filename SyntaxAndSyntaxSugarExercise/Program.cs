namespace SyntaxAndSyntaxSugarExercise
{
    public class Program
    {
        static void Main(string[] args)
        { 
            var answer = 4;
            Console.WriteLine((answer < 9) ? $" {answer} is less than 9" : $" {answer} is greater than or equal to nine");
        }
    }
}
