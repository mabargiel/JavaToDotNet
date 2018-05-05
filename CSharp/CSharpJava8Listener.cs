using System.IO;
using System.Text;

namespace JavaToDotNet.Translators.CSharp
{
    public class CSharpJava8Listener : Java8BaseListener
    {
        private readonly StringBuilder _strBuilder;

        public CSharpJava8Listener(StringBuilder strBuilder)
        {
            _strBuilder = strBuilder;
        }
    }
}