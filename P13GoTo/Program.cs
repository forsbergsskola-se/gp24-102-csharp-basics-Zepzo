Random random = new Random();
int number = random.Next(0, 101);
//Console.WriteLine(number);

int guesses = 0;

Console.WriteLine("Im thinking of a number guess a number");
Begining:
string answer = Console.ReadLine();
int intAnswer = Convert.ToInt32(answer);

bool isBigger = intAnswer > number;
bool isSmaller = intAnswer < number;
bool isTheSame = intAnswer == number;

if (isBigger)
{
    guesses++;
    Console.WriteLine("Your guess is too big. Guess smaller");
    goto Begining;
}
else if (isSmaller)
{
    guesses++;
    Console.WriteLine("Your guess is too small. Guess bigger");
    goto Begining;
}

else if (isTheSame)
{
    guesses++;
    Console.WriteLine("Your guess is corect");
}

else
{
    Console.WriteLine("Something went wrong please try again");
    goto Begining;
}

Console.WriteLine($"You made {guesses} guesses!");