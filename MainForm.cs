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
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            LadaForm lada = new LadaForm();
            lada.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PaganiForm pagani = new PaganiForm();
            pagani.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
