using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fatih
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int bul(double[] dizi,double bulunacak)
        {
            for(int i=0;i<dizi.Length;i++)
            {
                if(bulunacak==dizi[i])
                {
                    return i;
                }
            }
            return 0;
        }
        private void btnhesapla_Click(object sender, EventArgs e)
        {
            double fark;
            double[] satir = new double[]{24,26,28,30,32,34,36,38,40,42,44,46,48,50,52,54,56};
            double[] sutun = new double[61];
            sutun[0] = 0;
            for(int i =1;i<61;i++)
            {
                sutun[i] = sutun[i - 1] + 0.5;
            }
            
            double[,] array2D = new double[18,17];
            array2D[4, 0] = 84; array2D[4, 1] = 84; array2D[4, 2] = 85; array2D[4, 3] = 86; array2D[4, 4] = 86; array2D[4, 5] = 87;
            array2D[4, 6] = 87; array2D[4, 7] = 88; array2D[4, 8] = 88; array2D[4, 9] = 89; array2D[4, 10] = 90; array2D[4, 11] = 90;
            array2D[4, 12] = 90; array2D[4, 13] = 90; array2D[4, 14] = 90; array2D[4, 15] = 90; array2D[4, 16] = 90;
            
            array2D[5, 0] = 80; array2D[5, 1] = 81; array2D[5, 2] = 82; array2D[5, 3] = 83; array2D[5, 4] = 83; array2D[5, 5] = 84;
            array2D[5, 6] = 85; array2D[5, 7] = 85; array2D[5, 8] = 85; array2D[5, 9] = 86; array2D[5, 10] = 87; array2D[5, 11] = 87;
            array2D[5, 12] = 87; array2D[5, 13] = 87; array2D[5, 14] = 87; array2D[5, 15] = 87; array2D[5, 16] = 87;

            array2D[6, 0] = 76; array2D[6, 1] = 77; array2D[6, 2] = 78; array2D[6, 3] = 79; array2D[6, 4] = 80; array2D[6, 5] = 81;
            array2D[6, 6] = 81; array2D[6, 7] = 82; array2D[6, 8] = 82; array2D[6, 9] = 83; array2D[6, 10] = 84; array2D[6, 11] = 84;
            array2D[6, 12] = 84; array2D[6, 13] = 84; array2D[6, 14] = 84; array2D[6, 15] = 84; array2D[6, 16] = 85;

            array2D[7, 0] = 72; array2D[7, 1] = 73; array2D[7, 2] = 74; array2D[7, 3] = 75; array2D[7, 4] = 76; array2D[7, 5] = 78;
            array2D[7, 6] = 79; array2D[7, 7] = 79; array2D[7, 8] = 79; array2D[7, 9] = 80; array2D[7, 10] = 81; array2D[7, 11] = 81;
            array2D[7, 12] = 81; array2D[7, 13] = 81; array2D[7, 14] = 82; array2D[7, 15] = 82; array2D[7, 16] = 83;

            array2D[8, 0] = 69; array2D[8, 1] = 70; array2D[8, 2] = 71; array2D[8, 3] = 72; array2D[8, 4] = 74; array2D[8, 5] = 75;
            array2D[8, 6] = 75; array2D[8, 7] = 76; array2D[8, 8] = 77; array2D[8, 9] = 78; array2D[8, 10] = 79; array2D[8, 11] = 79;
            array2D[8, 12] = 79; array2D[8, 13] = 79; array2D[8, 14] = 80; array2D[8, 15] = 80; array2D[8, 16] = 81;
            
            array2D[9, 0] = 65; array2D[9, 1] = 66; array2D[9, 2] = 67; array2D[9, 3] = 69; array2D[9, 4] = 71; array2D[9, 5] = 72;
            array2D[9, 6] = 72; array2D[9, 7] = 73; array2D[9, 8] = 74; array2D[9, 9] = 75; array2D[9, 10] = 76; array2D[9, 11] = 76;
            array2D[9, 12] = 76; array2D[9, 13] = 76; array2D[9, 14] = 77; array2D[9, 15] = 78; array2D[9, 16] = 79;

            array2D[10, 0] = 62; array2D[10, 1] = 64; array2D[10, 2] = 65; array2D[10, 3] = 66; array2D[10, 4] = 68; array2D[10, 5] = 69;
            array2D[10, 6] = 69; array2D[10, 7] = 70; array2D[10, 8] = 71; array2D[10, 9] = 72; array2D[10, 10] = 73; array2D[10, 11] = 74;
            array2D[10, 12] = 74; array2D[10, 13] = 74; array2D[10, 14] = 75; array2D[10, 15] = 76; array2D[10, 16] = 77;

            array2D[11, 0] = 59; array2D[11, 1] = 61; array2D[11, 2] = 62; array2D[11, 3] = 63; array2D[11, 4] = 64; array2D[11, 5] = 66;
            array2D[11, 6] = 66; array2D[11, 7] = 68; array2D[11, 8] = 70; array2D[11, 9] = 70; array2D[11, 10] = 71; array2D[11, 11] = 72;
            array2D[11, 12] = 72; array2D[11, 13] = 72; array2D[11, 14] = 73; array2D[11, 15] = 74; array2D[11, 16] = 75;

            array2D[12, 0] = 56; array2D[12, 1] = 58; array2D[12, 2] = 59; array2D[12, 3] = 61; array2D[12, 4] = 62; array2D[12, 5] = 63;
            array2D[12, 6] = 64; array2D[12, 7] = 65; array2D[12, 8] = 66; array2D[12, 9] = 68; array2D[12, 10] = 68; array2D[12, 11] = 70;
            array2D[12, 12] = 70; array2D[12, 13] = 70; array2D[12, 14] = 71; array2D[12, 15] = 72; array2D[12, 16] = 73;

            array2D[13, 0] = 52; array2D[13, 1] = 54; array2D[13, 2] = 56; array2D[13, 3] = 58; array2D[13, 4] = 60; array2D[13, 5] = 61;
            array2D[13, 6] = 62; array2D[13, 7] = 60; array2D[13, 8] = 64; array2D[13, 9] = 65; array2D[13, 10] = 66; array2D[13, 11] = 67;
            array2D[13, 12] = 68; array2D[13, 13] = 68; array2D[13, 14] = 69; array2D[13, 15] = 70; array2D[13, 16] = 70;

            array2D[14, 0] = 49; array2D[14, 1] = 51; array2D[14, 2] = 53; array2D[14, 3] = 55; array2D[14, 4] = 57; array2D[14, 5] = 58;
            array2D[14, 6] = 59; array2D[14, 7] = 60; array2D[14, 8] = 61; array2D[14, 9] = 62; array2D[14, 10] = 63; array2D[14, 11] = 64;
            array2D[14, 12] = 64; array2D[14, 13] = 66; array2D[14, 14] = 67; array2D[14, 15] = 68; array2D[14, 16] = 68;

            array2D[15, 0] = 46; array2D[15, 1] = 48; array2D[15, 2] = 51; array2D[15, 3] = 53; array2D[15, 4] = 55; array2D[15, 5] = 56;
            array2D[15, 6] = 57; array2D[15, 7] = 58; array2D[15, 8] = 59; array2D[15, 9] = 60; array2D[15, 10] = 61; array2D[15, 11] = 62;
            array2D[15, 12] = 62; array2D[15, 13] = 64; array2D[15, 14] = 65; array2D[15, 15] = 66; array2D[15, 16] = 66;
            
            array2D[16, 0] = 43; array2D[16, 1] = 45; array2D[16, 2] = 47; array2D[16, 3] = 50; array2D[16, 4] = 52; array2D[16, 5] = 53;
            array2D[16, 6] = 54; array2D[16, 7] = 55; array2D[16, 8] = 56; array2D[16, 9] = 58; array2D[16, 10] = 59; array2D[16, 11] = 60;
            array2D[16, 12] = 60; array2D[16, 13] = 62; array2D[16, 14] = 63; array2D[16, 15] = 64; array2D[16, 16] = 64;

            array2D[17, 0] = 40; array2D[17, 1] = 43; array2D[17, 2] = 43; array2D[17, 3] = 47; array2D[17, 4] = 49; array2D[17, 5] = 51;
            array2D[17, 6] = 52; array2D[17, 7] = 53; array2D[17, 8] = 54; array2D[17, 9] = 55; array2D[17, 10] = 56; array2D[17, 11] = 57;
            array2D[17, 12] = 58; array2D[17, 13] = 60; array2D[17, 14] = 61; array2D[17, 15] = 62; array2D[17, 16] = 62;

            try
            {
                fark = Convert.ToDouble(txt1.Text) - Convert.ToDouble(txt2.Text);
                int a = bul(sutun, fark);
                //txt3.Text = a.ToString();
                int b = bul(satir, Convert.ToDouble(txt1.Text));

                txt3.Text = "%"+ array2D[a,b].ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Hatalı Giriş Yaptınız. Lütfen Sayı girişi yapınız", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt1.Text = "";
                txt2.Text = "";
                txt3.Text = "";
                txt1.Focus();
            }
            

        }

        private void btntemizle_Click(object sender, EventArgs e)
        {
            txt1.Text = "";
            txt2.Text = "";
            txt3.Text = "";
            txt1.Focus();
        }
    }
}
