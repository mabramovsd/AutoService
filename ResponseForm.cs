using System;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;

namespace AutoService
{
    public partial class ResponseForm : Form
    {
        public ResponseForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MailAddress fromMailAddress = new MailAddress("beavisabra@gmail.com", "Михаил Абрамов");
            MailAddress toAddress = new MailAddress("beavisabra@gmail.com", "Михаил Абрамов");

            using (MailMessage mailMessage = new MailMessage(fromMailAddress, toAddress))
            using (SmtpClient smtpClient = new SmtpClient())
            {
                mailMessage.Subject = comboBox1.Text;
                mailMessage.Body = textBox1.Text;
                
                smtpClient.Host = "smtp.gmail.com";
                smtpClient.Port = 587;
                smtpClient.EnableSsl = true;
                smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtpClient.UseDefaultCredentials = false;
                smtpClient.Credentials = new NetworkCredential(fromMailAddress.Address, "Vb[fbkCthuttdbxF,hfvjd");

                smtpClient.Send(mailMessage);
            }

            MessageBox.Show("Ваше письмо отправлено");
        }
    }
}
