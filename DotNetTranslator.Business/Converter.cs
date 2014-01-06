using System.IO;
using System.Text;

namespace DotNetTranslator.Business
{
    public class Converter
    {
        private static readonly VisualBasicToCSharpConverter.Converting.Converter visualBasicToCSharpConverter =
            new VisualBasicToCSharpConverter.Converting.Converter();
        /// <summary>
        /// Convert a vb file to a CSharp equivalent.
        /// </summary>
        /// <param name="stream"></param>
        /// <returns></returns>
        public static Stream ConvertVBToCSharp(string file)
        {
            var tree = Roslyn.Compilers.VisualBasic.SyntaxTree.ParseFile(file);
            var csharpCode = visualBasicToCSharpConverter.Convert(tree);
            var rStream = new MemoryStream(
                Encoding.UTF8.GetBytes(
                    csharpCode.ToFullString()
                ));
            return rStream;
        }
    }
}
