namespace Lab3;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

// step 1 Operator Practice

int a = 10, b = 5, c = 15; 
Console.WriteLine(a > b);
Console.WriteLine(a < c);
Console.WriteLine(a > b && a > c); 
Console.WriteLine(a > b || c < b);

// step 2 Boolean Logic

bool isRaining = true; 
Console.WriteLine(isRaining);
bool haveUmbrella = false;
Console.WriteLine(haveUmbrella);

if (true)
{
    Console.WriteLine("Take an umbrella");
}
else
{
    Console.WriteLine("You're good to go!");
}

// step 3 Conditional Logic

Console.WriteLine("Enter age:");
int userAge = Convert.ToInt32(Console.ReadLine());
if (userAge < 5)
    {
        Console.WriteLine("Ticket is free!");
    }
if (userAge >= 5 && userAge <= 12)
    {
    Console.WriteLine("Child ticket: $5");
    }
if (userAge >= 13 && userAge <= 64)
    {
    Console.WriteLine("Standard ticket: $10");
    }
if (userAge >= 65)
    {
    Console.WriteLine("Senior ticket: $6");
    }

// step 4 Using a switch Statement

Console.WriteLine("Enter day of the week (1-7):");
int dayWeek;
if (int.TryParse(Console.ReadLine(), out dayWeek))
{
switch (dayWeek) 
{
case 1:
    Console.WriteLine("Monday");
    break;
case 2:
    Console.WriteLine("Tuesday");
    break;
case 3:
    Console.WriteLine("Wednesday");
    break;
case 4:
    Console.WriteLine("Thursday");
    break;
case 5:
    Console.WriteLine("Friday");
    break;
case 6:
    Console.WriteLine("Saturday");
    break;
case 7:
    Console.WriteLine("Sunday");
    break;
default:
    Console.WriteLine("Invalid day!");
    break;
}
}
else
    {
            Console.WriteLine("Invalid input!");
    }
    }
}

