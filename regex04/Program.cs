using System.Text.RegularExpressions;

namespace regex04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string x = "Завтрак в 09:00";
            var regex = new Regex(@"\b(?:[01][0-9]|2[0-3]):[0-5][0-9]\b");
            var matches = regex.Matches(x).Cast<Match>().Select(y => y.Value);
            foreach (var match in matches)
            {
                Console.WriteLine(match);
            }
        }
    }
}
