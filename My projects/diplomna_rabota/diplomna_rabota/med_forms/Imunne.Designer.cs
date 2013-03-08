namespace diplomna_rabota.med_forms
{
    partial class Imunne
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Imunne));
            this.resultIm = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ValueIm = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Value = new System.Windows.Forms.TextBox();
            this.Hours = new System.Windows.Forms.RadioButton();
            this.Months = new System.Windows.Forms.RadioButton();
            this.Years = new System.Windows.Forms.RadioButton();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // resultIm
            // 
            this.resultIm.BackColor = System.Drawing.Color.Wheat;
            this.resultIm.Location = new System.Drawing.Point(489, 96);
            this.resultIm.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.resultIm.Multiline = true;
            this.resultIm.Name = "resultIm";
            this.resultIm.Size = new System.Drawing.Size(303, 136);
            this.resultIm.TabIndex = 4;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Wheat;
            this.groupBox2.Controls.Add(this.ValueIm);
            this.groupBox2.Location = new System.Drawing.Point(13, 171);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(441, 131);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Търсене по имунизация";
            // 
            // ValueIm
            // 
            this.ValueIm.FormattingEnabled = true;
            this.ValueIm.Items.AddRange(new object[] {
            "Хепатит В",
            "Туберкулоза (БЦЖ ваксина, след отрицателна Манту проба)",
            "Полиомелит,дифтерия,тетанус,коклюш и хемофилус инфлуенце тип Б",
            "Полиомелит,дифтерия,тетанус и коклюш",
            "Пневмококи",
            "Морбили, паротит и рубеола",
            "Тетанус и дифтерия"});
            this.ValueIm.Location = new System.Drawing.Point(7, 38);
            this.ValueIm.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ValueIm.Name = "ValueIm";
            this.ValueIm.Size = new System.Drawing.Size(426, 23);
            this.ValueIm.TabIndex = 8;
            this.ValueIm.SelectedIndexChanged += new System.EventHandler(this.ValueIm_SelectedIndexChanged_1);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Wheat;
            this.groupBox3.Controls.Add(this.Value);
            this.groupBox3.Controls.Add(this.Hours);
            this.groupBox3.Controls.Add(this.Months);
            this.groupBox3.Controls.Add(this.Years);
            this.groupBox3.Location = new System.Drawing.Point(14, 16);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Size = new System.Drawing.Size(440, 132);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Търсене по възраст";
            // 
            // Value
            // 
            this.Value.Location = new System.Drawing.Point(20, 27);
            this.Value.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Value.Name = "Value";
            this.Value.Size = new System.Drawing.Size(152, 23);
            this.Value.TabIndex = 5;
            this.Value.TextChanged += new System.EventHandler(this.Value_TextChanged);
            // 
            // Hours
            // 
            this.Hours.AutoSize = true;
            this.Hours.Location = new System.Drawing.Point(310, 29);
            this.Hours.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Hours.Name = "Hours";
            this.Hours.Size = new System.Drawing.Size(60, 17);
            this.Hours.TabIndex = 4;
            this.Hours.TabStop = true;
            this.Hours.Text = "часове";
            this.Hours.UseVisualStyleBackColor = true;
            this.Hours.CheckedChanged += new System.EventHandler(this.hours_CheckedChanged);
            // 
            // Months
            // 
            this.Months.AutoSize = true;
            this.Months.Location = new System.Drawing.Point(310, 54);
            this.Months.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Months.Name = "Months";
            this.Months.Size = new System.Drawing.Size(63, 17);
            this.Months.TabIndex = 3;
            this.Months.TabStop = true;
            this.Months.Text = "месеци";
            this.Months.UseVisualStyleBackColor = true;
            this.Months.CheckedChanged += new System.EventHandler(this.months_CheckedChanged);
            // 
            // Years
            // 
            this.Years.AutoSize = true;
            this.Years.Location = new System.Drawing.Point(310, 81);
            this.Years.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Years.Name = "Years";
            this.Years.Size = new System.Drawing.Size(60, 17);
            this.Years.TabIndex = 2;
            this.Years.TabStop = true;
            this.Years.Text = "години";
            this.Years.UseVisualStyleBackColor = true;
            this.Years.CheckedChanged += new System.EventHandler(this.years_CheckedChanged);
            // 
            // Imunne
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.BackgroundImage = global::diplomna_rabota.Properties.Resources.soul_of_medicine1;
            this.ClientSize = new System.Drawing.Size(806, 336);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.resultIm);
            this.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Imunne";
            this.Text = "Имузационен календар";
            this.Load += new System.EventHandler(this.Imunne_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox resultIm;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox ValueIm;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton Hours;
        private System.Windows.Forms.RadioButton Months;
        private System.Windows.Forms.RadioButton Years;
        private System.Windows.Forms.TextBox Value;
    }
}