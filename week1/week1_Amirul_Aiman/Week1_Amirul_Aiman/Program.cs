﻿// Amirul Aiman
// ID : 134367
// Print your motto in a C# console project using visual studio or VS Code, then check in to GitHub.
Console.WriteLine("Hello, Friends!");
Console.WriteLine("\n--------------------------- Motto Printed in Different Syntax ----------------------------\n");

string Motto1 = "Chilling";
string Motto2 = "Improve";

Console.WriteLine($"1) Example One My Motto are {Motto2} and {Motto1}");

Console.WriteLine($"2) Example two My Motto are " + Motto1 + " and " + Motto2);

//-------------------------------------------------------------------------------------------------
Console.WriteLine("\n------------------------------------ Trim space print ------------------------------------\n");

string firstMotto = "                  Chilling";
string secMotto = "Improve                             ";

firstMotto = firstMotto.TrimStart();
secMotto = secMotto.TrimEnd();

Console.WriteLine($"1) Example One My Motto are {firstMotto} and {secMotto}");

Console.WriteLine($"2) Example two My Motto are " + secMotto + " and " + firstMotto);

//-------------------------------------------------------------------------------------------------
Console.WriteLine("\n----------------------------------- Searching Strings ------------------------------------\n");

string motto = $"My Motto are {firstMotto} and {secMotto}";
Console.WriteLine(motto);

Console.WriteLine("\nReplace Value");
Console.WriteLine(motto.Replace("Improve", "Nations"));

motto = motto.Replace("Chilling", "Healing");
Console.WriteLine(motto);

Console.WriteLine("\nSearch Contain");
Console.WriteLine(motto.Contains("Healing"));
Console.WriteLine(motto.Contains("Running"));

Console.WriteLine("\nChange to Uppercase");
Console.WriteLine(motto.ToUpper());

Console.WriteLine("\nLenght of strings");
Console.WriteLine(motto.Length);

Console.WriteLine("\nStarts with");
Console.WriteLine(motto.StartsWith("My "));