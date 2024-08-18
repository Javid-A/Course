namespace Method__Class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WriteToConsole("Javid");
            //var value = ReturnNumber(30);
            Console.WriteLine(ReturnNumber(20));
            Console.WriteLine(ReturnWord(middleName: "Middle", name: "Name"));
            ReturnWord("Hello");
        }


        //access modifier | return type(any type or void) | Name | parameter list

        public static void WriteToConsole(string name)
        {
            Console.WriteLine($"Hello {name}");
        }

        public static int ReturnNumber(int num)
        {
            return num;
        }

        public static string ReturnWord(string name, string middleName, string surname = null!)
        {
            //return name + " " + surname; tovsiye etmirem
            //return $"{name} {surname}";
            return string.Concat(name, " ", middleName, " ", surname);
        }
        public static string ReturnWord(string word)
        {
            Console.WriteLine(word[0] + "" + word[1]);
            return "";
        }
    }
}