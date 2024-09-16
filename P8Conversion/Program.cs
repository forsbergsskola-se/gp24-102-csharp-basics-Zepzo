/*
    Ask the user for a Number and assign the result to a variable.
    Convert the variable to Type float.
    Print the float to the Console.
    Convert the double number to type int.
    Print the int to the console.
    Convert the original string to type int.
    What happens? (Hint: You will see an Invalid Format Exception
*/

Console.WriteLine("Give me a number");
String number = Console.ReadLine();
double FloatNumber = Convert.ToDouble(number);
Console.WriteLine(number);
int IntNumber = (int) FloatNumber;
Console.WriteLine(IntNumber);

// Convering the fist string to int wont work brcause it cant trun letters in to numbers
