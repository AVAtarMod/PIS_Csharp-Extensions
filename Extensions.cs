using System;
using System.Collections.Generic;

namespace Extensions
{
    public class EList<T> : List<T>
    {
        public EList() : base()
        {

        }
        public EList(int capacity) : base(capacity)
        {

        }
        public EList(IEnumerable<T> collection) : base(collection)
        {

        }
        public override string ToString()
        {
            string result = "";
            if (Count > 0)
            {
                const string separator = ", ";
                foreach (T item in this)
                {
                    result += $"{item.ToString()}{separator}";
                }
                result = result.Remove(result.Length - separator.Length);
            }
            return result;
        }
    }
    public static class Extensions
    {
        public static EList<T> ToEList<T>(this List<T> list)
        {
            return (EList<T>)list;
        }
        public static EList<T> ToEList<T>(this IEnumerable<T> collection)
        {
            return (EList<T>)collection;
        }
        public static EList<T> ToEList<T>(this T[] array)
        {
            return new EList<T>(array);
        }
    }
    public class DebugConsole
    {
        public static void WriteLine(string message)
        {
#if DEBUG
            Console.WriteLine(message);
#endif
        }
        public static void Write(string message)
        {
#if DEBUG
            Console.Write(message);
#endif
        }
    }
}
