using System;
using System.IO;
using DotNetTranslator.Business;

namespace DotNetTranslator
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length != 2 ||
                !File.Exists(args[0]))
            {
                Console.WriteLine("Usage: GarbageToGold.exe <path/to/vb file> <path/to/csharp file>");
                return;
            }
            
            if (File.Exists(args[1]))
            {
                Console.WriteLine("Output file exists, please remove to output new file.");
            }


            using (var stream = Converter.ConvertVBToCSharp(args[0]))
            using (var fileStream = new FileStream(args[1],FileMode.CreateNew))
            {
                stream.Seek(0, SeekOrigin.Begin);
                stream.CopyTo(fileStream);
            }
        }
    }
}
