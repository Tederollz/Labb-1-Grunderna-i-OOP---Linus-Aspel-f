namespace Labb_1___Grunderna_i_OOP___Linus_Aspelöf
// Linus Aspelöf SUT23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle circle1 = new Circle(5);
            Circle circle2 = new Circle(6);

            double area1 = circle1.GetArea();
            double area2 = circle2.GetArea();

            Console.WriteLine($"\n\tArea av cirkel 1 med radie 5: {area1}" +
                $"\n\tArea av cirkel 2 med radie 6: {area2}");
            Console.ReadKey();
        }
    }
}