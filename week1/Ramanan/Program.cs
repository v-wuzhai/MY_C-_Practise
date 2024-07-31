
/*
    Ramanan BYS

    WEEK 1
 */


string motto1 = "Wira is a King";
string motto2 = "Trust Your Time";

Console.WriteLine("First motto is " + motto1 + " and second motto is " + motto2); //method 1
Console.WriteLine($"First motto is {motto1} and second motto is {motto2}"); //method 2

string motto3 = " Wira is a King   ";
string motto4 = "Trust your Time       ";
string motto5 = "Begin your life      ";

motto3 = motto3.TrimStart();

Console.WriteLine($"First motto is {motto3} and second motto is {motto4.TrimEnd()}");
Console.WriteLine($"{motto5.Trim()}");

string motto6 = "Wira is a king";
string motto7 = "Monster";

Console.WriteLine($"{motto6.Replace("King", "Monster")}"); //method 1
Console.WriteLine($"{motto6.Replace("Monster", motto7)}"); //method 2

motto6 = motto6.Replace("Monster", motto7); //method 3            
Console.WriteLine(motto6);


string motto8 = "Wira is a King";
string motto9 = "Trust Your time";

Console.WriteLine($"{motto8.ToUpper()}");
Console.WriteLine($"{motto9.ToLower()}");


string motto10 = "Wira Is a King";

Console.WriteLine($"{motto10.Length}");

string motto11 = "Wira is a King";

Console.WriteLine($"{motto11.StartsWith("Wira")}");
Console.WriteLine($"{motto11.StartsWith(" Wira")}");
Console.WriteLine($"{motto11.StartsWith("King")}");

Console.WriteLine($"\n{motto11.EndsWith("King")}");
Console.WriteLine($"{motto11.EndsWith("King ")}");
Console.WriteLine($"{motto11.EndsWith("Wira")}");

