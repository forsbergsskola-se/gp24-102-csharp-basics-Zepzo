Console.WriteLine("Welcome to Nim!");
Console.WriteLine("1 Player(1)");
Console.WriteLine("2 Players(2)");
string player = Console.ReadLine();
int intPlayer = Convert.ToInt32(player);

if (intPlayer == 1)
{
    int matches = 25;
    int loop = 0;
    Start:
    if (loop < matches)
    {
        Console.Write("|");
        loop++;
        goto Start;
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

}

// end of 1 player and start of 2 players

if (intPlayer == 2)
{
    int matches = 24;
    int loop = 0;
    bool isPlayer1Trun = true;
    bool isPlayer2Turn = false;
    
    Start:
    if (loop < matches)
    {
        Console.Write("|");
        loop++;
        goto Start;
    }
    
    Number:
    loop = 0;
    Console.WriteLine("");
    Console.WriteLine($"Is player1 trun:{isPlayer1Trun}|| Is player2 trun:{isPlayer2Turn}");
    Console.WriteLine($"How many matches would you like to draw?(1, 2 or 3)({matches})");
    string draw = Console.ReadLine();
    int intDraw = Convert.ToInt32(draw);
    if (intDraw == 1 || intDraw == 2 || intDraw == 3)
    {
        matches -= intDraw;
    }
    else
    {
        Console.WriteLine("Please enter a number between 1, 2 or 3");
        goto Number;
    }
    
    if (matches <= 0)
    {
        if (isPlayer1Trun)
        {
            Console.WriteLine("Oh on player 1 lost :(");
        }
        
        else if (isPlayer2Turn)
        {
            Console.WriteLine("Oh no player 2 lost :(");
        }
        goto End;
    }

    if (isPlayer1Trun)
    {
        isPlayer1Trun = false;
        isPlayer2Turn = true;
    }
    
    else if (isPlayer2Turn)
    {
        isPlayer2Turn = false;
        isPlayer1Trun = true;
    }
    goto Start;
}

End:
Console.WriteLine("Game Over");