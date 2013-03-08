namespace diplomna_rabota.med_forms
{
    partial class Drugs
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label генерично_имеLabel1;
            System.Windows.Forms.Label търговско_имеLabel1;
            System.Windows.Forms.Label производителLabel1;
            System.Windows.Forms.Label лекарствена_формаLabel1;
            System.Windows.Forms.Label нЗОК_кодLabel;
            System.Windows.Forms.Label групи_терапевтични_агентиLabel1;
            System.Windows.Forms.Label механизъм_на_действиеLabel1;
            System.Windows.Forms.Label нежелани_лекарствени_действияLabel1;
            System.Windows.Forms.Label специални_противопоказанияLabel1;
            System.Windows.Forms.Label кратка_лекарствена_характеристикаLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Drugs));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.drugsDataSet5 = new diplomna_rabota.Data_tables.DrugsDataSet5();
            this.drugsTableAdapter1 = new diplomna_rabota.Data_tables.DrugsDataSet5TableAdapters.DrugsTableAdapter();
            this.tableAdapterManager1 = new diplomna_rabota.Data_tables.DrugsDataSet5TableAdapters.TableAdapterManager();
            this.генерично_имеTextBox1 = new System.Windows.Forms.TextBox();
            this.търговско_имеTextBox1 = new System.Windows.Forms.TextBox();
            this.производителTextBox1 = new System.Windows.Forms.TextBox();
            this.лекарствена_формаTextBox1 = new System.Windows.Forms.TextBox();
            this.нЗОК_кодTextBox1 = new System.Windows.Forms.TextBox();
            this.групи_терапевтични_агентиTextBox1 = new System.Windows.Forms.TextBox();
            this.механизъм_на_действиеTextBox1 = new System.Windows.Forms.TextBox();
            this.нежелани_лекарствени_действияTextBox1 = new System.Windows.Forms.TextBox();
            this.специални_противопоказанияTextBox1 = new System.Windows.Forms.TextBox();
            this.кратка_лекарствена_характеристикаTextBox1 = new System.Windows.Forms.TextBox();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            генерично_имеLabel1 = new System.Windows.Forms.Label();
            търговско_имеLabel1 = new System.Windows.Forms.Label();
            производителLabel1 = new System.Windows.Forms.Label();
            лекарствена_формаLabel1 = new System.Windows.Forms.Label();
            нЗОК_кодLabel = new System.Windows.Forms.Label();
            групи_терапевтични_агентиLabel1 = new System.Windows.Forms.Label();
            механизъм_на_действиеLabel1 = new System.Windows.Forms.Label();
            нежелани_лекарствени_действияLabel1 = new System.Windows.Forms.Label();
            специални_противопоказанияLabel1 = new System.Windows.Forms.Label();
            кратка_лекарствена_характеристикаLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.drugsDataSet5)).BeginInit();
            this.SuspendLayout();
            // 
            // генерично_имеLabel1
            // 
            генерично_имеLabel1.AutoSize = true;
            генерично_имеLabel1.Location = new System.Drawing.Point(87, 39);
            генерично_имеLabel1.Name = "генерично_имеLabel1";
            генерично_имеLabel1.Size = new System.Drawing.Size(99, 17);
            генерично_имеLabel1.TabIndex = 21;
            генерично_имеLabel1.Text = "Генерично име:";
            // 
            // търговско_имеLabel1
            // 
            търговско_имеLabel1.AutoSize = true;
            търговско_имеLabel1.Location = new System.Drawing.Point(88, 86);
            търговско_имеLabel1.Name = "търговско_имеLabel1";
            търговско_имеLabel1.Size = new System.Drawing.Size(98, 17);
            търговско_имеLabel1.TabIndex = 22;
            търговско_имеLabel1.Text = "Търговско име:";
            // 
            // производителLabel1
            // 
            производителLabel1.AutoSize = true;
            производителLabel1.Location = new System.Drawing.Point(89, 145);
            производителLabel1.Name = "производителLabel1";
            производителLabel1.Size = new System.Drawing.Size(97, 17);
            производителLabel1.TabIndex = 23;
            производителLabel1.Text = "Производител:";
            // 
            // лекарствена_формаLabel1
            // 
            лекарствена_формаLabel1.AutoSize = true;
            лекарствена_формаLabel1.Location = new System.Drawing.Point(62, 199);
            лекарствена_формаLabel1.Name = "лекарствена_формаLabel1";
            лекарствена_формаLabel1.Size = new System.Drawing.Size(124, 17);
            лекарствена_формаLabel1.TabIndex = 24;
            лекарствена_формаLabel1.Text = "Лекарствена форма:";
            // 
            // нЗОК_кодLabel
            // 
            нЗОК_кодLabel.AutoSize = true;
            нЗОК_кодLabel.Location = new System.Drawing.Point(116, 245);
            нЗОК_кодLabel.Name = "нЗОК_кодLabel";
            нЗОК_кодLabel.Size = new System.Drawing.Size(70, 17);
            нЗОК_кодLabel.TabIndex = 25;
            нЗОК_кодLabel.Text = "НЗОК код:";
            // 
            // групи_терапевтични_агентиLabel1
            // 
            групи_терапевтични_агентиLabel1.AutoSize = true;
            групи_терапевтични_агентиLabel1.Location = new System.Drawing.Point(13, 311);
            групи_терапевтични_агентиLabel1.Name = "групи_терапевтични_агентиLabel1";
            групи_терапевтични_агентиLabel1.Size = new System.Drawing.Size(173, 17);
            групи_терапевтични_агентиLabel1.TabIndex = 26;
            групи_терапевтични_агентиLabel1.Text = "Групи терапевтични агенти:";
            // 
            // механизъм_на_действиеLabel1
            // 
            механизъм_на_действиеLabel1.AutoSize = true;
            механизъм_на_действиеLabel1.Location = new System.Drawing.Point(541, 25);
            механизъм_на_действиеLabel1.Name = "механизъм_на_действиеLabel1";
            механизъм_на_действиеLabel1.Size = new System.Drawing.Size(151, 17);
            механизъм_на_действиеLabel1.TabIndex = 27;
            механизъм_на_действиеLabel1.Text = "Механизъм на действие:";
            // 
            // нежелани_лекарствени_действияLabel1
            // 
            нежелани_лекарствени_действияLabel1.AutoSize = true;
            нежелани_лекарствени_действияLabel1.Location = new System.Drawing.Point(490, 149);
            нежелани_лекарствени_действияLabel1.Name = "нежелани_лекарствени_действияLabel1";
            нежелани_лекарствени_действияLabel1.Size = new System.Drawing.Size(202, 17);
            нежелани_лекарствени_действияLabel1.TabIndex = 28;
            нежелани_лекарствени_действияLabel1.Text = "Нежелани лекарствени действия:";
            // 
            // специални_противопоказанияLabel1
            // 
            специални_противопоказанияLabel1.AutoSize = true;
            специални_противопоказанияLabel1.Location = new System.Drawing.Point(504, 311);
            специални_противопоказанияLabel1.Name = "специални_противопоказанияLabel1";
            специални_противопоказанияLabel1.Size = new System.Drawing.Size(188, 17);
            специални_противопоказанияLabel1.TabIndex = 29;
            специални_противопоказанияLabel1.Text = "Специални противопоказания:";
            // 
            // кратка_лекарствена_характеристикаLabel
            // 
            кратка_лекарствена_характеристикаLabel.AutoSize = true;
            кратка_лекарствена_характеристикаLabel.Location = new System.Drawing.Point(476, 414);
            кратка_лекарствена_характеристикаLabel.Name = "кратка_лекарствена_характеристикаLabel";
            кратка_лекарствена_характеристикаLabel.Size = new System.Drawing.Size(216, 17);
            кратка_лекарствена_характеристикаLabel.TabIndex = 30;
            кратка_лекарствена_характеристикаLabel.Text = "Кратка лекарствена характеристика:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn15,
            this.dataGridViewTextBoxColumn16,
            this.dataGridViewTextBoxColumn17,
            this.dataGridViewTextBoxColumn18,
            this.dataGridViewTextBoxColumn19,
            this.dataGridViewTextBoxColumn20});
            this.dataGridView1.DataSource = this.bindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(1, 466);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1129, 195);
            this.dataGridView1.TabIndex = 0;
            // 
            // bindingSource2
            // 
            this.bindingSource2.DataMember = "Drugs";
            this.bindingSource2.DataSource = this.drugsDataSet5;
            this.bindingSource2.CurrentChanged += new System.EventHandler(this.bindingSource2_CurrentChanged);
            // 
            // drugsDataSet5
            // 
            this.drugsDataSet5.DataSetName = "DrugsDataSet5";
            this.drugsDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // drugsTableAdapter1
            // 
            this.drugsTableAdapter1.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.DrugsTableAdapter = this.drugsTableAdapter1;
            this.tableAdapterManager1.UpdateOrder = diplomna_rabota.Data_tables.DrugsDataSet5TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // генерично_имеTextBox1
            // 
            this.генерично_имеTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource2, "Генерично име", true));
            this.генерично_имеTextBox1.Location = new System.Drawing.Point(210, 39);
            this.генерично_имеTextBox1.Name = "генерично_имеTextBox1";
            this.генерично_имеTextBox1.Size = new System.Drawing.Size(144, 24);
            this.генерично_имеTextBox1.TabIndex = 22;
            // 
            // търговско_имеTextBox1
            // 
            this.търговско_имеTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource2, "Търговско име", true));
            this.търговско_имеTextBox1.Location = new System.Drawing.Point(210, 86);
            this.търговско_имеTextBox1.Name = "търговско_имеTextBox1";
            this.търговско_имеTextBox1.Size = new System.Drawing.Size(144, 24);
            this.търговско_имеTextBox1.TabIndex = 23;
            // 
            // производителTextBox1
            // 
            this.производителTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource2, "Производител", true));
            this.производителTextBox1.Location = new System.Drawing.Point(210, 142);
            this.производителTextBox1.Name = "производителTextBox1";
            this.производителTextBox1.Size = new System.Drawing.Size(144, 24);
            this.производителTextBox1.TabIndex = 24;
            // 
            // лекарствена_формаTextBox1
            // 
            this.лекарствена_формаTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource2, "Лекарствена форма", true));
            this.лекарствена_формаTextBox1.Location = new System.Drawing.Point(210, 192);
            this.лекарствена_формаTextBox1.Name = "лекарствена_формаTextBox1";
            this.лекарствена_формаTextBox1.Size = new System.Drawing.Size(144, 24);
            this.лекарствена_формаTextBox1.TabIndex = 25;
            // 
            // нЗОК_кодTextBox1
            // 
            this.нЗОК_кодTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource2, "НЗОК код", true));
            this.нЗОК_кодTextBox1.Location = new System.Drawing.Point(210, 245);
            this.нЗОК_кодTextBox1.Name = "нЗОК_кодTextBox1";
            this.нЗОК_кодTextBox1.Size = new System.Drawing.Size(144, 24);
            this.нЗОК_кодTextBox1.TabIndex = 26;
            // 
            // групи_терапевтични_агентиTextBox1
            // 
            this.групи_терапевтични_агентиTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource2, "Групи терапевтични агенти", true));
            this.групи_терапевтични_агентиTextBox1.Location = new System.Drawing.Point(210, 304);
            this.групи_терапевтични_агентиTextBox1.Name = "групи_терапевтични_агентиTextBox1";
            this.групи_терапевтични_агентиTextBox1.Size = new System.Drawing.Size(144, 24);
            this.групи_терапевтични_агентиTextBox1.TabIndex = 27;
            // 
            // механизъм_на_действиеTextBox1
            // 
            this.механизъм_на_действиеTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource2, "Механизъм на действие", true));
            this.механизъм_на_действиеTextBox1.Location = new System.Drawing.Point(774, 18);
            this.механизъм_на_действиеTextBox1.Multiline = true;
            this.механизъм_на_действиеTextBox1.Name = "механизъм_на_действиеTextBox1";
            this.механизъм_на_действиеTextBox1.Size = new System.Drawing.Size(290, 112);
            this.механизъм_на_действиеTextBox1.TabIndex = 28;
            // 
            // нежелани_лекарствени_действияTextBox1
            // 
            this.нежелани_лекарствени_действияTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource2, "Нежелани лекарствени действия", true));
            this.нежелани_лекарствени_действияTextBox1.Location = new System.Drawing.Point(774, 149);
            this.нежелани_лекарствени_действияTextBox1.Multiline = true;
            this.нежелани_лекарствени_действияTextBox1.Name = "нежелани_лекарствени_действияTextBox1";
            this.нежелани_лекарствени_действияTextBox1.Size = new System.Drawing.Size(290, 113);
            this.нежелани_лекарствени_действияTextBox1.TabIndex = 29;
            // 
            // специални_противопоказанияTextBox1
            // 
            this.специални_противопоказанияTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource2, "Специални противопоказания", true));
            this.специални_противопоказанияTextBox1.Location = new System.Drawing.Point(774, 292);
            this.специални_противопоказанияTextBox1.Multiline = true;
            this.специални_противопоказанияTextBox1.Name = "специални_противопоказанияTextBox1";
            this.специални_противопоказанияTextBox1.Size = new System.Drawing.Size(290, 90);
            this.специални_противопоказанияTextBox1.TabIndex = 30;
            // 
            // кратка_лекарствена_характеристикаTextBox1
            // 
            this.кратка_лекарствена_характеристикаTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource2, "Кратка лекарствена характеристика", true));
            this.кратка_лекарствена_характеристикаTextBox1.Location = new System.Drawing.Point(774, 414);
            this.кратка_лекарствена_характеристикаTextBox1.Name = "кратка_лекарствена_характеристикаTextBox1";
            this.кратка_лекарствена_характеристикаTextBox1.Size = new System.Drawing.Size(290, 24);
            this.кратка_лекарствена_характеристикаTextBox1.TabIndex = 31;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "Генерично име";
            this.dataGridViewTextBoxColumn11.HeaderText = "Генерично име";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "Търговско име";
            this.dataGridViewTextBoxColumn12.HeaderText = "Търговско име";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "Производител";
            this.dataGridViewTextBoxColumn13.HeaderText = "Производител";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "Лекарствена форма";
            this.dataGridViewTextBoxColumn14.HeaderText = "Лекарствена форма";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "НЗОК код";
            this.dataGridViewTextBoxColumn15.HeaderText = "НЗОК код";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.DataPropertyName = "Групи терапевтични агенти";
            this.dataGridViewTextBoxColumn16.HeaderText = "Групи терапевтични агенти";
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.DataPropertyName = "Механизъм на действие";
            this.dataGridViewTextBoxColumn17.HeaderText = "Механизъм на действие";
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            // 
            // dataGridViewTextBoxColumn18
            // 
            this.dataGridViewTextBoxColumn18.DataPropertyName = "Нежелани лекарствени действия";
            this.dataGridViewTextBoxColumn18.HeaderText = "Нежелани лекарствени действия";
            this.dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
            // 
            // dataGridViewTextBoxColumn19
            // 
            this.dataGridViewTextBoxColumn19.DataPropertyName = "Специални противопоказания";
            this.dataGridViewTextBoxColumn19.HeaderText = "Специални противопоказания";
            this.dataGridViewTextBoxColumn19.Name = "dataGridViewTextBoxColumn19";
            // 
            // dataGridViewTextBoxColumn20
            // 
            this.dataGridViewTextBoxColumn20.DataPropertyName = "Кратка лекарствена характеристика";
            this.dataGridViewTextBoxColumn20.HeaderText = "Кратка лекарствена характеристика";
            this.dataGridViewTextBoxColumn20.Name = "dataGridViewTextBoxColumn20";
            this.dataGridViewTextBoxColumn20.Width = 180;
            // 
            // Drugs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(1131, 663);
            this.Controls.Add(кратка_лекарствена_характеристикаLabel);
            this.Controls.Add(this.кратка_лекарствена_характеристикаTextBox1);
            this.Controls.Add(специални_противопоказанияLabel1);
            this.Controls.Add(this.специални_противопоказанияTextBox1);
            this.Controls.Add(нежелани_лекарствени_действияLabel1);
            this.Controls.Add(this.нежелани_лекарствени_действияTextBox1);
            this.Controls.Add(механизъм_на_действиеLabel1);
            this.Controls.Add(this.механизъм_на_действиеTextBox1);
            this.Controls.Add(групи_терапевтични_агентиLabel1);
            this.Controls.Add(this.групи_терапевтични_агентиTextBox1);
            this.Controls.Add(нЗОК_кодLabel);
            this.Controls.Add(this.нЗОК_кодTextBox1);
            this.Controls.Add(лекарствена_формаLabel1);
            this.Controls.Add(this.лекарствена_формаTextBox1);
            this.Controls.Add(производителLabel1);
            this.Controls.Add(this.производителTextBox1);
            this.Controls.Add(търговско_имеLabel1);
            this.Controls.Add(this.търговско_имеTextBox1);
            this.Controls.Add(генерично_имеLabel1);
            this.Controls.Add(this.генерично_имеTextBox1);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "Drugs";
            this.Text = "Лекарствени средства";
            this.Load += new System.EventHandler(this.Drugs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.drugsDataSet5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;

        private Data_tables.DrugsDataSet5 drugsDataSet5;
        private System.Windows.Forms.BindingSource bindingSource2;
        private Data_tables.DrugsDataSet5TableAdapters.DrugsTableAdapter drugsTableAdapter1;
        private Data_tables.DrugsDataSet5TableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.TextBox генерично_имеTextBox1;
        private System.Windows.Forms.TextBox търговско_имеTextBox1;
        private System.Windows.Forms.TextBox производителTextBox1;
        private System.Windows.Forms.TextBox лекарствена_формаTextBox1;
        private System.Windows.Forms.TextBox нЗОК_кодTextBox1;
        private System.Windows.Forms.TextBox групи_терапевтични_агентиTextBox1;
        private System.Windows.Forms.TextBox механизъм_на_действиеTextBox1;
        private System.Windows.Forms.TextBox нежелани_лекарствени_действияTextBox1;
        private System.Windows.Forms.TextBox специални_противопоказанияTextBox1;
        private System.Windows.Forms.TextBox кратка_лекарствена_характеристикаTextBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn19;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn20;
    }
}