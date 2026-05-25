using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bankacılık_Uygulaması__asıl_hali_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string name;
        string surname;
        double tc;
      

        KisiselBilgiler kb = new KisiselBilgiler();
        HesapBilgileri hb= new HesapBilgileri();

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                name = Nametxtbox.Text;
                surname = Surnametxtbox.Text;
                tc = Convert.ToDouble(TCnotxtbox.Text);
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            if(name==kb.Ad && surname==kb.Soyad&& tc == kb.TCno)
            {
                MessageBox.Show("Bilgiler Doğru!");
                kb.Bilgiler = true;

                bakiyelabel.Text = hb.HesapToplamı.ToString();
            }
            else
            {
                MessageBox.Show("Girilen Bilgiler yanlış, lütfen tekrar dene.");
                kb.Bilgiler= false;
            }

        }

        private void ParaGonderbtn_Click(object sender, EventArgs e)
        {
            if (kb.Bilgiler == true)
            {
                double paragonder = Convert.ToDouble(paraGondertxtbox.Text);
                if (paragonder <= hb.HesapToplamı && paragonder > 0)
                {
                    hb.HesapToplamı -= paragonder;
                    bakiyelabel.Text = hb.HesapToplamı.ToString();
                    MessageBox.Show($"Hesaptan {paragonder}TL para gönderildi!");

                }
                else MessageBox.Show($"Yetersiz bakiye");
            }
            else
            {
                MessageBox.Show("Lütfen kullanıcı bilgilerini giriniz.");
            }
        }
    }
}
