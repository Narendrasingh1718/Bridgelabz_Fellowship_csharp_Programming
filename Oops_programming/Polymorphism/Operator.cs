using System;

class Complex
{
    public int Real { get; set; }
    public int Imaginary { get; set; }

    public Complex(int real, int imaginary)
    {
        Real = real;
        Imaginary = imaginary;
    }

    // Overloading + operator
    public static Complex operator +(Complex c1, Complex c2)
    {
        return new Complex(
            c1.Real + c2.Real,
            c1.Imaginary + c2.Imaginary
        );
    }

    public void Display()
    {
        Console.WriteLine($"{Real} + {Imaginary}i");
    }
}

class Operator
{
    static void Main()
    {
        Complex c1 = new Complex(2, 3);
        Complex c2 = new Complex(4, 5);

        Complex result = c1 + c2; // Uses overloaded operator

        result.Display(); // Output: 6 + 8i
    }
}