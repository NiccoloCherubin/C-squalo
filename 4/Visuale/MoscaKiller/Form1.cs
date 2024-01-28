using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;
using System.Threading.Tasks;

namespace Tiro_a_segno
{
    public partial class Main : Form
    {
        int secondi = 0;
        private System.Windows.Forms.Button btnClose;
        Point Posizione;
        Random XY;
        int i = 0;
        public Main()
        {
            InitializeComponent();
            Posizione = new Point();
            pcFigura.SizeMode = PictureBoxSizeMode.StretchImage;
            pnlArea.BackgroundImageLayout = ImageLayout.Stretch;
            XY = new Random();
            Step.Enabled = false;
            btnMosca.Checked = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Step_Tick(object sender, EventArgs e)
        {
            Posizione.X = XY.Next(0, (pnlArea.ClientSize.Width - pcFigura.Width) + 1);
            Posizione.Y = XY.Next(0, (pnlArea.ClientSize.Height - pcFigura.Height) + 1);
            pcFigura.Location = Posizione;
        }
        private void btnMosca_CheckedChanged(object sender, EventArgs e)
        {
            Immagine immagine = new Immagine(Environment.CurrentDirectory + "\\mosca_immagini\\mosca.gif");
            pcFigura.Image = immagine.RitornoImmagine();
        }

        private void btnFarfalla_CheckedChanged(object sender, EventArgs e)
        {
            Immagine immagine = new Immagine(Environment.CurrentDirectory + "\\mosca_immagini\\farfalla.gif");
            pcFigura.Image = immagine.RitornoImmagine();
        }

        private void btnApe_CheckedChanged(object sender, EventArgs e)
        {
            Immagine immagine = new Immagine(Environment.CurrentDirectory + "\\mosca_immagini\\ape.gif");
            pcFigura.Image = immagine.RitornoImmagine();
        }

        private void Main_HelpButtonClicked(object sender, CancelEventArgs e)
        {
            MessageBox.Show("Buona fortuna", "Informazioni sul gioco:");
        }


        private void btnStart_Click(object sender, EventArgs e)
        {
            Step.Interval = 1000;
            Step.Enabled = true;
        }

        private void pcFigura_Click(object sender, EventArgs e)
        {
            // quando si clicca la figura
            Immagine immagine;
            string path = Environment.CurrentDirectory + "\\mosca_immagini";
            // verifico scelta dell'utente
            if (btnFarfalla.Checked)
            {
                //farfalla
                immagine = new Immagine(path + "\\farfallaX.gif");

            }
            else if (btnApe.Checked)
            {
                //Ape
                immagine = new Immagine(path + "\\apeX.gif");
            }
            else
            {
                //mosca
                immagine = new Immagine(path + "\\moscaX.gif");
            }
            pcFigura.Image = immagine.RitornoImmagine();
            // fermo il gioco
            Step.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Ripristina l'immagine alla versione normale facendo ripartire il gioco
            Immagine immagine;
            string path = Environment.CurrentDirectory + "\\mosca_immagini";
            if (btnFarfalla.Checked)
            {
                immagine = new Immagine(path + "\\farfalla.gif");
            }
            else if (btnApe.Checked)
            {
                immagine = new Immagine(path + "\\ape.gif");
            }
            else
            {
                immagine = new Immagine(path + "\\mosca.gif");
            }
            pcFigura.Image = immagine.RitornoImmagine();
            Step.Enabled = true;
            
        }
    }
}
