using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace curefalanfilan
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

        static float ivme = 9.81F;
        static int aci = 0;
        static double cisimTepeUcusSüresi
        {
            get;set;
        }
        static double cisimMenzil
        {
            get;set;
        }
        static double cisimTepeMaksYükseklik
        {
            get;set;
        }

        public static void cisimAtis(double Vo, int cisimAci)
        {
            Form1 form = (Form1)Application.OpenForms["Form1"];
            //Sonuç için gereksinimler
            double cisimAciSin = Math.Abs(Math.Sin(Math.PI / 180 * cisimAci));
            double cisimAciCos = Math.Abs(Math.Cos(Math.PI / 180 * cisimAci));
            double cisimHizTepe = cisimAciCos * Vo;
            double cisimTepeCikisSuresi = cisimAciSin * Vo / ivme;
            //Sonuç için gereksinimler

            //Bilgilendirme
            //  Console.WriteLine(cisimAci + "'nın sinüsü: " + cisimAciSin);
            // Console.WriteLine(cisimAci + "'nın kosinüsü: " + cisimAciCos);
            //Bilgilendirme

            //  Console.Write("Cismin Uçuş Süresi: ");//Alınacak
             cisimTepeUcusSüresi = Math.Round(cisimTepeCikisSuresi * 2, 2);
            
           // form.label9.Visible = true;
            form.label8.Text = cisimTepeUcusSüresi + " saniye";

            // Console.WriteLine();

            // Console.Write("Cismin ulaşabileceği Maksimum Yüksekliği:  ");//Alınacak
             cisimTepeMaksYükseklik = Math.Round(0.5 * ivme * cisimTepeCikisSuresi * cisimTepeCikisSuresi, 2);
           // form.label5.Visible = true;
            form.label6.Text = cisimTepeMaksYükseklik + " metre";



            //Console.Write("Cismin Menzili: ");//Alınacak
             cisimMenzil = Math.Round(cisimHizTepe * cisimTepeUcusSüresi, 2);
           // form.label7.Visible = true;
            form.label7.Text = cisimMenzil + " metre";

        }

        public void panel1_Paint(object sender, PaintEventArgs e)
        {
            int trackbarCarpani = trackBarGrafikCarpani.Value;
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            PointF[] points = {
            new PointF(20, 525),//10,515
            new PointF(trackbarCarpani*Convert.ToSingle((cisimMenzil)/2)+20, 525-trackbarCarpani*Convert.ToSingle(cisimTepeMaksYükseklik)),
            new PointF(trackbarCarpani*Convert.ToSingle(cisimMenzil)+20, 525)};
            PointF[] points2 = { 
                new PointF(trackbarCarpani*Convert.ToSingle(cisimMenzil)/2,528-trackbarCarpani*Convert.ToSingle(cisimTepeMaksYükseklik)),
                };
            Pen pen = new Pen(Color.Green,4);
            pen.StartCap = System.Drawing.Drawing2D.LineCap.RoundAnchor;
            pen.EndCap = System.Drawing.Drawing2D.LineCap.ArrowAnchor;
            e.Graphics.DrawCurve(pen, points);

            Pen pen2 = new Pen(Color.Green, 1);
            pen2.EndCap = System.Drawing.Drawing2D.LineCap.ArrowAnchor;
            e.Graphics.DrawLine(pen2, 0, 540, 1060, 540);

            Pen pen3 = new Pen(Color.Green, 3);
            pen3.StartCap = System.Drawing.Drawing2D.LineCap.ArrowAnchor;
            pen3.EndCap = System.Drawing.Drawing2D.LineCap.ArrowAnchor;
            e.Graphics.DrawLine(pen3, 15, 575, trackbarCarpani * Convert.ToSingle(cisimMenzil)+15, 575);

            Pen pen4 = new Pen(Color.Green, 3);
            pen4.StartCap = System.Drawing.Drawing2D.LineCap.ArrowAnchor;
            pen4.EndCap = System.Drawing.Drawing2D.LineCap.ArrowAnchor;
            e.Graphics.DrawLine(pen4, 5, 535, 5, 525 - trackbarCarpani * Convert.ToSingle(cisimTepeMaksYükseklik));

            label10.Location = new Point(trackbarCarpani * Convert.ToInt32( cisimMenzil / 2), 565);
            label10.Text = Convert.ToString(cisimMenzil)+" Metre";

            label11.Location = new Point(3, 525- trackbarCarpani * Convert.ToInt32(cisimTepeMaksYükseklik/2));
            label11.Text = Convert.ToString(cisimTepeMaksYükseklik) + " Metre";
        }

        public void buttonOlc_Click(object sender, EventArgs e)
        {
            aci = int.Parse(maskedTextBoxAci.Text);
            double Vo = double.Parse(textBoxHiz.Text);
            if (aci > 90 || aci < 0)
            {
                labelError.Visible = true;
                labelError.Text = "Girdiğiniz açı 90 ile 0 arasında olmalıdır.";
                // label5.Visible = false;
                //label7.Visible = false;
                //label9.Visible = false;
                trackBarGrafikCarpani.Visible = false;
                label9.Visible = false;
                label10.Visible = false;
            }
            else if (aci <= 90 || aci >= 0)
            {
                labelError.Visible = false;
               // label5.Visible = true;
                //label7.Visible = true;
                //label9.Visible = true;
                cisimAtis(Vo, aci);
                panel1.Refresh();
                trackBarGrafikCarpani.Visible = true;
                label9.Visible = true;
                label10.Visible = true;
                label11.Visible = true;
            }

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }


    }
}
