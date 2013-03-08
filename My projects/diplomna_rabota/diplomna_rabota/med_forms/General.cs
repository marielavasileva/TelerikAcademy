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
    public partial class General : Form
    {
        public General()
        {
            InitializeComponent();
        }

        
        private void button4_Click_1(object sender, EventArgs e)
        {
            Examinations exam = new Examinations();
            exam.ShowDialog();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            MKB1 mkb = new MKB1();
            mkb.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Medicines medForm = new Medicines();
            medForm.ShowDialog();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            ECG_diagnosis ecgForm = new ECG_diagnosis();
            ecgForm.ShowDialog();
        
        }

              
    }
}
