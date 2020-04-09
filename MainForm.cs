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
            #region Заполнение массива машин
            Filter.car_list.Clear();
            string[] lines = System.IO.File.ReadAllLines("Автомобили.txt");

            foreach (string str in lines)
            {
                string[] parts = str.Split(new string[] { ", " }, StringSplitOptions.None);
                Car car = new Car(parts[0], Convert.ToInt32(parts[1]), Convert.ToInt32(parts[2]), parts[3]);
                Filter.car_list.Add(car);
            }
            #endregion
        }


        /// <summary>
        /// Открываем машину
        /// </summary>
        private void carClick(object sender, EventArgs e)
        {
            Filter.carClick(sender, e);
        }
        
        private void helpButton_Click(object sender, EventArgs e)
        {
            HelpForm help = new HelpForm();
            help.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Filter s = new Filter();
            s.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            FavouriteCarsForm s = new FavouriteCarsForm();
            s.ShowDialog();
        }

        private void AddCarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddCarForm s = new AddCarForm();
            s.ShowDialog();
            MainForm_Load(sender, e);
        }
    }
}
