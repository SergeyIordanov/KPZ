using KPZ_Lab2.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KPZ_Lab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            labelError.Text = "";
//            textBoxExpression.Text = 
//@"if( a + (b / 4) >= c / 2)
//    r = 4 - a * b;
//else
//    r = (b + c) * (c + (d - 5) * 2);";
        }

        private void textBoxExpression_TextChanged(object sender, EventArgs e)
        {
            labelError.Text = "";
            //if (!Validator.Validate(textBoxExpression.Text))
            //labelError.Text = "Invalid input";
            LexemeBuilder builder = new LexemeBuilder(textBoxExpression.Text,
            listBoxIdentifiers, listBoxConstants, listBoxOperations, listBoxBrackets);
            textBoxResult.Text = builder.Build();
        }
    }
}
