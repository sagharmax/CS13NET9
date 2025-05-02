// *** // Storing any type of object
object height = 1.75;
object name = "John Doe";
Console.WriteLine($"{name} is {height} meters tall.");

// int length1 = name.Length; // This will cause a compile-time error
int length2 = ((string)name).Length; // This will work
Console.WriteLine($"{name} has {length2} characters.");


// *** // Storing dynamic types
dynamic something;
something = new[] {3, 5, 7};
something = 12;
something = "Hello, World!";
Console.WriteLine($"The length of somthing is {something.Length}.");
Console.WriteLine($"something is a {something.GetType()}.");


// *** // Getting and setting the default values for types
Console.WriteLine($"default(int) = {default(int)}");
Console.WriteLine($"default(bool) = {default(bool)}");
Console.WriteLine($"default(datetime) = {default(DateTime)}");
Console.WriteLine($"default(string) = {default(string) ?? "<Null>"}");
int number = 13;
Console.WriteLine($"number set to {number}");
number = default;
Console.WriteLine($"number reset to its default value {number}");