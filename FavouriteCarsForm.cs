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
    public partial class FavouriteCarsForm : Form
    {
        public static List<Car> my_cars = new List<Car>();

        public FavouriteCarsForm()
        {
            InitializeComponent();
            int x = 10;
            int y = 10;
            foreach (Car car in my_cars)
            {
                Button btn = new Button();
                btn.Text = car.btn.Text;
                btn.Location = new Point(x, y);
                btn.Size = new Size(140, 40);
                btn.Click += new EventHandler(Filter.carClick);
                Controls.Add(btn);

                PictureBox picture = new PictureBox();
                picture.Location = new Point(x, y + 40);
                picture.Size = new Size(140, 100);
                picture.SizeMode = PictureBoxSizeMode.StretchImage;
                picture.Image = car.picture.Image;
                Controls.Add(picture);

                x = x + 150;
                if (x + 150 > Width)
                {
                    x = 10;
                    y = y + 150;
                }
            }
        }

        private void FavouriteCarsForm_Load(object sender, EventArgs e)
        {

        }
    }
}
