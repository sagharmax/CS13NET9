// *** // Formatting using numbered positional arguments
using System.Globalization;

CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo("en-US");
int numberOfApples = 12;
decimal pricePerApple = 0.35M;
Console.WriteLine("{0} apples cost {1:C}", numberOfApples, numberOfApples * pricePerApple);
string formattedString = string.Format("{0} apples cost {1:C}", numberOfApples, numberOfApples * pricePerApple);

Console.WriteLine("{0} {1} lived in {2}", "John", "Doe", "New York");
Console.WriteLine("{0} {1} lived in {2} and worked in {3} team at {4}", "John", "Doe", "New York", "Development", "Microsoft");


// *** // Formatting using interpolated strings
Console.WriteLine($"{numberOfApples} apples cost {numberOfApples * pricePerApple:C}");


// *** // Understanding format strings
string applesText = "apples";
int applesCount = 1234;
string bananaText = "bananas";
int bananaCount = 56789;
Console.WriteLine();
Console.WriteLine($"{"Name", -10} {"Count", 6}");
Console.WriteLine($"{applesText, -10} {applesCount, 6:N0}");
Console.WriteLine($"{bananaText, -10} {bananaCount, 6:N0}");

decimal value = 12.5678M;
Console.WriteLine($"Currency: {value:C}, Percentage: {value:0.00%}");


// *** // Getting text input from the user
Console.Write("Type your first name and press Enter: ");
string firstName = Console.ReadLine() ?? string.Empty;
Console.Write("Type your age and press Enter: ");
string age = Console.ReadLine() ?? string.Empty;
Console.WriteLine($"Hello {firstName}, you are {age} years old.");


// *** // Getting key input from the user
Console.Write("Press any key combination: ");
ConsoleKeyInfo keyInfo = Console.ReadKey();
Console.WriteLine();
Console.WriteLine($"Key: {keyInfo.Key}, KeyChar: {keyInfo.KeyChar}, Modifiers: {keyInfo.Modifiers}");
