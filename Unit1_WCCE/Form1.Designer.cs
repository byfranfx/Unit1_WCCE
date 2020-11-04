namespace Unit1_WCCE
{
    partial class mainForm
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
            this.messagesTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.listBox = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // messagesTextBox
            // 
            this.messagesTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.messagesTextBox.ForeColor = System.Drawing.Color.White;
            this.messagesTextBox.Location = new System.Drawing.Point(216, 12);
            this.messagesTextBox.Multiline = true;
            this.messagesTextBox.Name = "messagesTextBox";
            this.messagesTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.messagesTextBox.Size = new System.Drawing.Size(450, 426);
            this.messagesTextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            this.label1.DoubleClick += new System.EventHandler(this.label1_DoubleClick);
            // 
            // numericUpDown
            // 
            this.numericUpDown.Location = new System.Drawing.Point(28, 55);
            this.numericUpDown.Name = "numericUpDown";
            this.numericUpDown.Size = new System.Drawing.Size(146, 20);
            this.numericUpDown.TabIndex = 2;
            this.numericUpDown.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.Location = new System.Drawing.Point(28, 93);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(146, 56);
            this.listBox.TabIndex = 3;
            this.listBox.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(28, 167);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(146, 20);
            this.textBox1.TabIndex = 4;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(678, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.numericUpDown);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.messagesTextBox);
            this.Name = "mainForm";
            this.Text = "Form1";
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.mainForm_MouseClick);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox messagesTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.TextBox textBox1;
    }
}

