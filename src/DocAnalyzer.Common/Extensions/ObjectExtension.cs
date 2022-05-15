namespace DocAnalyzer.Common.Extensions
{
    public static class ObjectExtension
    {
        public static string? ToNormalizedString(this object obj)
        {
            return obj?.ToString()?.Trim();
        }
    }
}
