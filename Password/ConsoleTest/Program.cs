using CryptoServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTest
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i = 0; i < 10; i++)
            {
                var pwd = Password.Generate();
                Console.WriteLine(pwd);

            }
            Console.Read();
        }
    }
}
