// See https://aka.ms/new-console-template for more information
// Console.WriteLine($"Hello, {this.userName}! You have {this.Age}");
ReadNameAndAge();

static void ReadNameAndAge()
{
    System.Console.WriteLine("What is your name?");
    string userName = Console.ReadLine();

    System.Console.WriteLine("What is your age?");
    int age = int.Parse(Console.ReadLine());

    System.Console.WriteLine($"Hello, {userName}! You are {age}, congratulations!");
}
