using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KPZ_Lab2.Services
{
    public class LexemeBuilder
    {
        private ListBox id, con, op, br;
        private string expr, lexeme;
        private int idCount, conCount, opCount, brCount;
        
        public LexemeBuilder(string expr, ListBox id, ListBox con, ListBox op, ListBox br)
        {
            this.id = id;
            this.con = con;
            this.op = op;
            this.br = br;

            this.lexeme = "";
            this.expr = expr;

            idCount = conCount = opCount = brCount = 1;
        }

        public string Build()
        {
            id.Items.Clear();
            con.Items.Clear();
            op.Items.Clear();
            br.Items.Clear();
            
            expr = expr.Replace("else ", "&");
            expr = expr.Replace("else\n", "&");
            expr = expr.Replace("else\r", "&");
            expr = expr.Replace(" ", String.Empty);
            expr = expr.Replace("\r", String.Empty);
            expr = expr.Replace("\n", String.Empty);

            int counter = 1;
            while (expr.Length > 0)
            {
                //string test = (expr.Substring(0, counter));
                if (counter > expr.Length)
                {
                    putCluster(expr);
                    break;
                }
                if (!isCluster(expr.Substring(0, counter)))
                {
                    if (!isCluster(expr.Substring(0, counter - 1)))
                    {
                        lexeme = "Cannot recognize lexemes";
                        break;
                    }
                    putCluster(expr.Substring(0, counter - 1));
                    expr = expr.Substring(counter - 1, expr.Length - (counter-1));
                    counter = 1;
                }
                else
                {
                    counter++;
                }
            }
            return lexeme;
        }

        private void putCluster(string s)
        {
            if (s[s.Length - 1].Equals('.'))
                lexeme += "(cannot recognize!)";
            string letters = "([a-z]|[A-Z])";
            string numbers = "([0-9])";
            if (Regex.IsMatch(s, "^([(]|[)])$", RegexOptions.Compiled | RegexOptions.IgnoreCase))
            {
                bool isExist = false;
                foreach (string item in br.Items)
                {
                    if (item.Split('|')[1].Trim().Equals(s))
                    {
                        lexeme += "(4," + item.Split('|')[0].Trim() + ")";
                        isExist = true;
                        break;
                    }
                }
                if (!isExist)
                {
                    lexeme += "(4," + brCount + ")";
                    string str = brCount + " | " + s;
                    br.Items.Add(str);
                    brCount++;
                }
            }          
            if (Regex.IsMatch(s, String.Format("^(([_]|{1})([_]|{1}|{0})*)$", numbers, letters), RegexOptions.Compiled | RegexOptions.IgnoreCase))
            {
                bool isExist = false;
                foreach (string item in id.Items)
                {
                    if (item.Split('|')[1].Trim().Equals(s))
                    {
                        lexeme += "(1," + item.Split('|')[0].Trim() + ")";
                        isExist = true;
                        break;
                    }
                }
                if (!isExist)
                {
                    if(!s.Equals("if") && !s.Equals("else"))
                    {
                        lexeme += "(1," + idCount + ")";
                        string str = idCount + " | " + s;
                        id.Items.Add(str);
                        idCount++;
                    }
                }
            }
            if (Regex.IsMatch(s, "^([+]|[=]|[-]|[/]|[*]|[>]|[<]|<=|>=|==|!=|[;]|if|&)$", RegexOptions.Compiled | RegexOptions.IgnoreCase))
            {
                bool isExist = false;

                foreach (string item in op.Items)
                {
                    if(s.Equals("&"))
                    {
                        if (item.Split('|')[1].Trim().Equals("else"))
                        {
                            lexeme += "(3," + item.Split('|')[0].Trim() + ")";
                            isExist = true;
                            break;
                        }
                    }
                    if (item.Split('|')[1].Trim().Equals(s))
                    {
                        lexeme += "(3," + item.Split('|')[0].Trim() + ")";
                        isExist = true;
                        break;
                    }
                }
                if (!isExist)
                {
                    if (s.Equals("&"))
                    {
                        lexeme += "(3," + opCount + ")";
                        string str = opCount + " | " + "else";
                        op.Items.Add(str);
                        opCount++;
                    }
                    else {
                        lexeme += "(3," + opCount + ")";
                        string str = opCount + " | " + s;
                        op.Items.Add(str);
                        opCount++;
                    }
                }
            }
            if (Regex.IsMatch(s, String.Format("^({0}+|({0}+[.]{0}+))$", numbers), RegexOptions.Compiled | RegexOptions.IgnoreCase))
            {
                bool isExist = false;
                foreach (string item in con.Items)
                {
                    if (item.Split('|')[1].Trim().Equals(s))
                    {
                        lexeme += "(2," + item.Split('|')[0].Trim() + ")";
                        isExist = true;
                        break;
                    }
                }
                if (!isExist)
                {
                    lexeme += "(2," + conCount + ")";
                    string str = conCount + " | " + s;
                    con.Items.Add(str);
                    conCount++;
                }
            }
        }

        private static bool isCluster(string s)
        {
            string letters = "([a-z]|[A-Z])";
            string numbers = "([0-9])";
            if (Regex.IsMatch(s, @"^([(]|[)])$", RegexOptions.Compiled | RegexOptions.IgnoreCase))
            {
                return true;
            }
            if (Regex.IsMatch(s, @"^([+]|[=]|[-]|[/]|[*]|[>]|[<]|<=|>=|==|!=|[;]|[!])$", RegexOptions.Compiled | RegexOptions.IgnoreCase))
            {
                return true;
            }
            if (Regex.IsMatch(s, String.Format(@"^(([_]|{1})([_]|{1}|{0})*)$", numbers, letters), RegexOptions.Compiled | RegexOptions.IgnoreCase))
            {
                return true;
            }
            if (Regex.IsMatch(s, String.Format(@"^({0}+|({0}*[.]{0}*))$", numbers), RegexOptions.Compiled | RegexOptions.IgnoreCase))
            {
                return true;
            }
            if (Regex.IsMatch(s, String.Format("^[&]$"), RegexOptions.Compiled | RegexOptions.IgnoreCase))
            {
                return true;
            }
            return false;
        }
    }
}
