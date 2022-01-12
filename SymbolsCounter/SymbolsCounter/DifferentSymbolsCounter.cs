using System;

namespace SymbolsCounter
{
    /// <summary>
    /// Count max different symbols lengths
    /// </summary>
   public class DifferentSymbolsCounter
    {
        /// <summary>
        /// Count max different symbols lengths
        /// </summary>
        /// <param name="line">String to search for max number of symbols </param>
        /// <returns>Returns max lengths different symbols</returns>
        public static int MaxDifferentSymbols(string line)
        {

            int maxCount = 0;

            for (int i = 0; i < line.Length; i++)
            {
                int curCount = 1;

                for (int j = i; j < line.Length - 1; j++)
                {

                    if (line[j] == line[j + 1])
                    {
                        break;
                    }
                    curCount++;
                }
                  
                if (curCount > maxCount)
                {
                  maxCount = curCount;
                }
            }  
            
            return maxCount;
        }

    }
}
