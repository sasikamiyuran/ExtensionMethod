namespace Implementation
{
    public static class ExtensionMethod
    {
        public static string RightSubstring(this String s, int count)
        {
            return s.Substring(s.Length - count);
        }
    }
}