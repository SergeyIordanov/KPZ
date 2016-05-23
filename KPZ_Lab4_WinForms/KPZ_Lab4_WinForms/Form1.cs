using System;
using System.Windows.Forms;
using System.IO;
using System.Drawing;

namespace KPZ_Lab4_WinForms
{
    public partial class Form1 : Form
    {
        const string FILE_NAME = "data.dat";
        public Form1()
        {
            InitializeComponent();
            textBoxInput.Text = 
                @"if (_ab <= 23.12 + a)
   res = a + (_alla * kobz) - leps / (galk + (boria));
else
   res = (5.213 - git);";
        }

        private void buttonExecute_Click(object sender, EventArgs e)
        {
            textBoxResult.Text = "";
            string s = textBoxInput.Text;

            File.WriteAllText(FILE_NAME, s);
            Token t;
            Scanner scanner = new Scanner(FILE_NAME);
            while ((t = scanner.Scan()).kind != 0)
            {
                textBoxResult.Text += (string.Format("Token:{0}, Lexeme {1}\r\n", t.kind, t.val));
            }
            scanner = new Scanner(FILE_NAME);
            Parser parser = new Parser(scanner);
            parser.Parse();           
            textBoxResult.Text += parser.errors.count + " errors detected\n";
            if (parser.errors.count > 0)
                textBoxInput.BackColor = Color.LightCoral;
            else
                textBoxInput.BackColor = Color.PaleGreen;
        }

        private void textBoxInput_TextChanged(object sender, EventArgs e)
        {
            textBoxInput.BackColor = Color.White;
        }
    }
}
