using System.Collections.Generic;

namespace contianLinQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] Names = { "tom", "dick", "harry", "mary", "jay" };
            var q0 = Names.OrderBy(x => x.Length);
            var q1 = q0.Where((s) => s.Contains('a') );
            foreach (var s in q1)
            {
                Console.WriteLine(s);
            }

        }
    }
}