using System;

/// <summary>
/// Dump a object using ObjectDumper library</summary>
/// <remarks>
/// Compile with:
///     mcs DumpObject.cs  lib/ObjectDumper/ObjectDumper.cs
public class DumpObject
{
    public static void Main()
    {
        Data1 d = new Data1();
        ObjectDumper.Write(d);
    }
}

public class Data1
{
    public int a = 1;
    public string b = "string";
    public void method1() { }
}
