using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirectoryInfoDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var di = new DirectoryInfo(@"c:\vidobu\");

            Console.WriteLine(di.CreationTime);

            foreach (var dir in di.EnumerateDirectories("*", SearchOption.AllDirectories))
            {
                Console.WriteLine(dir.FullName);
            }

            Console.WriteLine(di.LastAccessTime);

            Console.ReadKey();

        }
    }
}
