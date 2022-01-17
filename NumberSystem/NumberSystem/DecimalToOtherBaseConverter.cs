using System;

namespace NumberSystem
{
   public class DecimalToOtherBaseConverter
   {
        /// <summary>
        /// The method converts a decimal number to a base number. 
        /// </summary>
        /// <param name="number"></param>
        /// <param name="systemBase"></param>
        /// <returns>
        /// Returns a converted number.
        /// </returns>
        public string Convert(int number, int systemBase)
        {
            string result = "";
            if (systemBase > 20 || systemBase < 2)
            {
                throw new ArgumentOutOfRangeException();
            }
            while (number != 0)
            {
                int rest = number % systemBase;
                if (rest >= 10 && rest <= 20)
                {
                    char smbToAdd = (char)(rest + 55);
                    result += smbToAdd;

                }
                else
                {
                    result += rest.ToString();
                }
                number = number/systemBase;
            }
            char[] stringToReverse = result.ToCharArray();
            Array.Reverse(stringToReverse);
            return new string(stringToReverse);
        }
   
   }
}
