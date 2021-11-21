using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TecAvProg_TP6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            System.Net.Mail.MailMessage mmsg = new System.Net.Mail.MailMessage();
            mmsg.To.Add(txtPara.Text);
            mmsg.Subject = txtAsunto.Text;
            mmsg.SubjectEncoding = System.Text.Encoding.UTF8;
            mmsg.CC.Add(txtCc.Text);

            mmsg.Body = txtCuerpo.Text;
            mmsg.BodyEncoding = System.Text.Encoding.UTF8;
            mmsg.IsBodyHtml = false;
            mmsg.From = new System.Net.Mail.MailAddress("bordond75@gmail.com");

            System.Net.Mail.SmtpClient cliente = new System.Net.Mail.SmtpClient();
            cliente.Credentials = new System.Net.NetworkCredential("bordond75@gmail.com","wlM29jes");
            cliente.Port = 587;
            cliente.EnableSsl = true;
            cliente.Host = "smtp.gmail.com";
            try
            {
                cliente.Send(mmsg);
                MessageBox.Show("El email ha sido enviado correctamente.");
                txtPara.Clear();
                txtCc.Clear();
                txtAsunto.Clear();
                txtCuerpo.Clear();
            }
            catch (Exception)
            {
                MessageBox.Show("Error al enviar el email.");
            }
        }
    }
}
