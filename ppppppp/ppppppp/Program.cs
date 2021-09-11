using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ppppppp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("enter polindrom: ");
            string a; string b;
            b = Console.ReadLine();
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
