Random random = new Random();
int number = random.Next(0, 101);
//Console.WriteLine(number);

int guesses = 0;
Start:
Console.WriteLine("What do you want to play?(1-5)");
Console.WriteLine("Guess number(1)");
Console.WriteLine("Print money(2)");
Console.WriteLine("Print triangel(3)");
Console.WriteLine("Print pattern(4)");
Console.WriteLine("Exit(5)");
string Goto = Console.ReadLine();
int intGoto = Convert.ToInt32(Goto);

if (intGoto == 1)
{
    goto guessNumber;
}

else if (intGoto == 2)
{
    goto PrintMoney;
}

else if (intGoto == 3)
{
    goto PrintTriangel;
}

else if (intGoto == 4)
{
    goto PrintPattern;
}

else if (intGoto == 5)
{
    goto Exit;
}

else
{
    goto Start;
}

guessNumber:
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
Console.ReadLine();
goto Start;
// End of guess number and start of print money
PrintMoney:

Console.WriteLine("How much money do you want?");
string money = Console.ReadLine();
int intMoney = Convert.ToInt32(money);
int i = 0;

Console.Write("Here is your money: ");

while (i <= intMoney)
{
    Console.Write("$");
    i++;
}

Console.WriteLine("");
Console.ReadLine();
goto Start;
// End of print money and start of print triangel
PrintTriangel:

Console.WriteLine("How big do you want your triangel");
string triangel = Console.ReadLine();
int intTriangel = Convert.ToInt32(triangel);
int y = 1;
t1:

if (intTriangel > 0)
{
    while (y <= intTriangel)
    {
        Console.Write("#");
        y++;
    }
    Console.WriteLine("");
    intTriangel--;
    y = 1;
    goto t1;
}
else
{
    Console.ReadLine();
    goto Start;
}
// End of print triangel and start of print pattern
PrintPattern:

Console.WriteLine("How big do you want your pattern?");
string patern = Console.ReadLine();
int intPatern = Convert.ToInt32(patern);
int p = 0;
p1:
bool isEven = p % 2 == 0;


if (p < intPatern)
{
    if (isEven)
    {
        Console.WriteLine("#-#-#-#-#-");
        p++;
        goto p1;
    }

    else if (!isEven)
    {
        Console.WriteLine("-#-#-#-#-#");
        p++;
        goto p1;
    }
}

Console.ReadLine();
goto Start;
//End of print pattern

Exit:
Console.WriteLine("Quiting the program");