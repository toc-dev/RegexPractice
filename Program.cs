using System;
using System.Text.RegularExpressions;

namespace RegexPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] str = { "tochukwu@yahoo.com", "sage@gmail.com", "awsatyahoo" };

            foreach(string s in str)
            {
                Console.WriteLine("{0} {1} is a valid email.", s,
                    isValidEmailAddress(s) ? "is" : "is not");
            }
            Console.ReadKey();
        }
        public static bool isValidEmailAddress(string inputEmail)
        {
            string strRegex = @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z";

            Regex re = new Regex(strRegex, RegexOptions.IgnoreCase);
            if (re.IsMatch(inputEmail)) return (true); else return (false);
        }
    }
}
