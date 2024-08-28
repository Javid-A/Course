using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Access_modifiers
{
    public class BankAccount:Account
    {
       
        public BankAccount()
        {
            Account account = new Account();
            //Protected inheritance alinmadan cagirila bilmir
            //account.Protected = 5;
            Public = 5;
            Protected = 15;
        }


        public void Get()
        {
            Console.WriteLine(Protected);
        }

        public override string ToString()
        {
            return $"{Protected}";
        }
    }
}
