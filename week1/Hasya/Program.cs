// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, Hasya!");

// Introducing strings
string motto1 = "Hard work beats talent when talent doesn't work hard.          ";
string motto2 = "      Success is earned, not given.";

// Basic trim
motto1 = motto1.Trim();

// Trim in line
Console.WriteLine($"My mottos are {motto1} and {motto2.Trim()}.");

// Searching strings
string mottos = $"My mottos are {motto1} and {motto2.Trim()}.";

// Replace string 1
Console.WriteLine(mottos);
Console.WriteLine(mottos.Replace("Hard work beats talent when talent doesn't work hard.", "Dedication transforms dreams into reality."));
Console.WriteLine(mottos);

// Replace string 2
Console.WriteLine(mottos);
mottos = mottos.Replace("Hard work beats talent when talent doesn't work hard.", "Dedication transforms dreams into reality.");
Console.WriteLine(mottos);

// Searching string
Console.WriteLine(mottos.Contains("Dedication transforms dreams into reality"));

// Uppercase
Console.WriteLine(mottos.ToUpper());

// Lowercase
Console.WriteLine(mottos.ToLower());

// Length
Console.WriteLine(mottos.Length);

// Starts with
Console.WriteLine(mottos.StartsWith("My "));
