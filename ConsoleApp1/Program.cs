// See https://aka.ms/new-console-template for more information
using ConsoleApp1;
using System.Drawing;

Console.WriteLine("ENTER W AND H");
int Width = Convert.ToInt32(Console.ReadLine());
int Height = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("R eller T");
string R = Console.ReadLine();

Shape shape;

if (R == "r")
{
    Rektangel r = new Rektangel(Width, Height);
    Console.WriteLine(r.Omkrets());
    Console.WriteLine(r.Area());
}

if (R == "t")
{
    Triangel t = new Triangel(Width, Height);
    Console.WriteLine(t.Omkrets());
    Console.WriteLine(t.Area());
}




int i = int.Parse(Console.ReadLine());
