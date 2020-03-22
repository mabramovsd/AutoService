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
        /// <summary>
        /// Выбранная машина
        /// </summary>
        Car car;
        public LadaForm(Car _car)
        {
            car = _car;
            InitializeComponent();

            Text = car.name + " " + car.price.ToString();
            label2.Text = car.kuzov;
            try
            {
                pictureBox1.Load("../../Pictures/" + car.name + ".jpg");
            }
            catch (Exception) { }

            try
            {
                textBox1.Text = File.ReadAllText("../../Pictures/" + car.name + ".txt");
            }
            catch (Exception) { }
        }

        private void LadaForm_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (FavouriteCarsForm.my_cars.ContainsKey(car))
                FavouriteCarsForm.my_cars[car] = FavouriteCarsForm.my_cars[car] + 1;
            else
                FavouriteCarsForm.my_cars.Add(car, 1);
        }
    }
}
