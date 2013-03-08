namespace diplomna_rabota.med_forms
{
    partial class AKR
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AKR));
            this.pH = new System.Windows.Forms.TextBox();
            this.CO = new System.Windows.Forms.TextBox();
            this.SB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.result = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pH
            // 
            this.pH.Location = new System.Drawing.Point(38, 55);
            this.pH.Margin = new System.Windows.Forms.Padding(4);
            this.pH.Name = "pH";
            this.pH.Size = new System.Drawing.Size(143, 24);
            this.pH.TabIndex = 1;
            // 
            // CO
            // 
            this.CO.Location = new System.Drawing.Point(38, 142);
            this.CO.Margin = new System.Windows.Forms.Padding(4);
            this.CO.Name = "CO";
            this.CO.Size = new System.Drawing.Size(143, 24);
            this.CO.TabIndex = 2;
            // 
            // SB
            // 
            this.SB.Location = new System.Drawing.Point(38, 217);
            this.SB.Margin = new System.Windows.Forms.Padding(4);
            this.SB.Name = "SB";
            this.SB.Size = new System.Drawing.Size(143, 24);
            this.SB.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "pH:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 121);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "pCO2 (mmHg):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 200);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "SB (mmol/l):";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(329, 44);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(266, 35);
            this.button1.TabIndex = 9;
            this.button1.Text = "Определи АКС";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // result
            // 
            this.result.BackColor = System.Drawing.SystemColors.Info;
            this.result.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.result.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.result.Location = new System.Drawing.Point(328, 121);
            this.result.Margin = new System.Windows.Forms.Padding(4);
            this.result.Multiline = true;
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(267, 120);
            this.result.TabIndex = 10;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(38, 266);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(127, 24);
            this.button2.TabIndex = 11;
            this.button2.Text = "Изчисти";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // AKR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(634, 309);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.result);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SB);
            this.Controls.Add(this.CO);
            this.Controls.Add(this.pH);
            this.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AKR";
            this.Text = "AKR";
            this.Load += new System.EventHandler(this.AKR_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox pH;
        private System.Windows.Forms.TextBox CO;
        private System.Windows.Forms.TextBox SB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox result;
        private System.Windows.Forms.Button button2;
    }
}