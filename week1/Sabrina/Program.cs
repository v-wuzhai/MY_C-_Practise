// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, Sabrina!");

//introducing string
string firstMotto = "The past remains unchangeable            ";
string secondMotto = "       The future cannot be foretold";

//basic trim
firstMotto = firstMotto.Trim();

//trim in line
Console.WriteLine($"My mottos are {firstMotto} and {secondMotto.Trim()}.");

//searching strings
string mottos = $"My mottos are {firstMotto} and {secondMotto.Trim()}.";

//replace string 1
Console.WriteLine(mottos);
Console.WriteLine(mottos.Replace("The past remains unchangeable", "The past cannot be changed"));
Console.WriteLine(mottos);

//replace string 2
Console.WriteLine(mottos);
mottos = mottos.Replace("The past remains unchangeable", "The past cannot be changed");
Console.WriteLine(mottos);

//searching string
Console.WriteLine(mottos.Contains("The past cannot be changed"));

//uppercase
Console.WriteLine(mottos.ToUpper());

//lowercase
Console.WriteLine(mottos.ToLower());

//length
Console.WriteLine(mottos.Length);

//startswith
Console.WriteLine(mottos.StartsWith("My "));