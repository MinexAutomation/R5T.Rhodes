﻿using System;

namespace R5T.Rhodes.Construction
{
    class Program
    {
        static void Main(string[] args)
        {
            Construction.SubMain();

            Program.SubMain();
        }

        private static void SubMain()
        {
            Console.WriteLine("Hello World!");
        }
    }
}
