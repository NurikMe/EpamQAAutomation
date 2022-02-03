using System;
using System.Text;

namespace FirstTask
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 1)
            {
                TextAnalyzer textAnalyzer = new TextAnalyzer();
                int amountOfSymbols = textAnalyzer.FindLengtOfLongestUniqueSymbolSequence(args[0]);
                Console.WriteLine(amountOfSymbols);
            }
        }
        
    }
}
