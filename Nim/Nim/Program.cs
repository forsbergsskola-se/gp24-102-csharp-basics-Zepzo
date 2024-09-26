using System.Runtime.InteropServices.JavaScript;
int intSeed = 123243;
Random random = new Random(intSeed);
Console.WriteLine("Welcome to Nim!");
int matches = 25;
int loop = 0;
Start:
if (loop < matches)
{
    Console.Write("|");
    loop++;
    goto Start;
}

else
{   
    goto Number;
}

Number:
loop = 0;
Console.WriteLine("");
Console.WriteLine($"How many matches would you like to draw?(1, 2 or 3)({matches})");
string draw = Console.ReadLine();
int intDraw = Convert.ToInt32(draw);
if (intDraw == 1 || intDraw == 2 || intDraw == 3)
{
    matches -= intDraw;
    goto AiStart;
        
        
}
else
{
    Console.WriteLine("Please enter a number between 1, 2 or 3");
    goto Number;
}

AiStart:
if (matches <= 0)
{
    Console.WriteLine("Oh no! you lost :(");
    goto End;
}
int intNumber1 = 4 - intDraw;
Console.WriteLine($"The AI draws {intNumber1} matches");
matches -= intNumber1;

if (matches > 0)
{
    goto Start;
}

if (matches <= 0)
{
    Console.WriteLine("You win! yay :)");
    goto End;
}

End:
Console.WriteLine("Game Over");