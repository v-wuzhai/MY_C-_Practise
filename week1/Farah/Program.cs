// See https://aka.ms/new-console-template for more information


Console.WriteLine("\n--------------------------- Motto in Different Syntax ----------------------------\n");

string Motto1 = "Find what you’d die for";
string Motto2 = "and then live for it";

Console.WriteLine($"My motto is {Motto1}, {Motto2}. "); //firstStyle
Console.WriteLine($"My motto is " + Motto1 + "," + Motto2 + "."); //secStyle

Console.WriteLine("\n------------------------------------ Trim space print ------------------------------------\n");

string firstMotto = "                  Find what you’d die for";
string secMotto = "and then live for it                             ";

firstMotto = firstMotto.TrimStart();
secMotto = secMotto.TrimEnd();

Console.WriteLine($"My motto is {firstMotto}, {secMotto}. "); //firstStyle
Console.WriteLine($"My motto is " + firstMotto + "," + secMotto + "."); //secStyle


Console.WriteLine("\n----------------------------------- Searching strings ------------------------------------\n");

string motto = $"My motto is {firstMotto} , {secMotto}.";
Console.WriteLine(motto);

Console.WriteLine("\nReplace Value");
Console.WriteLine(motto.Replace("Find", "Search"));

Console.WriteLine("\nSearch Contain");
Console.WriteLine(motto.Contains("die"));
Console.WriteLine(motto.Contains("suicide"));

Console.WriteLine("\nChange to Uppercase");
Console.WriteLine(motto.ToUpper());

Console.WriteLine("\nLength of strings");
Console.WriteLine(motto.Length);

Console.WriteLine("\nEnd with");
Console.WriteLine(motto.EndsWith("."));

Console.WriteLine("\nEnd with");
Console.WriteLine(motto.EndsWith("motto"));