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
    }
}
