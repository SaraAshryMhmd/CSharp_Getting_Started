
namespace Intro_To_WPF.Core
{
    public static class Extensions
    {
        public static int DISPAY_NUMERIC_VALUE = 0;
        public static bool IsNumeric(this string text)
        {
            // Check if the string is a valid numeric value
            return int.TryParse(text, out _);
        }
    }
}
