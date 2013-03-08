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
    public partial class Medicines : Form
    {
        public Medicines()
        {
            InitializeComponent();
        }       

       

         
        private void покажиВсичкиМедикаментиToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Drugs drug1 = new Drugs();
            drug1.ShowDialog();
        }

        private void добавиНовМедикаментToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NEwMedicine nMed = new NEwMedicine();
            nMed.ShowDialog();
        }

        

        private void Medicines_Load(object sender, EventArgs e)
        {
            
            this.drugsTableAdapterTerapy.Fill(this.drugsDataSetTerapy.Drugs);
           
            this.drugsTableAdapterGen.Fill(this.drugsDataSetGen.Drugs);
            
            this.drugsTableAdapterRpodname.Fill(this.drugsDataSetProdname.Drugs);
           
            this.drugsTableAdapterDrug.Fill(this.drugsDataSetDrug.Drugs);
            
            this.drugsTableAdapter.Fill(this.drugsDataSet.Drugs);
            
            this.drugsTableAdapterKod.Fill(this.drugsDataSetKod.Drugs);
            
            this.drugsTableAdapGeneric.Fill(this.drugsDataGeneric.Drugs);
            
            this.drugsTableAdapterName.Fill(this.drugsDataName.Drugs);
            
            this.drugsTableKod.Fill(this.drugsDataKod.Drugs);
            
            this.drugsTableImnicM.Fill(this.drugsDataIndicM.Drugs);
          
            this.drugsTableAdapterIndications.Fill(this.drugsDataSetIndication.Drugs);
            // TODO: This line of code loads data into the 'drugsDataIndication.Drugs' table. You can move, or remove it, as needed.
            this.drugsTableAdapterIndication.Fill(this.drugsIndication.Drugs);
            // TODO: This line of code loads data into the 'drugsDataSetMedicine.Drugs' table. You can move, or remove it, as needed.
            this.drugsTableAdapterMedicine.Fill(this.drugsDataSetMedicine.Drugs);
            // TODO: This line of code loads data into the 'drugsDataSetReaction.Drugs' table. You can move, or remove it, as needed.
            this.drugsTableAdapterReaction.Fill(this.drugsDataSetReaction.Drugs);
            // TODO: This line of code loads data into the 'drugsReactions.Drugs' table. You can move, or remove it, as needed.
            this.drugsTableAdapterReactions.Fill(this.drugsReactions.Drugs);
            // TODO: This line of code loads data into the 'drugsDataActivity.Drugs' table. You can move, or remove it, as needed.
            this.drugsTableAdapterAction.Fill(this.drugsDataActivity.Drugs);
            // TODO: This line of code loads data into the 'drugsActivity.Drugs' table. You can move, or remove it, as needed.
            this.drugsTableAdapterActivity.Fill(this.drugsActivity.Drugs);
            
        }
          

        
        
        

        

        

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                this.drugsTableAdapterActivity.FillBy(this.drugsActivity.Drugs, ((string)(System.Convert.ChangeType(this.actionCombo.Text, typeof(string)))));
            }
            catch (System.Exception)
            {
                //Show all the data when the group filter query is invalid..
                this.drugsTableAdapterActivity.Fill(this.drugsActivity.Drugs);
            }
            reaction.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            reaction.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        private void reaction_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                this.drugsTableAdapterReactions.FillByReaction(this.drugsReactions.Drugs, ((string)(System.Convert.ChangeType(this.reaction.Text, typeof(string)))));
            }
            catch (System.Exception)
            {
                //Show all the data when the group filter query is invalid..
                this.drugsTableAdapterReactions.Fill(this.drugsReactions.Drugs);
            }
            reaction.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            reaction.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        private void medicine_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                this.drugsTableAdapterReactions.FillByMedicine(this.drugsReactions.Drugs, ((string)(System.Convert.ChangeType(this.medicine.Text, typeof(string)))));
            }
            catch (System.Exception)
            {
                //Show all the data when the group filter query is invalid..
                this.drugsTableAdapterReactions.Fill(this.drugsReactions.Drugs);
            }
            medicine.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            medicine.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

       

        private void indication_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            try
            {
                this.drugsTableAdapterIndication.FillByIndication(this.drugsIndication.Drugs, ((string)(System.Convert.ChangeType(this.indication.Text, typeof(string)))));
            }
            catch (System.Exception)
            {
                //Show all the data when the group filter query is invalid..
                this.drugsTableAdapterIndication.Fill(this.drugsIndication.Drugs);
            }
            indication.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            indication.AutoCompleteSource = AutoCompleteSource.ListItems;
        

        }    

        
        private void medicineG_SelectedIndexChanged_1(object sender, EventArgs e)
        {
             try
            {
                this.drugsTableAdapterIndication.FillByMedicineG(this.drugsIndication.Drugs, ((string)(System.Convert.ChangeType(this.medicineG.Text, typeof(string)))));
            }
            catch (System.Exception)
            {
                //Show all the data when the group filter query is invalid..
                this.drugsTableAdapterIndication.Fill(this.drugsIndication.Drugs);
            }
            medicineG.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            medicineG.AutoCompleteSource = AutoCompleteSource.ListItems;


        
        } 

       

        

        private void name_SelectedIndexChanged(object sender, EventArgs e)
        {
             try
            {
                this.drugsTableKod.FillByName(this.drugsDataKod.Drugs, ((string)(System.Convert.ChangeType(this.name.Text, typeof(string)))));
            }
            catch (System.Exception)
            {
                //Show all the data when the group filter query is invalid..
                this.drugsTableKod.Fill(this.drugsDataKod.Drugs);
            }
            name.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            name.AutoCompleteSource = AutoCompleteSource.ListItems;


        
        }

        private void generic_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                this.drugsTableKod.FillByGeneric(this.drugsDataKod.Drugs, ((string)(System.Convert.ChangeType(this.generic.Text, typeof(string)))));
            }
            catch (System.Exception)
            {
                //Show all the data when the group filter query is invalid..
                this.drugsTableKod.Fill(this.drugsDataKod.Drugs);
            }
            generic.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            generic.AutoCompleteSource = AutoCompleteSource.ListItems;

        }

        private void code_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                this.drugsTableKod.FillByCode(this.drugsDataKod.Drugs, ((string)(System.Convert.ChangeType(this.code.Text, typeof(string)))));
            }
            catch (System.Exception)
            {
                //Show all the data when the group filter query is invalid..
                this.drugsTableKod.Fill(this.drugsDataKod.Drugs);
            }
            code.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            code.AutoCompleteSource = AutoCompleteSource.ListItems;
        }
              

        
        

        private void gename_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            try
            {
                this.drugsTableAdapterDrug.FillByDrug1(this.drugsDataSetDrug.Drugs, ((string)(System.Convert.ChangeType(this.gename.Text, typeof(string)))));
            }
            catch (System.Exception)
            {
                this.drugsTableAdapterDrug.Fill(this.drugsDataSetDrug.Drugs);
            }
            gename.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            gename.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        private void terapy_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            try
            {
                this.drugsTableAdapterDrug.FillByTerapy(this.drugsDataSetDrug.Drugs, ((string)(System.Convert.ChangeType(this.terapy.Text, typeof(string)))));
            }
            catch (System.Exception)
            {
                this.drugsTableAdapterDrug.Fill(this.drugsDataSetDrug.Drugs);
            }
            terapy.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            terapy.AutoCompleteSource = AutoCompleteSource.ListItems;

        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

       
        

       

       
            
        
}

        }

        

        

        
        

        

        

       

        

       


        
        
    

