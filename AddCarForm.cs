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
    public partial class AddCarForm : Form
    {
        public AddCarForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = 0;
            if (!Int32.TryParse(PriceTB.Text, out a))
            {
                MessageBox.Show("Цена - не число!");
                return;
            }

            System.IO.File.AppendAllText("Автомобили.txt", 
                Environment.NewLine + 
                NameTB.Text + ", " + 
                PriceTB.Text + ", " + 
                PowerTB.Text + ", " +
                kuzovCB.Text);

            if (FileName != "")
            {
                System.IO.File.Copy(FileName,
                    "../../Pictures/" + NameTB.Text + ".jpg");
            }

            MessageBox.Show("Сохранено");
        }

        /// <summary>
        /// Файл с машинкой
        /// </summary>
        string FileName = "";

        private void button2_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                FileName = openFileDialog1.FileName;
                pictureBox1.Load(FileName);
            }
        }
    }
}
