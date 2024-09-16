/*
    Ask the user for his age

    Print one of these statements (the correct one):

        You are an adult
        You are a child
        You are a teenager

    Ask the user for another integer

    Tell him, which is the greater number, the number just given, or his age

    Tell him, whether the greater number is

        an even (like 2 4 6) number
        an odd (like 1 3 5) number

    Hint: How you can find out, whether a number is even or odd?

    Hint: There is an arithmetic operator on the operators-slide that helps you here :)

    Hint: Don't feel ashamed asking another student or googling How to find out if a number is even c#

    BONUS: Do the age-task using the ternary operator
*/

Console.WriteLine("What is your age?");
string age = Console.ReadLine();
int intAge = Convert.ToInt32(age);

bool isChild = intAge >= 0 && intAge <= 12;
bool isTeenager = intAge >= 13 && intAge <= 19;
bool isAdult = intAge >= 20;

if (isChild)
{
    Console.WriteLine("You are a Child");
}

else if (isTeenager)
{
    Console.WriteLine("You are a teenager");
}

else if (isAdult)
{
    Console.WriteLine("You are an adult");
}

else
{
    Console.WriteLine("Something went wrong please try again");
}

Console.WriteLine("Give me a new number");
string number = Console.ReadLine();
int intNumber = Convert.ToInt32(number);

bool isBigger = intAge < intNumber;
bool isSmaller = intAge > intNumber;

bool isEven = intNumber % 2 == 0;

if (isBigger)
{
    Console.WriteLine("This number is bigger");
}

else if (isSmaller)
{
    Console.WriteLine("Your age is bigger");
}

else
{
    Console.WriteLine("Something went wrong please try again");
}

if (isEven)
{
    Console.WriteLine("Your number is even");
}

else
{
    Console.WriteLine("Your number is odd");
}


