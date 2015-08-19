using System;
using System.Collections.Generic;
using System.Linq;

/// <summary>
/// Using Enumerable.Select() & XML documentation features</summary>
/// <remarks>
/// To generate document:
///     mcs Squares.cs /doc:Squares.xml</remarks>
public class Squares
{
   public static void Main()
   {
        IEnumerable<int> squares = Enumerable.Range(1, 10).Select(x => x * x);

        foreach (int num in squares)
        {
            Console.WriteLine(num);
        }
   }
}
