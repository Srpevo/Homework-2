using System.Data;
using System.Text;
using Nums;
using Math = ConsoleApp4.Math;
//For math

//#1
Numbering.AddNumbering(1);


bool CheckDay()
{
    return DateTime.Now.DayOfWeek == DayOfWeek.Tuesday;
}

Console.WriteLine(CheckDay());

//#2
Numbering.AddNumbering(2);


void Words()
{
    StringBuilder Result = new StringBuilder();

    for (; ; )
    {
        string EnteredWords = Console.ReadLine();

        if (EnteredWords.ToLower() == "Exit".ToLower())
        {
            break;
        }

        Result.Append(EnteredWords);
    }
    Console.WriteLine(Result);
}

Words();

//#3

Numbering.AddNumbering(3);


string Option = "";

Console.WriteLine("Select Math operator [+] [-] [/] [*] [||]");

Option = Console.ReadLine();
Console.Clear();

switch (Option)
{
    case "+":
        Math.SetNums();
        Console.WriteLine(Math.Addition());
        break;
    case "-":
        Math.SetNums();
        Console.WriteLine(Math.Subtraction());
        break;
    case "/":
        Math.SetNums();
        Console.WriteLine(Math.Division());
        break;
    case "*":
        Math.SetNums();
        Console.WriteLine(Math.MultiPlication());
        break;
    case "||":
        Math.SetNum();
        Console.WriteLine(Math.Absolute());
        break;
}