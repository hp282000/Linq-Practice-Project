using System.Linq;
using System;
using System.Xml.Linq;

internal class Program

{
    private static void Main(string[] args)
    {
        string[] name1 = { "hp", "sd", "pt", "as" };

        //LinqQuery

        var linqquery = from n in name1
                        where n.Contains('s')
                        select n;

        foreach (var name in linqquery)
        {
            Console.WriteLine(name);
        }


        //Method Syntax

        var result = name1.Where(nam =>  nam.Contains('a'));

        //Console.WriteLine(result.FirstOrDefault[0]);
        foreach (var name2 in result) {
            Console.WriteLine(name2);
        }
    }
}

