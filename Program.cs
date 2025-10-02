// NUMBER GUESSING GAME

Random random = new Random();
bool playAgain = true;
int min = 1;   // minimum number
int max = 10;  // maximum number
int guess; // stores user's guess
int number; // stores the number to guess
int attempts; // stores number of attempts
string response;

do
{
    // Reset guess and attempts
    guess = 0;
    attempts = 0;
    number = random.Next(min, max + 1);

    while (guess != number)
    {
        Console.Write($"\nEnter a number from {min} - {max}: ");
        guess = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"Guess: {guess}");

        if (guess > number)
        {
            Console.WriteLine($"{guess} is too high");
        } 
        else if (guess < number)
        {
            Console.WriteLine($"{guess} is too low");
        }

            attempts++;
    }

    Console.WriteLine($"\nCorrect guess!! {guess} = {number}");
    Console.WriteLine($"Attempts: {attempts}");

    Console.Write("\nWould you like to play again (Y/N)? ");
    response = Console.ReadLine().Trim().ToUpper();

    if (response == "Y")
    {
        playAgain = true;
    }
    else if (response == "N")
    {
        playAgain = false;
    }

} while (playAgain);

Console.WriteLine("\nThanks for playing!");
