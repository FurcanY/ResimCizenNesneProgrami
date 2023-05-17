using System.Drawing;
using System.Media;

namespace ResimCizenNesneProgrami
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Nesne1.BackColor = Color.White;
        }
        int adimSayisi = 1;
        //adim sayisi bir butona basilgidinda kac adim gitmeli onu tutan degisken
        //(ayarlama butonundan alinan degerle degisir)
        bool gorunmezMi = false;
        //nesnenin gorunmez olup olmadigini tutan bool degiskeni
        int cizimBuyuklugu = 25;
        //daha sonra cizim buyuklugu degistirilmek istenirse buradan degistirmek kolay olsun diye degisken olusturulur.



        private void RenkAyarla_btn_Click(object sender, EventArgs e)
        {
            ColorDialog renkayarla = new ColorDialog();
            renkayarla.ShowDialog();
            renk_pnl.BackColor = renkayarla.Color;

        }

        private void yukari_btn_Click(object sender, EventArgs e)
        {
            //cizim alanini cikmamasi icin yapilan bir kontrol ifadesi.
            if (CizimArena_grbbx.Top < Nesne1.Top - (cizimBuyuklugu * adimSayisi))
            {
                Nesne1.Top -= (cizimBuyuklugu * adimSayisi);
            }

        }

        private void asagi_btn_Click(object sender, EventArgs e)
        {
            //cizim alanini cikmamasi icin yapilan bir kontrol ifadesi.
            if (CizimArena_grbbx.Bottom >= Nesne1.Bottom + (cizimBuyuklugu * adimSayisi))
            {
                Nesne1.Top += (cizimBuyuklugu * adimSayisi);
            }
        }

        private void sag_btn_Click(object sender, EventArgs e)
        {
            //cizim alanini cikmamasi icin yapilan bir kontrol ifadesi.
            if (CizimArena_grbbx.Right >= Nesne1.Right + (cizimBuyuklugu * adimSayisi))
            {
                Nesne1.Left += (cizimBuyuklugu * adimSayisi);
            }
        }

        private void sol_btn_Click(object sender, EventArgs e)
        {
            //cizim alanini cikmamasi icin yapilan bir kontrol ifadesi.
            if (CizimArena_grbbx.Left <= Nesne1.Left - (cizimBuyuklugu * adimSayisi))
            {
                Nesne1.Left -= (cizimBuyuklugu * adimSayisi);
            }
        }

        private void ayarla_btn_Click(object sender, EventArgs e)
        {
            adimSayisi = Convert.ToInt32(ayarla_txtbox.Text);
            //adim sayisini textboxdan alip degistirdim.
            //bu adim sayisi hareket etmede carpim olarak etki yapacak
            ayarla_txtbox.Text = adimSayisi.ToString();
            //daha sonra kac adim attigimizi unutmamak icin textbox textine yazdim.
        }

        public void ciz_btn_Click(object sender, EventArgs e)
        {
            Graphics grafik = CreateGraphics();
            //grafik olusturmak icin gerekli islem
            Pen kalem = new Pen(renk_pnl.BackColor, cizimBuyuklugu);
            grafik.DrawLine(kalem, Nesne1.Left, Nesne1.Top - 13, Nesne1.Right, Nesne1.Top - 13);

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gorunmez_btn_Click(object sender, EventArgs e)
        {
            if (gorunmezMi == true)
            {
                gorunmezMi = false;
                Nesne1.Visible = true;
            }
            else
            {
                gorunmezMi = true;
                Nesne1.Visible = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CizimArena_grbbx.Visible = true;
            CizimArena_grbbx.Visible = false;
        }
    }
}