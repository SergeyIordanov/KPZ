using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KPZ_Lab1
{
    static class Translator
    {
        public static string Translate(string input)
        {
            string result = "";
            if (hasElse(input))
            {
                // if else
                ExpressionTranslator exTranslator = new ExpressionTranslator();
                string condition = translateCondition(ref input);
                string[] arr = new string[] { "else" };
                string beforeElse = input.Split(arr, 2, StringSplitOptions.RemoveEmptyEntries)[0];
                string afterElse = input.Split(arr, 2, StringSplitOptions.RemoveEmptyEntries)[1];
                result += condition + " gotoA1 gotoA2 A1:" + exTranslator.Translate(beforeElse) +
                    " gotoA3 A2:" + exTranslator.Translate(afterElse) + " A3:";
            }
            else
            {
                // if
                ExpressionTranslator exTranslator = new ExpressionTranslator();
                string condition = translateCondition(ref input);
                result += condition + " gotoA1 A1:" + exTranslator.Translate(input);
            }
            return result;
        }

        private static string translateCondition(ref string input)
        {
            string condition = "";
            input = input.Substring(3);

            int i = 0;
            int counter = 1;
            while (counter != 0)
            {
                if (input[i] == '(')
                    counter++;
                if (input[i] == ')')
                    counter--;
                condition += input[i];
                i++;
            }
            condition = condition.Substring(0, condition.Length - 1);
            //for(int i = 0; counter >= 0)

            input = input.Substring(i);

            string res = "";
            ExpressionTranslator exTranslator = new ExpressionTranslator();
            string[] arr = condition.Split('=');
            if(arr.Length == 1)
            {
                // > <
                if(condition.Split('<').Length > 1)
                {
                    // <
                    string[] arr2 = condition.Split('<');
                    res += exTranslator.Translate(arr2[0]);
                    res += exTranslator.Translate(arr2[1]);
                    res += "<";
                }
                else
                {
                    // >
                    string[] arr3 = condition.Split('>');
                    res += exTranslator.Translate(arr3[0]);
                    res += exTranslator.Translate(arr3[1]);
                    res += ">";
                }
            }
            else if(arr.Length == 2)
            {
                // != <= >=
                char last = arr[0][arr[0].Length - 1];
                arr[0] = arr[0].Substring(0, arr[0].Length - 1);
                res += exTranslator.Translate(arr[0]);
                res += exTranslator.Translate(arr[1]);
                res += last.ToString()  + "=";
            }
            else
            {
                // ==
                res += exTranslator.Translate(arr[0]);
                res += exTranslator.Translate(arr[2]);
                res += "==";
            }
            return res;
        }

        private static bool hasElse(string input)
        {
            for (int i = 0; i < input.Length - 1; i++)
                if (input[i] == 'e' && input[i + 1] == 'l')
                    return true;
            return false;
        }
    }
}
