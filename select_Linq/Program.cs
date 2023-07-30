using System.Collections.Generic;

namespace select_Linq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] Names = { "tom", "dick", "harry", "mary", "jay" };
            var q1 = Names.Where((s) => s.Length == 3);
            foreach (var s in q1)
            {
                Console.WriteLine(s);
            }

        }
    }
}