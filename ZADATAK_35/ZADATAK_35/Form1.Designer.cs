namespace ZADATAK_35
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            fajlToolStripMenuItem = new ToolStripMenuItem();
            otvoriExcelToolStripMenuItem = new ToolStripMenuItem();
            otvoriSlikuToolStripMenuItem = new ToolStripMenuItem();
            otvoriWordToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            oProgramuToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fajlToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(548, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fajlToolStripMenuItem
            // 
            fajlToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { otvoriExcelToolStripMenuItem, otvoriSlikuToolStripMenuItem, otvoriWordToolStripMenuItem, exitToolStripMenuItem, oProgramuToolStripMenuItem });
            fajlToolStripMenuItem.Name = "fajlToolStripMenuItem";
            fajlToolStripMenuItem.Size = new Size(37, 20);
            fajlToolStripMenuItem.Text = "&Fajl";
            // 
            // otvoriExcelToolStripMenuItem
            // 
            otvoriExcelToolStripMenuItem.Name = "otvoriExcelToolStripMenuItem";
            otvoriExcelToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.E;
            otvoriExcelToolStripMenuItem.Size = new Size(184, 22);
            otvoriExcelToolStripMenuItem.Text = "Otvori Excel";
            otvoriExcelToolStripMenuItem.Click += otvoriExcelToolStripMenuItem_Click;
            // 
            // otvoriSlikuToolStripMenuItem
            // 
            otvoriSlikuToolStripMenuItem.Name = "otvoriSlikuToolStripMenuItem";
            otvoriSlikuToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.L;
            otvoriSlikuToolStripMenuItem.Size = new Size(184, 22);
            otvoriSlikuToolStripMenuItem.Text = "Otvori Sliku";
            otvoriSlikuToolStripMenuItem.Click += otvoriSlikuToolStripMenuItem_Click;
            // 
            // otvoriWordToolStripMenuItem
            // 
            otvoriWordToolStripMenuItem.Name = "otvoriWordToolStripMenuItem";
            otvoriWordToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.W;
            otvoriWordToolStripMenuItem.Size = new Size(184, 22);
            otvoriWordToolStripMenuItem.Text = "Otvori Word";
            otvoriWordToolStripMenuItem.Click += otvoriWordToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.X;
            exitToolStripMenuItem.Size = new Size(184, 22);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // oProgramuToolStripMenuItem
            // 
            oProgramuToolStripMenuItem.Name = "oProgramuToolStripMenuItem";
            oProgramuToolStripMenuItem.Size = new Size(184, 22);
            oProgramuToolStripMenuItem.Text = "O Programu";
            oProgramuToolStripMenuItem.Click += oProgramuToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(548, 450);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fajlToolStripMenuItem;
        private ToolStripMenuItem otvoriExcelToolStripMenuItem;
        private ToolStripMenuItem otvoriSlikuToolStripMenuItem;
        private ToolStripMenuItem otvoriWordToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem oProgramuToolStripMenuItem;
    }
}
