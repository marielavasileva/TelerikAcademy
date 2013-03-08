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
    public partial class Examinations : Form
    {
        

        public Examinations()
        {
            InitializeComponent();
        }

        

        

        

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
          
        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void ExCreatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExCreat1 newMDIChild = new ExCreat1();
            // Set the Parent Form of the Child window.
            newMDIChild.MdiParent = this;
            // Display the new form.
            newMDIChild.Show();
        }

        private void BSAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BSA12 newMDIChild1 = new BSA12();
            // Set the Parent Form of the Child window.
            newMDIChild1.MdiParent = this;
            // Display the new form.
            newMDIChild1.Show();
        }

        private void CalendarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Imunne newMDIChild2 = new Imunne();
            // Set the Parent Form of the Child window.
            newMDIChild2.MdiParent = this;
            // Display the new form.
            newMDIChild2.Show();
        }

        private void OsmalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Osmola newMDIChild3 = new Osmola();
            // Set the Parent Form of the Child window.
            newMDIChild3.MdiParent = this;
            // Display the new form.
            newMDIChild3.Show();
        }

        private void аКРToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AKR newMDIChild4 = new AKR();
            // Set the Parent Form of the Child window.
            newMDIChild4.MdiParent = this;
            // Display the new form.
            newMDIChild4.Show();
        }

        private void хатологичниИзследванияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bloodExamin newMDIChild5 = new bloodExamin();
            newMDIChild5.MdiParent = this;
            // Display the new form.
            newMDIChild5.Show();
        }

        private void Examinations_Load(object sender, EventArgs e)
        {

        }        
    }
}
