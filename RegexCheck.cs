using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BTL_HSK_ver_1
{
    internal class RegexCheck
    {
        public static bool IsAccount(string acc)
        {
            return Regex.IsMatch(acc, "^[a-zA-Z0-9]{5,32}$");
        }

        public static bool IsPassword(string pass)
        {
            return Regex.IsMatch(pass, "^[a-zA-Z0-9]{5,32}$");
        }

        public static bool IsEmail(string email)
        {
            return Regex.IsMatch(email, @"^[a-z0-9][-a-z0-9._]+@([-a-z0-9]+[.])+[a-z]{2,5}$");
        }
    }
}
