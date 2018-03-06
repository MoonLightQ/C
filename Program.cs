﻿using System;
using System.Collections.Generic;
namespace C
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-------Viva la Vida!-------");
            //Test LexicalScanner
            String sourceCode = System.IO.File.ReadAllText("./TestCode/lex.c.txt");
            LexicalScanner scanner = new LexicalScanner(sourceCode);
            IEnumerable<Token> tokens = scanner.Lex();
            Console.WriteLine("-----------Source----------");
            Console.WriteLine();
            Console.WriteLine(sourceCode);
            Console.WriteLine("-------End of Source-------");
            Console.WriteLine("-----------Tokens----------");
            Console.WriteLine();
            foreach (var item in tokens)
            {
                Console.WriteLine(item.ToString());
            }
            Console.WriteLine();
            Console.WriteLine("-------End of Tokens-------");
            Console.WriteLine("-------Viva la Vida!-------");
            Console.ReadKey();
        }
    }
}
