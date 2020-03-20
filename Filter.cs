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
    /// <summary>
    /// Автомобиль
    /// </summary>
    public struct Car
    {
        public string name;
        public int price;
        /// <summary>
        /// Тип кузова
        /// </summary>
        public string kuzov;
        public Button btn;
        /// <summary>
        /// Картинка
        /// </summary>
        public PictureBox picture;

        /// <summary>
        /// Создаем автомобиль
        /// </summary>
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
        /// <summary>
        /// Массив машин
        /// </summary>
        Car[] car_list = new Car[11];
        
        public Filter()
        {
            InitializeComponent();
            car_list[0] = new Car("Lada Vesta", 500000, "Седан");
            car_list[1] = new Car("Toyota Camry", 1500000, "Седан");
            car_list[2] = new Car("Ford Focus", 800000, "Хэтчбек");
            car_list[3] = new Car("Lada Priora", 450000, "Седан");
            car_list[4] = new Car("KIA Optima", 1200000, "Седан");
            car_list[5] = new Car("Pagani Zonda", 12000000, "Суперкар");
            car_list[6] = new Car("McLaren Senna", 12000000, "Суперкар");
            car_list[7] = new Car("Renault Logan", 350000, "Седан");
            car_list[8] = new Car("Ford Sierra", 350000, "Седан");
            car_list[9] = new Car("Audi 80", 150000, "Седан");
            car_list[10] = new Car("Audi A8", 550000, "Седан");

            int x = 10;
            int y = 10;
            for (int i = 0; i < car_list.Length; i = i + 1)
            {
                car_list[i].btn.Location = new Point(x, y);
                car_list[i].btn.Size = new Size(140, 40);
                car_list[i].btn.Tag = car_list[i].price;
                car_list[i].btn.AccessibleName = car_list[i].kuzov;
                car_list[i].btn.Click += new EventHandler(carClick);
                carsPanel.Controls.Add(car_list[i].btn);

                car_list[i].picture.Location = new Point(x, y + 40);
                car_list[i].picture.Size = new Size(140, 100);
                carsPanel.Controls.Add(car_list[i].picture);

                x = x + 150;
                if (x + 150 > carsPanel.Width)
                {
                    x = 10;
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
            int x = 10;
            int y = 10;
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
                    !car_list[i].name.ToLower().Contains(searchTextBox.Text.ToLower()))
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
                    if (x + 150 > carsPanel.Width)
                    {
                        x = 10;
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

        private void button1_Click(object sender, EventArgs e)
        {
            //Без фильтра
            if (carsPanel.Location.Y >= 100)
            {
                filterPanel.Size = new Size(filterPanel.Size.Width, 25);
                carsPanel.Size = new Size(carsPanel.Size.Width, 360);
                carsPanel.Location = new Point(4, 40);
            }
            //С фильтром
            else
            {
                filterPanel.Size = new Size(filterPanel.Size.Width, 95);
                carsPanel.Size = new Size(carsPanel.Size.Width, 300);
                carsPanel.Location = new Point(4, 100);
            }
        }

        private void priceTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) &&
                e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void filterButton_MouseEnter(object sender, EventArgs e)
        {
        }
    }
}
