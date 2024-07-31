/*
    FARIS AFIQ - 138195

    WEEK 1
    Print your motto in a C# console project using
    visual studio or VS Code, then check in to GitHub.
 */

Console.WriteLine("farisafiq");

//CONCANTENATION
Console.WriteLine("\nCONCANTENATION");

string motto1 = "valar morghulis";
string motto2 = "plata o plomo";

Console.WriteLine("First motto is " + motto1 + " and second motto is " + motto2); //method 1
Console.WriteLine($"First motto is {motto1} and second motto is {motto2}"); //method 2


//TRIM
Console.WriteLine("\nTRIM");

string motto3 = "      valar morghulis";
string motto4 = "plata o plomo        ";
string motto5 = "    valar plomo      ";

motto3 = motto3.TrimStart();

Console.WriteLine($"First motto is {motto3} and second motto is {motto4.TrimEnd()}");
Console.WriteLine($"{motto5.Trim()}");


//REPLACE
Console.WriteLine("\nREPLACE");

string motto6 = "valar morghulis";
string motto7 = "dohaeris";

Console.WriteLine($"{motto6.Replace("morghulis", "dohaeris")}"); //method 1
Console.WriteLine($"{motto6.Replace("morghulis", motto7)}"); //method 2

motto6 = motto6.Replace("morghulis", motto7); //method 3            
Console.WriteLine(motto6);


//UPPER/LOWERCASE
Console.WriteLine("\nUPPER/LOWERCASE");

string motto8 = "valar morghulis";
string motto9 = "PLATA O PLOMO";

Console.WriteLine($"{motto8.ToUpper()}");
Console.WriteLine($"{motto9.ToLower()}");


//LENGTH
Console.WriteLine("\nLENGTH");

string motto10 = "valar morghulis";

Console.WriteLine($"{motto10.Length}");


//CONTAINS
Console.WriteLine("\nCONTAINS");

string motto11 = "valar morghulis";

Console.WriteLine($"{motto11.StartsWith("valar")}");
Console.WriteLine($"{motto11.StartsWith(" valar")}");
Console.WriteLine($"{motto11.StartsWith("morghulis")}");

Console.WriteLine($"\n{motto11.EndsWith("morghulis")}");
Console.WriteLine($"{motto11.EndsWith("morghulis ")}");
Console.WriteLine($"{motto11.EndsWith("valar")}");

