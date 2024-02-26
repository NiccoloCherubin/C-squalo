
namespace Tiro_a_segno
{
    partial class Main
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.btnClose = new System.Windows.Forms.Button();
            this.pnlArea = new System.Windows.Forms.Panel();
            this.pcFigura = new System.Windows.Forms.PictureBox();
            this.Step = new System.Windows.Forms.Timer(this.components);
            this.btnMosca = new System.Windows.Forms.RadioButton();
            this.btnFarfalla = new System.Windows.Forms.RadioButton();
            this.btnApe = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.btn_Reset = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnEsperto = new System.Windows.Forms.RadioButton();
            this.BtnDifficile = new System.Windows.Forms.RadioButton();
            this.BtnMedio = new System.Windows.Forms.RadioButton();
            this.btnFacile = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.labelUccisioni = new System.Windows.Forms.Label();
            this.pnlArea.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcFigura)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnClose.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.Black;
            this.btnClose.Location = new System.Drawing.Point(922, 545);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 38);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "CHIUDI\r\n";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pnlArea
            // 
            this.pnlArea.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlArea.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlArea.BackgroundImage")));
            this.pnlArea.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlArea.Controls.Add(this.pcFigura);
            this.pnlArea.Location = new System.Drawing.Point(12, 12);
            this.pnlArea.Name = "pnlArea";
            this.pnlArea.Size = new System.Drawing.Size(823, 570);
            this.pnlArea.TabIndex = 1;
            this.pnlArea.Click += new System.EventHandler(this.pnlArea_Click);
            this.pnlArea.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pcFigura
            // 
            this.pcFigura.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pcFigura.BackColor = System.Drawing.Color.Transparent;
            this.pcFigura.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pcFigura.Location = new System.Drawing.Point(770, 524);
            this.pcFigura.Name = "pcFigura";
            this.pcFigura.Size = new System.Drawing.Size(53, 46);
            this.pcFigura.TabIndex = 0;
            this.pcFigura.TabStop = false;
            this.pcFigura.Click += new System.EventHandler(this.pcFigura_Click);
            // 
            // Step
            // 
            this.Step.Interval = 1000;
            this.Step.Tick += new System.EventHandler(this.Step_Tick);
            // 
            // btnMosca
            // 
            this.btnMosca.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMosca.AutoSize = true;
            this.btnMosca.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnMosca.Location = new System.Drawing.Point(6, 19);
            this.btnMosca.Name = "btnMosca";
            this.btnMosca.Size = new System.Drawing.Size(59, 19);
            this.btnMosca.TabIndex = 9;
            this.btnMosca.Text = "Mosca";
            this.btnMosca.UseVisualStyleBackColor = false;
            this.btnMosca.CheckedChanged += new System.EventHandler(this.btnMosca_CheckedChanged);
            // 
            // btnFarfalla
            // 
            this.btnFarfalla.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFarfalla.AutoSize = true;
            this.btnFarfalla.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnFarfalla.Location = new System.Drawing.Point(6, 42);
            this.btnFarfalla.Name = "btnFarfalla";
            this.btnFarfalla.Size = new System.Drawing.Size(64, 19);
            this.btnFarfalla.TabIndex = 10;
            this.btnFarfalla.Text = "Farfalla";
            this.btnFarfalla.UseVisualStyleBackColor = false;
            this.btnFarfalla.CheckedChanged += new System.EventHandler(this.btnFarfalla_CheckedChanged);
            // 
            // btnApe
            // 
            this.btnApe.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnApe.AutoSize = true;
            this.btnApe.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnApe.Location = new System.Drawing.Point(6, 65);
            this.btnApe.Name = "btnApe";
            this.btnApe.Size = new System.Drawing.Size(47, 19);
            this.btnApe.TabIndex = 11;
            this.btnApe.Text = "Ape";
            this.btnApe.UseVisualStyleBackColor = false;
            this.btnApe.CheckedChanged += new System.EventHandler(this.btnApe_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.btnMosca);
            this.groupBox2.Controls.Add(this.btnFarfalla);
            this.groupBox2.Controls.Add(this.btnApe);
            this.groupBox2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(857, 68);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(130, 94);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Insetto";
            // 
            // btnStart
            // 
            this.btnStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStart.BackColor = System.Drawing.Color.Yellow;
            this.btnStart.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(841, 500);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 38);
            this.btnStart.TabIndex = 14;
            this.btnStart.Text = "AVVIA";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btn_Reset
            // 
            this.btn_Reset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Reset.BackColor = System.Drawing.Color.Brown;
            this.btn_Reset.Location = new System.Drawing.Point(841, 545);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(75, 36);
            this.btn_Reset.TabIndex = 15;
            this.btn_Reset.Text = "Reset";
            this.btn_Reset.UseVisualStyleBackColor = false;
            this.btn_Reset.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.BtnEsperto);
            this.groupBox1.Controls.Add(this.BtnDifficile);
            this.groupBox1.Controls.Add(this.BtnMedio);
            this.groupBox1.Controls.Add(this.btnFacile);
            this.groupBox1.Location = new System.Drawing.Point(863, 187);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(124, 127);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Difficoltà";
            // 
            // BtnEsperto
            // 
            this.BtnEsperto.AutoSize = true;
            this.BtnEsperto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BtnEsperto.Location = new System.Drawing.Point(13, 96);
            this.BtnEsperto.Name = "BtnEsperto";
            this.BtnEsperto.Size = new System.Drawing.Size(61, 17);
            this.BtnEsperto.TabIndex = 3;
            this.BtnEsperto.TabStop = true;
            this.BtnEsperto.Text = "Esperto";
            this.BtnEsperto.UseVisualStyleBackColor = false;
            this.BtnEsperto.CheckedChanged += new System.EventHandler(this.BtnEsperto_CheckedChanged);
            // 
            // BtnDifficile
            // 
            this.BtnDifficile.AutoSize = true;
            this.BtnDifficile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.BtnDifficile.Location = new System.Drawing.Point(13, 73);
            this.BtnDifficile.Name = "BtnDifficile";
            this.BtnDifficile.Size = new System.Drawing.Size(59, 17);
            this.BtnDifficile.TabIndex = 2;
            this.BtnDifficile.TabStop = true;
            this.BtnDifficile.Text = "Difficile";
            this.BtnDifficile.UseVisualStyleBackColor = false;
            this.BtnDifficile.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // BtnMedio
            // 
            this.BtnMedio.AutoSize = true;
            this.BtnMedio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.BtnMedio.Location = new System.Drawing.Point(13, 50);
            this.BtnMedio.Name = "BtnMedio";
            this.BtnMedio.Size = new System.Drawing.Size(54, 17);
            this.BtnMedio.TabIndex = 1;
            this.BtnMedio.TabStop = true;
            this.BtnMedio.Text = "Media";
            this.BtnMedio.UseVisualStyleBackColor = false;
            this.BtnMedio.CheckedChanged += new System.EventHandler(this.BtnMedio_CheckedChanged);
            // 
            // btnFacile
            // 
            this.btnFacile.AutoSize = true;
            this.btnFacile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnFacile.Location = new System.Drawing.Point(11, 27);
            this.btnFacile.Name = "btnFacile";
            this.btnFacile.Size = new System.Drawing.Size(53, 17);
            this.btnFacile.TabIndex = 0;
            this.btnFacile.TabStop = true;
            this.btnFacile.Text = "Facile";
            this.btnFacile.UseVisualStyleBackColor = false;
            this.btnFacile.CheckedChanged += new System.EventHandler(this.btnFacile_CheckedChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(863, 343);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Uccisioni";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelUccisioni
            // 
            this.labelUccisioni.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelUccisioni.AutoSize = true;
            this.labelUccisioni.Location = new System.Drawing.Point(922, 342);
            this.labelUccisioni.Name = "labelUccisioni";
            this.labelUccisioni.Size = new System.Drawing.Size(35, 13);
            this.labelUccisioni.TabIndex = 18;
            this.labelUccisioni.Text = "label2";
            // 
            // Main
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(999, 594);
            this.Controls.Add(this.labelUccisioni);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_Reset);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.pnlArea);
            this.Controls.Add(this.btnClose);
            this.Cursor = System.Windows.Forms.Cursors.Cross;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.Text = "Mosca Killer";
            this.HelpButtonClicked += new System.ComponentModel.CancelEventHandler(this.Main_HelpButtonClicked);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlArea.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcFigura)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.Panel pnlArea;
        private System.Windows.Forms.PictureBox pcFigura;
        private System.Windows.Forms.Timer Step;
        private System.Windows.Forms.RadioButton btnMosca;
        private System.Windows.Forms.RadioButton btnFarfalla;
        private System.Windows.Forms.RadioButton btnApe;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btn_Reset;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton BtnDifficile;
        private System.Windows.Forms.RadioButton BtnMedio;
        private System.Windows.Forms.RadioButton btnFacile;
        private System.Windows.Forms.RadioButton BtnEsperto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelUccisioni;
    }
}

