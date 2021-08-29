using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Runtime.Remoting.Messaging;
using LokantaOtomasyonu;

namespace GirisProgrami
{
    public partial class frmGiriş : Form
    {
        public frmGiriş()
        {
            InitializeComponent();
        }
        /*
            burada ve alt kısımlarda sql kullanıldı 
        */
        // veri tabanını kullanır, proğram kapansa dahi veri tabanında yapılan işlemler kaydedilir
        SqlConnection baglanti = new SqlConnection(@"Server=localhost\SQLEXPRESS;Database=GirisEkrani;Trusted_Connection=True;");

        public void kullanici(TextBox kullaniciadi, TextBox sifre)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand();
            komut.Connection = baglanti;

            /*
                burada "radioButton" aracının "checked" özelliği kullanılmıştır
            */
            //checked özelliği ; seçili radio butonun hangi işlevi yapacağını kontrol eder 

            if (rbYönetici.Checked == true)
            {
                komut.CommandText = "select * from Yoneticiİslem where kullaniciadi='" + kullaniciadi.Text + "'";
            }
            if (rbPersonel.Checked == true)
            {
                komut.CommandText = "select * from Üyeİslem where kullaniciadi='" + kullaniciadi.Text + "'";
            }
            SqlDataReader read = komut.ExecuteReader();
            if (read.Read() == true)
            {
                if (sifre.Text == read["sifre"].ToString())
                {
                    if (rbYönetici.Checked == true)
                     {
                         MessageBox.Show("Yönetici Giriş Başarılı","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
                         FrmYonetici f2 = new FrmYonetici();
                         f2.ShowDialog();
                     }
                    if (rbPersonel.Checked == true)
                     {
                         MessageBox.Show("Personel Giriş Başarılı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                         frmPersonel f1 = new frmPersonel();
                         f1.ShowDialog();
                     }
                }
                else
                {
                    MessageBox.Show("Şifre Hatalı","Hata",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Bilgileri Kontrol Ediniz","Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            baglanti.Close();
        }
 
        /*
            burada "button" aracının "click" olayı kullanılmıştır
        */
        //clik olayı; tıklandığı zaman işlem yapar 
        private void btnGiris_Click_1(object sender, EventArgs e)
        {
            kullanici(txtKullanici, txtSifre);
        }

        private void frmGiriş_Load(object sender, EventArgs e)
        {
            /*
                burada "notify ıcon" aracının "","BalloonTipText","BalloonTipIcon ", 
                    "BalloonTipTitle" ve diğer özellikleri kullanılmıştır.
            */
            //Balloon Tip Title özelliği;sağ alt köşede gelen balonun başlığını belirler
            //Balloon Tip Icon özelliği;sağ alt köşede gelen balonun ikonunu belirler
            //Balloon Tip Text özelliği; sağ alt köşede gelen balonun yazısını belirler
            notifyIcon1.Text = "Lokanta Otomasyonu Çalışıyor";
            notifyIcon1.Visible = true;
            notifyIcon1.BalloonTipText = "Çalışıyor";
            notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
            notifyIcon1.BalloonTipTitle = "Lokanta Otomasyonu";
            notifyIcon1.ShowBalloonTip(30000);

            /*
                burada "text box" aracının "Password Char" özelliği kullanılmıştır 
            */
            //"Password Char" özelliği; şifre girerken gösterilecek karakteri belirler

            txtSifre.PasswordChar = '*';

            /*
                burada "text box" aracının "Multiline" özelliği kullanılmıştır 
            */
            //"Multiline" özelliği; birden fazla satır girilmesini ayarlar

            txtKullanici.Multiline = false;
            txtSifre.Multiline = false;

            /*
                burada "text box" aracının "font" özelliği kullanılmıştır
            */
            //"font" özelliği; yazının şeklini belirler

            txtKullanici.Font = new Font(txtKullanici.Font, txtKullanici.Font.Style ^ FontStyle.Bold);
            
            /*
                burada "radioButton" aracının "Text" özelliği kullanılmıştır
            */
            //text özelliği ; radio butonun hangi isim ile görüneceği yazılır

            rbYönetici.Text ="Yönetici";
            rbPersonel.Text = "Personel";

            /*
                burada "button" aracının "enable" ,"visible" ve "text" özelliği kullanılmıştır 
            */
            //enable özelliği; işlenebilirliktir, true olursa işlem yapılır false olursa yapılmaz
            //visble özelliği; görünebilirliktir, true olursa görünür false olursa görünmez
            //text özelliği ; button un hangi isim ile görüneceği yazılır

            btnGiris.Enabled = true;
            btnGiris.Visible = true;
            btnGiris.Text = "Giriş Yap";

            /*
                burada "label" aracının "visible" özelliği kullanılmıştır
            */
            //visble özelliği ; görünebilirliktir, true olursa görünür false olursa görünmez

            label1.Visible = true;
            label2.Visible = true;

            /*
                burada "label" aracının "text" özelliği kullanılmıştır
            */
            //"text" özelliği :form üzerinde görünecek yazıyı yazmamızı sağlar

            label1.Text = "Kullanıcı Adı";
            label2.Text = "Şifre";

        }
    }
}