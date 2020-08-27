namespace Sluneční_soustava
{
    partial class Form1
    {
        /// <summary>
        /// Vyžadovaná proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolnit všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by měl být spravovaný prostředek odstraněn, jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu návrháře - neupravovat
        /// obsah této metody s editorem kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.checkBoxTrajektorie = new System.Windows.Forms.CheckBox();
            this.checkBoxPopisky = new System.Windows.Forms.CheckBox();
            this.checkBoxMesice = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDownZrychleni = new System.Windows.Forms.NumericUpDown();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.pictureBoxScena = new System.Windows.Forms.PictureBox();
            this.radioButtonHodiny = new System.Windows.Forms.RadioButton();
            this.radioButtonDny = new System.Windows.Forms.RadioButton();
            this.radioButtonRoky = new System.Windows.Forms.RadioButton();
            this.panelOvladani = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBoxCelaObrazovka = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownZrychleni)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxScena)).BeginInit();
            this.panelOvladani.SuspendLayout();
            this.SuspendLayout();
            // 
            // checkBoxTrajektorie
            // 
            this.checkBoxTrajektorie.AutoSize = true;
            this.checkBoxTrajektorie.Checked = true;
            this.checkBoxTrajektorie.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxTrajektorie.Location = new System.Drawing.Point(56, 8);
            this.checkBoxTrajektorie.Name = "checkBoxTrajektorie";
            this.checkBoxTrajektorie.Size = new System.Drawing.Size(88, 17);
            this.checkBoxTrajektorie.TabIndex = 1;
            this.checkBoxTrajektorie.Text = "trajektorie (T)";
            this.checkBoxTrajektorie.UseVisualStyleBackColor = true;
            this.checkBoxTrajektorie.CheckedChanged += new System.EventHandler(this.checkBoxTrajektorie_CheckedChanged);
            // 
            // checkBoxPopisky
            // 
            this.checkBoxPopisky.AutoSize = true;
            this.checkBoxPopisky.Location = new System.Drawing.Point(153, 8);
            this.checkBoxPopisky.Name = "checkBoxPopisky";
            this.checkBoxPopisky.Size = new System.Drawing.Size(78, 17);
            this.checkBoxPopisky.TabIndex = 2;
            this.checkBoxPopisky.Text = "popisky (P)";
            this.checkBoxPopisky.UseVisualStyleBackColor = true;
            this.checkBoxPopisky.CheckedChanged += new System.EventHandler(this.checkBoxPopisky_CheckedChanged);
            // 
            // checkBoxMesice
            // 
            this.checkBoxMesice.AutoSize = true;
            this.checkBoxMesice.Location = new System.Drawing.Point(237, 8);
            this.checkBoxMesice.Name = "checkBoxMesice";
            this.checkBoxMesice.Size = new System.Drawing.Size(79, 17);
            this.checkBoxMesice.TabIndex = 3;
            this.checkBoxMesice.Text = "měsíce (M)";
            this.checkBoxMesice.UseVisualStyleBackColor = true;
            this.checkBoxMesice.CheckedChanged += new System.EventHandler(this.checkBoxMesice_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Za sekundu uplyne";
            // 
            // numericUpDownZrychleni
            // 
            this.numericUpDownZrychleni.InterceptArrowKeys = false;
            this.numericUpDownZrychleni.Location = new System.Drawing.Point(119, 31);
            this.numericUpDownZrychleni.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownZrychleni.Name = "numericUpDownZrychleni";
            this.numericUpDownZrychleni.Size = new System.Drawing.Size(60, 20);
            this.numericUpDownZrychleni.TabIndex = 5;
            this.numericUpDownZrychleni.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // timer
            // 
            this.timer.Interval = 30;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // pictureBoxScena
            // 
            this.pictureBoxScena.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxScena.BackColor = System.Drawing.Color.Black;
            this.pictureBoxScena.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxScena.Location = new System.Drawing.Point(13, 61);
            this.pictureBoxScena.Name = "pictureBoxScena";
            this.pictureBoxScena.Size = new System.Drawing.Size(759, 739);
            this.pictureBoxScena.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxScena.TabIndex = 7;
            this.pictureBoxScena.TabStop = false;
            this.pictureBoxScena.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBoxScena_MouseMove);
            this.pictureBoxScena.Resize += new System.EventHandler(this.pictureBoxScena_Resize);
            // 
            // radioButtonHodiny
            // 
            this.radioButtonHodiny.AutoSize = true;
            this.radioButtonHodiny.Location = new System.Drawing.Point(228, 30);
            this.radioButtonHodiny.Name = "radioButtonHodiny";
            this.radioButtonHodiny.Size = new System.Drawing.Size(68, 17);
            this.radioButtonHodiny.TabIndex = 8;
            this.radioButtonHodiny.Text = "hodin (H)";
            this.radioButtonHodiny.UseVisualStyleBackColor = true;
            // 
            // radioButtonDny
            // 
            this.radioButtonDny.AutoSize = true;
            this.radioButtonDny.Checked = true;
            this.radioButtonDny.Location = new System.Drawing.Point(302, 30);
            this.radioButtonDny.Name = "radioButtonDny";
            this.radioButtonDny.Size = new System.Drawing.Size(60, 17);
            this.radioButtonDny.TabIndex = 9;
            this.radioButtonDny.TabStop = true;
            this.radioButtonDny.Text = "dnů (D)";
            this.radioButtonDny.UseVisualStyleBackColor = true;
            // 
            // radioButtonRoky
            // 
            this.radioButtonRoky.AutoSize = true;
            this.radioButtonRoky.Location = new System.Drawing.Point(368, 30);
            this.radioButtonRoky.Name = "radioButtonRoky";
            this.radioButtonRoky.Size = new System.Drawing.Size(63, 17);
            this.radioButtonRoky.TabIndex = 10;
            this.radioButtonRoky.Text = "roků (R)";
            this.radioButtonRoky.UseVisualStyleBackColor = true;
            // 
            // panelOvladani
            // 
            this.panelOvladani.Controls.Add(this.label3);
            this.panelOvladani.Controls.Add(this.label2);
            this.panelOvladani.Controls.Add(this.checkBoxCelaObrazovka);
            this.panelOvladani.Controls.Add(this.checkBoxTrajektorie);
            this.panelOvladani.Controls.Add(this.radioButtonRoky);
            this.panelOvladani.Controls.Add(this.checkBoxPopisky);
            this.panelOvladani.Controls.Add(this.radioButtonDny);
            this.panelOvladani.Controls.Add(this.checkBoxMesice);
            this.panelOvladani.Controls.Add(this.radioButtonHodiny);
            this.panelOvladani.Controls.Add(this.label1);
            this.panelOvladani.Controls.Add(this.numericUpDownZrychleni);
            this.panelOvladani.Location = new System.Drawing.Point(0, 0);
            this.panelOvladani.Name = "panelOvladani";
            this.panelOvladani.Size = new System.Drawing.Size(454, 60);
            this.panelOvladani.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(185, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "(šipky)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Kreslit:";
            // 
            // checkBoxCelaObrazovka
            // 
            this.checkBoxCelaObrazovka.AutoSize = true;
            this.checkBoxCelaObrazovka.Location = new System.Drawing.Point(322, 8);
            this.checkBoxCelaObrazovka.Name = "checkBoxCelaObrazovka";
            this.checkBoxCelaObrazovka.Size = new System.Drawing.Size(126, 17);
            this.checkBoxCelaObrazovka.TabIndex = 11;
            this.checkBoxCelaObrazovka.Text = "celá obrazovka (F11)";
            this.checkBoxCelaObrazovka.UseVisualStyleBackColor = true;
            this.checkBoxCelaObrazovka.CheckedChanged += new System.EventHandler(this.checkBoxCelaObrazovka_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 812);
            this.Controls.Add(this.panelOvladani);
            this.Controls.Add(this.pictureBoxScena);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MinimumSize = new System.Drawing.Size(800, 850);
            this.Name = "Form1";
            this.Text = "Koperníkův model sluneční soustavy - Michal Maršálek květen 2013";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownZrychleni)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxScena)).EndInit();
            this.panelOvladani.ResumeLayout(false);
            this.panelOvladani.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBoxTrajektorie;
        private System.Windows.Forms.CheckBox checkBoxPopisky;
        private System.Windows.Forms.CheckBox checkBoxMesice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDownZrychleni;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.PictureBox pictureBoxScena;
        private System.Windows.Forms.RadioButton radioButtonHodiny;
        private System.Windows.Forms.RadioButton radioButtonDny;
        private System.Windows.Forms.RadioButton radioButtonRoky;
        private System.Windows.Forms.Panel panelOvladani;
        private System.Windows.Forms.CheckBox checkBoxCelaObrazovka;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

