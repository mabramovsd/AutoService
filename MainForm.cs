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
            Filter.car_list[0] = new Car("Lada Vesta", 500000, "Седан");
            Filter.car_list[1] = new Car("Toyota Camry", 1500000, "Седан");
            Filter.car_list[2] = new Car("Ford Focus", 800000, "Хэтчбек");
            Filter.car_list[3] = new Car("Lada Priora", 450000, "Седан");
            Filter.car_list[4] = new Car("KIA Optima", 1200000, "Седан");
            Filter.car_list[5] = new Car("Pagani Zonda", 12000000, "Суперкар");
            Filter.car_list[6] = new Car("McLaren Senna", 12000000, "Суперкар");
            Filter.car_list[7] = new Car("Renault Logan", 350000, "Седан");
            Filter.car_list[8] = new Car("Ford Sierra", 350000, "Седан");
            Filter.car_list[9] = new Car("Audi 80", 150000, "Седан");
            Filter.car_list[10] = new Car("Audi A8", 550000, "Седан");
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
    }
}
