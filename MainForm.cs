﻿using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Mail;
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
                Car car = new Car(parts[0], Convert.ToInt32(parts[1]), Convert.ToInt32(parts[2]), parts[3], parts[4]);
                Filter.car_list.Add(car);
            }
            #endregion

            #region Словари

            RusWords.Add("Фильтр", "Фильтр");
            RusWords.Add("Войти", "Войти");
            RusWords.Add("Выйти", "Выйти");

            EngWords.Add("Фильтр", "Filter");
            EngWords.Add("Войти", "Login");
            EngWords.Add("Выйти", "Logout");

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

        private void прислатьПрайслистToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MailAddress fromMailAddress = new MailAddress("beavisabra@gmail.com", "Михаил Абрамов");
            MailAddress toAddress = new MailAddress("beavisabra@gmail.com", "Михаил Абрамов");

            using (MailMessage mailMessage = new MailMessage(fromMailAddress, toAddress))
            using (SmtpClient smtpClient = new SmtpClient())
            {
                mailMessage.Subject = "Привет";
                mailMessage.Body = "А вот и список Машин";
                mailMessage.Attachments.Add(new Attachment("Авто.txt"));

                smtpClient.Host = "smtp.gmail.com";
                smtpClient.Port = 587;
                smtpClient.EnableSsl = true;
                smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtpClient.UseDefaultCredentials = false;
                smtpClient.Credentials = new NetworkCredential(fromMailAddress.Address, "Vb[fbkCthuttdbxF,hfvjd");

                smtpClient.Send(mailMessage);
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            //Вход / выход
            if (AuthForm.Login == "")
            {
                AuthForm af = new AuthForm();
                af.ShowDialog();
            }
            else
            {
                AuthForm.Login = "";
            }


            if (AuthForm.Login == "")
            {
                label1.Text = "";
            }
            else
            {
                label1.Text = "Привет, " + AuthForm.Login;
            }

            translateAll();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            ResponseForm rf = new ResponseForm();
            rf.ShowDialog();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        public static Dictionary<string, string> RusWords = new Dictionary<string, string>();
        public static Dictionary<string, string> EngWords = new Dictionary<string, string>();
        public static string Language = "Ru";

        /// <summary>
        /// Перевод слова
        /// </summary>
        public static string GetTranslation(string Key)
        {
            string result = "";
            Dictionary<string, string> Words = 
                (Language == "Ru") ? RusWords : EngWords;

            try
            {
                result = Words[Key];
            }
            catch (Exception) { }

            return result;
        }

        void translateAll()
        {
            button7.Text = GetTranslation("Фильтр");
            if (AuthForm.Login == "")
                button9.Text = GetTranslation("Войти");
            else
                button9.Text = GetTranslation("Выйти");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Language = "Ru";
            translateAll();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Language = "En";
            translateAll();
        }
    }
}
