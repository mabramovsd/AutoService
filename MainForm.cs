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
    }
}
