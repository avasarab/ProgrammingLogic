namespace Lab5;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

// step 1 Problem 1: Seasons of the Year

string[] strSeason = { "Spring", "Summer", "Fall", "Winter" };
foreach (string str in strSeason)
 {
    Console.WriteLine($"Season: {str}");
 }
// step 2 Problem 2: Days of the Week (1–7)

string[] days = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
    Console.Write("Enter a number (1–7): ");
    if (int.TryParse(Console.ReadLine(), out int num) && num >= 1 && num <= 7)
    {
    Console.WriteLine($"That day is: {days[num - 1]}");
    }
    else
    {
    Console.WriteLine("Invalid input! Enter a number between 1 and 7.");
    }

// step 3 Problem 3: Favorite Books and Authors

string[] books = { "Harry Potter", "A Court of Thorns And Roses", "Legends and Lattes" };
string[] authors = {"JK Rowling", "Sarah J Maas", "Travis Baldree" };
    for (int i = 0; i < books.Length; i++)
{
    Console.WriteLine($"{books[i]} by {authors[i]}");
}

// step 4 Problem 4: Temperature Tracker

int[] temperatures = { 65, 72, 78, 70, 68 };
    Array.Sort(temperatures);
    Console.WriteLine("Sorted Temperatures: " + string.Join(" ", temperatures));
    Console.WriteLine($"Highest Temperature: {temperatures[^1]}");
    Console.WriteLine($"Lowest Temperature: {temperatures[0]}");

// step 5 Problem 5: Reverse Countdown
int [] countdown = { 5, 4, 3, 2, 1 };
    Array.Reverse(countdown);
    Console.Write("Countdown: ");
        for (int i = 0; i < countdown.Length; i++)
        {
            Console.Write(countdown[i] + " ");
        }
    }
