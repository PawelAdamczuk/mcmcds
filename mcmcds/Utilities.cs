using System.Text;

namespace mcmcds
{
    public static class Utilities
    {
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
                if (price[i] == '.')
                    price[i] = ',';
            }

            try
            {
                int priceInt = (int)(double.Parse(price.ToString()) * 100);
                return priceInt;
            }
            catch (System.Exception exception)
            {
                throw exception;
            }
        }
    }
}