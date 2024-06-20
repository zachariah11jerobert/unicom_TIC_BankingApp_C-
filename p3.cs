namespace BankApp
{
    class Account
    {
        public string accountNumber;
        public string accountHolderName;
        public float balance;

        public void printDetails()
        {
            Console.WriteLine($"Account Number : {this.accountNumber} \n Account Holder Name : {this.accountHolderName} \n Balance : {this.balance}");
            Console.WriteLine("----------------------------------------------------");
        }

      
    }

    class Bank
    {
        int accountIndex=0;
        Account[] accounts=new Account[10];

        public void createAccount()
        {

            Account accountObj = new Account();

            Console.Write("Enter Account Number : ");
            accountObj.accountNumber = Console.ReadLine();

            Console.Write("Enter Account Holder Name : ");
            accountObj.accountHolderName = Console.ReadLine();

            Console.Write("Enter Account Initial Balance : ");
            accountObj.balance = float.Parse(Console.ReadLine());

            accounts[accountIndex] = accountObj;
            accountIndex = accountIndex + 1;
        }

        public void listAccounts()
        {
            for(int i = 0; i < accountIndex; i = i + 1)
            {
                accounts[i].printDetails();
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Bank bankObj = new Bank();

            string isExit = "no";
            while (isExit != "yes")
            {
                Console.WriteLine("" +
                    "1. Create Account \n" +
                    "2. List Accounts \n" +
                    "3. Remove Accounts");

                string option = Console.ReadLine();
                Console.Clear();
                switch (option)
                {
                    case "1":

                        string isAccountCreate = "yes";
                        while (isAccountCreate != "no")
                        {
                            bankObj.createAccount();
                            Console.Write("-----Do you want to create Accont yes/no : ");
                            isAccountCreate = Console.ReadLine();
                        }
                        break;
                    case "2":
                        bankObj.listAccounts();
                        Console.WriteLine("Account Listing Called");
                        break;
                    case "3":
                       
                        Console.WriteLine("Delete Operation Called");
                        break;
                    default:
                        Console.WriteLine("No such Operation");
                        break;
                }

                Console.WriteLine("Do you want to exit yes/no : ");
                isExit = Console.ReadLine();
            }
        }
    }
}