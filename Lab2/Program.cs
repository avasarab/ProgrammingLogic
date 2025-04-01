using System.Transactions;

namespace Lab2;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

// step 1 Variable Declarations

int myInt = 23;
    Console.WriteLine(myInt);
double myDoubleNum = 8.9999D;
    Console.WriteLine(myDoubleNum);
float myFloat = 9.99999F;
    Console.WriteLine(myFloat);
char myChar = 'A';
    Console.WriteLine(myChar);
bool myBool = true;
    Console.WriteLine(myBool);
string myString = "Howdy";
    Console.WriteLine(myString);

// step 2 Type Casting

bool myNewBool= true;
    Console.WriteLine(myNewBool);
    Console.WriteLine(Convert.ToString(myNewBool));
double myDouble = 9.78;
int myNewInt = (int) myDouble;
    Console.WriteLine(myDouble);
    Console.WriteLine(myNewInt);
    Console.WriteLine(Convert.ToString(myNewInt));
    

// step 3 User Input and Type Conversion

Console.WriteLine("Enter name:");
string userName = Console.ReadLine();
Console.WriteLine("Enter age");
int age = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Hello, " + userName + " age: " + age);

// step 4 Arithmetic Operators

int num1 = 12;
int num2 = 24;

Console.WriteLine("num1: " + num1);
Console.WriteLine("num2: " + num2);

int addition = num1 + 10;
Console.WriteLine("Addition: " + addition);
int subtraction = num2 - 2;
Console.WriteLine("Subtraction: " + subtraction);
int multiplication = num1 * 3;
Console.WriteLine("Multiplication: " + multiplication);
int division = num2 / 2;
Console.WriteLine("Division: " + division);
int modulus = num1 % 2;
Console.WriteLine("Modulus: " + modulus);

// step 5 Floating Point Precision

float mySecondFloat = 1.123456789F;
Console.WriteLine(mySecondFloat); // rounded up
double mySecondDouble = 1.123456789D;
Console.WriteLine(mySecondDouble); // kept original number

// step 6 Increment and Decrement

int myMiscInt = 10;
myMiscInt++;
Console.WriteLine(myMiscInt);
myMiscInt--;
Console.WriteLine(myMiscInt);

        }
    }
