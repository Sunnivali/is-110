// AccountTest
// Creating and manipulationg an Acoount object.
using System;

class AccountTest
{
    static void Main()
    {

        Account myAccount = new Account();

        Console.Clear();
        Console.WriteLine($"Initial name is: {myAccount.GetName()}");

        
        Console.WriteLine("Enter the name: ");
        string theName = Console.ReadLine();
        myAccount.SetName(theName);


        Console.WriteLine($"myAccount's name is: {myAccount.GetName()}");
    }
}

// A simple Account class that contians a private instance
// variavle name and public methods to Set and Get name's value.

class Account
{
    private string name;

    public void SetName(string accountName)
    {
        name = accountName;
    }

    public string GetName()
    {
        return name;
    }
}