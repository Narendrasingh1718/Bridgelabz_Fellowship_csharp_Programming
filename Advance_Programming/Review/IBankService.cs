using System;

namespace Review
{
    class Program
    {
        static void Main(string[] args)
        {
            IBankService service = new BankService();

            service.AddAccount();

            service.DisplayInfo();
        }
    }

    interface IBankService
    {
        void AddAccount();

        void DisplayInfo();
    }

    class BankService : IBankService
    {
        private string? accountHolderName;

        private int accountNo;

        private double amount;

        public void AddAccount()
        {
            Console.WriteLine("Enter Name:");
            accountHolderName = Console.ReadLine();

            Console.WriteLine("Enter Account Number:");
            accountNo = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Amount:");
            amount = Convert.ToDouble(Console.ReadLine());
        }

        public void DisplayInfo()
        {
            Console.WriteLine("----- Account Detail -----");

            Console.WriteLine(
                "Account Number : " + accountNo);

            Console.WriteLine(
                "Account Holder : " + accountHolderName);

            Console.WriteLine(
                "Amount : " + amount);
        }
    }
}