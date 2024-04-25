using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Noppa_Heita
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int[] numerot = new int[5];
            for (int i = 0; i < 5; i++) 
            {
                int NopanNumero = random.Next(1, 7);
                numerot[i] = NopanNumero;
            }
            int[] noppa1 = numerot;
            txt_noppa1_luvut.Clear();
            Array.Sort(numerot);
            foreach (var numero in noppa1) { txt_noppa1_luvut.AppendText($"{numero} {Environment.NewLine}"); }

            int[] numerot2 = new int[5];
            for (int j = 0; j < 5; j++)
            {
                int NopanNumero2 = random.Next(1, 7);
                numerot2[j] = NopanNumero2;
            }
            int[] noppa2 = numerot2;
            txt_noppa2_luvut.Clear();
            Array.Sort(numerot2);
            foreach (var numero2 in noppa2) { txt_noppa2_luvut.AppendText($"{numero2} {Environment.NewLine}"); }
            txt_yhteensa.Clear();

            int noppien_numerot = 0;
            foreach (int numero1 in noppa1)
            {
                noppien_numerot += numero1;
            }
            foreach (int numero2 in noppa2)
            {
            noppien_numerot += numero2;
            }
            txt_yhteensa.AppendText($"{noppien_numerot}");
        }
    }
}
