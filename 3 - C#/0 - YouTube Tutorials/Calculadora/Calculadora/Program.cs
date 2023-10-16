// VARIABLES INT
int numero1;
int numero2;
// VARIABLE OPERACION (+, -, * y /)
string operacion;
// VARIABLE RESULTADO
float resultado = 0;
// VARIABLE BOOLEANA
bool errorOperacion = false;

// MENSAJE 
Console.WriteLine("");
Console.WriteLine("Bienvenid@ a mi calculadora básica !");
Console.WriteLine("");

// INTRUCCIONES
Console.WriteLine("Por favor, introduce tu primer número: ");
numero1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Por favor, introduce tu segundo número: ");
numero2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Por favor, introducir + para suma, - para resta, * para multiplicación o / para división");
operacion = Console.ReadLine(); 

// LÓGICA ALTERNATIVA CONDICIONAL   
if(operacion == "+")
{
    resultado = numero1 + numero2;
}
else if(operacion == "-")
{
    resultado = numero1 - numero2;
}
else if(operacion == "*")
{
    resultado = numero1 * numero2;
}
else if(operacion == "/")
{
    resultado = numero1 / numero2;
}
else
{
    errorOperacion = true;
    Console.WriteLine("Operación no válida! Utilizar +, -, * o /");
}

// RESULTADO (FINAL)
Console.WriteLine("");
if (errorOperacion)
{
    Console.WriteLine("No se puede ver el resultado :(");
}
else
{
    Console.WriteLine("El resultado es: " + resultado);
}

Console.ReadKey();