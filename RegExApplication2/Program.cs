using System.Text.RegularExpressions;

namespace RegExApplication2
{
    class Program
    {

        private static void showMatch(string text, string expr)
        {
            Console.WriteLine("The Expression1:" + expr);
            MatchCollection mc = Regex.Matches(text, expr);
            foreach (Match m in mc)
            {
                Console.WriteLine(m);
            }
        }
        static void Main(string[] args)
        {
            string str = "make maze and manage to measure it";

            Console.WriteLine("Matching words that start with 'm'and ends with'e':");
            showMatch(str, @"\bm\S*e\b");
            Console.ReadKey();
        }
    }
}
