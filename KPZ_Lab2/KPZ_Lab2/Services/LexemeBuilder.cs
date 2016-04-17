using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KPZ_Lab2.Services
{
    public static class LexemeBuilder
    {
        public static string Build(string expr, ListBox id, ListBox con, ListBox op, ListBox br)
        {
            if (!Validator.Validate(expr))
                return "Invalid exprasion.";
            // Implementation
            return "Result here!";
        }
    }
}
