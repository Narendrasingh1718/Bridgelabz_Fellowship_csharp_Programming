//using System;
//class Animal
//{
//    // Virtual method to allow overriding in derived classes
//    public virtual void Sound()
//    {
//        Console.WriteLine("Some generic animal sound");
//    }
//}
//class Dog : Animal
//{
//    // Overriding the base class method
//    public override void Sound()
//    {
//        Console.WriteLine("Bark");
//    }
//}
//class Cat : Animal
//{
//    // Overriding the base class method
//    public override void Sound()
//    {
//        Console.WriteLine("Meow");
//    }
//}
//class Runtime
//{
//    static void Main()
//    {
//        // Upcasting: Base class reference holding derived class

//        Animal myDog = new Dog();
//        Animal myCat = new Cat();

//        myDog.Sound(); // Outputs: Bark
//        myCat.Sound(); // Outputs: Meow
//    }
//}