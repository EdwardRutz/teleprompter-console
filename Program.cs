using System;
using System.Collections.Generic;
using System.IO;

namespace TeleprompterConsole
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        //Read and echo the file sampleQuotes.txt
        //The IEnumerable<T> interface is defined in the System.Collections.Generic namespace. 
        //The File class is defined in the System.IO namespace.

        static IEnumerable<string> ReadFrom(string file)
        {
            string line;
            using (var reader = File.OpenText(file))
            {
                while ((line = reader.ReadLine()) != null)
                {
                    yield return line;
                }
            }
        }
    }
}
