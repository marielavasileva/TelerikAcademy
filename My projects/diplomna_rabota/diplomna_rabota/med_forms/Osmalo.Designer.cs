namespace diplomna_rabota.med_forms
{
    partial class Osmola
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Osmola));
            this.Na = new System.Windows.Forms.TextBox();
            this.K = new System.Windows.Forms.TextBox();
            this.Urea = new System.Windows.Forms.TextBox();
            this.Glucose = new System.Windows.Forms.TextBox();
            this.Osmol = new System.Windows.Forms.Button();
            this.Osmolality = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.resultOsmo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Na
            // 
            this.Na.Location = new System.Drawing.Point(14, 30);
            this.Na.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Na.Name = "Na";
            this.Na.Size = new System.Drawing.Size(130, 24);
            this.Na.TabIndex = 0;
            // 
            // K
            // 
            this.K.Location = new System.Drawing.Point(14, 90);
            this.K.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.K.Name = "K";
            this.K.Size = new System.Drawing.Size(130, 24);
            this.K.TabIndex = 1;
            // 
            // Urea
            // 
            this.Urea.Location = new System.Drawing.Point(14, 150);
            this.Urea.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Urea.Name = "Urea";
            this.Urea.Size = new System.Drawing.Size(130, 24);
            this.Urea.TabIndex = 2;
            // 
            // Glucose
            // 
            this.Glucose.Location = new System.Drawing.Point(14, 214);
            this.Glucose.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Glucose.Name = "Glucose";
            this.Glucose.Size = new System.Drawing.Size(130, 24);
            this.Glucose.TabIndex = 3;
            // 
            // Osmol
            // 
            this.Osmol.BackColor = System.Drawing.Color.Purple;
            this.Osmol.Location = new System.Drawing.Point(282, 24);
            this.Osmol.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Osmol.Name = "Osmol";
            this.Osmol.Size = new System.Drawing.Size(178, 30);
            this.Osmol.TabIndex = 4;
            this.Osmol.Text = "Изчисли";
            this.Osmol.UseVisualStyleBackColor = false;
            this.Osmol.Click += new System.EventHandler(this.button1_Click);
            // 
            // Osmolality
            // 
            this.Osmolality.Location = new System.Drawing.Point(277, 113);
            this.Osmolality.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Osmolality.Multiline = true;
            this.Osmolality.Name = "Osmolality";
            this.Osmolality.Size = new System.Drawing.Size(178, 33);
            this.Osmolality.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Na:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "K:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Урея:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Кръвна захар:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(279, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Осмолалитет:";
            // 
            // resultOsmo
            // 
            this.resultOsmo.Location = new System.Drawing.Point(277, 168);
            this.resultOsmo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.resultOsmo.Multiline = true;
            this.resultOsmo.Name = "resultOsmo";
            this.resultOsmo.Size = new System.Drawing.Size(173, 97);
            this.resultOsmo.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(461, 129);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "mosml/kg";
            // 
            // Osmola
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Purple;
            this.BackgroundImage = global::diplomna_rabota.Properties.Resources._1289063310k6A9H6;
            this.ClientSize = new System.Drawing.Size(546, 280);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.resultOsmo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Osmolality);
            this.Controls.Add(this.Osmol);
            this.Controls.Add(this.Glucose);
            this.Controls.Add(this.Urea);
            this.Controls.Add(this.K);
            this.Controls.Add(this.Na);
            this.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Osmola";
            this.Text = "Осмолалитет";
            this.Load += new System.EventHandler(this.Osmola_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Na;
        private System.Windows.Forms.TextBox K;
        private System.Windows.Forms.TextBox Urea;
        private System.Windows.Forms.TextBox Glucose;
        private System.Windows.Forms.Button Osmol;
        private System.Windows.Forms.TextBox Osmolality;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox resultOsmo;
        private System.Windows.Forms.Label label6;
    }
}