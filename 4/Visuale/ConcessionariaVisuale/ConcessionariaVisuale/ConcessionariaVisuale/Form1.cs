using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConcessionariaVisuale
{
    public partial class Form1 : Form
    {
        bool auto;
        List<Veicolo> lista;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lista = new List<Veicolo>();
        }

        private void autoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //disibalito scelta per le moto
            auto = true;
            radioButton1.Visible = false;
            radioButton2.Visible = false;
            label6.Visible = false;

            PortaCasco.Visible = false;
            PortaCascoCheck.Visible = false;

            //abilito scelte per le auto            
            textBoxNumeroVolumi.Visible = true;
            label5.Visible = true;

            textBoxCilindrata.Visible = true;
            label4.Visible = true;

            //imposto costo al km
            textBox4.Text = "0.4";
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void motoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //disabilito inserimento per macchine
            auto = false;
            textBoxNumeroVolumi.Visible = false;
            label5.Visible = false;

            textBoxCilindrata.Visible = false;
            label4.Visible = false;

            //abilito scelta per moto
            radioButton1.Visible = true;
            radioButton2.Visible = true;
            label6.Visible = true;

            PortaCasco.Visible = true;
            PortaCascoCheck.Visible = true;

            //imposto costo al km
            textBox4.Text = "0.2";


        }

        private void Create_Click(object sender, EventArgs e)
        {
            if (!textBoxCilindrata.Visible && !radioButton1.Visible)
            {
                MessageBox.Show("Seleziona da menu strip", "ERRORE SCELTA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Veicolo v;
            if (auto)
            {
                //crea auto
                v = new Auto(
                    textBoxModello.Text,
                    InserimentoDouble(textBox2.Text),
                    InserimentoDouble(textBox4.Text),
                    textBoxMarca.Text,
                    InserimentoInt(textBoxCilindrata.Text),
                    InserimentoInt(textBoxNumeroVolumi.Text));
            }
            else
            {
                //verifico tempi moto
                int tempi;
                if (radioButton1.Checked)
                    tempi = 2;

                else
                    tempi = 4;

                //crea moto

                v = new Moto(
                    textBoxModello.Text,
                    InserimentoDouble(textBox2.Text),
                    InserimentoDouble(textBox4.Text),
                    textBoxMarca.Text,
                    tempi,
                    PortaCascoCheck.Checked);
            }

            ListaVetture.Items.Add(v.Stampa());
        }
        static double InserimentoDouble(string inserimento)
        {
            double temp;

            if (double.TryParse(inserimento, out temp) || temp < 1)
            {
                return temp;
            }

            MessageBox.Show("Errore inserimento dati", "COGLIONE", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            return -1;
        }
        static int InserimentoInt(string inserimento)
        {
            int temp;

            if (int.TryParse(inserimento, out temp) || temp < 1)
            {
                return temp;
            }

            MessageBox.Show("Errore inserimento dati", "COGLIONE", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            return -1;
        }

        private void Remove_Click(object sender, EventArgs e)
        {
            if (ListaVetture.SelectedItem == null)
            {
                MessageBox.Show("Selezionare qualcosa per rimuoverlo", "ERRORE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {

                if (MessageBox.Show("Sicuro di volere rimuovere l'oggetto selezionato?", "RIMOZIONE", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    ListaVetture.Items.Remove(ListaVetture.SelectedItem);
                }
                else
                {
                    return;
                }
            }
        }
    }
}
