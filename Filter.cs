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
        /// <summary>
        /// Название машины
        /// </summary>
        public string name;
        /// <summary>
        /// ЦЕна авто
        /// </summary>
        public int price;
        /// <summary>
        /// Тип кузова
        /// </summary>
        public string kuzov;
        /// <summary>
        /// Мощность
        /// </summary>
        public int power;
        /// <summary>
        /// Кнопка
        /// </summary>
        public Button btn;
        /// <summary>
        /// Картинка
        /// </summary>
        public PictureBox picture;

        /// <summary>
        /// Создаем автомобиль
        /// </summary>
        public Car(string _name, int _price, int _power, string _kuzov)
        {
            name = _name;
            power = _power;
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
        public static Car[] car_list = new Car[11];
        
        public Filter()
        {
            InitializeComponent();
            
            #region Автоматическое расположение машин на форме
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
            #endregion
        }

        /// <summary>
        /// Открываем машину
        /// </summary>
        public static void carClick(object sender, EventArgs e)
        {
            for (int i = 0; i < car_list.Length; i = i + 1)
            {
                if (((Button)sender).Text == car_list[i].btn.Text)
                {
                    LadaForm lada = new LadaForm(car_list[i]);
                    lada.Show();
                }
            }
        }

        /// <summary>
        /// Открываем машину
        /// </summary>
        public static void carClick2(object sender, EventArgs e)
        {
            for (int i = 0; i < car_list.Length; i = i + 1)
            {
                if (((PictureBox)sender).Image == car_list[i].picture.Image)
                {
                    LadaForm lada = new LadaForm(car_list[i]);
                    lada.Show();
                }
            }
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
