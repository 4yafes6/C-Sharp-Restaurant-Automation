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

namespace LokantaOtomasyonu
{
    public partial class FrmYonetici : Form
    {
        public FrmYonetici()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Server=localhost\SQLEXPRESS;Database=GirisEkrani;Trusted_Connection=True;");
        public void txtSil()
        {
            mtxtTc.Text = "";
            txtAdSoyad.Text = "";
            txtYaş.Text = "";
            cboxCİnsiyet.Text = "";
            mtxtTelefon.Text = "";
            txtKullaniciAdi.Text = "";
            txtSifre.Text = "";
            mtxtTc2.Text = "";
            txtAdSoyad2.Text = "";
            txtYaş2.Text = "";
            cboxCinsiyet2.Text = "";
            mtxtTelefon2.Text = "";
            txtKullaniciadi2.Text = "";
            txtSifre2.Text = "";
        }
        public void ekle()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Üyeislem(tcno,adsoyad,yaş,cinsiyet,telefon,kullaniciadi,sifre) values(@tcno,@adsoyad,@yaş,@cinsiyet,@telefon,@kullaniciadi,@sifre)", baglanti);
            komut.Parameters.AddWithValue("@tcno", mtxtTc.Text);
            komut.Parameters.AddWithValue("@adsoyad", txtAdSoyad.Text);
            komut.Parameters.AddWithValue("@yaş", txtYaş.Text);
            komut.Parameters.AddWithValue("@cinsiyet", cboxCİnsiyet.Text);
            komut.Parameters.AddWithValue("@telefon", mtxtTelefon.Text);
            komut.Parameters.AddWithValue("@kullaniciadi", txtKullaniciAdi.Text);
            komut.Parameters.AddWithValue("@sifre", txtSifre.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            uyelistele();
            txtSil();
        }
        public void uyelistele()
        {
            baglanti.Open();
            DataSet daset = new DataSet();
            SqlDataAdapter adtr = new SqlDataAdapter("select * from Üyeİslem", baglanti);
            adtr.Fill(daset, "Üyeİslem");
            dataGridView1.DataSource = daset.Tables["Üyeİslem"];
            baglanti.Close();
        }
        public void uyelistele2()
        {
            baglanti.Open();
            DataSet daset = new DataSet();
            SqlDataAdapter adtr = new SqlDataAdapter("select * from Yoneticiİslem", baglanti);
            adtr.Fill(daset, "Yoneticiİslem");
            dataGridView2.DataSource = daset.Tables["Yoneticiİslem"];
            baglanti.Close();
        }
        public void güncelle()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update Üyeİslem set adsoyad=@adsoyad,yaş=@yaş,cinsiyet=@cinsiyet,telefon=@telefon,kullaniciadi=@kullaniciadi,sifre=@sifre where tcno=@tcno", baglanti);
            komut.Parameters.AddWithValue("tcno", mtxtTc.Text);
            komut.Parameters.AddWithValue("adsoyad", txtAdSoyad.Text);
            komut.Parameters.AddWithValue("yaş", txtYaş.Text);
            komut.Parameters.AddWithValue("cinsiyet", cboxCİnsiyet.Text);
            komut.Parameters.AddWithValue("telefon", mtxtTelefon.Text);
            komut.Parameters.AddWithValue("kullaniciadi", txtKullaniciAdi.Text);
            komut.Parameters.AddWithValue("sifre", txtSifre.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            uyelistele();
            txtSil();

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            ekle();
            MessageBox.Show("Yeni Bir Personel Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            güncelle();
            MessageBox.Show("Personel Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut3 = new SqlCommand(" delete from Üyeİslem where tcno=@tcno", baglanti);
            komut3.Parameters.AddWithValue("@tcno", dataGridView1.CurrentRow.Cells["tcno"].Value.ToString());
            komut3.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Silme İşlemi Başarılı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            uyelistele();
            txtSil();
        }

        /*
            burada 'dataGridView' aracının 'cell double click ' olayı kullanılmıştır
         */
        //bu olay 2 kere tıklanıldıında seçmesini sağlar
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            mtxtTc.Text = dataGridView1.CurrentRow.Cells["tcno"].Value.ToString();
            txtAdSoyad.Text = dataGridView1.CurrentRow.Cells["adsoyad"].Value.ToString();
            txtYaş.Text = dataGridView1.CurrentRow.Cells["yaş"].Value.ToString();
            cboxCİnsiyet.Text = dataGridView1.CurrentRow.Cells["cinsiyet"].Value.ToString();
            mtxtTelefon.Text = dataGridView1.CurrentRow.Cells["telefon"].Value.ToString();
            txtKullaniciAdi.Text = dataGridView1.CurrentRow.Cells["kullaniciadi"].Value.ToString();
            txtSifre.Text = dataGridView1.CurrentRow.Cells["sifre"].Value.ToString();
        }

        private void dataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            mtxtTc2.Text = dataGridView2.CurrentRow.Cells["tcno"].Value.ToString();
            txtAdSoyad2.Text = dataGridView2.CurrentRow.Cells["adsoyad"].Value.ToString();
            txtYaş2.Text = dataGridView2.CurrentRow.Cells["yaş"].Value.ToString();
            cboxCinsiyet2.Text = dataGridView2.CurrentRow.Cells["cinsiyet"].Value.ToString();
            mtxtTelefon2.Text = dataGridView2.CurrentRow.Cells["telefon"].Value.ToString();
            txtKullaniciadi2.Text = dataGridView2.CurrentRow.Cells["kullaniciadi"].Value.ToString();
            txtSifre2.Text = dataGridView2.CurrentRow.Cells["sifre"].Value.ToString();
        }

        private void btnKaydet2_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Yoneticiİslem(tcno,adsoyad,yaş,cinsiyet,telefon,kullaniciadi,sifre) values(@tcno,@adsoyad,@yaş,@cinsiyet,@telefon,@kullaniciadi,@sifre)", baglanti);
            komut.Parameters.AddWithValue("@tcno", mtxtTc2.Text);
            komut.Parameters.AddWithValue("@adsoyad", txtAdSoyad2.Text);
            komut.Parameters.AddWithValue("@yaş", txtYaş2.Text);
            komut.Parameters.AddWithValue("@cinsiyet", cboxCinsiyet2.Text);
            komut.Parameters.AddWithValue("@telefon", mtxtTelefon2.Text);
            komut.Parameters.AddWithValue("@kullaniciadi", txtKullaniciadi2.Text);
            komut.Parameters.AddWithValue("@sifre", txtSifre2.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            uyelistele2();
            MessageBox.Show("Yeni Bir Yönetici Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtSil();
        }

        private void btnSil2_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut3 = new SqlCommand(" delete from Yoneticiİslem where tcno=@tcno", baglanti);
            komut3.Parameters.AddWithValue("@tcno", dataGridView2.CurrentRow.Cells["tcno"].Value.ToString());
            komut3.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Silme İşlemi Başarılı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            uyelistele2();
            txtSil();

        }

        private void btnGüncelleme2_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update Yoneticiİslem set adsoyad=@adsoyad,yaş=@yaş,cinsiyet=@cinsiyet,telefon=@telefon,kullaniciadi=@kullaniciadi,sifre=@sifre where tcno=@tcno", baglanti);
            komut.Parameters.AddWithValue("tcno", mtxtTc2.Text);
            komut.Parameters.AddWithValue("adsoyad", txtAdSoyad2.Text);
            komut.Parameters.AddWithValue("yaş", txtYaş2.Text);
            komut.Parameters.AddWithValue("cinsiyet", cboxCinsiyet2.Text);
            komut.Parameters.AddWithValue("telefon", mtxtTelefon2.Text);
            komut.Parameters.AddWithValue("kullaniciadi", txtKullaniciadi2.Text);
            komut.Parameters.AddWithValue("sifre", txtSifre2.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Yönetici Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            uyelistele2();
            txtSil();

        }

        private void FrmYonetici_Load(object sender, EventArgs e)
        {

            /*
                burada 'combo box' aracının 'sorted' özellliği kullanılmıştır  
            */
            //'sorted' özellliği; ogelerin sıralanıp sıralanmayacağını belirtir
            cboxCİnsiyet.Sorted = true;
            cboxCinsiyet2.Sorted = true;

            /*
                burada 'combo box' aracının 'Drop Down Style' özellliği kullanılmıştır 
            */
            //'Drop Down Style' özellliği; öğelerin nasıl göründüğünü ve işlevini belirler
            cboxCİnsiyet.DropDownStyle = ComboBoxStyle.DropDown;
            cboxCinsiyet2.DropDownStyle = ComboBoxStyle.DropDown;

            /*
                burada 'combo box' aracının 'Flat Style' özellliği kullanılmıştır
            */
            //'Flat Style' özellliği; combo box ın nasıl göründüğünü belirler
            cboxCİnsiyet.FlatStyle = FlatStyle.Standard;
            cboxCinsiyet2.FlatStyle = FlatStyle.System;

            /*
                burada 'combo box' aracının 'items' özellliği kullanılmıştır
            */
            //'items' özellliği; combo box da hangi kelimelerin hazır olarak verileceğini belirler
            cboxCİnsiyet.Items.Add("Erkek");
            cboxCİnsiyet.Items.Add("Kadın");
            cboxCinsiyet2.Items.Add("Erkek");
            cboxCinsiyet2.Items.Add("Kadın");

            /*
                burada 'masked text box' aracının 'mask' özellliği kullanılmıştır  
            */
            //'mask' özellliği; girilecek yazının hangi formatta yazılacağını gösterir

            mtxtTc.Mask = "000-000-00-000";
            mtxtTc2.Mask = "000-000-00-000";
            mtxtTelefon.Mask = "(999) 000 - 0000";
            mtxtTelefon2.Mask = "(999) 000 - 0000";

            /*
                burada "text box" aracının "Password Char" özelliği kullanılmıştır 
            */
            //"Password Char" özelliği; şifre girerken gösterilecek karakteri belirler

            txtSifre.PasswordChar = '*';
            txtSifre2.PasswordChar = '*';

            /*
                burada 'masked text box' aracının 'Text Mask Format' özellliği kullanılmıştır  
            */
            //Text Mask Format özelliği; text üzerinden döndürülen değerlerin 
            //sabit değerler ve istem karakteri içerip içermediğini gösterir 

            mtxtTc.TextMaskFormat =MaskFormat.IncludeLiterals;
            mtxtTc2.TextMaskFormat = MaskFormat.IncludeLiterals;
            mtxtTelefon.TextMaskFormat = MaskFormat.IncludeLiterals;
            mtxtTelefon2.TextMaskFormat = MaskFormat.IncludeLiterals;

            /*
                burada 'dataGridView' aracının 'grid color' özellliği kullanılmıştır   
            */
            //grid color özellliği; dataGridView aracının içindeki tablo çizgilerinin rengini belirler

            dataGridView1.GridColor = Color.DarkGreen;
            dataGridView2.GridColor = Color.DarkGreen;

            /*
                burada 'dataGridView' aracının 'Multi Select' özellliği kullanılmıştır   
            */
            //Multi Select özellliği; aynı anda birden fazla satır veya sutun seçmesini ayarlar

            dataGridView1.MultiSelect = true;
            dataGridView2.MultiSelect = true;

            /*
                burada 'dataGridView' aracının 'Selection Mode' özellliği kullanılmıştır               
            */
            //'Selection Mode' özellliği ; hücrelerin nasıl seçilebileceğini ayarlar

            dataGridView1.SelectionMode = DataGridViewSelectionMode.RowHeaderSelect;
            dataGridView2.SelectionMode = DataGridViewSelectionMode.RowHeaderSelect;

            /*
                burada 'dataGridView' aracının 'Border Style' özellliği kullanılmıştır               
            */
            //'Border Style' özellliği: kenarlık stilini belirler

            dataGridView1.BorderStyle = BorderStyle.Fixed3D;
            dataGridView2.BorderStyle = BorderStyle.Fixed3D;

            uyelistele();
            uyelistele2();
        }

        /*
              burada 'masked text box' aracının 'validating' olayı kullanılmıştır  
        */
        //'validating' olayı; denetim doğrularken gerçekleşir
        private void mtxtTc_Validating(object sender, CancelEventArgs e)
        {
            if (mtxtTc.Text.Length == 14)
                /*
                    burada 'error Provider' aracının 'SetError' özellliği kullanılmıştır
                */
                //'SetError' özellliği; hata ayarlarını düzenler
                errorProvider1.SetError(mtxtTc, "");
            else
            errorProvider1.SetError(mtxtTc, "TC Kimlik Numarası 11 Haneli Olmalıdır");
        }

        private void mtxtTc2_Validating(object sender, CancelEventArgs e)
        {
            if (mtxtTc2.Text.Length == 14)
                errorProvider1.SetError(mtxtTc2, "");
            else
                errorProvider1.SetError(mtxtTc2, "TC Kimlik Numarası 11 Haneli Olmalıdır");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            frmPersonel personel = new frmPersonel();
            personel.ShowDialog();
        }
    }
}
