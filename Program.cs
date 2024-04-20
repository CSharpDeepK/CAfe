using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_5_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap test: ");
            int test = int.Parse(Console.ReadLine());   
            for(int i =0; i <= test; i++)
            {
                Console.WriteLine("Nhap n: ");
                int n = int.Parse(Console.ReadLine());
                Console.WriteLine($"Test {i} ");
                if(n < 0)
                {
                    Console.WriteLine("No result");
                }
                else
                {
                    for(int j =0; j <= n; j++)
                    {
                        if(j % 2 == 0)
                        {
                            Console.WriteLine(j + "");
                        }
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
