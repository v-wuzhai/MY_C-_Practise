// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello guys!");

int amount = 3;
string food = "        cucumbers         ";
string veg = "                                    vegetables                           ";

food = food.Trim();
veg = veg.Trim();

Console.WriteLine($"I dislike {food} especially {amount} {food}");
Console.WriteLine($"I can eat every " + veg + " but not " + food);

string foot1 = "Nunez";
string footsent = $"I like {foot1} as an athlete";

Console.WriteLine(footsent);
footsent = footsent.Replace("Nunez","VVD");
Console.WriteLine(footsent);
Console.WriteLine(footsent.Contains("VVD"));
Console.WriteLine(footsent.ToLower());
Console.WriteLine(footsent.Length);
Console.WriteLine(footsent.StartsWith("Hehe"));