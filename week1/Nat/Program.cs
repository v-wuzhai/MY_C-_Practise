// Ainatul Ja'afar
// Print your motto in a C# console project using visual studio or VS Code, then check in to GitHub.

Console.WriteLine("\n--------------------------- Motto Printed in Different Syntax ----------------------------\n");

string Motto1 = "Live life";
string Motto2 = "Never give up";

Console.WriteLine($"1) My Motto are {Motto1} and {Motto2}");

Console.WriteLine($"2) My Motto are " + Motto1 + " and " + Motto2);

//-------------------------------------------------------------------------------------------------
Console.WriteLine("\n------------------------------------ Trim space print ------------------------------------\n");

string firstMotto = "             Live life";
string secondMotto = "Never give up        ";

firstMotto = firstMotto.TrimStart();
secondMotto = secondMotto.TrimEnd();

Console.WriteLine($"1) My Motto are {firstMotto} and {secondMotto}");

Console.WriteLine($"2) My Motto are " + secondMotto + " and " + firstMotto);

//-------------------------------------------------------------------------------------------------
Console.WriteLine("\n----------------------------------- Searching Strings ------------------------------------\n");

string motto = $"My Motto are {firstMotto} and {secondMotto}";
Console.WriteLine(motto);

Console.WriteLine("\nReplace Value");
Console.WriteLine(motto.Replace("Live life", "To the fullest"));

motto = motto.Replace("Never give up", "Heads up");
Console.WriteLine(motto);

Console.WriteLine("\nSearch Contain");
Console.WriteLine(motto.Contains("Live"));
Console.WriteLine(motto.Contains("Die"));

Console.WriteLine("\nChange to Uppercase");
Console.WriteLine(motto.ToUpper());

Console.WriteLine("\nLenght of strings");
Console.WriteLine(motto.Length);

Console.WriteLine("\nStarts with");
Console.WriteLine(motto.StartsWith("My "));