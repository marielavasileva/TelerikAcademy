using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace diplomna_rabota.med_forms
{
    public partial class Drugs : Form
    {
        public Drugs()
        {
            InitializeComponent();
        }

        private void Drugs_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'drugsDataSet5.Drugs' table. You can move, or remove it, as needed.
            this.drugsTableAdapter1.Fill(this.drugsDataSet5.Drugs);
            // TODO: This line of code loads data into the 'drugsDataSet1.Drugs' table. You can move, or remove it, as needed.
            
            // TODO: This line of code loads data into the 'drugsDataSet1.Drugs' table. You can move, or remove it, as needed.
            //this.drugsTableAdapter.Fill(this.drugsDataSet1.Drugs);

        }

        private void кратка_лекарствена_характеристикаTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void bindingSource2_CurrentChanged(object sender, EventArgs e)
        {

        }

        
        
    }
}
