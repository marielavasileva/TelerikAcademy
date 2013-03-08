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
    public partial class AKR : Form
    {
        public AKR()
        {
            InitializeComponent();
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string s = "7,36";
                double Const = Double.Parse(s);
                string s1 = "7,44";
                double Const1 = Double.Parse(s1);

                double hydrogen = Double.Parse(pH.Text);
                int carbon = Int32.Parse(CO.Text);
                int stBase = Int32.Parse(SB.Text);

                if ((hydrogen >= Const) && (hydrogen <= Const1) && (stBase <= 25) && (stBase >= 21) && (carbon <= 45) && (carbon >= 35))
                {
                    result.Text = "Нормалко алкално-киселинно състояние!";
                }

                else if ((hydrogen < Const) && (carbon > 45) && (stBase <= 25) && (stBase >= 21))
                {
                    result.Text = "Състоянието е дихателна ацидоза";
                }


                else if ((hydrogen > Const1) && (carbon < 35) && (stBase <= 25) && (stBase >= 21))
                {
                    result.Text = "Състоянието е дихателна алкалоза";
                }

                else if ((hydrogen < Const) && (carbon > 45) && (stBase >= 25))
                {
                    result.Text = "Състоянието е частично компенсирана дихателна ацидоза";
                }

                else if ((hydrogen > Const1) && (carbon < 35) && (stBase < 21))
                {
                    result.Text = "Състоянието е частично компенсирана дихателна алкалоза";
                }

                else if ((hydrogen < Const) && (stBase < 21) && (carbon <= 45) && (carbon >= 35))
                {
                    result.Text = "Състоянието е метаболитна ацидоза ";
                }

                else if ((hydrogen > Const1) && (stBase > 25) && (carbon <= 45) && (carbon >= 35))
                {
                    result.Text = "Състоянието е метаболитна алкалоза";
                }

                else if ((hydrogen < Const) && (stBase < 21) && (carbon < 35))
                {
                    result.Text = "Състоянието е частично компенсирана метаболитна ацидоза";
                }

                else if ((hydrogen > Const1) && (stBase > 25) && (carbon > 45))
                {
                    result.Text = "Състоянието е частично компенсирана метаболитна алкалоза";
                }

                else if ((hydrogen < Const) && (stBase < 21) && (carbon > 45))
                {
                    result.Text = "Състоянието е смесена ацидоза";
                }

                else if ((hydrogen <= Const1) && (hydrogen > Const) && (stBase > 25) && (carbon > 45))
                {
                    result.Text = "Комплексно състояние";
                }

                else
                {
                    result.Text = "Моля коригирайте данните или направете повторно изследване!";
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Моля, въвеждайте само цифрови стойности в полетата !");

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pH.Clear();
            CO.Clear();
            SB.Clear();
            result.Clear();
        }

        private void AKR_Load(object sender, EventArgs e)
        {

        }

        


       
    }
}
