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
using System.IO;
using System.Text;

namespace DotNetTranslator.Business
{
    public class Converter
    {
        private static readonly VisualBasicToCSharpConverter.Converting.Converter visualBasicToCSharpConverter =
            new VisualBasicToCSharpConverter.Converting.Converter();
        private static readonly CSharpToVisualBasicConverter.Converting.Converter csharpToVisualBasicConverter = 
            new CSharpToVisualBasicConverter.Converting.Converter();
        
        /// <summary>
        /// Convert a vb file to a C# memory stream.
        /// Usage: 
        /// using(var stream = Converter.ConvertVbToCSharp(filePath))
        /// {
        /// ....
        /// }
        /// </summary>
        /// <param name="file">String containing the file path of the input source.</param>
        /// <returns>File stream of the converted code.</returns>
        public static Stream ConvertVbtoCSharp(string file)
        {
            var vbAst = Roslyn.Compilers.VisualBasic.SyntaxTree.ParseFile(file);
            var csharpAst = visualBasicToCSharpConverter.Convert(vbAst);
            var rStream = new MemoryStream(
                Encoding.UTF8.GetBytes(
                    csharpAst.ToFullString()
                ));
            return rStream;
        }

        /// <summary>
        /// Convert a vb code to a C# string.
        /// Usage: 
        /// var csharpCode = Converter.ConvertVbtoCSharpString(vbCode);
        /// </summary>
        /// <param name="content">String containing the CSharp code.</param>
        /// <returns>File stream of the converted code.</returns>
        public static string ConvertVbtoCSharpString(string content)
        {
            var vbAst = Roslyn.Compilers.VisualBasic.SyntaxTree.ParseText(content);
            var csharpAst = visualBasicToCSharpConverter.Convert(vbAst);
            return csharpAst.ToFullString();
        }

        /// <summary>
        /// Convert a C# source file to a VB memory stream.
        /// Usage: 
        /// using(var stream = Converter.ConvertCSharpToVb(filePath))
        /// {
        /// ....
        /// }
        /// </summary>
        /// <param name="file">String containing the file path of the input source.</param>
        /// <returns>File stream of the converted code.</returns>
        public static Stream ConvertCSharpToVb(string file)
        {
            var vbAst = Roslyn.Compilers.VisualBasic.SyntaxTree.ParseFile(file);
            var csharpAst = visualBasicToCSharpConverter.Convert(vbAst);
            var rStream = new MemoryStream(
                Encoding.UTF8.GetBytes(
                    csharpAst.ToFullString()
                ));
            return rStream;
        }

        /// <summary>
        /// Convert a C# source file to a VB memory stream.
        /// Usage: 
        /// var vbCode = Converter.ConvertVbtoCSharpString(csharpCode);
        /// </summary>
        /// <param name="content">String containing the CSharp code.</param>
        /// <returns>File stream of the converted code.</returns>
        public static string ConvertCSharpToVbString(string content)
        {
            var vbAst = Roslyn.Compilers.VisualBasic.SyntaxTree.ParseText(content);
            var csharpAst = visualBasicToCSharpConverter.Convert(vbAst);
            return csharpAst.ToFullString();
        }
    }
}
