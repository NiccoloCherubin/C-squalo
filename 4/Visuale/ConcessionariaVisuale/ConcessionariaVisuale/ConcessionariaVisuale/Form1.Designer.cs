namespace ConcessionariaVisuale
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Create = new System.Windows.Forms.Button();
            this.textBoxMarca = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBoxModello = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBoxCilindrata = new System.Windows.Forms.TextBox();
            this.textBoxNumeroVolumi = new System.Windows.Forms.TextBox();
            this.LabelMarca = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.PortaCasco = new System.Windows.Forms.Label();
            this.PortaCascoCheck = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.ListaVetture = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MenuSpogliarello = new System.Windows.Forms.ToolStripMenuItem();
            this.autoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.motoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Remove = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Create
            // 
            this.Create.Location = new System.Drawing.Point(82, 321);
            this.Create.Name = "Create";
            this.Create.Size = new System.Drawing.Size(75, 23);
            this.Create.TabIndex = 0;
            this.Create.Text = "Crea";
            this.Create.UseVisualStyleBackColor = true;
            this.Create.Click += new System.EventHandler(this.Create_Click);
            // 
            // textBoxMarca
            // 
            this.textBoxMarca.Location = new System.Drawing.Point(1, 36);
            this.textBoxMarca.Name = "textBoxMarca";
            this.textBoxMarca.Size = new System.Drawing.Size(100, 20);
            this.textBoxMarca.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(1, 85);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 4;
            // 
            // textBoxModello
            // 
            this.textBoxModello.Location = new System.Drawing.Point(141, 35);
            this.textBoxModello.Name = "textBoxModello";
            this.textBoxModello.Size = new System.Drawing.Size(100, 20);
            this.textBoxModello.TabIndex = 5;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(141, 85);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 6;
            // 
            // textBoxCilindrata
            // 
            this.textBoxCilindrata.Location = new System.Drawing.Point(1, 128);
            this.textBoxCilindrata.Name = "textBoxCilindrata";
            this.textBoxCilindrata.Size = new System.Drawing.Size(100, 20);
            this.textBoxCilindrata.TabIndex = 7;
            this.textBoxCilindrata.Visible = false;
            // 
            // textBoxNumeroVolumi
            // 
            this.textBoxNumeroVolumi.Location = new System.Drawing.Point(141, 128);
            this.textBoxNumeroVolumi.Name = "textBoxNumeroVolumi";
            this.textBoxNumeroVolumi.Size = new System.Drawing.Size(100, 20);
            this.textBoxNumeroVolumi.TabIndex = 8;
            this.textBoxNumeroVolumi.Visible = false;
            // 
            // LabelMarca
            // 
            this.LabelMarca.AutoSize = true;
            this.LabelMarca.Location = new System.Drawing.Point(1, 17);
            this.LabelMarca.Name = "LabelMarca";
            this.LabelMarca.Size = new System.Drawing.Size(37, 13);
            this.LabelMarca.TabIndex = 11;
            this.LabelMarca.Text = "Marca";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(141, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Modello";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Km Percorsi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(141, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Costo al km";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Cilindrata";
            this.label4.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(141, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Numero Volumi";
            this.label5.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1, 112);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Numero Tempi";
            this.label6.Visible = false;
            // 
            // PortaCasco
            // 
            this.PortaCasco.AutoSize = true;
            this.PortaCasco.Location = new System.Drawing.Point(141, 124);
            this.PortaCasco.Name = "PortaCasco";
            this.PortaCasco.Size = new System.Drawing.Size(65, 13);
            this.PortaCasco.TabIndex = 20;
            this.PortaCasco.Text = "Porta Casco";
            this.PortaCasco.Visible = false;
            // 
            // PortaCascoCheck
            // 
            this.PortaCascoCheck.AutoSize = true;
            this.PortaCascoCheck.Location = new System.Drawing.Point(141, 141);
            this.PortaCascoCheck.Name = "PortaCascoCheck";
            this.PortaCascoCheck.Size = new System.Drawing.Size(35, 17);
            this.PortaCascoCheck.TabIndex = 21;
            this.PortaCascoCheck.Text = "Sì";
            this.PortaCascoCheck.UseVisualStyleBackColor = true;
            this.PortaCascoCheck.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.PortaCascoCheck);
            this.groupBox1.Controls.Add(this.PortaCasco);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.LabelMarca);
            this.groupBox1.Controls.Add(this.textBoxNumeroVolumi);
            this.groupBox1.Controls.Add(this.textBoxCilindrata);
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Controls.Add(this.textBoxModello);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBoxMarca);
            this.groupBox1.Location = new System.Drawing.Point(11, 68);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(255, 182);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dati";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(0, 153);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(60, 17);
            this.radioButton2.TabIndex = 23;
            this.radioButton2.Text = "Quattro";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.Visible = false;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(2, 129);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(45, 17);
            this.radioButton1.TabIndex = 22;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Due";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.Visible = false;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // ListaVetture
            // 
            this.ListaVetture.FormattingEnabled = true;
            this.ListaVetture.Location = new System.Drawing.Point(272, 68);
            this.ListaVetture.Name = "ListaVetture";
            this.ListaVetture.Size = new System.Drawing.Size(498, 238);
            this.ListaVetture.TabIndex = 23;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuSpogliarello});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 24;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MenuSpogliarello
            // 
            this.MenuSpogliarello.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.autoToolStripMenuItem,
            this.motoToolStripMenuItem});
            this.MenuSpogliarello.Name = "MenuSpogliarello";
            this.MenuSpogliarello.Size = new System.Drawing.Size(57, 20);
            this.MenuSpogliarello.Text = "Veicolo";
            // 
            // autoToolStripMenuItem
            // 
            this.autoToolStripMenuItem.Name = "autoToolStripMenuItem";
            this.autoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.autoToolStripMenuItem.Text = "Auto";
            this.autoToolStripMenuItem.Click += new System.EventHandler(this.autoToolStripMenuItem_Click);
            // 
            // motoToolStripMenuItem
            // 
            this.motoToolStripMenuItem.Name = "motoToolStripMenuItem";
            this.motoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.motoToolStripMenuItem.Text = "Moto";
            this.motoToolStripMenuItem.Click += new System.EventHandler(this.motoToolStripMenuItem_Click);
            // 
            // Remove
            // 
            this.Remove.Location = new System.Drawing.Point(424, 321);
            this.Remove.Name = "Remove";
            this.Remove.Size = new System.Drawing.Size(75, 23);
            this.Remove.TabIndex = 25;
            this.Remove.Text = "Rimuovi";
            this.Remove.UseVisualStyleBackColor = true;
            this.Remove.Click += new System.EventHandler(this.Remove_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Remove);
            this.Controls.Add(this.ListaVetture);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Create);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Concessionaria";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Create;
        private System.Windows.Forms.TextBox textBoxMarca;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBoxModello;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBoxCilindrata;
        private System.Windows.Forms.TextBox textBoxNumeroVolumi;
        private System.Windows.Forms.Label LabelMarca;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label PortaCasco;
        private System.Windows.Forms.CheckBox PortaCascoCheck;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox ListaVetture;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MenuSpogliarello;
        private System.Windows.Forms.ToolStripMenuItem autoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem motoToolStripMenuItem;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Button Remove;
    }
}

