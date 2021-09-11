using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ppppppp
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lines = File.ReadAllLines(@"X:\one.txt"); 
                foreach (string s in lines)
            {
                if (File.Exists(@"X:\one.txt"))
                  {
                    while (s != null) { 
            Console.WriteLine(s);
            string a; string b = s;
        //    b = Console.ReadLine();
            char[] bReverse = b.ToCharArray();
            Array.Reverse(bReverse);
            a = new string(bReverse);
            Console.Write("reverse: ");
            Console.WriteLine(a);
            if (string.CompareOrdinal(a,b)==0)
            { Console.WriteLine("its a polindrom"); }
            else { Console.WriteLine("its not polindrome"); }
                    }
                }
            }
        }
    }
}
