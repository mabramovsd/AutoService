using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoService
{
    public partial class LadaForm : Form
    {
        public LadaForm(string car, string price, string kuzov)
        {
            InitializeComponent();

            Text = car + " " + price;
            label2.Text = kuzov;
            try
            {
                pictureBox1.Load("../../Pictures/" + car + ".jpg");
            }
            catch (Exception) { }

            try
            {
                textBox1.Text = File.ReadAllText("../../Pictures/" + car + ".txt");
            }
            catch (Exception) { }
        }

        private void LadaForm_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
