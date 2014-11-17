namespace DAA.TP.lab2
{
    using System;
    using System.Text.RegularExpressions;

    class Program
    {
        /// <summary>
        /// Проверка GUID на корректность с помощью регулярного выражения
        /// </summary>
        /// <param name="GUID">GUID, который нужно проверить</param>
        /// <returns>Результат проверки GUID</returns>
        private static string GUIDCheck(string GUID)
        {
            Regex match = new Regex(Pattern.pattern, RegexOptions.IgnoreCase);//создание экземпляра класса, по шаблону с игнорированием регистра
            return match.IsMatch(GUID).ToString();//проверка совпадает строка с шаблоном или нет
        }
        /// <summary>
        /// Точка входа в программу
        /// </summary>
        static void Main()
        {
            string GUID1 = "6F9619FF-8B86-D011-B42D-00CF4FC964FF";
            string GUID2 = "(6F9619FF-8B86-D011-B42D-00CF4FC964FF)";
            Console.WriteLine(GUIDCheck(GUID1));
            Console.WriteLine(GUIDCheck(GUID2));
            //foreach (Match GuidPart in Regex.Matches(GUID, Pattern.pattern, RegexOptions.IgnoreCase))
            //{
            //    Console.WriteLine(GuidPart.Value);
            //}
            //Console.WriteLine(Regex.Match(GUID, Pattern.pattern, RegexOptions.IgnoreCase));
            Console.ReadLine();
        }
    }
}
