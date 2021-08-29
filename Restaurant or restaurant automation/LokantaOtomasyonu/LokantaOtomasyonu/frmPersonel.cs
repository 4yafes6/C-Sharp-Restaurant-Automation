using GirisProgrami;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LokantaOtomasyonu
{
    public partial class frmPersonel : Form
    {
        public frmPersonel()
        {
            InitializeComponent();
        }

        private void frmPersonel_Load(object sender, EventArgs e)
        {

            /*
                burada "group Box" aracının "Text" özelliği kullanılmıştır.
            */
            //"Text" özelliği ; group box üzerinde görünecek yazıyı yazmamızı sağlar
            groupBox1.Text = "Masalar;";
            groupBox2.Text = "Menü";

            ToolTip tt1 = new ToolTip();
            /*
                burada "Tool tip" aracının "tool tip title","tool tip ıcon","is ballon " 
                        ve "set tool tip" özellikleri kullanılmıştır.
            */
            //tool tip title özelliği; bilgi kutucuğunun(tool tip) başlığını verir
            //tool tip ıcon özelliği; bilgi kutucuğunun iconunu belirler
            //is ballon özelliği; bilgi kutucuğunun balon içinde olup olmayacağını belirler
            //set tool tip özelliği; bilgi kutucuğunun hangi nesnede hangi yazıyı yazacağını gösterir
            tt1.ToolTipTitle = "Bilgi";
            tt1.ToolTipIcon = ToolTipIcon.Info;
            tt1.IsBalloon = true;
            tt1.SetToolTip(pictureBox1, "Lütfen Önce Yemek Seçiniz");
            tt1.SetToolTip(pictureBox2, "Lütfen Önce Yemek Seçiniz");
            tt1.SetToolTip(pictureBox3, "Lütfen Önce Yemek Seçiniz");
            tt1.SetToolTip(pictureBox4, "Lütfen Önce Yemek Seçiniz");
            tt1.SetToolTip(pictureBox5, "Lütfen Önce Yemek Seçiniz");

            /*
                burada "picture box" aracının "size mode " özelliği kullanılmıştır.
            */
            //"size mode " özelliği ; resimin kutucukda nasıl yerleşeceğini belirler
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;

            /*
                burada "picture box" aracının "image" özelliği kullanılmıştır.
            */
            //"image" özelliği ; resmin alınacağı dosyanın konumunu belirler
            /*pictureBox2.Image = Image.FromFile(@"C:\Users\Yusuf\Desktop\lokanta ikonları\masa.jpg");
            pictureBox3.Image = Image.FromFile(@"C:\Users\Yusuf\Desktop\lokanta ikonları\masa.jpg");
            pictureBox4.Image = Image.FromFile(@"C:\Users\Yusuf\Desktop\lokanta ikonları\masa.jpg");
            pictureBox5.Image = Image.FromFile(@"C:\Users\Yusuf\Desktop\lokanta ikonları\masa.jpg");*/

            //sonradan burası yorum satırı haline getirilmiştir

            /*
                burada "checked List Box" aracının "sorted" özelliği kullanılmıştır
            */
            //"sorted" özelliği ; nesnelerin sıralanıp sıralanmayacağını belirler
            checkedListBox1.Sorted = true;
            checkedListBox2.Sorted = true;
            checkedListBox3.Sorted = true;
            checkedListBox4.Sorted = true;
            checkedListBox5.Sorted = true;
            checkedListBox6.Sorted = true;

            /*
                burada "label" aracının "text" özelliği kullanılmıştır
            */
            //"text" özelliği; hangi yazı ile görüneceğini belirler
            label7.Text = "Çorbalar";

            /*
                burada "menü strip" aracının "text" özelliği kullanılmıştır
            */
            //"text" özelliği; hangi yazı ile görüneceğini belirler
            menuStrip1.Text = "Dosya";

            /*
                burada "timer" aracının "interval" özelliği kullanılmıştır
            */
            //"interval" özelliği ; sayacın ilerleme sıklığını milisaniye cinsinden ayarlar
            timer1.Interval = 1000;
            timer2.Interval = 1000;
            timer3.Interval = 1000;
            timer4.Interval = 1000;
            timer5.Interval = 1000;

            /*
                burada "list box" aracının "back color" özelliği kullanılmıştır
            */
            //"back color" özelliği ; arka plan rengini ayarlar
            listBox1.BackColor = Color.SkyBlue;
            listBox2.BackColor = Color.SkyBlue;
            listBox3.BackColor = Color.SkyBlue;
            listBox4.BackColor = Color.SkyBlue;
            listBox5.BackColor = Color.SkyBlue;

            /*
                burada "check box" aracının "text" ve "checked" özelliği kullanılmıştır
            */
            //"text" özelliği; hangi yazı ile görüneceğini belirler
            //"checked" özelliği ; seçili veya seçilmeden başlamasını sağlar
            checkBox1.Text = "Hesabı Öde";
            checkBox1.Checked = false;
            checkBox2.Text = "Hesabı Öde";
            checkBox2.Checked = false;
            checkBox3.Text = "Hesabı Öde";
            checkBox3.Checked = false;
            checkBox4.Text = "Hesabı Öde";
            checkBox4.Checked = false;
            checkBox5.Text = "Hesabı Öde";
            checkBox5.Checked = false;
        }

        /*
            burada "picture box" aracının "click" olayı kullanılmıştır
        */
        //"click" olayı ; tıklandığı zaman işlem yapar
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            toolTip1.Tag = "Lütfen Yemek Seçtikden Sonra Masaya Tıklayınız";

            //yemek fiyatları

            //çorbalar
            if (checkedListBox5.GetItemCheckState(0) == CheckState.Checked)
            {
                numericUpDown1.Value += 5;
            }
            if (checkedListBox5.GetItemCheckState(1) == CheckState.Checked)
            {
                numericUpDown1.Value += 5;
            }
            if (checkedListBox5.GetItemCheckState(2) == CheckState.Checked)
            {
                numericUpDown1.Value += 6;
            }
            if (checkedListBox5.GetItemCheckState(3) == CheckState.Checked)
            {
                numericUpDown1.Value += 5;
            }
            //pilavlar
            if (checkedListBox6.GetItemCheckState(0) == CheckState.Checked)
            {
                numericUpDown1.Value += 7;
            }
            if (checkedListBox6.GetItemCheckState(1) == CheckState.Checked)
            {
                numericUpDown1.Value += 8;
            }
            if (checkedListBox6.GetItemCheckState(2) == CheckState.Checked)
            {
                numericUpDown1.Value += 7;
            }
            if (checkedListBox6.GetItemCheckState(3) == CheckState.Checked)
            {
                numericUpDown1.Value += 9;
            }
            //ana yemekler
            if (checkedListBox2.GetItemCheckState(0) == CheckState.Checked)
            {
                numericUpDown1.Value += 8;
            }
            if (checkedListBox2.GetItemCheckState(1) == CheckState.Checked)
            {
                numericUpDown1.Value += 15;
            }
            if (checkedListBox2.GetItemCheckState(2) == CheckState.Checked)
            {
                numericUpDown1.Value += 6;
            }
            if (checkedListBox2.GetItemCheckState(3) == CheckState.Checked)
            {
                numericUpDown1.Value += 10;
            }
            //tatlılar
            if (checkedListBox4.GetItemCheckState(0) == CheckState.Checked)
            {
                numericUpDown1.Value += 4;
            }
            if (checkedListBox4.GetItemCheckState(1) == CheckState.Checked)
            {
                numericUpDown1.Value += 2;
            }
            if (checkedListBox4.GetItemCheckState(2) == CheckState.Checked)
            {
                numericUpDown1.Value += 3;
            }
            if (checkedListBox4.GetItemCheckState(3) == CheckState.Checked)
            {
                numericUpDown1.Value += 3;
            }
            //içecekler
            if (checkedListBox3.GetItemCheckState(0) == CheckState.Checked)
            {
                numericUpDown1.Value += 2;
            }
            if (checkedListBox3.GetItemCheckState(1) == CheckState.Checked)
            {
                numericUpDown1.Value += 2;
            }
            if (checkedListBox3.GetItemCheckState(2) == CheckState.Checked)
            {
                numericUpDown1.Value += 1;
            }
            if (checkedListBox3.GetItemCheckState(3) == CheckState.Checked)
            {
                numericUpDown1.Value += 1;
            }
            //özel menüler
            if (checkedListBox1.GetItemCheckState(0) == CheckState.Checked)
            {
                numericUpDown1.Value += 9;
            }
            if (checkedListBox1.GetItemCheckState(1) == CheckState.Checked)
            {
                numericUpDown1.Value += 16;
            }
            if (checkedListBox1.GetItemCheckState(2) == CheckState.Checked)
            {
                numericUpDown1.Value += 10;
            }
            if (checkedListBox1.GetItemCheckState(3) == CheckState.Checked)
            {
                numericUpDown1.Value += 14;
            }

            //checked list box dan list box a veri çekme
            foreach (string item in checkedListBox1.CheckedItems)
            {
                listBox1.Items.Add(item);
            }
            //işaretlenen veriyi geri silme 
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                checkedListBox1.SetItemChecked(i, false);
            }

            foreach (string item in checkedListBox2.CheckedItems)
            {
                listBox1.Items.Add(item);
            }
            for (int i = 0; i < checkedListBox2.Items.Count; i++)
            {
                checkedListBox2.SetItemChecked(i, false);
            }

            foreach (string item in checkedListBox3.CheckedItems)
            {
                listBox1.Items.Add(item);
            }
            for (int i = 0; i < checkedListBox3.Items.Count; i++)
            {
                checkedListBox3.SetItemChecked(i, false);
            }

            foreach (string item in checkedListBox4.CheckedItems)
            {
                listBox1.Items.Add(item);
            }
            for (int i = 0; i < checkedListBox4.Items.Count; i++)
            {
                checkedListBox4.SetItemChecked(i, false);
            }

            foreach (string item in checkedListBox5.CheckedItems)
            {
                listBox1.Items.Add(item);
            }
            for (int i = 0; i < checkedListBox5.Items.Count; i++)
            {
                checkedListBox5.SetItemChecked(i, false);
            }
            foreach (string item in checkedListBox6.CheckedItems)
            {
                listBox1.Items.Add(item);
            }
            for (int i = 0; i < checkedListBox6.Items.Count; i++)
            {
                checkedListBox6.SetItemChecked(i, false);
            }

            timer1.Start();

            /*
                burada "progres bar" aracının "Minimum","Maximum","Step" ve "value" özellikleri kullanılmıştır
            */
            progressBar1.Maximum = 100;
            progressBar1.Minimum = 0;
            progressBar1.Step = 1;
            if (progressBar1.Value != 100)
            {
                progressBar1.Value = progressBar1.Value + 100;
            }

            /*
                burada "check box" aracının "checked" özelliği kullanılmıştır
            */
            checkBox1.Checked = false;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

            //çorbalar
            if (checkedListBox5.GetItemCheckState(0) == CheckState.Checked)
            {
                numericUpDown2.Value += 5;
            }
            if (checkedListBox5.GetItemCheckState(1) == CheckState.Checked)
            {
                numericUpDown2.Value += 4;
            }
            if (checkedListBox5.GetItemCheckState(2) == CheckState.Checked)
            {
                numericUpDown2.Value += 6;
            }
            if (checkedListBox5.GetItemCheckState(3) == CheckState.Checked)
            {
                numericUpDown2.Value += 5;
            }
            //pilavlar
            if (checkedListBox6.GetItemCheckState(0) == CheckState.Checked)
            {
                numericUpDown2.Value += 7;
            }
            if (checkedListBox6.GetItemCheckState(1) == CheckState.Checked)
            {
                numericUpDown2.Value += 8;
            }
            if (checkedListBox6.GetItemCheckState(2) == CheckState.Checked)
            {
                numericUpDown2.Value += 7;
            }
            if (checkedListBox6.GetItemCheckState(3) == CheckState.Checked)
            {
                numericUpDown2.Value += 9;
            }
            //ana yemekler
            if (checkedListBox2.GetItemCheckState(0) == CheckState.Checked)
            {
                numericUpDown2.Value += 8;
            }
            if (checkedListBox2.GetItemCheckState(1) == CheckState.Checked)
            {
                numericUpDown2.Value += 15;
            }
            if (checkedListBox2.GetItemCheckState(2) == CheckState.Checked)
            {
                numericUpDown2.Value += 6;
            }
            if (checkedListBox2.GetItemCheckState(3) == CheckState.Checked)
            {
                numericUpDown2.Value += 10;
            }
            //tatlılar
            if (checkedListBox4.GetItemCheckState(0) == CheckState.Checked)
            {
                numericUpDown2.Value += 4;
            }
            if (checkedListBox4.GetItemCheckState(1) == CheckState.Checked)
            {
                numericUpDown2.Value += 2;
            }
            if (checkedListBox4.GetItemCheckState(2) == CheckState.Checked)
            {
                numericUpDown2.Value += 3;
            }
            if (checkedListBox4.GetItemCheckState(3) == CheckState.Checked)
            {
                numericUpDown2.Value += 3;
            }
            //içecekler
            if (checkedListBox3.GetItemCheckState(0) == CheckState.Checked)
            {
                numericUpDown2.Value += 2;
            }
            if (checkedListBox3.GetItemCheckState(1) == CheckState.Checked)
            {
                numericUpDown2.Value += 2;
            }
            if (checkedListBox3.GetItemCheckState(2) == CheckState.Checked)
            {
                numericUpDown2.Value += 1;
            }
            if (checkedListBox3.GetItemCheckState(3) == CheckState.Checked)
            {
                numericUpDown2.Value += 1;
            }
            //özel menüler
            if (checkedListBox1.GetItemCheckState(0) == CheckState.Checked)
            {
                numericUpDown2.Value += 9;
            }
            if (checkedListBox1.GetItemCheckState(1) == CheckState.Checked)
            {
                numericUpDown2.Value += 16;
            }
            if (checkedListBox1.GetItemCheckState(2) == CheckState.Checked)
            {
                numericUpDown2.Value += 10;
            }
            if (checkedListBox1.GetItemCheckState(3) == CheckState.Checked)
            {
                numericUpDown2.Value += 14;
            }

            foreach (string item in checkedListBox1.CheckedItems)
            {
                listBox2.Items.Add(item);
            }
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                checkedListBox1.SetItemChecked(i, false);
            }

            foreach (string item in checkedListBox2.CheckedItems)
            {
                listBox2.Items.Add(item);
            }
            for (int i = 0; i < checkedListBox2.Items.Count; i++)
            {
                checkedListBox2.SetItemChecked(i, false);
            }

            foreach (string item in checkedListBox3.CheckedItems)
            {
                listBox2.Items.Add(item);
            }
            for (int i = 0; i < checkedListBox3.Items.Count; i++)
            {
                checkedListBox3.SetItemChecked(i, false);
            }

            foreach (string item in checkedListBox4.CheckedItems)
            {
                listBox2.Items.Add(item);
            }
            for (int i = 0; i < checkedListBox4.Items.Count; i++)
            {
                checkedListBox4.SetItemChecked(i, false);
            }

            foreach (string item in checkedListBox5.CheckedItems)
            {
                listBox2.Items.Add(item);
            }
            for (int i = 0; i < checkedListBox5.Items.Count; i++)
            {
                checkedListBox5.SetItemChecked(i, false);
            }
            foreach (string item in checkedListBox6.CheckedItems)
            {
                listBox2.Items.Add(item);
            }
            for (int i = 0; i < checkedListBox6.Items.Count; i++)
            {
                checkedListBox6.SetItemChecked(i, false);
            }

            timer2.Start();

            if (progressBar2.Value != 100)
            {
                progressBar2.Value = progressBar2.Value + 100;
            }

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            //çorbalar
            if (checkedListBox5.GetItemCheckState(0) == CheckState.Checked)
            {
                numericUpDown3.Value += 5;
            }
            if (checkedListBox5.GetItemCheckState(1) == CheckState.Checked)
            {
                numericUpDown3.Value += 4;
            }
            if (checkedListBox5.GetItemCheckState(2) == CheckState.Checked)
            {
                numericUpDown3.Value += 6;
            }
            if (checkedListBox5.GetItemCheckState(3) == CheckState.Checked)
            {
                numericUpDown3.Value += 5;
            }
            //pilavlar
            if (checkedListBox6.GetItemCheckState(0) == CheckState.Checked)
            {
                numericUpDown3.Value += 7;
            }
            if (checkedListBox6.GetItemCheckState(1) == CheckState.Checked)
            {
                numericUpDown3.Value += 8;
            }
            if (checkedListBox6.GetItemCheckState(2) == CheckState.Checked)
            {
                numericUpDown3.Value += 7;
            }
            if (checkedListBox6.GetItemCheckState(3) == CheckState.Checked)
            {
                numericUpDown3.Value += 9;
            }
            //ana yemekler
            if (checkedListBox2.GetItemCheckState(0) == CheckState.Checked)
            {
                numericUpDown3.Value += 8;
            }
            if (checkedListBox2.GetItemCheckState(1) == CheckState.Checked)
            {
                numericUpDown3.Value += 15;
            }
            if (checkedListBox2.GetItemCheckState(2) == CheckState.Checked)
            {
                numericUpDown3.Value += 6;
            }
            if (checkedListBox2.GetItemCheckState(3) == CheckState.Checked)
            {
                numericUpDown3.Value += 10;
            }
            //tatlılar
            if (checkedListBox4.GetItemCheckState(0) == CheckState.Checked)
            {
                numericUpDown3.Value += 4;
            }
            if (checkedListBox4.GetItemCheckState(1) == CheckState.Checked)
            {
                numericUpDown3.Value += 2;
            }
            if (checkedListBox4.GetItemCheckState(2) == CheckState.Checked)
            {
                numericUpDown3.Value += 3;
            }
            if (checkedListBox4.GetItemCheckState(3) == CheckState.Checked)
            {
                numericUpDown3.Value += 3;
            }
            //içecekler
            if (checkedListBox3.GetItemCheckState(0) == CheckState.Checked)
            {
                numericUpDown3.Value += 2;
            }
            if (checkedListBox3.GetItemCheckState(1) == CheckState.Checked)
            {
                numericUpDown3.Value += 2;
            }
            if (checkedListBox3.GetItemCheckState(2) == CheckState.Checked)
            {
                numericUpDown3.Value += 1;
            }
            if (checkedListBox3.GetItemCheckState(3) == CheckState.Checked)
            {
                numericUpDown3.Value += 1;
            }
            //özel menüler
            if (checkedListBox1.GetItemCheckState(0) == CheckState.Checked)
            {
                numericUpDown3.Value += 9;
            }
            if (checkedListBox1.GetItemCheckState(1) == CheckState.Checked)
            {
                numericUpDown3.Value += 16;
            }
            if (checkedListBox1.GetItemCheckState(2) == CheckState.Checked)
            {
                numericUpDown3.Value += 10;
            }
            if (checkedListBox1.GetItemCheckState(3) == CheckState.Checked)
            {
                numericUpDown3.Value += 14;
            }

            foreach (string item in checkedListBox1.CheckedItems)
            {
                listBox3.Items.Add(item);
            }
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                checkedListBox1.SetItemChecked(i, false);
            }

            foreach (string item in checkedListBox2.CheckedItems)
            {
                listBox3.Items.Add(item);
            }
            for (int i = 0; i < checkedListBox2.Items.Count; i++)
            {
                checkedListBox2.SetItemChecked(i, false);
            }

            foreach (string item in checkedListBox3.CheckedItems)
            {
                listBox3.Items.Add(item);
            }
            for (int i = 0; i < checkedListBox3.Items.Count; i++)
            {
                checkedListBox3.SetItemChecked(i, false);
            }

            foreach (string item in checkedListBox4.CheckedItems)
            {
                listBox3.Items.Add(item);
            }
            for (int i = 0; i < checkedListBox4.Items.Count; i++)
            {
                checkedListBox4.SetItemChecked(i, false);
            }

            foreach (string item in checkedListBox5.CheckedItems)
            {
                listBox3.Items.Add(item);
            }
            for (int i = 0; i < checkedListBox5.Items.Count; i++)
            {
                checkedListBox5.SetItemChecked(i, false);
            }
            foreach (string item in checkedListBox6.CheckedItems)
            {
                listBox3.Items.Add(item);
            }
            for (int i = 0; i < checkedListBox6.Items.Count; i++)
            {
                checkedListBox6.SetItemChecked(i, false);
            }

            timer3.Start();

            if (progressBar3.Value != 100)
            {
                progressBar3.Value = progressBar3.Value + 100;
            }

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            //çorbalar
            if (checkedListBox5.GetItemCheckState(0) == CheckState.Checked)
            {
                numericUpDown4.Value += 5;
            }
            if (checkedListBox5.GetItemCheckState(1) == CheckState.Checked)
            {
                numericUpDown4.Value += 4;
            }
            if (checkedListBox5.GetItemCheckState(2) == CheckState.Checked)
            {
                numericUpDown4.Value += 6;
            }
            if (checkedListBox5.GetItemCheckState(3) == CheckState.Checked)
            {
                numericUpDown4.Value += 5;
            }
            //pilavlar
            if (checkedListBox6.GetItemCheckState(0) == CheckState.Checked)
            {
                numericUpDown4.Value += 7;
            }
            if (checkedListBox6.GetItemCheckState(1) == CheckState.Checked)
            {
                numericUpDown4.Value += 8;
            }
            if (checkedListBox6.GetItemCheckState(2) == CheckState.Checked)
            {
                numericUpDown4.Value += 7;
            }
            if (checkedListBox6.GetItemCheckState(3) == CheckState.Checked)
            {
                numericUpDown4.Value += 9;
            }
            //ana yemekler
            if (checkedListBox2.GetItemCheckState(0) == CheckState.Checked)
            {
                numericUpDown4.Value += 8;
            }
            if (checkedListBox2.GetItemCheckState(1) == CheckState.Checked)
            {
                numericUpDown4.Value += 15;
            }
            if (checkedListBox2.GetItemCheckState(2) == CheckState.Checked)
            {
                numericUpDown4.Value += 6;
            }
            if (checkedListBox2.GetItemCheckState(3) == CheckState.Checked)
            {
                numericUpDown4.Value += 10;
            }
            //tatlılar
            if (checkedListBox4.GetItemCheckState(0) == CheckState.Checked)
            {
                numericUpDown4.Value += 4;
            }
            if (checkedListBox4.GetItemCheckState(1) == CheckState.Checked)
            {
                numericUpDown4.Value += 2;
            }
            if (checkedListBox4.GetItemCheckState(2) == CheckState.Checked)
            {
                numericUpDown4.Value += 3;
            }
            if (checkedListBox4.GetItemCheckState(3) == CheckState.Checked)
            {
                numericUpDown4.Value += 3;
            }
            //içecekler
            if (checkedListBox3.GetItemCheckState(0) == CheckState.Checked)
            {
                numericUpDown4.Value += 2;
            }
            if (checkedListBox3.GetItemCheckState(1) == CheckState.Checked)
            {
                numericUpDown4.Value += 2;
            }
            if (checkedListBox3.GetItemCheckState(2) == CheckState.Checked)
            {
                numericUpDown4.Value += 1;
            }
            if (checkedListBox3.GetItemCheckState(3) == CheckState.Checked)
            {
                numericUpDown4.Value += 1;
            }
            //özel menüler
            if (checkedListBox1.GetItemCheckState(0) == CheckState.Checked)
            {
                numericUpDown4.Value += 9;
            }
            if (checkedListBox1.GetItemCheckState(1) == CheckState.Checked)
            {
                numericUpDown4.Value += 16;
            }
            if (checkedListBox1.GetItemCheckState(2) == CheckState.Checked)
            {
                numericUpDown4.Value += 10;
            }
            if (checkedListBox1.GetItemCheckState(3) == CheckState.Checked)
            {
                numericUpDown4.Value += 14;
            }

            foreach (string item in checkedListBox1.CheckedItems)
            {
                listBox4.Items.Add(item);
            }
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                checkedListBox1.SetItemChecked(i, false);
            }

            foreach (string item in checkedListBox2.CheckedItems)
            {
                listBox4.Items.Add(item);
            }
            for (int i = 0; i < checkedListBox2.Items.Count; i++)
            {
                checkedListBox2.SetItemChecked(i, false);
            }

            foreach (string item in checkedListBox3.CheckedItems)
            {
                listBox4.Items.Add(item);
            }
            for (int i = 0; i < checkedListBox3.Items.Count; i++)
            {
                checkedListBox3.SetItemChecked(i, false);
            }

            foreach (string item in checkedListBox4.CheckedItems)
            {
                listBox4.Items.Add(item);
            }
            for (int i = 0; i < checkedListBox4.Items.Count; i++)
            {
                checkedListBox4.SetItemChecked(i, false);
            }

            foreach (string item in checkedListBox5.CheckedItems)
            {
                listBox4.Items.Add(item);
            }
            for (int i = 0; i < checkedListBox5.Items.Count; i++)
            {
                checkedListBox5.SetItemChecked(i, false);
            }
            foreach (string item in checkedListBox6.CheckedItems)
            {
                listBox4.Items.Add(item);
            }
            for (int i = 0; i < checkedListBox6.Items.Count; i++)
            {
                checkedListBox6.SetItemChecked(i, false);
            }

            timer4.Start();

            if (progressBar4.Value != 100)
            {
                progressBar4.Value = progressBar4.Value + 100;
            }

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {


            //çorbalar
            if (checkedListBox5.GetItemCheckState(0) == CheckState.Checked)
            {
                numericUpDown5.Value += 5;
            }
            if (checkedListBox5.GetItemCheckState(1) == CheckState.Checked)
            {
                numericUpDown5.Value += 4;
            }
            if (checkedListBox5.GetItemCheckState(2) == CheckState.Checked)
            {
                numericUpDown5.Value += 6;
            }
            if (checkedListBox5.GetItemCheckState(3) == CheckState.Checked)
            {
                numericUpDown5.Value += 5;
            }
            //pilavlar
            if (checkedListBox6.GetItemCheckState(0) == CheckState.Checked)
            {
                numericUpDown5.Value += 7;
            }
            if (checkedListBox6.GetItemCheckState(1) == CheckState.Checked)
            {
                numericUpDown5.Value += 8;
            }
            if (checkedListBox6.GetItemCheckState(2) == CheckState.Checked)
            {
                numericUpDown5.Value += 7;
            }
            if (checkedListBox6.GetItemCheckState(3) == CheckState.Checked)
            {
                numericUpDown5.Value += 9;
            }
            //ana yemekler
            if (checkedListBox2.GetItemCheckState(0) == CheckState.Checked)
            {
                numericUpDown5.Value += 8;
            }
            if (checkedListBox2.GetItemCheckState(1) == CheckState.Checked)
            {
                numericUpDown5.Value += 15;
            }
            if (checkedListBox2.GetItemCheckState(2) == CheckState.Checked)
            {
                numericUpDown5.Value += 6;
            }
            if (checkedListBox2.GetItemCheckState(3) == CheckState.Checked)
            {
                numericUpDown5.Value += 10;
            }
            //tatlılar
            if (checkedListBox4.GetItemCheckState(0) == CheckState.Checked)
            {
                numericUpDown5.Value += 4;
            }
            if (checkedListBox4.GetItemCheckState(1) == CheckState.Checked)
            {
                numericUpDown5.Value += 2;
            }
            if (checkedListBox4.GetItemCheckState(2) == CheckState.Checked)
            {
                numericUpDown5.Value += 3;
            }
            if (checkedListBox4.GetItemCheckState(3) == CheckState.Checked)
            {
                numericUpDown5.Value += 3;
            }
            //içecekler
            if (checkedListBox3.GetItemCheckState(0) == CheckState.Checked)
            {
                numericUpDown5.Value += 2;
            }
            if (checkedListBox3.GetItemCheckState(1) == CheckState.Checked)
            {
                numericUpDown5.Value += 2;
            }
            if (checkedListBox3.GetItemCheckState(2) == CheckState.Checked)
            {
                numericUpDown5.Value += 1;
            }
            if (checkedListBox3.GetItemCheckState(3) == CheckState.Checked)
            {
                numericUpDown5.Value += 1;
            }
            //özel menüler
            if (checkedListBox1.GetItemCheckState(0) == CheckState.Checked)
            {
                numericUpDown5.Value += 9;
            }
            if (checkedListBox1.GetItemCheckState(1) == CheckState.Checked)
            {
                numericUpDown5.Value += 16;
            }
            if (checkedListBox1.GetItemCheckState(2) == CheckState.Checked)
            {
                numericUpDown5.Value += 10;
            }
            if (checkedListBox1.GetItemCheckState(3) == CheckState.Checked)
            {
                numericUpDown5.Value += 14;
            }

            foreach (string item in checkedListBox1.CheckedItems)
            {
                listBox5.Items.Add(item);
            }
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                checkedListBox1.SetItemChecked(i, false);
            }

            foreach (string item in checkedListBox2.CheckedItems)
            {
                listBox5.Items.Add(item);
            }
            for (int i = 0; i < checkedListBox2.Items.Count; i++)
            {
                checkedListBox2.SetItemChecked(i, false);
            }

            foreach (string item in checkedListBox3.CheckedItems)
            {
                listBox5.Items.Add(item);
            }
            for (int i = 0; i < checkedListBox3.Items.Count; i++)
            {
                checkedListBox3.SetItemChecked(i, false);
            }

            foreach (string item in checkedListBox4.CheckedItems)
            {
                listBox5.Items.Add(item);
            }
            for (int i = 0; i < checkedListBox4.Items.Count; i++)
            {
                checkedListBox4.SetItemChecked(i, false);
            }

            foreach (string item in checkedListBox5.CheckedItems)
            {
                listBox5.Items.Add(item);
            }
            for (int i = 0; i < checkedListBox5.Items.Count; i++)
            {
                checkedListBox5.SetItemChecked(i, false);
            }
            foreach (string item in checkedListBox6.CheckedItems)
            {
                listBox5.Items.Add(item);
            }
            for (int i = 0; i < checkedListBox6.Items.Count; i++)
            {
                checkedListBox6.SetItemChecked(i, false);
            }

            timer5.Start();

            if (progressBar5.Value != 100)
            {
                progressBar5.Value = progressBar5.Value + 100;
            }

        }


        /*
            burada "timer" aracının "tick" olayı kullanılmıştır
        */
        //"tick" olayı;timer da süre ilerledikce işlem yapar
        private void timer1_Tick(object sender, EventArgs e)
        {
            int sayi = Convert.ToInt32(label22.Text);
            sayi++;
            label22.Text = sayi.ToString();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            int sayi = Convert.ToInt32(label23.Text);
            sayi++;
            label23.Text = sayi.ToString();
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            int sayi = Convert.ToInt32(label24.Text);
            sayi++;
            label24.Text = sayi.ToString();
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            int sayi = Convert.ToInt32(label25.Text);
            sayi++;
            label25.Text = sayi.ToString();
        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            int sayi = Convert.ToInt32(label26.Text);
            sayi++;
            label26.Text = sayi.ToString();
        }

        /*
            burada "check box" aracının "checked changed" olayı kullanılmıştır
        */
        //"checked changed" olayı; check box seçildiği zaman yapılacak işlemi ayarlar
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            if (progressBar1.Value == 100)
            {
                progressBar1.Value = progressBar1.Value - 100;
            }
            timer1.Stop();
            label22.Text = "0";
            numericUpDown1.Value = 0;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            if (progressBar2.Value == 100)
            {
                progressBar2.Value = progressBar2.Value - 100;
            }
            timer2.Stop();
            label23.Text = "0";
            numericUpDown2.Value = 0;
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            listBox3.Items.Clear();
            if (progressBar3.Value == 100)
            {
                progressBar3.Value = progressBar3.Value - 100;
            }
            timer3.Stop();
            label24.Text = "0";
            numericUpDown3.Value = 0;
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            listBox4.Items.Clear();
            if (progressBar4.Value == 100)
            {
                progressBar4.Value = progressBar4.Value - 100;
            }
            timer4.Stop();
            label25.Text = "0";
            numericUpDown4.Value = 0;
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            listBox5.Items.Clear();
            if (progressBar5.Value == 100)
            {
                progressBar5.Value = progressBar5.Value - 100;
            }
            timer5.Stop();
            label26.Text = "0";
            numericUpDown5.Value = 0;
        }

        /*
            burada "menü stript" aracının "clik" olayı kullanılmıştır 
        */
        //"click" olayı ; tıklandığı zaman işlem yapar
        private void yöneticiKullanımınaGeçToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGiriş giriş = new frmGiriş();
            giriş.ShowDialog();

        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tümListeleriTemizleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            listBox4.Items.Clear();
            listBox5.Items.Clear();
        }

        private void tümSüreleriTemizleToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            label22.Text = "0";
            timer2.Stop();
            label23.Text = "0";
            timer3.Stop();
            label24.Text = "0";
            timer4.Stop();
            label25.Text = "0";
            timer5.Stop();
            label26.Text = "0";
        }

        private void tümFiyatlarıTemizleToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            numericUpDown1.Value = 0;
            numericUpDown2.Value = 0;
            numericUpDown3.Value = 0;
            numericUpDown4.Value = 0;
            numericUpDown5.Value = 0;
        }

        private void tümMasalarıTemizleToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            if (progressBar1.Value == 100)
            {
                progressBar1.Value = progressBar1.Value - 100;
            }
            timer1.Stop();
            label22.Text = "0";
            numericUpDown1.Value = 0;

            listBox2.Items.Clear();
            if (progressBar2.Value == 100)
            {
                progressBar2.Value = progressBar2.Value - 100;
            }
            timer2.Stop();
            label23.Text = "0";
            numericUpDown2.Value = 0;

            listBox3.Items.Clear();
            if (progressBar3.Value == 100)
            {
                progressBar3.Value = progressBar3.Value - 100;
            }
            timer3.Stop();
            label24.Text = "0";
            numericUpDown3.Value = 0;

            listBox4.Items.Clear();
            if (progressBar4.Value == 100)
            {
                progressBar4.Value = progressBar4.Value - 100;
            }
            timer4.Stop();
            label25.Text = "0";
            numericUpDown4.Value = 0;

            listBox5.Items.Clear();
            if (progressBar5.Value == 100)
            {
                progressBar5.Value = progressBar5.Value - 100;
            }
            timer5.Stop();
            label26.Text = "0";
            numericUpDown5.Value = 0;
        }

        private void yemekListesiniTemizleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void geçenSüreyiTemizleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            label22.Text = "0";
        }

        private void fiyatıTemizleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            numericUpDown1.Value = 0;
        }

        private void lİsteyiTemizleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
        }

        private void süreyiTemizleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer2.Stop();
            label23.Text = "0";
        }

        private void fiyatıTemizleToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            numericUpDown2.Value = 0;
        }

        private void listeyiTemizleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBox3.Items.Clear();
        }

        private void süreyiTemizleToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            timer3.Stop();
            label24.Text = "0";
        }

        private void fiyatıTemizleToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            numericUpDown3.Value = 0;
        }

        private void lİsteyiTemizleToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            listBox4.Items.Clear();
        }

        private void süreyiTemizleToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            timer4.Stop();
            label25.Text = "0";
        }

        private void fiyatıTemizleToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            numericUpDown4.Value = 0;
        }

        private void listeyiTemizleToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            listBox5.Items.Clear();
        }

        private void süreyiTemizleToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            timer5.Stop();
            label26.Text = "0";
        }

        private void fiyatıTemizleToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            numericUpDown5.Value = 0;

        }

        private void kullanımKılavuzuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Yardım yardım = new Yardım();
            yardım.ShowDialog();
        }
    }
}
