namespace BankApp
{
    class Program
    {
        static void Main(string[] args)
        {
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
                        Console.WriteLine("Account Creation Called");
                        break;
                    case "2":
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