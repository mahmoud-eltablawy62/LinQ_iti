namespace multipul
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>()

            {2,4,6,7,1,4,2,9,1};


            var s_num = numbers.OrderBy(s => s);
            var d_num = s_num.Distinct();
            var mul = delegate (int x, int y) { return x * y; };
            foreach (var q in d_num)
            {
                Console.WriteLine("number==> " + q + "multiply==>"+mul(q, q));
            }

        }
    }
}