// *** // Storing numbers
using System.ComponentModel;
using System.Linq.Expressions;

uint naturalNumber = 23;
int integerNumber = -23;
float floatNumber = 23.5f;
double doubleNumber = 23.5;


// *** // Using binary or hexadecimal notation
int decimalNotation = 2_000_000;
int binaryNotation = 0b_0001_1110_1000_0100_1000_0000; // 2 million in binary
int hexadecimalNotation = 0x_1E_8480; // 2 million in hexadecimal

Console.WriteLine($"{decimalNotation} == {binaryNotation}");
Console.WriteLine($"{decimalNotation} == {hexadecimalNotation}");

Console.WriteLine($"{decimalNotation:N0}");
Console.WriteLine($"{binaryNotation:N0}");
Console.WriteLine($"{hexadecimalNotation:N0}");

Console.WriteLine($"{decimalNotation:X}");
Console.WriteLine($"{binaryNotation:X}");
Console.WriteLine($"{hexadecimalNotation:X}");


// *** // Writing code to explore number sizes
Console.WriteLine($"int uses {sizeof(int)} bytes, and can store values from {int.MinValue:N0} to {int.MaxValue:N0}.");
Console.WriteLine($"uint uses {sizeof(uint)} bytes, and can store values from {uint.MinValue:N0} to {uint.MaxValue:N0}.");
Console.WriteLine($"long uses {sizeof(long)} bytes, and can store values from {long.MinValue:N0} to {long.MaxValue:N0}.");
Console.WriteLine($"ulong uses {sizeof(ulong)} bytes, and can store values from {ulong.MinValue:N0} to {ulong.MaxValue:N0}.");
Console.WriteLine($"float uses {sizeof(float)} bytes, and can store values from {float.MinValue:N0} to {float.MaxValue:N0}.");
Console.WriteLine($"double uses {sizeof(double)} bytes, and can store values from {double.MinValue:N0} to {double.MaxValue:N0}.");
Console.WriteLine($"decimal uses {sizeof(decimal)} bytes, and can store values from {decimal.MinValue:N0} to {decimal.MaxValue:N0}.");
Console.WriteLine($"char uses {sizeof(char)} bytes, and can store values from {char.MinValue:N0} to {char.MaxValue:N0}.");
Console.WriteLine($"byte uses {sizeof(byte)} bytes, and can store values from {byte.MinValue:N0} to {byte.MaxValue:N0}.");
Console.WriteLine($"sbyte uses {sizeof(sbyte)} bytes, and can store values from {sbyte.MinValue:N0} to {sbyte.MaxValue:N0}.");
Console.WriteLine($"short uses {sizeof(short)} bytes, and can store values from {short.MinValue:N0} to {short.MaxValue:N0}.");
Console.WriteLine($"ushort uses {sizeof(ushort)} bytes, and can store values from {ushort.MinValue:N0} to {ushort.MaxValue:N0}.");


// *** // Comparing double and decimal types
Console.WriteLine("Using doubles:");
double a = 0.1;
double b = 0.2;
if (a + b == 0.3)
{
    Console.WriteLine("a + b == 0.3");
}
else
{
    Console.WriteLine("a + b != 0.3");
}

decimal c = 0.1m;
decimal d = 0.2m;
if (c + d == 0.3m)
{
    Console.WriteLine("c + d == 0.3");
}
else
{
    Console.WriteLine("c + d != 0.3");
}


// *** // Special real number values
Console.WriteLine($"double.Epsilon: {double.Epsilon}");
Console.WriteLine($"double.Epsilon to 324 decimal places: {double.Epsilon.ToString("N324")}");
Console.WriteLine($"double.Epsilon to 330 decimal places: {double.Epsilon.ToString("N330")}");
const int col1 = 37;
const int col2 = 6;
string line = new('-', col1 + col2 + 3);
Console.WriteLine(line);
Console.WriteLine($"{"Expression",-col1} | {"Value",col2}");
Console.WriteLine(line);
Console.WriteLine($"{"double.NaN",-col1} | {double.NaN, col2}");
Console.WriteLine($"{"double.PositiveInfinity",-col1} | {double.PositiveInfinity, col2}");
Console.WriteLine($"{"double.NegativeInfinity",-col1} | {double.NegativeInfinity, col2}");
Console.WriteLine(line);
Console.WriteLine($"{"0.0 / 0.0",-col1} | {0.0 / 0.0, col2}");
Console.WriteLine($"{"3.0 / 0.0",-col1} | {1.0 / 0.0, col2}");
Console.WriteLine($"{"-3.0 / 0.0",-col1} | {1.0 / -0.0, col2}");
Console.WriteLine($"{"3.0 / 0.0 == double.PositiveInfinity",-col1} | {3.0 / 0.0 == double.PositiveInfinity, col2}");
Console.WriteLine($"{"-3.0 / 0.0 == double.NegativeInfinity",-col1} | {-3.0 / 0.0 == double.NegativeInfinity, col2}");
Console.WriteLine($"{"0.0 / 3.0",-col1} | {0.0 / 3.0, col2}");
Console.WriteLine($"{"0.0 / -3.0",-col1} | {0.0 / -3.0, col2}");
Console.WriteLine(line);


// *** // New number types and unsafe code
unsafe
{
    Console.WriteLine($"Half uses {sizeof(Half)} bytes, and can store values from {Half.MinValue:N0} to {Half.MaxValue:N0}.");
    Console.WriteLine($"Int128 uses {sizeof(Int128)} bytes, and can store values from {Int128.MinValue:N0} to {Int128.MaxValue:N0}.");
}
