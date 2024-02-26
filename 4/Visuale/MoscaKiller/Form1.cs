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

namespace Tiro_a_segno
{
    public partial class Main : Form
    {
        int secondi = 0;
        private System.Windows.Forms.Button btnClose;
        Point Posizione;
        Random XY;
        int errori = 0;
        int uccisioni = 0;
        int maxClicks;
        public Main()
        {
            InitializeComponent();
            Posizione = new Point();
            pcFigura.SizeMode = PictureBoxSizeMode.StretchImage;
            pnlArea.BackgroundImageLayout = ImageLayout.Stretch;
            XY = new Random();
            Step.Enabled = false;
            btnMosca.Checked = true;
            btnFacile.Checked = true;
            labelUccisioni.Text = uccisioni.ToString();
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
            button1_Click(sender, e);
            Step.Interval = 1000;
            Step.Enabled = true;
        }

        private void pcFigura_Click(object sender, EventArgs e)
        {
            uccisioni++;
            labelUccisioni.Text = uccisioni.ToString();
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
            MessageBox.Show("colpito", "congrats");
            button1_Click(sender, e);
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Ripristina l'immagine alla versione normale facendo ripartire il gioco
            uccisioni = 0;
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
        private void btnFacile_CheckedChanged(object sender, EventArgs e)
        {
            errori = 0; // reset contaore
            maxClicks = 5;
            button1_Click(sender,  e);
            //btn facile
            Step.Interval = 1000;
            Step.Enabled = true;
        }

        private void BtnMedio_CheckedChanged(object sender, EventArgs e)
        {
            errori = 0; // reset contaore
            maxClicks = 7;
            button1_Click(sender, e);
            //btn medio
            Step.Interval = 750;
            Step.Enabled = true;
        }
        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            errori = 0; // reset contaore
            maxClicks = 10;
            button1_Click(sender, e);
            //btn difficile
            Step.Interval = 500;
            Step.Enabled = true;
        }

        private void BtnEsperto_CheckedChanged(object sender, EventArgs e)
        {
            errori = 0; // reset contaore
            maxClicks = 3; // uno esperto non sbaglia
            button1_Click(sender, e);
            //btn esperto            
            Step.Interval = 200;
            Step.Enabled = true;
        }

        private void pnlArea_Click(object sender, EventArgs e)
        {
            //cliccato lo sfondo
            if(errori == maxClicks)
            {
                Step.Enabled = false; // ferma il gioco
                MessageBox.Show($"Hai raggiunto il limite massimo di errori : {maxClicks} per questa difficoltà","GAME OVER", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            errori++; // aumento contatore di click sullo sfondo (utente manca la mosca)
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
