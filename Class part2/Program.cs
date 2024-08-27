namespace Class_part2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Phone phone = new Phone(1,"Samsung","S24 Ultra");
            Cup cup = new Cup(1,"Coffee",4);
            Console.WriteLine(cup.Id);
        }
    }
}
