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
            expr = expr.Replace("if", "#");
            expr = expr.Replace("else", "^");
            for(int i = 0; i < expr.Length; i++)
            {
                //Operations
                if (Regex.IsMatch(expr[i].ToString(), string.Format(@"^[-]|[+]|[*]|[/]|[=]|[<]|[>]|[#]|[!]|['^']|[;]$"), RegexOptions.Compiled | RegexOptions.IgnoreCase))
                {
                    bool isExist = false;
                    foreach (string item in op.Items)
                    {
                        if (item.Substring(item.Length - 2).Trim().Equals(expr[i].ToString()))
                        {
                            lexeme += "(3," + item.Substring(0, 2).Trim() + ")";
                            isExist = true;
                            break;
                        }
                    }
                    if (expr[i] == '#' || expr[i] == '^')
                    {
                        lexeme += "(3," + opCount + ")";
                        string s = "";
                        if(expr[i] == '#')
                            s += opCount + " | " + "if";
                        else
                            s += opCount + " | " + "else";
                        op.Items.Add(s);
                        opCount++;
                    }
                    else if (expr[i] == '=' && expr[i+1] == '=')
                    {
                        lexeme += "(3," + opCount + ")";
                        string s = opCount + " | " + "==";
                        op.Items.Add(s);
                        opCount++;
                        i++;
                    }
                    else if ((expr[i] == '>' || expr[i] == '<' || expr[i] == '!') && expr[i + 1] == '=')
                    {
                        lexeme += "(3," + opCount + ")";
                        string s = opCount + " | " + expr[i].ToString() + "=";
                        op.Items.Add(s);
                        opCount++;
                        i++;
                    }
                    else if (!isExist)
                    {
                        lexeme += "(3," + opCount + ")";
                        string s = opCount + " | " + expr[i].ToString();
                        op.Items.Add(s);
                        opCount++;
                    }
                }
                // Identifiers
                if (Regex.IsMatch(expr[i].ToString(), string.Format(@"^[a-z]|[A-Z]$"), RegexOptions.Compiled | RegexOptions.IgnoreCase))
                {
                    bool isExist = false;
                    foreach (string item in id.Items)
                    {
                        if (item.Substring(item.Length - 1).Equals(expr[i].ToString()))
                        {
                            lexeme += "(1," + item.Substring(0, 2).Trim() + ")";
                            isExist = true;
                            break;
                        }
                    }
                    if (!isExist)
                    {
                        lexeme += "(1," + idCount + ")";
                        string s = idCount + " | " + expr[i].ToString();
                        id.Items.Add(s);
                        idCount++;
                    }
                }
                // Constants
                if (Regex.IsMatch(expr[i].ToString(), string.Format(@"^[0-9]$"), RegexOptions.Compiled | RegexOptions.IgnoreCase))
                {
                    bool isExist = false;
                    foreach(string item in con.Items)
                    {
                        if(item.Substring(item.Length-1).Equals(expr[i].ToString()))
                        {
                            lexeme += "(2," + item.Substring(0, 2).Trim() + ")";
                            isExist = true;
                            break;
                        }
                    }
                    if (!isExist)
                    {
                        lexeme += "(2," + conCount + ")";
                        string s = conCount + " | " + expr[i].ToString();
                        con.Items.Add(s);
                        conCount++;
                    }
                }
                // Brackets
                if (Regex.IsMatch(expr[i].ToString(), string.Format(@"^[(]|[)]$"), RegexOptions.Compiled | RegexOptions.IgnoreCase))
                {
                    if (br.Items.Count == 0)
                    {
                        string s1 = brCount + " | " + "(";
                        br.Items.Add(s1);
                        brCount++;
                        string s2 = brCount + " | " + ")";
                        br.Items.Add(s2);
                    }
                    if(expr[i] == '(')
                        lexeme += "(4,1)";
                    else
                        lexeme += "(4,2)";
                }
            }
            return lexeme;
        }
    }
}
