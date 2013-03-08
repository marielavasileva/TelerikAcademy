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
    public partial class MKB1 : Form
    {
        public MKB1()
        {
            InitializeComponent();
        }
  
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void MKB1_Load(object sender, EventArgs e)
        {
                        
            // TODO: This line of code loads data into the 'mKbDataMKB.MKB' table. You can move, or remove it, as needed.
            this.mKBTableAdapter3.Fill(this.mKbDataMKB.MKB);
            // TODO: This line of code loads data into the 'mKbDisease.MKB' table. You can move, or remove it, as needed.
            this.mKBTableAdapter2.Fill(this.mKbDisease.MKB);
            // TODO: This line of code loads data into the 'mKbCode.MKB' table. You can move, or remove it, as needed.
            this.mKBTableAdapter1.Fill(this.mKbCode.MKB);
            this.mKBTableAdapter.Fill(this.mKbDataSet1.MKB);
        }
               

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                this.mKBTableAdapter.FillBy1(this.mKbDataSet1.MKB, ((string)(System.Convert.ChangeType(this.comboBox1.Text, typeof(string)))));
            }
            catch (System.Exception)
            {
                
                this.mKBTableAdapter.Fill(this.mKbDataSet1.MKB);
            }
            comboBox1.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBox1.AutoCompleteSource = AutoCompleteSource.ListItems;



        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                this.mKBTableAdapter.FillBy(this.mKbDataSet1.MKB, ((string)(System.Convert.ChangeType(this.comboBox2.Text, typeof(string)))));
            }
            catch (System.Exception)
            {
                //Show all the data when the group filter query is invalid..
                this.mKBTableAdapter.Fill(this.mKbDataSet1.MKB);
            }

            comboBox2.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBox2.AutoCompleteSource = AutoCompleteSource.ListItems;
        }          

        
        }
    }






       

       