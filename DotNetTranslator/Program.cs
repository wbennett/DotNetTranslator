//***********************************************
// Author: Paul Bennett wm.paul.bennett@gmail.com
//
// Licensed under the Apache License, Version 2.0 (the
// "License"); you may not use this file except in
// compliance with the License. You may obtain a copy of
// the License at
//
// http://www.apache.org/licenses/LICENSE-2.0 
//
// THIS CODE IS PROVIDED ON AN *AS IS* BASIS, WITHOUT WARRANTIES
// OR CONDITIONS OF ANY KIND, EITHER EXPRESS OR IMPLIED,
// INCLUDING WITHOUT LIMITATION ANY IMPLIED WARRANTIES
// OR CONDITIONS OF TITLE, FITNESS FOR A PARTICULAR
// PURPOSE, MERCHANTABILITY OR NON-INFRINGEMENT.
//
// See the Apache 2 License for the specific language
// governing permissions and limitations under the License.
//
// *********************************************************
using System;
using System.IO;
using DotNetTranslator.Business;

namespace DotNetTranslator
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputFile;
            string outputFile;
            if (args.Length != 2 || !File.Exists(args[0]))
            {
                Console.WriteLine("Usage: DotNetTranslator.exe <path/to/vb file> <path/to/csharp file>");
                Console.Write("Enter path to .vb file: ");
                inputFile = Console.ReadLine();
                Console.Write("Enter path to save the .cs file too: ");
                outputFile = Console.ReadLine();
            }
            else
            {
                inputFile = args[0];
                outputFile = args[1];
            }
            
            if (File.Exists(outputFile))
            {
                Console.WriteLine("{0} already exists do you want to delete it? yes or no: ", outputFile);
                if(Console.ReadLine().ToLower() == "yes")
                {
                    File.Delete(outputFile);                    
                }
            }


            using (var stream = Converter.ConvertVbtoCSharp(inputFile))
            using (var fileStream = new FileStream(outputFile,FileMode.CreateNew))
            {
                stream.Seek(0, SeekOrigin.Begin);
                stream.CopyTo(fileStream);
            }

            if(File.Exists(outputFile))
            {
                Console.WriteLine("Conversion successful");
            }
            else
            {
                Console.WriteLine("There was an error, conversion was unsuccessful");
            }
            Console.ReadLine();
        }
    }
}
