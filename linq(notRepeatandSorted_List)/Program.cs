namespace linq_notRepeatandSorted_List_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List <int> numbers = new List<int>()

            {2,4,6,7,1,4,2,9,1};

            
            var s_num = numbers.OrderBy(s => s);
            var d_num = s_num.Distinct();
            foreach (var q in d_num ) {
                Console.WriteLine(q);
            }

        }
    }
}