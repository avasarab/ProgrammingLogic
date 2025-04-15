using System.Globalization;

namespace Lab4;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

// Problem 1: Simple For Loop

for (int x = 1; x <= 10; x++) 
{
  Console.WriteLine(x);
}

// Problem 2: Even Numbers from 1 to 20 (Using Modulus Operator)

for (int i = 1; i <= 20; i++)
if (i % 2 == 0)
{
    Console.WriteLine(i);
}

// Problem 3: While Loop Countdown

int number = 5;
while (number >= 1) 
{
  Console.WriteLine(number);
  number--;
}

// Problem 4: Do/While User Input

int numberAgain = 0;
do 
        {
            Console.Write("Enter a number greater than 100: ");
        } while (!int.TryParse(Console.ReadLine(), out numberAgain) || numberAgain <= 100);

        Console.WriteLine($"Valid number entered: {numberAgain}");

// Problem 5: While Loop – Multiples of 10 from 10 to 1000

int whileLoop = 10;
while (whileLoop <= 1000) 
{
  Console.WriteLine(whileLoop);
  whileLoop +=10;
}

// Problem 6: Pattern Printer (Using Nested Loops)

for (int triangleList = 1; triangleList <= 10; triangleList++) 
{ 
  for (int j = 1; j <= triangleList; j++) 
  {
    Console.Write("*");
  }
  Console.WriteLine();
}
    }
}
    