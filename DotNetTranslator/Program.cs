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


            using (var stream = Converter.ConvertVbtoCSharp(args[0]))
            using (var fileStream = new FileStream(args[1],FileMode.CreateNew))
            {
                stream.Seek(0, SeekOrigin.Begin);
                stream.CopyTo(fileStream);
            }
        }
    }
}
