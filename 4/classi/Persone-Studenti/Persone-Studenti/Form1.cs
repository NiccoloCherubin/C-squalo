using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Persone_Studenti
{
    public partial class Form1 : Form
    {
        List<Persona> lista = new List<Persona>();
        public Form1()
        {
            InitializeComponent();
            pictureBox1.Image = null;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void CreaStudente_Click(object sender, EventArgs e)
        {
            string nome = textBox1.Text, cognome = textBox2.Text;

            if (String.IsNullOrEmpty(nome) || String.IsNullOrEmpty(cognome) || pictureBox1.Image == null)
            {
                MessageBox.Show("Dati non validi", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Studente studente = new Studente(nome, cognome, pictureBox1.Image);

            if (lista.Exists(x => studente == x))
            {
                MessageBox.Show("Dati Doppi", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            lista.Add(studente);
            listBox1.Items.Add(studente);

            Pulisci();
        }

        private void CreaPersona_Click(object sender, EventArgs e)
        {
            string nome = textBox1.Text, cognome = textBox2.Text;

            if (String.IsNullOrEmpty(nome) || String.IsNullOrEmpty(cognome) || pictureBox1.Image == null)
            {
                MessageBox.Show("Dati non validi", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Persona persona = new Persona(nome, cognome, pictureBox1.Image);

            if (lista.Exists(x => persona == x))
            {
                MessageBox.Show("Dati Doppi", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            lista.Add(persona);
            listBox1.Items.Add(persona);

            Pulisci();
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.CheckFileExists = true;    //permette di verificare l'esistenza del file
            op.InitialDirectory = System.IO.Directory.GetCurrentDirectory() + "\\immagini\\";
            op.DefaultExt = "jpg";
            op.Filter = "jpg files (.jpg)|*.jpg";   //visualizzo tutti i file che hanno la stessa estensione
            if (op.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(op.FileName);
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }

        }
        private void Pulisci()
        {
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            pictureBox1.Image = null;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                Persona persona = lista[listBox1.SelectedIndex];
                textBox3.Text = persona.nome;
                textBox4.Text = persona.cognome;
                pictureBox2.Image = persona.immagine;
            }
            else
            {
                MessageBox.Show("Errore", "Nessuna persona nella lista", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
