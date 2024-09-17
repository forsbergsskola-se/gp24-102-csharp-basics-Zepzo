/*
    Solve this Mathematical problem using code and output the result:

    Ask the user for an amount of seconds

    Simplify the time:

    Calculate, how many days, hours, minutes and seconds the time contains

        You need Division and Remainder after Division!

    Print each part of the time

    Then, print all components together in the format D.H:M:S

        Days
        Hours
        Minutes
        Seconds

    Then, print how many days that is in total as a fraction
*/

Console.WriteLine("Give me an amount of seconds");
string seconds = Console.ReadLine();
int intSeconds = Convert.ToInt32(seconds);
double doubleSeconds = Convert.ToDouble(seconds);

double doubleDays = doubleSeconds / 86400;

int days = intSeconds / 86400;
intSeconds = intSeconds - (86400 * days);

int hours = intSeconds / 3600;
intSeconds = intSeconds - (3600 * hours);

int minutes = intSeconds / 60;
intSeconds = intSeconds - (60 * minutes);

Console.WriteLine(days);
Console.WriteLine(hours);
Console.WriteLine(minutes);
Console.WriteLine(intSeconds);
Console.WriteLine($"{days}.{hours}:{minutes}:{intSeconds}");
Console.WriteLine(doubleDays);
