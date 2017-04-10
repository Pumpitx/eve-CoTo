namespace eve_CoTo
{
    partial class Mainwindow
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.BoxRace = new System.Windows.Forms.GroupBox();
            this.radioCaldari = new System.Windows.Forms.RadioButton();
            this.radioMinmatar = new System.Windows.Forms.RadioButton();
            this.radioGallente = new System.Windows.Forms.RadioButton();
            this.radioAmarr = new System.Windows.Forms.RadioButton();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.BoxRace.SuspendLayout();
            this.SuspendLayout();
            // 
            // BoxRace
            // 
            this.BoxRace.AutoSize = true;
            this.BoxRace.Controls.Add(this.radioAmarr);
            this.BoxRace.Controls.Add(this.radioGallente);
            this.BoxRace.Controls.Add(this.radioMinmatar);
            this.BoxRace.Controls.Add(this.radioCaldari);
            this.BoxRace.Location = new System.Drawing.Point(12, 12);
            this.BoxRace.Name = "BoxRace";
            this.BoxRace.Size = new System.Drawing.Size(187, 80);
            this.BoxRace.TabIndex = 0;
            this.BoxRace.TabStop = false;
            this.BoxRace.Text = "Race";
            // 
            // radioCaldari
            // 
            this.radioCaldari.AutoSize = true;
            this.radioCaldari.Location = new System.Drawing.Point(7, 20);
            this.radioCaldari.Name = "radioCaldari";
            this.radioCaldari.Size = new System.Drawing.Size(57, 17);
            this.radioCaldari.TabIndex = 0;
            this.radioCaldari.TabStop = true;
            this.radioCaldari.Text = "Caldari";
            this.radioCaldari.UseVisualStyleBackColor = true;
            // 
            // radioMinmatar
            // 
            this.radioMinmatar.AutoSize = true;
            this.radioMinmatar.Location = new System.Drawing.Point(99, 20);
            this.radioMinmatar.Name = "radioMinmatar";
            this.radioMinmatar.Size = new System.Drawing.Size(68, 17);
            this.radioMinmatar.TabIndex = 1;
            this.radioMinmatar.TabStop = true;
            this.radioMinmatar.Text = "Minmatar";
            this.radioMinmatar.UseVisualStyleBackColor = true;
            // 
            // radioGallente
            // 
            this.radioGallente.AutoSize = true;
            this.radioGallente.Location = new System.Drawing.Point(7, 44);
            this.radioGallente.Name = "radioGallente";
            this.radioGallente.Size = new System.Drawing.Size(64, 17);
            this.radioGallente.TabIndex = 2;
            this.radioGallente.TabStop = true;
            this.radioGallente.Text = "Gallente";
            this.radioGallente.UseVisualStyleBackColor = true;
            // 
            // radioAmarr
            // 
            this.radioAmarr.AutoSize = true;
            this.radioAmarr.Location = new System.Drawing.Point(99, 44);
            this.radioAmarr.Name = "radioAmarr";
            this.radioAmarr.Size = new System.Drawing.Size(52, 17);
            this.radioAmarr.TabIndex = 3;
            this.radioAmarr.TabStop = true;
            this.radioAmarr.Text = "Amarr";
            this.radioAmarr.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(216, 20);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(312, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(211, 56);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(112, 32);
            this.buttonAdd.TabIndex = 2;
            this.buttonAdd.Text = "Add Component";
            this.buttonAdd.UseVisualStyleBackColor = true;
            // 
            // Mainwindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1306, 667);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.BoxRace);
            this.Name = "Mainwindow";
            this.Text = "eve-CoTo";
            this.BoxRace.ResumeLayout(false);
            this.BoxRace.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox BoxRace;
        private System.Windows.Forms.RadioButton radioAmarr;
        private System.Windows.Forms.RadioButton radioGallente;
        private System.Windows.Forms.RadioButton radioMinmatar;
        private System.Windows.Forms.RadioButton radioCaldari;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button buttonAdd;
    }
}

