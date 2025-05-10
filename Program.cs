using System;


namespace NumberGuesser
{
class Program
{
    static void Main(string[] args)
    {
     
        GetAppInfo();
        string userName = GetUserName();
        GreetUser(userName);
        
        Random random = new Random();
        int correctNumber = random.Next(1, 11); // Random number between 1 and 10
        bool correctAnswer = false;

        Console.WriteLine("Guess a number between 1 and 10");
        while (!correctAnswer)
        {
            string userInput = Console.ReadLine();
            if (!int.TryParse(userInput, out int guess))
            {
                PrintColorMessage(ConsoleColor.Red, "Please enter a valid number.");
                continue;
            }

            if (guess < 1 || guess > 10)
            {
                PrintColorMessage(ConsoleColor.Red, "Please enter a number between 1 and 10.");
                continue;
            }

            if (guess == correctNumber)
            {
                PrintColorMessage(ConsoleColor.Green, "Congratulations! You guessed the correct number!");
                correctAnswer = true;
            }
            else
            {
                PrintColorMessage(ConsoleColor.Red, "Wrong guess. Try again!");
            }
        }
 
    }

    static void GetAppInfo()
    {
        string appName ="Number Guesser";
        string appVersion = "1.0.0";    
        string appAuthor = "Sylwia Rosol";
        string info = $"{appName}: Version {appVersion} by {appAuthor}";

        PrintColorMessage(ConsoleColor.DarkGray, info);

       
    }
    static string GetUserName()
    {
        Console.WriteLine("What is your name?");
        string userName = Console.ReadLine();
        return userName;
    }
    static void GreetUser(string userName)
    {
        string info = $"Hello {userName}, let's play a game!";
        PrintColorMessage(ConsoleColor.Blue, info);
    }

    static void PrintColorMessage(ConsoleColor color, string message)
    {
        Console.ForegroundColor = color;
        Console.WriteLine(message);
        Console.ResetColor();
    }

}
}