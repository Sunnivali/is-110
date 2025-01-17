
//Fig. 4.12
// Reading and writing monetary amounts with Account objects.
using System;
class AccountTest
{
    static void Main()
    {
        Account account1 = new Account("Sunniva Lien", 50.00m);
        Account account2 = new Account("Mathias Thoresen", -7.53m);
                // disply initial balance of each object
        Console.Clear();
        Console.WriteLine(
            $"{account1.Name}'s balance: {account1.Balance:C}");
        Console.WriteLine(
            $"{account2.Name}'s balance: {account2.Balance:C}");
                //prompt for then read input
        Console.Write(
            "\nEnter deposit amount for account1: ");
        decimal depositAmount = decimal.Parse(Console.ReadLine());
        Console.WriteLine($"adding {depositAmount:C} to account1 balance\n");
        account1.Deposit(depositAmount); // add to account1's balance
                // display balance
        Console.WriteLine(
            $"{account1.Name}'s balance: {account1.Balance:C}");
        Console.WriteLine(
            $"{account2.Name}'s balance: {account2.Balance:C}");
                //prompt for then read input
        Console.Write("\nEnter deposit amount for account2: ");
        depositAmount = decimal.Parse(Console.ReadLine());
        Console.WriteLine(
            $"adding {depositAmount:C} to account2 balance\n"); 
        account2.Deposit(depositAmount); //add to account2's balance
                // disply balance
        Console.WriteLine(
            $"{account1.Name}'s balance: {account1.Balance:C}");
        Console.WriteLine(
            $"{account2.Name}'s balance: {account2.Balance:C}");
    }  
}




// Fig 4.13
// Account class with a balance and a Deposit method
class Account
{
    public string Name { get; set; } // auto-implemented property
    private decimal balance; // instance variable

    public Account(string accountName, decimal initialBalance)
    {
        Name = accountName;
       if (initialBalance < 0) // if the balance is negativ
       {
            balance = 0; // set the balance to 0
       } 
       else
       {
            balance = initialBalance; // or set it to the original value
       }
    }
            //Balance property with  validation
    public decimal Balance
    {
        get
        {
            return balance;
        }
        private set // can be used only eithin the class
        {
            // validate that the balance is grater than 0.0; if it's not,
            // instance variable balance keeps its prior value
            if (value >= 0.0m) // m indecates that 0.0 is a decimal literal
            {
                balance = value;
            }
        }
    }
            // method that deposits (adds) only a valid ampunt to tha balance
    public void Deposit(decimal depositAmount)
    {
        if (depositAmount > 0.0m) // if the depositAmount is valid
        {
            Balance = Balance + depositAmount; // add it to the balance
        }
    }
}


//ikke heilt lik koden i boko, då eg ikke fekk verdien til account2 til å bli 0 fra staten av.
// fått løysning av chatgtp
//kan vær kommentarane ikke sammsvare heilt