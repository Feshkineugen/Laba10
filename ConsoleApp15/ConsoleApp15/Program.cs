﻿using System;
using System.IO;
namespace FileWork
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                StreamReader text = new StreamReader(@"C:\Users\Admin\OneDrive\Рабочий стол\file\file.txt");
                string[] array = text.ReadToEnd().Split('\n');
                foreach (var i in array)
                {
                    Console.WriteLine(i);
                }
                {
                    Console.WriteLine(i);
                }
            }
            catch (OutOfMemoryException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (System.IO.IOException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}