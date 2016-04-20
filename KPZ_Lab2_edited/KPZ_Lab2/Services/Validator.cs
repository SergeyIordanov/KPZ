using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace KPZ_Lab2.Services
{
    public static class Validator
    {
        public static bool Validate(string expr)
        {
            // Check brackets (opened == closed && situations like ')a(' is absent)
            int countOpened = 0;
            foreach (char ch in expr)
            {
                if (countOpened < 0) return false;
                if (ch == '(') countOpened++;
                if (ch == ')') countOpened--;
            }
            if (countOpened != 0) return false;

            string identifier = "[a-z]|[A-Z]";
            string constant = "[0-9]";
            string operation = "[+]|[-]|[/]|[*]";//"'+'|'-'|'*'|'/'";
            string boolOperation = "==|<=|>=|>|<|!=";

            string arithmeticalEx = string.Format(
                @"[(]*\s*(({0})|({1}))\s*[)]*\s*(({2})\s*[(]*\s*(({0})|({1}))\s*[)]*\s*)*",
                identifier, constant, operation);

            return Regex.IsMatch(expr, string.Format(
                @"^\s*if\s*[(]\s*({4})\s*({3})\s*({4})\s*[)](\s|\n)*({0})\s*[=]\s*({4})\s*;(\s|\n)*((else(\s|\n)*({0})\s*[=]\s*({4})\s*;(\s|\n)*)|(\s|\n)*)$", 
                identifier, constant, operation, boolOperation, arithmeticalEx),
                RegexOptions.Compiled | RegexOptions.IgnoreCase);
        }
    }
}
