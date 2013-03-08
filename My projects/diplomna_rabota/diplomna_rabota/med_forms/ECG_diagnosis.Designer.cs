namespace diplomna_rabota.med_forms
{
    partial class ECG_diagnosis
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
            this.pictureBoxEcg = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxEcg = new System.Windows.Forms.TextBox();
            this.ecgChoice = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEcg)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxEcg
            // 
            this.pictureBoxEcg.Location = new System.Drawing.Point(12, 62);
            this.pictureBoxEcg.Name = "pictureBoxEcg";
            this.pictureBoxEcg.Size = new System.Drawing.Size(1060, 552);
            this.pictureBoxEcg.TabIndex = 0;
            this.pictureBoxEcg.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1199, 359);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 31);
            this.button1.TabIndex = 1;
            this.button1.Text = "Покажи";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1106, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Разчитане:";
            // 
            // textBoxEcg
            // 
            this.textBoxEcg.Location = new System.Drawing.Point(1095, 98);
            this.textBoxEcg.Multiline = true;
            this.textBoxEcg.Name = "textBoxEcg";
            this.textBoxEcg.Size = new System.Drawing.Size(249, 226);
            this.textBoxEcg.TabIndex = 3;
            // 
            // ecgChoice
            // 
            this.ecgChoice.FormattingEnabled = true;
            this.ecgChoice.Items.AddRange(new object[] {
            "Остър  долно-латерален и преден миокарден инфаркт",
            "Остър латерален миокарден инфаркт",
            "Предсърдно мъждене , десен бедрен блок, ляв преден хемиблок",
            "AV блок първа степен",
            "Нодален ритъм",
            "AV блок първа степен с хипокалиемия",
            "Ляв заден хемиблок",
            "Синдром на удължен QT интервал",
            "Синусова брадикардия",
            "Синусова брадикардия, AV блок II степен, ляв бедрен блок",
            "Синусов ритъм",
            "Синусова тахикардия",
            "Камерна бигеминия",
            "Камерен пейсмейкър",
            "Камерна тахикардия",
            "WPW",
            "Ширококомплексни екстрасистоли",
            "Стар долен миокарден инфаркт",
            "AV блок III степен",
            "Тежка лявокамерна хипертрофия",
            "Синусов ритъм с предсърдни екстрасистоли",
            "Предсъдно трептене с 2:1 блок",
            "Синусова аритмия",
            "Синусова тахикардия с неспецифични ST промени , говорещи за белодробна тромбембол" +
                "ия",
            "AV блок I степен с остър Non-Q миокарден инфаркт",
            "Миокардна исхемия с ST депресия",
            "Декстрокардия",
            "Стар миокарден инфаркт с камерна аневризма",
            "Стар миокарден инфаркт с R върху T камерна екстрасистола, водеща до камерно трепт" +
                "ене",
            "Акцелериран идионодален ритъм",
            "Плоска Т вълна, с поява на U вълна, хипокалиемия, вероятен микседем",
            "Ширококомплексна тахикардия, дължаща се на синдром на WPW",
            "Деснокамерна хипертрофия",
            "Синдром на болния синусов възел",
            "Предсърдно трептене с AV блок 4:1",
            "ST елевация във всички отвеждания , дължаща се на перикардит",
            "LGL синдром",
            "T вълнова инверсия, дължаща се на субарахноидален кръвоизлив",
            "Перикарден излив с бифазни и отрицателни Т вълни",
            "Предсърдно мъждене с WPW синдром",
            "Prinzmetal ангина",
            "Brugada  синдром",
            "AV блок 2:1 , десен бедрен блок, ляв преден хемиблок"});
            this.ecgChoice.Location = new System.Drawing.Point(30, 16);
            this.ecgChoice.Name = "ecgChoice";
            this.ecgChoice.Size = new System.Drawing.Size(535, 25);
            this.ecgChoice.TabIndex = 4;
            this.ecgChoice.SelectedIndexChanged += new System.EventHandler(this.ecgChoice_SelectedIndexChanged);
            // 
            // ECG_diagnosis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::diplomna_rabota.Properties.Resources.ecg;
            this.ClientSize = new System.Drawing.Size(1370, 626);
            this.Controls.Add(this.ecgChoice);
            this.Controls.Add(this.textBoxEcg);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBoxEcg);
            this.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "ECG_diagnosis";
            this.Text = "ЕКГ диагностика";
            this.Load += new System.EventHandler(this.ECG_diagnosis_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEcg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxEcg;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxEcg;
        private System.Windows.Forms.ComboBox ecgChoice;
    }
}