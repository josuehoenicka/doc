string answer;
float result;

Console.WriteLine("What shape would you like to find the area of? Please enter 'r' for rectangle or 'a' for cicle");
Console.WriteLine("");

answer = Console.ReadLine();

if(answer == "r")
{
    Console.WriteLine("");
    Console.WriteLine("Please enter the height of the rectangle");
    float height = float.Parse(Console.ReadLine());
    Console.WriteLine("");
    Console.WriteLine("Please enter the width of the rectangle");
    float width = float.Parse(Console.ReadLine());
    result = height * width;
    Console.WriteLine("");
    Console.WriteLine("The result is " + result);
}
if(answer == "a")
{
    Console.WriteLine("");
    Console.WriteLine("Please enter the radius of the circle");
    float radius = float.Parse(Console.ReadLine());
    result = (float)Math.PI * (radius * radius);
    Console.WriteLine("");
    Console.WriteLine("The result is " + result);
}
if(answer != "r" && answer != "a")
{
    Console.WriteLine("ERROR! Invalid selection. Press any key to exit");
}
Console.ReadKey();