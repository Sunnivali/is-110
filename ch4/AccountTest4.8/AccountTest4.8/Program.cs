// AccountTest
// Fig. 4.9 Using tha Account constructor to set an Account's name
// when an Account object is created.
using System;

class AccountTest
{
    static void Main()
    {

        Account account1 = new Account("Sunniva");
        Account account2 = new Account("Mathias");

        Console.Clear();
        Console.WriteLine($"account1 name is: {account1.Name}");
        Console.WriteLine($"account2 name is: {account2.Name}");
    }
}

// Fig. 4.8 Account class with a constructor that initializes an Account's name.

class Account
{

    public string Name { get; set; }
    public Account(string accountName)
    {
        Name = accountName;
    }
}