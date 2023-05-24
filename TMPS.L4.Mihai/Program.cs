using TMPS.L4.Mihai.Iterator;
using TMPS.L4.Mihai.Observer;
using TMPS.L4.Mihai.Strategy;

class Program
{
    static void Main(string[] args)
    {
        BankAccount bankAccount = new BankAccount();
        bankAccount.RegisterObserver(new SmsNotification());
        bankAccount.RegisterObserver(new EmailNotification());

        bankAccount.Balance = 1000;

        // Strategy pattern usage
        IInterestCalculator calculator = new SimpleInterestCalculator();
        double interest = calculator.CalculateInterest(bankAccount.Balance);
        Console.WriteLine($"Interest: {interest}");

        // Iterator pattern usage
        List<string> transactions = new List<string> { "Deposit", "Withdraw", "Transfer" };
        IIterator iterator = new TransactionHistoryIterator(transactions);
        while (iterator.HasNext())
        {
            string transaction = (string)iterator.Next();
            Console.WriteLine($"Transaction: {transaction}");
        }
    }
}