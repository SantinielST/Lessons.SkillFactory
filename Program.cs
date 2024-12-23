// See https://aka.ms/new-console-template for more information
Console.WriteLine("\tHello,\n World!");

//double result = (double)5 / 2;


//string MyName;
//MyName = "Pavel";
//byte age = 39;
//bool havePet = true;
//float shoeSize = 43.5f;

//Console.WriteLine(MyName);

//Console.WriteLine("\t Мне 39 лет");
//Console.WriteLine("\t My name is \n {0}", MyName);
//Console.WriteLine("\u0040");

//Console.ReadKey();

//Console.WriteLine("My name is " + MyName);
//Console.WriteLine("My age is " + age);
//Console.WriteLine("Do you have a pet? " + havePet);
//Console.WriteLine("My shoe size " + shoeSize);

//Console.WriteLine("IntMin {0} ", int.MinValue);
//Console.WriteLine("IntMax {0} ", int.MaxValue);

DaysOfWeek MyFavoriteDay;

MyFavoriteDay = DaysOfWeek.Friday;

Console.WriteLine(MyFavoriteDay);

double result = 10 % 3;

Console.WriteLine("5 / 2 = {0}", result);

Console.Write("Enter your name: ");
string name = Console.ReadLine();
Console.Write("Enter your age: ");
byte age = (byte)int.Parse(Console.ReadLine());
Console.WriteLine("Your name is {0} and age is {1} ", name, age);
Console.ReadKey();


int counter = 10;
Console.WriteLine("Value : {0} Increment: {1}", counter, counter++);

enum DaysOfWeek : byte
{
    Tuesday,
    Monday,
    Wednesday,
    Friday
}

enum Semaphore : short
{
    Red = 100,
    Yellow = 200,
    Green = 300
}

