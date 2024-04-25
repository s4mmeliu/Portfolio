using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mäkipyppy3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /* Tyylipisteet määräytyvät ilmalennon, alastulon ja sitä seuraavan 
             * loppuliun kokonaisuutena. Arvostelijoina toimii viisi tuomaria, 
             * mutta hyppääjän tyylipisteisiin ei lasketa eniten ja vähiten 
             * pisteitä antaneiden tuomareiden pisteitä. Virheettömästä suorituksesta 
             * saa 20 pistettä kultakin tuomarilta, joten hyppääjän maksimityylipisteet
             * on 60. (pisteet annetaan 0,5 pisteen tarkkuudella)*/

            double kp = 0, pit = 0, pist = 0;
            kp = double.Parse(textKpiste.Text);
            pit = double.Parse(textPituus.Text);
            pist = 60 + (pit - kp) * 1.8;
            textPituuspisteet.Text = pist.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double min = 100, max = -100, sum = 0; // Tuomari voi antaa 20 p maksimissaan ja tuomareita on 5 kpl
            int sarake, pit;
            pit = dataGridView1.ColumnCount - 1;
            for (sarake = 0; sarake <= pit; sarake++)
            {
                sum = sum + (double.Parse(dataGridView1.Rows[0].Cells[sarake].Value.ToString()));


                if (double.Parse(dataGridView1.Rows[0].Cells[sarake].Value.ToString()) > max)
                {
                    // etsitään max-pistemäärä
                    max = double.Parse(dataGridView1.Rows[0].Cells[sarake].Value.ToString());
                }
                
                if (double.Parse(dataGridView1.Rows[0].Cells[sarake].Value.ToString()) < min)
                {
                    // etsitään min-pistemäärä
                    min = double.Parse(dataGridView1.Rows[0].Cells[sarake].Value.ToString());
                }
            }
            sum = sum - min - max; // hyppääjän pisteisiin ei lasketa eniten eikä vähiten antaneiden tuomareiden pisteitä.
            textTyylip.Text = sum.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            /* Tuulihyvitys/-vähennys laskenta: Kunkin hypyn aikana tuuli mitataan 
             * viidestä kohdasta, joiden avulla lasketaan keskiarvo tuulen suunnalle
             * ja voimakkuudelle. Hyppääjälle annetaan takatuulesta hyvitysmetrejä 
             * ja vastatuulesta puolestaan tehdään vähennyksiä. Vähennyksen tai 
             * hyvityksen kokoon vaikuttavat tuulen voimakkuus ja mäen K-piste 
             * seuraavan kaavan mukaan: 
             * Tuulen vaikutus hypyn pituuteen = Tuulen voimakkuuden keskiarvo x (K-piste - 36)/20
*/
            double ka = 0, summa = 0,pisteet=0,kpiste;
            int sarake, pit;
            pit = dataGridView2.ColumnCount - 1;
            kpiste = double.Parse(textKpiste.Text);
            for (sarake = 0; sarake <= pit; sarake++)
            {
                summa =summa+ double.Parse(dataGridView2.Rows[0].Cells[sarake].Value.ToString());
            }
            ka = summa / 5; // lasketaan keskiarvo tuulen voimakkuuksille
            pisteet = ka * (kpiste - 36) / 20; 
            pisteet = pisteet * 1.8;

            textTuuli.Text = pisteet.ToString();
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView3.RowCount = 5;
            dataGridView3.Rows[0].Cells[0].Value = 1;
            dataGridView3.Rows[1].Cells[0].Value = 2;
            dataGridView3.Rows[2].Cells[0].Value = 3;
            dataGridView3.Rows[3].Cells[0].Value = 4;
            dataGridView3.Rows[4].Cells[0].Value = 5;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int rivi = 0;
            rivi = int.Parse(comboBox1.Text) - 1;
            dataGridView3.Rows[rivi].Cells[2].Value = textPituuspisteet.Text;
            dataGridView3.Rows[rivi].Cells[3].Value = textTyylip.Text;
            dataGridView3.Rows[rivi].Cells[4].Value = textTuuli.Text;
            dataGridView3.Rows[rivi].Cells[5].Value = textYhteispisteet.Text;


        }

        private void button5_Click(object sender, EventArgs e)
        {
            double summa = 0, pituus = 0, tyyli = 0, tuuli = 0;
            pituus = double.Parse(textPituuspisteet.Text);
            tyyli= double.Parse(textTyylip.Text);
            tuuli= double.Parse(textTuuli.Text);
            summa = pituus + tyyli + tuuli; // lasketaan yhteispisteet
            textYhteispisteet.Text = summa.ToString();

        }
    }
}
