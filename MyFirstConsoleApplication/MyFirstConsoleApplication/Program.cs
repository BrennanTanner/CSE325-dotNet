// See https://aka.ms/new-console-template for more information


    //declare personal data
    string name = "Brennan Tanner";
string location = "Idaho";

//output introduction
Console.WriteLine($"My name is {name}, I am from {location}");

//output Date
Console.WriteLine("Current date and time: " + DateTime.Now.ToString("MM / dd / yyyy"));

//get and output days until xmas, code used from: https://www.grepper.com/answers/341102/how+many+days+till+christmas
DateTime Xmas = new DateTime(DateTime.Now.Year, 12, 25);
TimeSpan diff = (Xmas - DateTime.Now);
Console.WriteLine("Days until Christmas: " + diff.Days);

//code from book
double width, height, woodLength, glassArea;
string widthString, heightString;

//get width
Console.Write("Window width: ");
widthString = Console.ReadLine();
width = double.Parse(widthString);

//get height
Console.Write("Window height: ");
heightString = Console.ReadLine();
height = double.Parse(heightString);

//do some math
woodLength = 2 * (width + height) * 3.25;
glassArea = 2 * (width * height);

//output
Console.WriteLine("The length of the wood is " +
woodLength + " feet");
Console.WriteLine("The area of the glass is " +
glassArea + " square metres");

Console.WriteLine("Press any key to continue");
Console.ReadKey();
