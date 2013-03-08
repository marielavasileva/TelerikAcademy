namespace diplomna_rabota.med_forms
{
    partial class Examinations
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Examinations));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.ExCreatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BSAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OsmalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CalendarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.хатологичниИзследванияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AKRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenu});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip.Size = new System.Drawing.Size(1195, 26);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // fileMenu
            // 
            this.fileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator5,
            this.ExCreatToolStripMenuItem,
            this.BSAToolStripMenuItem,
            this.OsmalToolStripMenuItem,
            this.CalendarToolStripMenuItem,
            this.хатологичниИзследванияToolStripMenuItem,
            this.AKRToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileMenu.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fileMenu.ImageTransparentColor = System.Drawing.SystemColors.ActiveBorder;
            this.fileMenu.Name = "fileMenu";
            this.fileMenu.Size = new System.Drawing.Size(182, 22);
            this.fileMenu.Text = "Медицински изследвания";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(256, 6);
            // 
            // ExCreatToolStripMenuItem
            // 
            this.ExCreatToolStripMenuItem.Name = "ExCreatToolStripMenuItem";
            this.ExCreatToolStripMenuItem.Size = new System.Drawing.Size(259, 22);
            this.ExCreatToolStripMenuItem.Text = "Креатининов клиърънс";
            this.ExCreatToolStripMenuItem.Click += new System.EventHandler(this.ExCreatToolStripMenuItem_Click);
            // 
            // BSAToolStripMenuItem
            // 
            this.BSAToolStripMenuItem.Name = "BSAToolStripMenuItem";
            this.BSAToolStripMenuItem.Size = new System.Drawing.Size(259, 22);
            this.BSAToolStripMenuItem.Text = "BSA и BMI";
            this.BSAToolStripMenuItem.Click += new System.EventHandler(this.BSAToolStripMenuItem_Click);
            // 
            // OsmalToolStripMenuItem
            // 
            this.OsmalToolStripMenuItem.Name = "OsmalToolStripMenuItem";
            this.OsmalToolStripMenuItem.Size = new System.Drawing.Size(259, 22);
            this.OsmalToolStripMenuItem.Text = "Осмаларитет";
            this.OsmalToolStripMenuItem.Click += new System.EventHandler(this.OsmalToolStripMenuItem_Click);
            // 
            // CalendarToolStripMenuItem
            // 
            this.CalendarToolStripMenuItem.Name = "CalendarToolStripMenuItem";
            this.CalendarToolStripMenuItem.Size = new System.Drawing.Size(259, 22);
            this.CalendarToolStripMenuItem.Text = "Имунизационен календар";
            this.CalendarToolStripMenuItem.Click += new System.EventHandler(this.CalendarToolStripMenuItem_Click);
            // 
            // хатологичниИзследванияToolStripMenuItem
            // 
            this.хатологичниИзследванияToolStripMenuItem.Name = "хатологичниИзследванияToolStripMenuItem";
            this.хатологичниИзследванияToolStripMenuItem.Size = new System.Drawing.Size(259, 22);
            this.хатологичниИзследванияToolStripMenuItem.Text = "Хематологични изследвания";
            this.хатологичниИзследванияToolStripMenuItem.Click += new System.EventHandler(this.хатологичниИзследванияToolStripMenuItem_Click);
            // 
            // AKRToolStripMenuItem
            // 
            this.AKRToolStripMenuItem.Name = "AKRToolStripMenuItem";
            this.AKRToolStripMenuItem.Size = new System.Drawing.Size(259, 22);
            this.AKRToolStripMenuItem.Text = "АКР";
            this.AKRToolStripMenuItem.Click += new System.EventHandler(this.аКРToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(259, 22);
            this.exitToolStripMenuItem.Text = "Изход";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolsStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Examinations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.ClientSize = new System.Drawing.Size(1195, 622);
            this.Controls.Add(this.menuStrip);
            this.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Examinations";
            this.Text = "Изследвания";
            this.Load += new System.EventHandler(this.Examinations_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem fileMenu;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem ExCreatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem BSAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OsmalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CalendarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AKRToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem хатологичниИзследванияToolStripMenuItem;
    }
}



