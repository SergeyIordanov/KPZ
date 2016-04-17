using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KPZ_Lab2.Services
{
    public static class LexemeBuilder
    {
        public static string Build(string expr, ListBox id, ListBox con, ListBox op, ListBox br)
        {
            id.Items.Clear();
            con.Items.Clear();
            op.Items.Clear();
            br.Items.Clear();

            if (!Validator.Validate(expr))
                return "Invalid exprassion";
         
            string lexeme = "";
            int idCount, conCount, opCount, brCount;
            idCount = conCount = opCount = brCount = 1;
            expr = expr.Replace(" ", String.Empty);
            foreach (char ch in expr)
            {
                if(Regex.IsMatch(ch.ToString(), string.Format(@"^[0-9]$"), RegexOptions.Compiled | RegexOptions.IgnoreCase))
                {
                    bool isExist = false;
                    foreach(string item in con.Items)
                    {
                        if(item.Substring(item.Length-1).Equals(ch.ToString()))
                        {
                            lexeme += "(2," + item.Substring(0, 2).Trim() + ")";
                            isExist = true;
                            break;
                        }
                    }
                    if (!isExist)
                    {
                        lexeme += "(2," + conCount + ")";
                        string s = conCount + " | " + ch.ToString();
                        con.Items.Add(s);
                        conCount++;
                    }
                }
            }
            return lexeme;
        }
    }
}
