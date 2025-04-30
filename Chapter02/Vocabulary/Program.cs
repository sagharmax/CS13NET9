using System.Reflection;
//#error version


// *** // Revealing the extent of the C# vocabulary
Assembly? myApplication = Assembly.GetEntryAssembly();
if (myApplication is null)
{
    Console.WriteLine("No assembly found.");
    return;
}

foreach (AssemblyName name in myApplication.GetReferencedAssemblies())
{
    Assembly assembly = Assembly.Load(name);
    int methodCount = 0;
    foreach (TypeInfo type in assembly.DefinedTypes)
    {
        methodCount += type.GetMethods().Length;
    }
    Console.WriteLine($"{assembly.DefinedTypes.Count()} types with {methodCount:N0} methods in {name.Name} assembly.");
}


// *** // Outputting emojis
Console.OutputEncoding = System.Text.Encoding.UTF8;
string grinningEmoji = "\U0001F600";
Console.WriteLine($"Grinning emoji: {grinningEmoji}");