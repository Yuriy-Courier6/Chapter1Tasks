using System;

namespace Chapter1.HelloMessageFormatter
{
    public static class Formatter
    {
        public static string FormatHelloMessage(string userName)
        {
            return $"{DateTime.Now:g} Hello, {userName.Trim()}!";
        }
    }
}
