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
    public struct Car
    {
        public string name;
        public int price;
        public string kuzov;
        public Button btn;
        public PictureBox picture;

        public Car(string _name, int _price, string _kuzov)
        {
            name = _name;
            price = _price;
            kuzov = _kuzov;

            btn = new Button();
            btn.Text = name;

            picture = new PictureBox();
            picture.SizeMode = PictureBoxSizeMode.StretchImage;

            try
            {
                picture.Load("../../Pictures/" + name + ".jpg");
            }
            catch (Exception) { }
        }
    }

    public partial class Filter : Form
    {
        Car[] car_list = new Car[6];
        
        public Filter()
        {
            InitializeComponent();
            car_list[0] = new Car("Lada Vesta", 500000, "Седан");
            car_list[1] = new Car("Toyota Camry", 1500000, "Седан");
            car_list[2] = new Car("Ford Focus", 800000, "Хэтчбек");
            car_list[3] = new Car("Lada Priora", 450000, "Седан");
            car_list[4] = new Car("KIA Optima", 1200000, "Седан");
            car_list[5] = new Car("Pagani Zonda", 12000000, "Суперкар");

            int x = 0;
            int y = 100;
            for (int i = 0; i < car_list.Length; i = i + 1)
            {
                car_list[i].btn.Location = new Point(x, y);
                car_list[i].btn.Size = new Size(140, 40);
                car_list[i].btn.Tag = car_list[i].price;
                car_list[i].btn.AccessibleName = car_list[i].kuzov;
                car_list[i].btn.Click += new EventHandler(carClick);
                Controls.Add(car_list[i].btn);

                car_list[i].picture.Location = new Point(x, y + 40);
                car_list[i].picture.Size = new Size(140, 100);
                Controls.Add(car_list[i].picture);

                x = x + 150;
                if (x + 140 > Width)
                {
                    x = 0;
                    y = y + 150;
                }
            }
        }

        /// <summary>
        /// Открываем машину
        /// </summary>
        private void carClick(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            LadaForm lada = new LadaForm(btn.Text, btn.Tag.ToString(), btn.AccessibleName);
            lada.Show();
        }

        private void Filter_Load(object sender, EventArgs e)
        {

        }

        private void filterClick(object sender, EventArgs e)
        {
            int x = 0;
            int y = 100;
            for (int i = 0; i < car_list.Length; i++)
            {
                car_list[i].btn.Visible = true;
                car_list[i].picture.Visible = true;

                if (kuzovCheckedListBox.CheckedItems.Count > 0 &&
                    !kuzovCheckedListBox.CheckedItems.Contains(car_list[i].kuzov))
                {
                    car_list[i].btn.Visible = false;
                    car_list[i].picture.Visible = false;
                }

                if (searchTextBox.Text != "" &&
                    !car_list[i].name.Contains(searchTextBox.Text))
                {
                    car_list[i].btn.Visible = false;
                    car_list[i].picture.Visible = false;
                }

                if (priceTextBox.Text != "" &&
                    car_list[i].price > Convert.ToInt32(priceTextBox.Text))
                {
                    car_list[i].btn.Visible = false;
                    car_list[i].picture.Visible = false;
                }

                if (car_list[i].btn.Visible)
                {
                    car_list[i].btn.Location = new Point(x, y);
                    car_list[i].picture.Location = new Point(x, y + 40);

                    x = x + 150;
                    if (x + 140 > Width)
                    {
                        x = 0;
                        y = y + 150;
                    }
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void priceTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                filterClick(null, null);
            }
        }

        private void kuzovCheckedListBox_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            filterClick(null, null);
        }

        private void kuzovCheckedListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            filterClick(null, null);
        }

        private void kuzovCheckedListBox_MouseClick(object sender, MouseEventArgs e)
        {
            filterClick(null, null);
        }
    }
}
