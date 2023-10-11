using System;

namespace StringLibrary
{
    public static class StringConcate
    {
        public static string ConcateWithTimestamp(this string input)
        {
            return DateTime.Now.ToString() + $" Hello, {input}!";
        }
    }
}
