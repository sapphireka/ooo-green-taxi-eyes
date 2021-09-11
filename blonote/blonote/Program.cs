using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace blonote
{
    class Program
    {
        static void Main(string[] args)
        {
            FileInfo fi = new FileInfo(@"X:\one.txt");
            if (fi != null)
                Console.WriteLine(String.Format("Information about file: {0}, {1} bytes, last modified on {2} - Full path: {3}", fi.Name, fi.Length, fi.LastWriteTime, fi.FullName));
            Console.ReadKey();
        }
    }
}
