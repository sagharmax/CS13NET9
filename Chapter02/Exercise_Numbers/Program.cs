using System.Runtime.CompilerServices;

Console.WriteLine(new string('-', 121));
Console.WriteLine($"{"Type",-10} {"Byte(s) of memeory",-15} {"Min",30} {"Max",60}");
Console.WriteLine(new string('-', 121));
Console.WriteLine($"{nameof(SByte),-10} {sizeof(sbyte),-18} {sbyte.MinValue,30} {sbyte.MaxValue,60}");
Console.WriteLine($"{nameof(Byte),-10} {sizeof(byte),-18} {byte.MinValue,30} {byte.MaxValue,60}");
Console.WriteLine($"{nameof(Int16),-10} {sizeof(short),-18} {short.MinValue,30} {short.MaxValue,60}");
Console.WriteLine($"{nameof(UInt16),-10} {sizeof(ushort),-18} {ushort.MinValue,30} {ushort.MaxValue,60}");
Console.WriteLine($"{nameof(Int32),-10} {sizeof(int),-18} {int.MinValue,30} {int.MaxValue,60}");
Console.WriteLine($"{nameof(UInt32),-10} {sizeof(uint),-18} {uint.MinValue,30} {uint.MaxValue,60}");
Console.WriteLine($"{nameof(Int64),-10} {sizeof(long),-18} {long.MinValue,30} {long.MaxValue,60}");
Console.WriteLine($"{nameof(UInt64),-10} {sizeof(ulong),-18} {ulong.MinValue,30} {ulong.MaxValue,60}");
Console.WriteLine($"{nameof(Int128),-10} {Unsafe.SizeOf<Int128>(),-8} {Int128.MinValue,30} {Int128.MaxValue,60}");
Console.WriteLine($"{nameof(UInt128),-10} {Unsafe.SizeOf<UInt128>(),-18} {UInt128.MinValue,30} {UInt128.MaxValue,60}");
Console.WriteLine($"{nameof(Half),-10} {Unsafe.SizeOf<Half>(),-18} {Half.MinValue,30} {Half.MaxValue,60}");
Console.WriteLine($"{nameof(Single),-10} {sizeof(float),-18} {float.MinValue,30} {float.MaxValue,60}");
Console.WriteLine($"{nameof(Double),-10} {sizeof(double),-18} {double.MinValue,30} {double.MaxValue,60}");
Console.WriteLine($"{nameof(Decimal),-10} {sizeof(decimal),-18} {decimal.MinValue,30} {decimal.MaxValue,60}");
