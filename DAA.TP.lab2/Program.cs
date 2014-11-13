namespace DAA.TP.lab2
{
    using System;
    using System.Text.RegularExpressions;

    class Program
    {
        private static string GUIDCheck(string GUID)
        {
            Regex match = new Regex(Pattern.pattern, RegexOptions.IgnoreCase);
            return match.IsMatch(GUID).ToString();
        }

        static void Main()
        {
            string GUID = "6F9619FF-8B86-D011-B42D-00CF4FC964FF";
            Console.WriteLine(GUIDCheck(GUID));
            //foreach (Match GuidPart in Regex.Matches(GUID, Pattern.pattern, RegexOptions.IgnoreCase))
            //{
            //    Console.WriteLine(GuidPart.Value);
            //}
            Console.WriteLine(Regex.Match(GUID, Pattern.pattern, RegexOptions.IgnoreCase));
            Console.ReadLine();
        }
    }
}
