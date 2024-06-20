namespace BankApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string isExit = "no";
            while (isExit != "yes")
            {
                Console.WriteLine("working......");

                Console.WriteLine("Do you want to exit yes/no : ");
                isExit=Console.ReadLine();
            }
        }
    }
}