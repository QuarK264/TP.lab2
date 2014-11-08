namespace DAA.TP.lab2
{
    using System;
    using System.Text.RegularExpressions;

    class Program
    {
        static void Main()
        {
            string pattern = @"\G([0-9a-f]+-{1})+([0-9a-f]{12})";
            string GUID = "6F9619FF-8B86-D011-B42D-00CF4FC964FF";
            Regex match = new Regex(pattern, RegexOptions.IgnoreCase);
            Console.WriteLine(match.IsMatch(GUID));
            //foreach (Match GuidPart in Regex.Matches(GUID, pattern, RegexOptions.IgnoreCase))
            //{
                //Console.WriteLine(GuidPart.Value);
            //}
            Console.WriteLine(Regex.Match(GUID, pattern, RegexOptions.IgnoreCase));
            Console.ReadLine();
        }
    }
}
