using System.Text;

namespace LeetCode.Extension
{
    public static class Extension
    {
        public static string ArrayToString<T>(this T[] array)
        {
            return string.Join(',', array);
        }

        public static string ArrayToString<T>(this T[][] array)
        {
            var builder = new StringBuilder();

            foreach (var row in array)
            {
                builder.AppendLine(string.Join(',', row));
            }

            return builder.ToString();
        }
    }
}
