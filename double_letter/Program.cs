using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zavdanya_from_ostap
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string[] words = text.Split(' ');

            Console.WriteLine();

            for (int i = 0; i < words.Length; i++)
            {
                for (int j = 0; j < words[i].Length - 1; j++)
                {

                    if (words[i][j] == words[i][j + 1])
                    {
                        Console.Write(words[i] + " ");
                    }
                }
            }
        }
    }
}