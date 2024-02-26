using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void CreaStudente_Click(object sender, EventArgs e)
        {
            string nome = textBox1.Text, cognome = textBox2.Text;

            if (!StringheValide(ref nome) && !StringheValide(ref cognome))
            {
                return;
            }

            Studente studente = new Studente(nome, cognome);

            if(lista.Exists(x => studente == x))
            {
                MessageBox.Show("Dati Doppi", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            lista.Add(studente);
            listBox1.Items.Add(studente);
        }

        private void CreaPersona_Click(object sender, EventArgs e)
        {
            string nome = textBox1.Text, cognome = textBox2.Text;

            if (!StringheValide(ref nome) && !StringheValide(ref cognome))
            {
                return;
            }

            Persona persona = new Persona(nome, cognome);

            if (lista.Exists(x => persona == x))
            {
                MessageBox.Show("Dati Doppi", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            lista.Add(persona);
            listBox1.Items.Add(persona);
        }
        private bool StringheValide(ref string valore1)
        {

            if (String.IsNullOrEmpty(valore1))
            {
                MessageBox.Show("Dati errati", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
      
    }
}
