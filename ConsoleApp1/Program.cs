// See https://aka.ms/new-console-template for more information
using ConsoleApp1;
using System.Security.Cryptography.X509Certificates;

Console.WriteLine("ENTER W AND H");
int Width = Convert .ToInt32(Console.ReadLine());
int Height = Convert .ToInt32(Console.ReadLine());
Console.WriteLine("R eller T");
string R  = Console.ReadLine();
Shape s;
if (R == "r")
{
    s = new Rektangel(Width, Height);
    Console.WriteLine(s.Omkrets());
    Console.WriteLine(s.Area());
}

if (R == "t")
{
    s = new Triangel(Width, Height);
    Console.WriteLine(s.Omkrets());
    Console.WriteLine(s.Area());
}


int i = int.Parse(Console.ReadLine());
