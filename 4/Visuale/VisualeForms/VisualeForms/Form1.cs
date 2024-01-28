using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VisualeForms
{
    public partial class Visuale : Form
    {
        private System.Windows.Forms.Button BtnClose;
        int contatore;
        Point xy = new Point();
        Random cOrd = new Random();
        public Visuale()
        {
            InitializeComponent();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Visuale_FormClosing(object sender, FormClosingEventArgs e)
        {

            if (MessageBox.Show("Vuoi chiudere il form?", "Avviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No) // componente visuale non presente nella palette
            {
                e.Cancel = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //timer1.Enabled = false;
            //MessageBox.Show("Scattato");
            //timer1.Enabled = true;
            Button bottone = new Button();
            xy.X = cOrd.Next(0, (ClientSize.Width - bottone.Width) - 1);
            xy.Y = cOrd.Next(0, (ClientSize.Height - bottone.Height) - 1);
            bottone.Location = xy;
            bottone.Name = "Bottone" + contatore;
            bottone.Size = new System.Drawing.Size(75, 23);
            bottone.TabIndex = 0;
            bottone.Text = "Bottone" + contatore;
            bottone.UseVisualStyleBackColor = true;
            Controls.Add(bottone);
            contatore++;


            bottone.Click += new System.EventHandler(this.bottone_Click);
        }
        private void bottone_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            MessageBox.Show("Premuto");
            timer1.Enabled = true;
        }
        private void Visuale_Load(object sender, EventArgs e)
        {
            contatore = 0;
        }

        private void CreaMosca_Click(object sender, EventArgs e)
        {         
            
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
           
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            string path = Environment.CurrentDirectory;
            pictureBox1.Image = Image.FromFile(path + "\\" + "mosca_immagini" + "\\" + "moscaX.gif");
        }
    }
}
