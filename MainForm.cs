using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoService
{
    public partial class MainForm : Form
    {
        int score = 0;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LadaForm lada = new LadaForm("Ford Focus");
            lada.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LadaForm lada = new LadaForm("Pagani Zonda");
            lada.Show();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            LadaForm lada = new LadaForm("KIA Optima");
            lada.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            LadaForm lada = new LadaForm(button4.Text);
            lada.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            LadaForm lada = new LadaForm(button5.Text);
            lada.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            LadaForm lada = new LadaForm(button6.Text);
            lada.Show();
        }

        private void helpButton_Click(object sender, EventArgs e)
        {
            HelpForm help = new HelpForm();
            help.Show();
        }
    }
}
