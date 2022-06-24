// See https://aka.ms/new-console-template for more information
using System.Drawing;
using Newtonsoft.Json;
using SpecificationPattern.Demo;
using SpecificationPattern.Demo.Specification.UserSpecification;

IEnumerable<User>? users = JsonConvert.DeserializeObject<IEnumerable<User>>(File.ReadAllText($@"../../../users.json"));
if (users is not null)
{
    var userFilter = new UserFilter();
    foreach (User item in userFilter.FilterUsersByName(users, "eslam"))
    {
        Console.ForegroundColor = ConsoleColor.DarkCyan;
        Console.Write($"Name : {item.Name} ");
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.Write($" - Age : {item.Age} ");
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.Write($" - Eye Color : {item.EyeColor}");
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.Write($" - Email : {item.Email}");
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(".");
        Console.WriteLine("----------------------------------------------------------------------------------------");
    }
    Console.ReadLine();
}

if (users is not null)
{
    var userFilter = new UserFilterSpecification();
    foreach (User item in userFilter.Filters(users, new ColorSpecification(EyeColor.Green)))
    {
        Console.ForegroundColor = ConsoleColor.DarkCyan;
        Console.Write($"Name : {item.Name} ");
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.Write($" - Age : {item.Age} ");
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.Write($" - Eye Color : {item.EyeColor}");
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.Write($" - Email : {item.Email}");
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(".");
        Console.WriteLine("----------------------------------------------------------------------------------------");
    }
    Console.ReadLine();
}
