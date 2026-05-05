using System;

// Abstract class
abstract class Animal
{
    // Abstract method (no body)
    public abstract void Sound();

    // Normal method
    public void Sleep()
    {
        Console.WriteLine("Animal is sleeping...");
    }
}

// Derived class
class Dog : Animal
{
    // Implement abstract method
    public override void Sound()
    {
        Console.WriteLine("Dog barks");
    }
}

class Wild
{
    static void Main()
    {
        Animal obj = new Dog();

        obj.Sound();  // Dog barks
        obj.Sleep();  // Animal is sleeping...
    }
}