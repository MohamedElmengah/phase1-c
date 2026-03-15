using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string code = "int x; read x; x := x + 1; write x;";

        string pattern = @"[A-Za-z]+|\d+|:=|[+\-*/]|;";

        MatchCollection matches = Regex.Matches(code, pattern);

        foreach (Match m in matches)
        {
            Console.WriteLine(m.Value);
        }
    }
}