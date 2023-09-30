int number1;
int number2;
float result = 0;
string answer;

Console.WriteLine("Welcome to my basic calculator !");
Console.WriteLine("Please enter your first number: ");

number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Please enter your second number: ");

number2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("What type of operation would you like to do ?");
Console.WriteLine("Please enter + for addition, - for subtraction, * for multiplication or / for division");

answer = Console.ReadLine();

if(answer == "+")
{
    result = number1 + number2;
} else if(answer == "-")
{
    result = number1 - number2;
} else if(answer == "*")
{
    result = number1 * number2;
} else if(answer == "/")
{
    result = number1 / number2;
} else
{
    Console.WriteLine("You introduce an invalid type of operation :(");
}

Console.WriteLine("The result is " + result);

Console.ReadKey();
