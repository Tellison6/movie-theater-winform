using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sinema_Salonu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Sinema salon;

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                salon = new Sinema(textBox1.Text, Convert.ToInt32(textBox2.Text));
                label5.Text = "Salon Oluşturuldu. Koltuk Sayısı: " + salon.BosKoltukOgren();
            }
            catch (Exception)
            {

                label5.Text = "Salon Oluşturulamadı! Bilgileri Kontrol Edin.";
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                salon.BiletSat(checkBox1.Checked);
                label5.Text = "Bilet satıldı. Kalan koltuk sayısı: " + salon.BosKoltukOgren();
            }
            catch (Exception)
            {
                label5.Text = "Salon Oluşturulamadı! Bilgileri Kontrol Edin.";
            }

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            try
            {
                salon.BiletIptal(checkBox1.Checked);
                label5.Text = "Bilet iptal edildi. Kalan koltuk sayısı: " + salon.BosKoltukOgren();
            }
            catch (Exception)
            {

                label5.Text = "Salon Oluşturulamadı! Bilgileri Kontrol Edin.";
            }
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            label3.Text = "Şu anki bakiye: " + salon.BakiyeOgren() + "TL";

        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            label5.Text = "Boş koltuk sayısı: " + salon.BosKoltukOgren();

        }
    }
}
