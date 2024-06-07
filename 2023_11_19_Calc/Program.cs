// See https://aka.ms/new-console-template for more information

Func<double, double, double> OurDelegate;

Console.WriteLine("Enter a Exc example: 5 - 6");
string ex = Console.ReadLine();
string[] exr=ex.Split(' ');
if (exr.Length != 3)
{
    Console.WriteLine("Let's Start!!!!!");
    Console.WriteLine($"Oopppps :( , Did you see the example???");
    return;
}

switch (exr[1])
{
    case "+":
        OurDelegate = (x, y) => x + y;
        break;
    case "-":
        OurDelegate = (x, y) => x - y;
        break;
    case "*":
        OurDelegate = (x, y) => x * y;
        break;
    case "/":
        OurDelegate = (x, y) => x / y;
        break;
    default:
        OurDelegate = (x, y) => double.NaN;
        break;
}
Console.WriteLine(OurDelegate(Convert.ToDouble(exr[0]), Convert.ToDouble(exr[2])));
