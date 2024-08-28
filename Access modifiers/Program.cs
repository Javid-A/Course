namespace Access_modifiers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Account acc = new Account();
            Console.WriteLine(acc.Public);
            BankAccount bank = new BankAccount();
            //bank.Public = 33;
            //Console.WriteLine(bank);
            //bank.Get();
        }
    }
}
