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
    public partial class Osmola : Form
    {
        public Osmola()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int na = Int32.Parse(Na.Text);
                double k = Double.Parse(K.Text);
                int urea = Int32.Parse(Urea.Text);
                double glucose = Double.Parse(Glucose.Text);
                double osmolality = (2 * (na + k)) + urea + glucose;
                Osmolality.Text = osmolality.ToString();

                if (osmolality <= 275)
                {
                    resultOsmo.Text = "Състоянието е хиперхидратация !";
                }

                else if (osmolality >= 295)
                {
                    resultOsmo.Text = "Състоянието е дехидратация!";
                }

                else if ((osmolality >= 275) && (osmolality <= 295))
                {
                    resultOsmo.Text = "Нормално състояние!";                                }
            }
            catch (Exception)
            {
                MessageBox.Show("Моля, въвеждайте само цифрови стойности в полетата !");

            }
        }

        private void Osmola_Load(object sender, EventArgs e)
        {

        }

        
    }
}
