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
    public partial class ExCreat1 : Form
    {
        public ExCreat1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                double koef = 140.0d;
                double koef1 = 72.0d;
                int wei = Int32.Parse(Weight.Text);
                int ag = Int32.Parse(Age.Text);
                int ser = Int32.Parse(Serum.Text);
                double cr_cl = (((koef - ag) * wei) / (koef1 * ser)) * 85;

                CR_CL.Text = cr_cl.ToString("0.00");


                if ((cr_cl <= 60) && (cr_cl > 25))
                {
                    resultCr.Text = "Първа степен бъбречна недостатъчност!";
                }

                else if ((cr_cl <= 25) && (cr_cl > 10))
                {
                    resultCr.Text = "Втора степен бъбречна недостатъчност!";
                }

                else if ((cr_cl <= 10) && (cr_cl > 5))
                {
                    resultCr.Text = "Трета степен бъбречна недостатъчност!";
                }

                else if ((cr_cl <= 5) && (cr_cl < 0))
                {
                    resultCr.Text = "Четвърта степен бъбречна недостатъчност!";
                }

                else
                {
                    resultCr.Text = "Стойностите са в нормалните граници !";
                }
            }
            catch (Exception )
            {
                MessageBox.Show("Моля, въвеждайте само цифрови стойности в полетата !");
            }

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                double koef = 140.0d;
                double koef1 = 72.0d;
                int wei = Int32.Parse(Weight.Text);
                int ag = Int32.Parse(Age.Text);
                int ser = Int32.Parse(Serum.Text);
                double cr_cl = Double.Parse(CR_CL.Text);
                cr_cl = (((koef - ag) * wei) / (koef1 * ser)) * 100;
                CR_CL.Text = cr_cl.ToString("0.00");


                if ((cr_cl <= 60) && (cr_cl > 25))
                {
                    resultCr.Text = "Първа степен бъбречна недостатъчност!";
                }

                else if ((cr_cl <= 25) && (cr_cl > 10))
                {
                    resultCr.Text = "Втора степен бъбречна недостатъчност!";
                }

                else if ((cr_cl <= 10) && (cr_cl > 5))
                {
                    resultCr.Text = "Трета степен бъбречна недостатъчност!";
                }

                else if ((cr_cl <= 5) && (cr_cl < 0))
                {
                    resultCr.Text = "Четвърта степен бъбречна недостатъчност!";
                }

                else
                {
                    resultCr.Text = "Стойностите са в нормалните граници !";
                }
            }
            catch(Exception)
            {
                MessageBox.Show("Моля, въвеждайте само цифрови стойности в полетата !");
            
            }
        }

        private void CR_CL_TextChanged(object sender, EventArgs e)
        {

        }

        
        



    }
}