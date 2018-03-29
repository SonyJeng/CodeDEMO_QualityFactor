using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("請輸入一個數：");
            int input = int.Parse(Console.ReadLine());
            int i = 1;
            int counter = 0;
            int fake = input;
            Console.WriteLine($"比{input}小的質數為：");
            while (fake != 1)
            {
                while ((fake - i) != 1)
                {
                    if (fake % (fake - i) == 0)
                    {
                        counter++;

                    }
                    i++;
                }
                if (counter == 0)
                {
                    Console.Write($"{fake}, ");
                }
                fake--;
                i = 1;
                counter = 0;
            }
            fake = input;
            i = 1;
            Console.WriteLine($"\n{input}的因數為：");
            while (fake >= i)
            {
                if (fake % i == 0)
                {
                    Console.Write($"{i}, ");
                }
                i++;
            }
            fake = input;
            i = 2;
            int j = 1;
            Console.WriteLine($"\n{input}的質因數為：");
            while (fake >= i)
            {
                if (fake % i == 0)
                {
                    while ((i - j) != 1)
                    {
                        if (i % (i - j) == 0)
                        {
                            counter++;

                        }
                        j++;
                    }
                    if (counter == 0)
                    {
                        Console.Write($"{i}, ");
                    }
                }
                i++;
            }
            Console.ReadKey();
        }
    }
}
