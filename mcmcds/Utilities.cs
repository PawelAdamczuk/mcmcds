using System.Text;
using System.Security.Cryptography;

namespace mcmcds
{
    public static class Utilities
    {
        public static string StringHash(string _input)
        {
            byte[] bytes = Encoding.UTF8.GetBytes(_input);
            SHA256Managed crypt = new SHA256Managed();
            byte[] hash = crypt.ComputeHash(bytes);
            string output = string.Empty;

            foreach (byte b in hash)
            {
                output += string.Format("{0:x2}", b);
            }

            return output;
        }

        public static bool TextValid(string text)
        {
            if (text.Contains(";"))
                return false;
            if (text.Contains("'"))
                return false;
            if (text.Contains("--"))
                return false;
            if (text.Contains("/"))
                return false;
            if (text.Contains("xp_"))
                return false;
            return true;
        }

        public static int PriceField(string _input){
            StringBuilder price = new StringBuilder(_input);
            for (int i = 0; i < price.Length; ++i)
            {
                if (price[i] == ',')
                    price[i] = '.';
            }

            try
            {
                int priceInt = (int)(double.Parse(price.ToString(), System.Globalization.CultureInfo.InvariantCulture) * 100);
                return priceInt;
            }
            catch (System.Exception exception)
            {
                throw exception;
            }
        }
    }
}