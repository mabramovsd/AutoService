using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoService
{
    public partial class FavouriteCarsForm : Form
    {
        //public static List<Car> my_cars = new List<Car>();

        public static Dictionary<Car, int> my_cars = new Dictionary<Car, int>();

        public FavouriteCarsForm()
        {
            InitializeComponent();
            int x = 10;
            int y = 10;
            foreach (KeyValuePair<Car, int> myCar in my_cars)
            {
                Car car = myCar.Key;

                #region 1 столбец
                PictureBox picture = new PictureBox();
                picture.Location = new Point(x, y);
                picture.Size = new Size(190, 140);
                picture.SizeMode = PictureBoxSizeMode.StretchImage;
                picture.Click += new EventHandler(Filter.carClick2);
                picture.Image = car.picture.Image;
                Controls.Add(picture);
                #endregion
                
                #region 2 столбец
                Label btn = new Label();
                btn.Text = car.btn.Text;
                btn.Font = new Font("Microsoft Sans Serif", 16);
                btn.Location = new Point(x + 200, y);
                btn.Size = new Size(160, 40);
                Controls.Add(btn);

                Label lbl = new Label();
                lbl.Text = "Цена: " + car.price.ToString();
                lbl.Font = new Font("Microsoft Sans Serif", 12);
                lbl.Location = new Point(x + 200, y + 40);
                lbl.Size = new Size(160, 30);
                Controls.Add(lbl);

                Label lbl2 = new Label();
                lbl2.Text = "Кузов: " + car.kuzov;
                lbl2.Font = new Font("Microsoft Sans Serif", 12);
                lbl2.Location = new Point(x + 200, y + 70);
                lbl2.Size = new Size(160, 30);
                Controls.Add(lbl2);

                Label lbl3 = new Label();
                lbl3.Text = "Мощность: " + car.power.ToString() + " л.с.";
                lbl3.Font = new Font("Microsoft Sans Serif", 12);
                lbl3.Location = new Point(x + 200, y + 110);
                lbl3.Size = new Size(160, 30);
                Controls.Add(lbl3);
                #endregion

                #region  3 столбец
                TextBox textBox1 = new TextBox();
                textBox1.ScrollBars = ScrollBars.Vertical;
                textBox1.BorderStyle = BorderStyle.None;
                textBox1.Font = new Font("Microsoft Sans Serif", 12F);
                textBox1.Location = new Point(x + 380, y);
                textBox1.Multiline = true;
                textBox1.ReadOnly = true;
                textBox1.Size = new Size(250, 140);
                textBox1.Text = "Для этого автомобиля информации не найдено";
                try
                {
                    textBox1.Text = File.ReadAllText("../../Pictures/" + car.name + ".txt");
                }
                catch (Exception) { }
                Controls.Add(textBox1);
                #endregion

                #region 4 столбец
                NumericUpDown numericUpDown1 = new NumericUpDown();
                numericUpDown1.Font = new Font("Microsoft Sans Serif", 24);
                numericUpDown1.Location = new Point(x + 640, y);
                numericUpDown1.Size = new Size(100, 50);
                numericUpDown1.Value = myCar.Value;
                numericUpDown1.ValueChanged += new EventHandler(CountChanged);
                Controls.Add(numericUpDown1);


                Label lbl5 = new Label();
                lbl5.Text = "Итого: " + (car.price * myCar.Value).ToString();
                lbl5.Font = new Font("Microsoft Sans Serif", 12);
                lbl5.Location = new Point(x + 640, y + 70);
                lbl5.Size = new Size(160, 30);
                Controls.Add(lbl5);

                #endregion

                y = y + 150;
            }

            RefreshPrices();
        }

        /// <summary>
        /// Обновление итоговой цены
        /// </summary>
        private void CountChanged(object sender, EventArgs e)
        {
            //КОличество
            NumericUpDown nud = (NumericUpDown)sender;

            //Смотрим, какая строка
            for (int i = 0; i < my_cars.Count; i++)
            {
                if (nud.Location == new Point(650, 150 * i + 10))
                {
                    //Бегаем по всей форме
                    //Цена
                    int price = 0;
                    foreach (Control ctrl in Controls)
                    {
                        if (ctrl is Label &&
                            ctrl.Location == new Point(210, 150 * i + 50))
                        {
                            price = Convert.ToInt32(ctrl.Text.Replace("Цена: ", ""));
                        }
                    }

                    //Итого
                    foreach (Control ctrl in Controls)
                    {
                        if (ctrl is Label &&
                            ctrl.Location == new Point(650, 150 * i + 80))
                        {
                            ctrl.Text = "Итого: " + (price * nud.Value).ToString();
                        }
                    }
                }
            }

            RefreshPrices();
        }

        //Итоговая стоимость
        void RefreshPrices()
        {
            int total = 0;
            int totalPrice = 0;

            for (int i = 0; i < my_cars.Count; i++)
            {
                //Бегаем по всей форме
                //Цена
                int price = 0;
                foreach (Control ctrl in Controls)
                {
                    if (ctrl is Label &&
                        ctrl.Location == new Point(210, 150 * i + 50))
                    {
                        price = Convert.ToInt32(ctrl.Text.Replace("Цена: ", ""));
                    }
                }

                //Количество
                int count = 0;
                foreach (Control ctrl in Controls)
                {
                    if (ctrl is NumericUpDown &&
                        ctrl.Location == new Point(650, 150 * i + 10))
                    {
                        count = (int)((NumericUpDown)ctrl).Value;
                    }
                }

                total = total + count;
                totalPrice = totalPrice + count * price;
            }

            Text = "Корзина (" + total + " товаров, " + totalPrice + " рублей)";//Смотрим, какая строка
        }

        private void FavouriteCarsForm_Load(object sender, EventArgs e)
        {

        }
    }
}
