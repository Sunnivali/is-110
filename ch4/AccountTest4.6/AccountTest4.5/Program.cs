// AccountTest
// Creating and manipulationg an Acoount object.
using System;

class AccountTest
{
    static void Main()
    {

        Account myAccount = new Account();

        Console.Clear();
        Console.WriteLine($"Initial name is: {myAccount.Name}");

        
        Console.WriteLine("Please enter the name: ");
        string theName = Console.ReadLine();
        myAccount.Name = theName;


        Console.WriteLine($"myAccount's name is: {myAccount.Name}");
    }
}

// A simple Account class that contians a private instance
// variavle name and public methods to Set and Get name's value.

class Account
{
    private string name;

    public string Name
    {
        get
        {
            return name;
        }

        set
        {
            name = value;
        }
    }

}