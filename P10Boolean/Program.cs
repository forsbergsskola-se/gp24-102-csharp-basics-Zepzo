/* 
    Ask the user for his age. Save it to a variable named age
First, do a few age-checks:

    Save to a bool-variable named isChild, whether the age is between 0 and 12
    Save to a bool-variable named isTeenager, whether the age is between 13 and 19
    Save to a bool-variable named isAdult, whether the age is greater 19

Then, print them all to the console like this:

    You are a child: True etc. (see sample below)
*/

Console.WriteLine("What is your age?");
string age = Console.ReadLine();
int IntAge = Convert.ToInt32(age);
bool IsChild = IntAge >= 0 && IntAge <= 12;
bool IsTeenager = IntAge >= 13 && IntAge <= 19;
bool IsAdult = IntAge >= 20;
Console.WriteLine("You are a child " + IsChild);
Console.WriteLine("You are a teenager " + IsTeenager);
Console.WriteLine("You are an adult " + IsAdult);