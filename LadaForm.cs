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
    public partial class LadaForm : Form
    {
        public LadaForm(string car)
        {
            InitializeComponent();

            Text = car;
            pictureBox1.Load("../../Pictures/" + car + ".jpg");

            if (car == "Ford Focus")
            {
                textBox1.Text = "Ford Focus" +
                    Environment.NewLine + "" +
                    Environment.NewLine + "Мощность 100 л.с.";
            }
            if (car == "KIA Optima")
            {
                textBox1.Text = "KIA Optima" +
                    Environment.NewLine + "" +
                    Environment.NewLine + "Мощность 100 л.с.";
            }
            if (car == "Pagani Zonda")
            {
                textBox1.Text = "Pagani Zonda" +
                    Environment.NewLine + "" +
                    Environment.NewLine + "Мощность 600 л.с.";
            }

        }

        private void LadaForm_Load(object sender, EventArgs e)
        {

        }
    }
}
