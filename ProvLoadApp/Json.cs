using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProvLoadApp
{
    public class Json
    {
        private const string INDENT_STRING = @"\tab";
        public static string FormatJson(string str)
        {
            int indent = 0;
            bool quoted = false;
            bool isObject = false;
            StringBuilder sb = new StringBuilder();
            sb.Append(@"{\rtf1\ansi\deff0\deftab310{\colortbl;\red0\green0\blue255;}{\fonttbl {\f0 Courier;}}\fs16");
            for (int i = 0; i < str.Length; i++)
            {
                char ch = str[i];
                switch (ch)
                {
                    case '{':
                    case '[':
                        sb.Append('\\');
                        sb.Append(ch);
                        if (!quoted)
                        {
                            sb.Append(@"\line");
                            Enumerable.Range(0, ++indent).ForEach(item => sb.Append(INDENT_STRING));
                            if (ch == '{')
                            {
                                isObject = true;
                                sb.Append(@"{\cf1 ");
                            }
                        }
                        break;
                    case '}':
                    case ']':
                        if (!quoted)
                        {
                            sb.Append(@"\line");
                            Enumerable.Range(0, --indent).ForEach(item => sb.Append(INDENT_STRING));
                            if (ch == '}')
                                isObject = false;
                        }
                        sb.Append('\\');
                        sb.Append(ch);
                        break;
                    case '"':
                        sb.Append(ch);
                        bool escaped = false;
                        var index = i;
                        while (index > 0 && str[--index] == '\\')
                            escaped = !escaped;
                        if (!escaped)
                            quoted = !quoted;
                        break;
                    case ',':
                        sb.Append(ch);
                        if (!quoted)
                        {
                            sb.Append(@"\line");
                            Enumerable.Range(0, indent).ForEach(item => sb.Append(INDENT_STRING));
                            if (isObject)
                                sb.Append(@"{\cf1 ");
                        }
                        break;
                    case ':':
                        if (!quoted)
                            sb.Append("} ");
                        sb.Append(ch);
                        if (!quoted)
                            sb.Append(" ");
                        break;
                    default:
                        sb.Append(ch);
                        break;
                }
            }
            sb.Append("}");
            return sb.ToString();
        }
    }

    static class Extensions
    {
        public static void ForEach<T>(this IEnumerable<T> ie, Action<T> action)
        {
            foreach (var i in ie)
            {
                action(i);
            }
        }
    }
}
