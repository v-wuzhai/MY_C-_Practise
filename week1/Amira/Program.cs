
// Amira Natasha
// IDE Version Control
// ID : 139087
// Print your motto in a C# console project using visual studio or VS Code, then check in to GitHub.   
Console.WriteLine("Motto Printed in Different Syntax\n");

string firstMotto = "Experience";
string secondMotto = "Learning";

Console.WriteLine($"1) Example One My Motto are {secondMotto} and {firstMotto}");

Console.WriteLine($"2) Example two My Motto are " + firstMotto + " and " + secondMotto);

//===================================================================================================
Console.WriteLine("\n================================================================================");
Console.WriteLine("Trim space print\n");

string firstMotto2 = "                  Learning";
string secondMotto2 = "Experience                             ";

firstMotto2 = firstMotto2.TrimStart();
secondMotto2 = secondMotto2.TrimEnd();

Console.WriteLine($"1) Example One My Motto are {firstMotto2} and {secondMotto2}");

Console.WriteLine($"2) Example two My Motto are " + secondMotto2 + " and " + firstMotto2);

//=================================================================================================
Console.WriteLine("\n================================================================================");
Console.WriteLine("Searching Strings\n");

string motto = $"My Moto are {firstMotto2} and {secondMotto2}";
Console.WriteLine(motto);

Console.WriteLine("\nReplace Value");
Console.WriteLine(motto.Replace("Learning", "Respect"));

motto = motto.Replace("Experience", "Cats");
Console.WriteLine(motto);

Console.WriteLine("\nSearch Contain");
Console.WriteLine(motto.Contains("Cats"));

Console.WriteLine("\nChange to Uppercase");
Console.WriteLine(motto.ToUpper());

Console.WriteLine("\nLenght of strings");
Console.WriteLine(motto.Length);

Console.WriteLine("\nStarts with");
Console.WriteLine(motto.StartsWith("My "));