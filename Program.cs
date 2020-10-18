using System;
class Program
{
    static void Main(string[] args)
    {
        string[] S = {
"        Console.WriteLine(\"using System;\");",
"        Console.WriteLine(\"class Program {\");",
"        Console.WriteLine(\"    static void Main(string[] args) {\");",
"",
"        Console.WriteLine(\"        string[] S = {\");",
"        foreach (string line in S) {",
"            string escapedLine = line.Replace(@\"\\\", @\"\\\\\")",
"                .Replace(\"\\\"\", \"\\\\\\\"\");",
"            Console.WriteLine(\"\\\"{0}\\\",\", escapedLine);",
"        }",
"        Console.WriteLine(\"        };\");",
"",
"        foreach (string line in S) Console.WriteLine(line);",
"",
"        Console.WriteLine(\"    }\");",
"        Console.WriteLine(\"}\");",
"",
"        Console.WriteLine(\"This quine can do other things too!\");",
"        Console.WriteLine(\"Press any key to exit.\");",
"",
"        Console.ReadKey(true);",
        };
        Console.WriteLine("using System;");
        Console.WriteLine("class Program {");
        Console.WriteLine("    static void Main(string[] args) {");

        Console.WriteLine("        string[] S = {");
        foreach (string line in S)
        {
            string escapedLine = line.Replace(@"\", @"\\")
                .Replace("\"", "\\\"");
            Console.WriteLine("\"{0}\",", escapedLine);
        }
        Console.WriteLine("        };");

        foreach (string line in S) Console.WriteLine(line);

        Console.WriteLine("    }");
        Console.WriteLine("}");

        Console.WriteLine("This quine can do other things too!");
        Console.WriteLine("Press any key to exit.");
        Console.ReadKey(true);
    }
}

