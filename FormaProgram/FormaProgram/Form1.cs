using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace FormaProgram
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //clear druga grupa
        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            richTextBox1.Clear();
        }

        //combo
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //run program btn
        private void button1_Click(object sender, EventArgs e)
        {
            string a = Convert.ToString(comboBox1.SelectedItem);
            Process.Start(a);
        }

        //checkbox
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBox1.Checked)
            {
                groupBox1.Visible = true;
            }
            else
            {
                groupBox1.Visible = false;
            }
        }

        //druga grupa
        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        //prva grupa
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void messageToolStripMenuItem_Click(object sender, EventArgs e)
        {

            string message = "Odaberi neko dugme.";
            string title = "Obavijest";
            MessageBoxButtons buttons = MessageBoxButtons.YesNoCancel;
            DialogResult result = MessageBox.Show(message, title, buttons);

            if (result == DialogResult.Yes || result == DialogResult.No || result == DialogResult.Cancel)
            {
                this.Close();
            }

        }

        private void textToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormaText formaText = new FormaText();
            formaText.ShowDialog();

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string message = "Jeste li sigurni da želite izaći?";
            string title = "Potvrda";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);

            if(result == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
