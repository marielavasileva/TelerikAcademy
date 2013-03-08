namespace diplomna_rabota.med_forms
{
    partial class MKB1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MKB1));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Заболяване = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.мКБКодDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mKBBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.mKbDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mKbDataSet1 = new diplomna_rabota.Data_tables.MKbDataSet();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.MKBbindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mKBBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.mKBTableAdapter = new diplomna_rabota.Data_tables.MKbDataSetTableAdapters.MKBTableAdapter();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.mKBBindingSource7 = new System.Windows.Forms.BindingSource(this.components);
            this.mKbDisease = new diplomna_rabota.Data_tables.MKbDisease();
            this.mKbDataSet11 = new diplomna_rabota.Data_tables.MKbDataSet1();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.mKBBindingSource6 = new System.Windows.Forms.BindingSource(this.components);
            this.mKbCode = new diplomna_rabota.Data_tables.MKbCode();
            this.mKbDataSet2 = new diplomna_rabota.Data_tables.MKbDataSet2();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.mKBTableAdapter1 = new diplomna_rabota.Data_tables.MKbCodeTableAdapters.MKBTableAdapter();
            this.mKBTableAdapter2 = new diplomna_rabota.Data_tables.MKbDiseaseTableAdapters.MKBTableAdapter();
            this.mKbCodeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mKbDataMKB = new diplomna_rabota.Data_tables.MKbDataMKB();
            this.mKBBindingSource5 = new System.Windows.Forms.BindingSource(this.components);
            this.mKBTableAdapter3 = new diplomna_rabota.Data_tables.MKbDataMKBTableAdapters.MKBTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mKBBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mKbDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mKbDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MKBbindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mKBBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mKBBindingSource7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mKbDisease)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mKbDataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mKBBindingSource6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mKbCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mKbDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mKbCodeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mKbDataMKB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mKBBindingSource5)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Moccasin;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Заболяване,
            this.мКБКодDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.mKBBindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(0, 170);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.Size = new System.Drawing.Size(863, 182);
            this.dataGridView1.StandardTab = true;
            this.dataGridView1.TabIndex = 0;
            // 
            // Заболяване
            // 
            this.Заболяване.DataPropertyName = "Заболяване";
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Заболяване.DefaultCellStyle = dataGridViewCellStyle2;
            this.Заболяване.HeaderText = "Заболяване";
            this.Заболяване.Name = "Заболяване";
            this.Заболяване.ReadOnly = true;
            this.Заболяване.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Заболяване.Width = 700;
            // 
            // мКБКодDataGridViewTextBoxColumn
            // 
            this.мКБКодDataGridViewTextBoxColumn.DataPropertyName = "МКБ код";
            this.мКБКодDataGridViewTextBoxColumn.HeaderText = "МКБ код";
            this.мКБКодDataGridViewTextBoxColumn.Name = "мКБКодDataGridViewTextBoxColumn";
            this.мКБКодDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mKBBindingSource2
            // 
            this.mKBBindingSource2.DataMember = "MKB";
            this.mKBBindingSource2.DataSource = this.mKbDataSet1BindingSource;
            // 
            // mKbDataSet1BindingSource
            // 
            this.mKbDataSet1BindingSource.DataSource = this.mKbDataSet1;
            this.mKbDataSet1BindingSource.Position = 0;
            // 
            // mKbDataSet1
            // 
            this.mKbDataSet1.DataSetName = "MKbDataSet";
            this.mKbDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = this.mKbDataSet1;
            this.bindingSource1.Position = 0;
            // 
            // mKBBindingSource1
            // 
            this.mKBBindingSource1.DataMember = "MKB";
            // 
            // mKBTableAdapter
            // 
            this.mKBTableAdapter.ClearBeforeFill = true;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.mKBBindingSource7;
            this.comboBox1.DisplayMember = "Заболяване";
            this.comboBox1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(39, 82);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(263, 26);
            this.comboBox1.TabIndex = 6;
            this.comboBox1.ValueMember = "Заболяване";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // mKBBindingSource7
            // 
            this.mKBBindingSource7.DataMember = "MKB";
            this.mKBBindingSource7.DataSource = this.mKbDisease;
            // 
            // mKbDisease
            // 
            this.mKbDisease.DataSetName = "MKbDisease";
            this.mKbDisease.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mKbDataSet11
            // 
            this.mKbDataSet11.DataSetName = "MKbDataSet1";
            this.mKbDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.mKBBindingSource6;
            this.comboBox2.DisplayMember = "МКБ код";
            this.comboBox2.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(39, 26);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(263, 26);
            this.comboBox2.TabIndex = 7;
            this.comboBox2.ValueMember = "МКБ код";
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // mKBBindingSource6
            // 
            this.mKBBindingSource6.DataMember = "MKB";
            this.mKBBindingSource6.DataSource = this.mKbCode;
            // 
            // mKbCode
            // 
            this.mKbCode.DataSetName = "MKbCode";
            this.mKbCode.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mKbDataSet2
            // 
            this.mKbDataSet2.DataSetName = "MKbDataSet2";
            this.mKbDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(340, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 18);
            this.label1.TabIndex = 8;
            this.label1.Text = "Търсене по МКБ код";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(340, 82);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 18);
            this.label2.TabIndex = 9;
            this.label2.Text = "Търсене по заболяване";
            // 
            // mKBTableAdapter1
            // 
            this.mKBTableAdapter1.ClearBeforeFill = true;
            // 
            // mKBTableAdapter2
            // 
            this.mKBTableAdapter2.ClearBeforeFill = true;
            // 
            // mKbCodeBindingSource
            // 
            this.mKbCodeBindingSource.DataSource = this.mKbCode;
            this.mKbCodeBindingSource.Position = 0;
            // 
            // mKbDataMKB
            // 
            this.mKbDataMKB.DataSetName = "MKbDataMKB";
            this.mKbDataMKB.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mKBBindingSource5
            // 
            this.mKBBindingSource5.DataMember = "MKB";
            this.mKBBindingSource5.DataSource = this.mKbDataMKB;
            // 
            // mKBTableAdapter3
            // 
            this.mKBTableAdapter3.ClearBeforeFill = true;
            // 
            // MKB1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.BackgroundImage = global::diplomna_rabota.Properties.Resources.Picture1;
            this.ClientSize = new System.Drawing.Size(864, 353);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MKB1";
            this.Text = "МКБ";
            this.Load += new System.EventHandler(this.MKB1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mKBBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mKbDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mKbDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MKBbindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mKBBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mKBBindingSource7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mKbDisease)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mKbDataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mKBBindingSource6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mKbCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mKbDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mKbCodeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mKbDataMKB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mKBBindingSource5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Data_tables.MKbDataSet mKbDataSet1;
        private System.Windows.Forms.BindingSource MKBbindingSource;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource mKbDataSet1BindingSource;
        private System.Windows.Forms.BindingSource mKBBindingSource1;
        private Data_tables.MKbDataSetTableAdapters.MKBTableAdapter mKBTableAdapter;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.ComboBox comboBox1;
        private Data_tables.MKbDataSet1 mKbDataSet11;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Data_tables.MKbDataSet2 mKbDataSet2;
        private Data_tables.MKbCode mKbCode;
        private System.Windows.Forms.BindingSource mKBBindingSource6;
        private Data_tables.MKbCodeTableAdapters.MKBTableAdapter mKBTableAdapter1;
        private Data_tables.MKbDisease mKbDisease;
        private System.Windows.Forms.BindingSource mKBBindingSource7;
        private Data_tables.MKbDiseaseTableAdapters.MKBTableAdapter mKBTableAdapter2;
        private System.Windows.Forms.BindingSource mKBBindingSource2;
        private System.Windows.Forms.BindingSource mKbCodeBindingSource;
        private Data_tables.MKbDataMKB mKbDataMKB;
        private System.Windows.Forms.BindingSource mKBBindingSource5;
        private Data_tables.MKbDataMKBTableAdapters.MKBTableAdapter mKBTableAdapter3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Заболяване;
        private System.Windows.Forms.DataGridViewTextBoxColumn мКБКодDataGridViewTextBoxColumn;
       


        //public System.Windows.Forms.DataGridViewCellEventHandler dataGridView1_CellContentClick_1 { get; set; }
    }
}