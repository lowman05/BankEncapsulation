namespace BankEncapsulation
{
    public class Program
    {
        static void Main(string[] args)
        {
            var account = new BankAccount();
            
            Console.WriteLine("New Deposit");
            account.Deposit(Convert.ToInt32(Console.ReadLine()));
            
            Console.WriteLine($"Your balance is now {account.GetBalance()}");
            



        }
    }
}
