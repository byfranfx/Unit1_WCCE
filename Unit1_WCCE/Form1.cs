using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Unit1_WCCE
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();

            listBox.Items.Add("item0");
            listBox.Items.Add("item1");
            listBox.Items.Add("item3");
            this.Controls.Add(listBox);

            messagesTextBox.Text += "MainForm loaded." + "\r\n";

        }

        private void mainForm_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right) messagesTextBox.Text += "Right Click." + "\r\n"; 
            if (e.Button == System.Windows.Forms.MouseButtons.Left)  messagesTextBox.Text += "Left Click." + "\r\n"; 
        }

        private void label1_DoubleClick(object sender, EventArgs e)
        {
            messagesTextBox.Text += "The system has detected a double click on the label." + "\r\n";
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            String numericValue = numericUpDown.Value.ToString();
            messagesTextBox.Text += "Numeric Up Down value changed to: " + numericValue + "\r\n";
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox.SelectedIndex == 0) messagesTextBox.Text += "ListBox selected item has changed to: 0" + "\r\n";
            if (listBox.SelectedIndex == 1) messagesTextBox.Text += "ListBox selected item has changed to: 1" + "\r\n";
            if (listBox.SelectedIndex == 2) messagesTextBox.Text += "ListBox selected item has changed to: 2" + "\r\n";
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            messagesTextBox.Text += "TextBox has lost the focus." + "\r\n";
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            messagesTextBox.Text += "TextBox has got the focus." + "\r\n";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            String values = textBox1.Text;
            String valuesLast = Convert.ToString(values[values.Length - 1]);
                        
            messagesTextBox.Text += "The key '" + valuesLast + "' has been clicked and released. " + "\r\n";
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            messagesTextBox.Text += "The mouse pointer is inside the image." + "\r\n";
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            messagesTextBox.Text += "The mouse pointer is outside the image." + "\r\n";
        }
    }
}
