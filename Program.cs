// Author: Yanzhi Wang
// Purpose: Define a struct Friend and a class Program to demonstrate shallow copy
// Restrictions: None

using System;

namespace StructToClass
{
struct Friend
{
public string name;
public string greeting;
public DateTime birthdate;
public string address;
}
    // Class Program to demonstrate shallow copy
class Program
{
    // Main method to create objects and call methods
    static void Main(string[] args)
    {
        Friend friend;
        Friend enemy;

        // create my friend Charlie Sheen
        friend.name = "Charlie Sheen";
        friend.greeting = "Dear Charlie";
        friend.birthdate = DateTime.Parse("1967-12-25");
        friend.address = "123 Any Street, NY NY 12202";

        // now he has become my enemy
        enemy = friend;

        // set the enemy greeting and address without changing the friend variable
        enemy.greeting = "Sorry Charlie";
        enemy.address = "Return to sender.  Address unknown.";

        Console.WriteLine($"friend.greeting => enemy.greeting: {friend.greeting} => {enemy.greeting}");
        Console.WriteLine($"friend.address => enemy.address: {friend.address} => {enemy.address}");
    }
}
}

// Class Friend to demonstrate shallow copy
public class Friend
{
public string name;
public string greeting;
public DateTime birthdate;
public string address;
    // ShallowCopy method to return a shallow copy of the Friend object
public Friend ShallowCopy()
{
    return (Friend)this.MemberwiseClone();
}
}

// Class Program to demonstrate shallow copy
class Program
{
// Main method to create objects and call methods
static void Main(string[] args)
{
Friend friend = new Friend();
Friend enemy = new Friend();
        // create my friend Charlie Sheen
    friend.name = "Charlie Sheen";
    friend.greeting = "Dear Charlie";
    friend.birthdate = DateTime.Parse("1967-12-25");
    friend.address = "123 Any Street, NY NY 12202";

    // now he has become my enemy
    enemy = friend.ShallowCopy();

    // set the enemy greeting and address without changing the friend variable
    enemy.greeting = "Sorry Charlie";
    enemy.address = "Return to sender.  Address unknown.";

    Console.WriteLine($"friend.greeting => enemy.greeting: {friend.greeting} => {enemy.greeting}");
    Console.WriteLine($"friend.address => enemy.address: {friend.address} => {enemy.address}");
}
}
