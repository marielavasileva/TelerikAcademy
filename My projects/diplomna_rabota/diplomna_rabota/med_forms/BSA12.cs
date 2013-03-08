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
    public partial class BSA12 : Form
    {
        public BSA12()
        {
            InitializeComponent();
        }

               

        private void CalcB_Click(object sender, EventArgs e)
        {
            try
            {
                double koef = 0.20247;
                double koef1 = 0.725;
                double koef2 = 0.425;
                double height = Double.Parse(HeightB.Text);
                int mass = Int32.Parse(MassB.Text);
                double bsa = (koef * (Math.Pow(height, koef1)) * (Math.Pow(mass, koef2)));
                BSAValue.Text = bsa.ToString();
                BSAValue = BSAb;
                BSAValue.Select();
            }
            catch (Exception)
            {
                MessageBox.Show("Моля, въвеждайте само цифрови стойности в полетата !");

            }
        }

        private void BSAb_TextChanged(object sender, EventArgs e)
        {
            BSAb = BSAValue;

        }

        

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                double bsaB = Double.Parse(BSAb.Text);
                double doseD = Double.Parse(DoseDefine.Text);
                double doseP = doseD * bsaB;
                DosePacient.Text = doseP.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Моля, въвеждайте само цифрови стойности в полетата !");

            }
        }

        private void CopyB_Click(object sender, EventArgs e)
        {
            BSAValue.Copy();
        }

        private void PasteB_Click(object sender, EventArgs e)
        {
            BSAb.Paste();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            HeightB.Clear();
            MassB.Clear();
            BSAValue.Clear();
            BSAb.Clear();
            DoseDefine.Clear();
            DosePacient.Clear();
            BSAValue.Clear();
            BMIndex.Clear();
        }
               

        private void bmi_Click(object sender, EventArgs e)
        {
            try
            {
                double height = Double.Parse(HeightB.Text);
                int mass = Int32.Parse(MassB.Text);
                double bodyMass = (mass) / (Math.Pow(height, 2));
                BMIndex.Text = bodyMass.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Моля, въвеждайте само цифрови стойности в полетата !");

            }
        }

        private void BMIndex_TextChanged(object sender, EventArgs e)
        {

        }

       
        
        
        

        
    }
}
