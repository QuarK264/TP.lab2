namespace DAA.TP.lab2
{
    using System;

    /// <summary>
    /// Статичный класс, содержащий шаблон регулярного выражения
    /// </summary>
    static class Pattern
    {
        /// <summary>
        /// Шаблон проверяющий GUID
        /// </summary>
        public static string pattern = @"\G\(*([0-9a-f]{8}-{1})([0-9a-f]{4}-{1}){3}([0-9a-f]{12})\)*";
    }
}
