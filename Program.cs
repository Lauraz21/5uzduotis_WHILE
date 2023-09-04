// 5

using System;

Console.WriteLine("Iveskite skaicius:" +
    "\nIvedus baigti - programa sustos ");

float sum = 0;
int i = 1;
bool continueSum = true;

do
{
    string userInput = Console.ReadLine();

    continueSum = userInput != "baigti";

    if (continueSum)
    {
        float userInput2 = Convert.ToSingle(userInput);
        sum += userInput2;
    }
}
while (continueSum);
Console.WriteLine(sum);






//5.1

string password = "bananas";
string userInput;

do
{
    Console.WriteLine(" Iveskite slaptazodi: ");
    userInput = Console.ReadLine();
}
while (userInput != password);

Console.WriteLine("Slaptazodis yra teisingas ");





//5.2

Console.WriteLine("Atspekite skaiciu 1-100 ");

Random random = new Random();
int numberToGuess = random.Next(1, 100);
int number;

do
{
    number = Convert.ToInt32(Console.ReadLine());

    if (number < numberToGuess)
    {
        Console.WriteLine("The number is higher");
    }

    if (number > numberToGuess)
    {
        Console.WriteLine("The number is lower");
    }

}
while (numberToGuess != number);
Console.WriteLine("Correct!");
