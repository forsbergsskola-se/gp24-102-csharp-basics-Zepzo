/*
    Ask the User for a Seed and store it in a variable.
    Initialize Random with the given Seed.
    Get three Random Numbers between 0 and 5 (including 0, excluding 5) and print them to the Console.
    Get three Random Numbers between 0 and 0.5 (including 0, excluding 0.5) and print them to the Console.
    Get three Random Numbers between 0.2 and 0.7 (including 0.2, excluding 0.7) and print them to the Console.
    Ask the user for a Critical Hit Chance between 0.0 (0%) and 1.0 (100%).

        Then simulate 5 Attacks where you roll for the Critical Hit Chance and print, whether it’s a Critical Hit. Or No Critical Hit.

    Hint: Thanks to using the Seed, you should actually receive the same results as me, if using the same Seed. Test it! :)
*/

Console.WriteLine("Give me a seed");
string seed = Console.ReadLine();
int intSeed = Convert.ToInt32(seed);
Random random = new Random(intSeed);
int intNumber1 = random.Next(0, 5);
int intNumber2 = random.Next(0, 5);
int intNumber3 = random.Next(0, 5);

Console.WriteLine("Random number between 0 and 5");

Console.WriteLine(intNumber1);
Console.WriteLine(intNumber2);
Console.WriteLine(intNumber3);

double floatNumber1 = random.NextDouble()+0.5;
double floatNumber2 = random.NextDouble()+0.5;
double floatNumber3 = random.NextDouble()+0.5;

Console.WriteLine("Random number between 0 and 0.5");

Console.WriteLine(floatNumber1);
Console.WriteLine(floatNumber2);
Console.WriteLine(floatNumber3);

double floatNumber4 = random.NextDouble()*(0.7-0.2)+0.2;
double floatNumber5 = random.NextDouble()*(0.7-0.2)+0.2;
double floatNumber6 = random.NextDouble()*(0.7-0.2)+0.2;

Console.WriteLine("Random number between 0.2 and 0.7");

Console.WriteLine(floatNumber4);
Console.WriteLine(floatNumber5);
Console.WriteLine(floatNumber6);

Console.WriteLine("Give me a critical chance (0-1)");
string critical = Console.ReadLine();
double doubleCritical = Convert.ToDouble(critical);

double roll1 = Random.Shared.NextDouble();
double roll2 = Random.Shared.NextDouble();
double roll3 = Random.Shared.NextDouble();
double roll4 = Random.Shared.NextDouble();
double roll5 = Random.Shared.NextDouble();


bool successful1 = roll1 < doubleCritical;
bool successful2 = roll2 < doubleCritical;
bool successful3 = roll3 < doubleCritical;
bool successful4 = roll4 < doubleCritical;
bool successful5 = roll4 < doubleCritical;

string isCrit = "Its a critical hit!";
string notcrit = "Its not a critical hit";


if (successful1)
{
    Console.WriteLine(isCrit);
}
else
{
    Console.WriteLine(notcrit);
}

if (successful2)
{
    Console.WriteLine(isCrit);
}
else
{
    Console.WriteLine(notcrit);
}

if (successful3)
{
    Console.WriteLine(isCrit);
}
else
{
    Console.WriteLine(notcrit);
}

if (successful4)
{
    Console.WriteLine(isCrit);
}
else
{
    Console.WriteLine(notcrit);
}

if (successful5)
{
    Console.WriteLine(isCrit);
}
else
{
    Console.WriteLine(notcrit);
}
