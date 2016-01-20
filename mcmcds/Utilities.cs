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
    }
}