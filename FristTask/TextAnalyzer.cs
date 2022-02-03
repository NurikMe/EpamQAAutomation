using System.Text;

namespace FirstTask
{
    public class TextAnalyzer
    {
        /// <summary>
        /// Finds distance from first char to last if they are equal
        /// </summary>
        /// <param name="maxUniqueChar"> string of longest unique char sequence </param>
        /// <param name="charForCheck"> next char from sequence </param>
        /// <returns></returns>
        private int FindDistanceToRepeatChar(StringBuilder maxUniqueChar, char charForCheck)
        {
            int distanceToRepeatChar = -1;
            for (int i = 0; i < maxUniqueChar.Length; i++)
            {
                if (maxUniqueChar[i] == charForCheck)
                {
                    distanceToRepeatChar = maxUniqueChar.Length - i - 1;
                }
            }

            return distanceToRepeatChar;
        }
        
        public int FindLengtOfLongestUniqueSymbolSequence(string symbolSequence)
        {
            int amountOfSymbols = 0;
            if (symbolSequence.Length != 0)
            {
                int length = 1;
                StringBuilder maxUniqueChar = new StringBuilder();
                maxUniqueChar.Append(symbolSequence[0]);
                for (int i = 1; i < symbolSequence.Length; i++)
                {
                    int distance = FindDistanceToRepeatChar(maxUniqueChar, symbolSequence[i]);
                    if (distance != -1)
                    {
                        if (length < maxUniqueChar.Length)
                        {
                            length = maxUniqueChar.Length;
                        };
                        maxUniqueChar.Clear();
                        i -= distance;
                        maxUniqueChar.Append(symbolSequence[i]);
                        continue;
                    }
                    else if (symbolSequence.Length - i != 1)
                    {
                        maxUniqueChar.Append(symbolSequence[i]);
                        continue;
                    }
                    maxUniqueChar.Append(symbolSequence[i]);
                }
                amountOfSymbols = length < maxUniqueChar.Length ? maxUniqueChar.Length : length;
            }

            return amountOfSymbols;
        }
    }
}
