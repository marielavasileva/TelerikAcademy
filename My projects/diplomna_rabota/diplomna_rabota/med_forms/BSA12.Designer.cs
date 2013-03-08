namespace diplomna_rabota.med_forms
{
    partial class BSA12
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BSA12));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.BMIndex = new System.Windows.Forms.TextBox();
            this.bmi = new System.Windows.Forms.Button();
            this.CalcB = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BSAValue = new System.Windows.Forms.TextBox();
            this.MassB = new System.Windows.Forms.TextBox();
            this.HeightB = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.ClearB = new System.Windows.Forms.Button();
            this.PasteB = new System.Windows.Forms.Button();
            this.CopyB = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.DosePacient = new System.Windows.Forms.TextBox();
            this.DoseDefine = new System.Windows.Forms.TextBox();
            this.BSAb = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.BMIndex);
            this.groupBox1.Controls.Add(this.bmi);
            this.groupBox1.Controls.Add(this.CalcB);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.BSAValue);
            this.groupBox1.Controls.Add(this.MassB);
            this.groupBox1.Controls.Add(this.HeightB);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Location = new System.Drawing.Point(20, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(806, 153);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "BSA";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(414, 81);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(33, 17);
            this.label12.TabIndex = 17;
            this.label12.Text = "BMI";
            // 
            // BMIndex
            // 
            this.BMIndex.Location = new System.Drawing.Point(414, 101);
            this.BMIndex.Name = "BMIndex";
            this.BMIndex.ReadOnly = true;
            this.BMIndex.Size = new System.Drawing.Size(145, 24);
            this.BMIndex.TabIndex = 5;
            this.BMIndex.TextChanged += new System.EventHandler(this.BMIndex_TextChanged);
            // 
            // bmi
            // 
            this.bmi.Location = new System.Drawing.Point(580, 95);
            this.bmi.Name = "bmi";
            this.bmi.Size = new System.Drawing.Size(115, 30);
            this.bmi.TabIndex = 16;
            this.bmi.Text = "Изчисли BMI";
            this.bmi.UseVisualStyleBackColor = true;
            this.bmi.Click += new System.EventHandler(this.bmi_Click);
            // 
            // CalcB
            // 
            this.CalcB.Location = new System.Drawing.Point(580, 32);
            this.CalcB.Name = "CalcB";
            this.CalcB.Size = new System.Drawing.Size(115, 31);
            this.CalcB.TabIndex = 15;
            this.CalcB.Text = "Изчисли  BSA";
            this.CalcB.UseVisualStyleBackColor = true;
            this.CalcB.Click += new System.EventHandler(this.CalcB_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(387, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(21, 24);
            this.label6.TabIndex = 14;
            this.label6.Text = "=";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(231, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 24);
            this.label5.TabIndex = 12;
            this.label5.Text = "*";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(414, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "BSA(m2)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(262, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Тегло(kg)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(106, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Височина (m)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(86, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "*";
            // 
            // BSAValue
            // 
            this.BSAValue.Location = new System.Drawing.Point(414, 38);
            this.BSAValue.Name = "BSAValue";
            this.BSAValue.ReadOnly = true;
            this.BSAValue.Size = new System.Drawing.Size(145, 24);
            this.BSAValue.TabIndex = 3;
            // 
            // MassB
            // 
            this.MassB.Location = new System.Drawing.Point(265, 39);
            this.MassB.Name = "MassB";
            this.MassB.Size = new System.Drawing.Size(116, 24);
            this.MassB.TabIndex = 2;
            // 
            // HeightB
            // 
            this.HeightB.Location = new System.Drawing.Point(109, 38);
            this.HeightB.Name = "HeightB";
            this.HeightB.Size = new System.Drawing.Size(116, 24);
            this.HeightB.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 38);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(74, 24);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "0.20247";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(this.ClearB);
            this.groupBox2.Controls.Add(this.PasteB);
            this.groupBox2.Controls.Add(this.CopyB);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.DosePacient);
            this.groupBox2.Controls.Add(this.DoseDefine);
            this.groupBox2.Controls.Add(this.BSAb);
            this.groupBox2.Location = new System.Drawing.Point(20, 216);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(806, 139);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Изчисляване на дозата";
            // 
            // button4
            // 
            this.button4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button4.Location = new System.Drawing.Point(549, 37);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(180, 28);
            this.button4.TabIndex = 28;
            this.button4.Text = "Изчисли дозата за пациента";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // ClearB
            // 
            this.ClearB.Location = new System.Drawing.Point(231, 84);
            this.ClearB.Name = "ClearB";
            this.ClearB.Size = new System.Drawing.Size(87, 27);
            this.ClearB.TabIndex = 27;
            this.ClearB.Text = "Изчисти";
            this.ClearB.UseVisualStyleBackColor = true;
            this.ClearB.Click += new System.EventHandler(this.button3_Click);
            // 
            // PasteB
            // 
            this.PasteB.Location = new System.Drawing.Point(109, 84);
            this.PasteB.Name = "PasteB";
            this.PasteB.Size = new System.Drawing.Size(85, 27);
            this.PasteB.TabIndex = 26;
            this.PasteB.Text = "Постави";
            this.PasteB.UseVisualStyleBackColor = true;
            this.PasteB.Click += new System.EventHandler(this.PasteB_Click);
            // 
            // CopyB
            // 
            this.CopyB.Location = new System.Drawing.Point(6, 84);
            this.CopyB.Name = "CopyB";
            this.CopyB.Size = new System.Drawing.Size(73, 27);
            this.CopyB.TabIndex = 25;
            this.CopyB.Text = "Копирай";
            this.CopyB.UseVisualStyleBackColor = true;
            this.CopyB.Click += new System.EventHandler(this.CopyB_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(384, 21);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(130, 17);
            this.label11.TabIndex = 24;
            this.label11.Text = "Доза за пациента(mg)";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(204, 20);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(129, 17);
            this.label10.TabIndex = 22;
            this.label10.Text = "Определена доза(mg)";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 20);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 17);
            this.label9.TabIndex = 20;
            this.label9.Text = "BSA(m2)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(357, 41);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(21, 24);
            this.label8.TabIndex = 18;
            this.label8.Text = "=";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(157, 41);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(17, 24);
            this.label7.TabIndex = 16;
            this.label7.Text = "*";
            // 
            // DosePacient
            // 
            this.DosePacient.Location = new System.Drawing.Point(384, 41);
            this.DosePacient.Name = "DosePacient";
            this.DosePacient.Size = new System.Drawing.Size(136, 24);
            this.DosePacient.TabIndex = 6;
            // 
            // DoseDefine
            // 
            this.DoseDefine.Location = new System.Drawing.Point(207, 41);
            this.DoseDefine.Name = "DoseDefine";
            this.DoseDefine.Size = new System.Drawing.Size(130, 24);
            this.DoseDefine.TabIndex = 5;
            // 
            // BSAb
            // 
            this.BSAb.Location = new System.Drawing.Point(6, 41);
            this.BSAb.Name = "BSAb";
            this.BSAb.Size = new System.Drawing.Size(130, 24);
            this.BSAb.TabIndex = 4;
            this.BSAb.TextChanged += new System.EventHandler(this.BSAb_TextChanged);
            // 
            // BSA12
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.ClientSize = new System.Drawing.Size(858, 368);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BSA12";
            this.Text = "BSA";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox BSAValue;
        private System.Windows.Forms.TextBox MassB;
        private System.Windows.Forms.TextBox HeightB;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox DosePacient;
        private System.Windows.Forms.TextBox DoseDefine;
        private System.Windows.Forms.TextBox BSAb;
        private System.Windows.Forms.Button ClearB;
        private System.Windows.Forms.Button PasteB;
        private System.Windows.Forms.Button CopyB;
        private System.Windows.Forms.Button CalcB;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button bmi;
        private System.Windows.Forms.TextBox BMIndex;
        private System.Windows.Forms.Label label12;
    }
}