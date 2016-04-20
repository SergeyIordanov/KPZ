namespace KPZ_Lab2
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxExpression = new System.Windows.Forms.TextBox();
            this.labelExpression = new System.Windows.Forms.Label();
            this.labelLogo = new System.Windows.Forms.Label();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.labelResult = new System.Windows.Forms.Label();
            this.listBoxIdentifiers = new System.Windows.Forms.ListBox();
            this.labelIdentifiers = new System.Windows.Forms.Label();
            this.labelConstants = new System.Windows.Forms.Label();
            this.listBoxConstants = new System.Windows.Forms.ListBox();
            this.labelOperations = new System.Windows.Forms.Label();
            this.listBoxOperations = new System.Windows.Forms.ListBox();
            this.labelBrackets = new System.Windows.Forms.Label();
            this.listBoxBrackets = new System.Windows.Forms.ListBox();
            this.labelError = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxExpression
            // 
            this.textBoxExpression.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxExpression.Location = new System.Drawing.Point(16, 107);
            this.textBoxExpression.MaxLength = 200;
            this.textBoxExpression.Multiline = true;
            this.textBoxExpression.Name = "textBoxExpression";
            this.textBoxExpression.Size = new System.Drawing.Size(495, 105);
            this.textBoxExpression.TabIndex = 0;
            this.textBoxExpression.TextChanged += new System.EventHandler(this.textBoxExpression_TextChanged);
            // 
            // labelExpression
            // 
            this.labelExpression.AutoSize = true;
            this.labelExpression.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelExpression.Location = new System.Drawing.Point(12, 80);
            this.labelExpression.Name = "labelExpression";
            this.labelExpression.Size = new System.Drawing.Size(200, 20);
            this.labelExpression.TabIndex = 1;
            this.labelExpression.Text = "Write your expression here:";
            // 
            // labelLogo
            // 
            this.labelLogo.AutoSize = true;
            this.labelLogo.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLogo.Location = new System.Drawing.Point(414, 9);
            this.labelLogo.Name = "labelLogo";
            this.labelLogo.Size = new System.Drawing.Size(261, 37);
            this.labelLogo.TabIndex = 2;
            this.labelLogo.Text = "Lexemes Builder ";
            // 
            // textBoxResult
            // 
            this.textBoxResult.Enabled = false;
            this.textBoxResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxResult.Location = new System.Drawing.Point(16, 277);
            this.textBoxResult.MaxLength = 60;
            this.textBoxResult.Multiline = true;
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.Size = new System.Drawing.Size(495, 74);
            this.textBoxResult.TabIndex = 3;
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelResult.Location = new System.Drawing.Point(12, 254);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(59, 20);
            this.labelResult.TabIndex = 4;
            this.labelResult.Text = "Result:";
            // 
            // listBoxIdentifiers
            // 
            this.listBoxIdentifiers.Enabled = false;
            this.listBoxIdentifiers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBoxIdentifiers.FormattingEnabled = true;
            this.listBoxIdentifiers.ItemHeight = 20;
            this.listBoxIdentifiers.Location = new System.Drawing.Point(534, 107);
            this.listBoxIdentifiers.Name = "listBoxIdentifiers";
            this.listBoxIdentifiers.Size = new System.Drawing.Size(125, 244);
            this.listBoxIdentifiers.TabIndex = 5;
            // 
            // labelIdentifiers
            // 
            this.labelIdentifiers.AutoSize = true;
            this.labelIdentifiers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelIdentifiers.Location = new System.Drawing.Point(536, 63);
            this.labelIdentifiers.Name = "labelIdentifiers";
            this.labelIdentifiers.Size = new System.Drawing.Size(117, 20);
            this.labelIdentifiers.TabIndex = 6;
            this.labelIdentifiers.Text = "Identifiers (1, x)";
            // 
            // labelConstants
            // 
            this.labelConstants.AutoSize = true;
            this.labelConstants.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelConstants.Location = new System.Drawing.Point(664, 63);
            this.labelConstants.Name = "labelConstants";
            this.labelConstants.Size = new System.Drawing.Size(120, 20);
            this.labelConstants.TabIndex = 8;
            this.labelConstants.Text = "Constants (2, x)";
            // 
            // listBoxConstants
            // 
            this.listBoxConstants.Enabled = false;
            this.listBoxConstants.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBoxConstants.FormattingEnabled = true;
            this.listBoxConstants.ItemHeight = 20;
            this.listBoxConstants.Location = new System.Drawing.Point(665, 107);
            this.listBoxConstants.Name = "listBoxConstants";
            this.listBoxConstants.Size = new System.Drawing.Size(125, 244);
            this.listBoxConstants.TabIndex = 7;
            // 
            // labelOperations
            // 
            this.labelOperations.AutoSize = true;
            this.labelOperations.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelOperations.Location = new System.Drawing.Point(795, 63);
            this.labelOperations.Name = "labelOperations";
            this.labelOperations.Size = new System.Drawing.Size(125, 20);
            this.labelOperations.TabIndex = 10;
            this.labelOperations.Text = "Operations (3, x)";
            // 
            // listBoxOperations
            // 
            this.listBoxOperations.Enabled = false;
            this.listBoxOperations.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBoxOperations.FormattingEnabled = true;
            this.listBoxOperations.ItemHeight = 20;
            this.listBoxOperations.Location = new System.Drawing.Point(796, 107);
            this.listBoxOperations.Name = "listBoxOperations";
            this.listBoxOperations.Size = new System.Drawing.Size(124, 244);
            this.listBoxOperations.TabIndex = 9;
            // 
            // labelBrackets
            // 
            this.labelBrackets.AutoSize = true;
            this.labelBrackets.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelBrackets.Location = new System.Drawing.Point(925, 63);
            this.labelBrackets.Name = "labelBrackets";
            this.labelBrackets.Size = new System.Drawing.Size(110, 20);
            this.labelBrackets.TabIndex = 12;
            this.labelBrackets.Text = "Brackets (4, x)";
            // 
            // listBoxBrackets
            // 
            this.listBoxBrackets.Enabled = false;
            this.listBoxBrackets.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBoxBrackets.FormattingEnabled = true;
            this.listBoxBrackets.ItemHeight = 20;
            this.listBoxBrackets.Location = new System.Drawing.Point(926, 107);
            this.listBoxBrackets.Name = "listBoxBrackets";
            this.listBoxBrackets.Size = new System.Drawing.Size(124, 244);
            this.listBoxBrackets.TabIndex = 11;
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelError.ForeColor = System.Drawing.Color.Red;
            this.labelError.Location = new System.Drawing.Point(12, 215);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(116, 20);
            this.labelError.TabIndex = 13;
            this.labelError.Text = "Place for errors";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(536, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "x | value";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(928, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "x | value";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(798, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "x | value";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(667, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 20);
            this.label4.TabIndex = 17;
            this.label4.Text = "x | value";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1070, 370);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelError);
            this.Controls.Add(this.labelBrackets);
            this.Controls.Add(this.listBoxBrackets);
            this.Controls.Add(this.labelOperations);
            this.Controls.Add(this.listBoxOperations);
            this.Controls.Add(this.labelConstants);
            this.Controls.Add(this.listBoxConstants);
            this.Controls.Add(this.labelIdentifiers);
            this.Controls.Add(this.listBoxIdentifiers);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.textBoxResult);
            this.Controls.Add(this.labelLogo);
            this.Controls.Add(this.labelExpression);
            this.Controls.Add(this.textBoxExpression);
            this.Name = "Form1";
            this.Text = "Lexemes builder";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxExpression;
        private System.Windows.Forms.Label labelExpression;
        private System.Windows.Forms.Label labelLogo;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.ListBox listBoxIdentifiers;
        private System.Windows.Forms.Label labelIdentifiers;
        private System.Windows.Forms.Label labelConstants;
        private System.Windows.Forms.ListBox listBoxConstants;
        private System.Windows.Forms.Label labelOperations;
        private System.Windows.Forms.ListBox listBoxOperations;
        private System.Windows.Forms.Label labelBrackets;
        private System.Windows.Forms.ListBox listBoxBrackets;
        private System.Windows.Forms.Label labelError;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

