// See https://aka.ms/new-console-template for more information
using MathLogic;

Console.WriteLine("Laten we rekenen!");

Rekenen calculator = new Rekenen();
try
{
Console.WriteLine(" 5/0=" + calculator.delen(5, 0));
}
catch (Exception ex)
{

	Console.WriteLine("Error: " + ex.Message);
}

