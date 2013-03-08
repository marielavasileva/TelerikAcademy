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
    public partial class NEwMedicine : Form
    {
        public NEwMedicine()
        {
            InitializeComponent();
            this.terapyAgentcombo.SelectedIndex = 0;
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void addMedicine_Click(object sender, EventArgs e)
        {
            Drug obj = new Drug ();
            obj.GenericName=this.genericBox.Text;
            obj.MedicineName=this.nameBox.Text;
            obj.Producer=this.prodBox.Text;
            obj.MedForm = this.medicineBox.Text;
            obj.NZOKCode= this.codeBox.Text;
            obj.Action= this.actionBox.Text;
            obj.SideEffect=this.sideEffectBox.Text;
            obj.ContraIndication=this.contraIndicationBox.Text;
            obj.MedicineDescrip=this.medicineDescripBox.Text;
            obj.TerapyAgent=(string)(this.terapyAgentcombo.Text !="" ? this.terapyAgentcombo.Text : "");

            try
            {
                NewMedicineValidation.validateMedicine(obj);
            }

            catch(NewMedicineValidationException exc)
            {
                 MessageBox.Show(exc.Message);
                return;

            }

            try
            {
                NewMedicineData.addMedicine(obj);
                MessageBox.Show("Медикаментът беше добавен успешно!");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Неуспешно добавяне: " + ex.Message);
            }


        }

        private void NEwMedicine_Load(object sender, EventArgs e)
        {

        }


            }
}     

            
           

         

            
        