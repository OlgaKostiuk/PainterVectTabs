namespace PainterVect
{
    partial class Form1
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
            this.toolBox1 = new PainterVect.ToolBox.ToolBox();
            this.statusBar1 = new PainterVect.StatusBar.StatusBar();
            this.toolBar1 = new PainterVect.ToolBar.ToolBar();
            this.mainMenu1 = new PainterVect.MainMenu();
            this.pTabControl1 = new PainterVect.PTabControl();
            this.SuspendLayout();
            // 
            // toolBox1
            // 
            this.toolBox1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.toolBox1.cmd = null;
            this.toolBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.toolBox1.Location = new System.Drawing.Point(809, 52);
            this.toolBox1.Name = "toolBox1";
            this.toolBox1.Size = new System.Drawing.Size(114, 532);
            this.toolBox1.TabIndex = 5;
            // 
            // statusBar1
            // 
            this.statusBar1.cmd = null;
            this.statusBar1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.statusBar1.Location = new System.Drawing.Point(0, 584);
            this.statusBar1.Name = "statusBar1";
            this.statusBar1.Size = new System.Drawing.Size(923, 32);
            this.statusBar1.TabIndex = 4;
            // 
            // toolBar1
            // 
            this.toolBar1.cmd = null;
            this.toolBar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.toolBar1.Location = new System.Drawing.Point(0, 28);
            this.toolBar1.Name = "toolBar1";
            this.toolBar1.Size = new System.Drawing.Size(923, 24);
            this.toolBar1.TabIndex = 3;
            // 
            // mainMenu1
            // 
            this.mainMenu1.cmd = null;
            this.mainMenu1.Dock = System.Windows.Forms.DockStyle.Top;
            this.mainMenu1.Location = new System.Drawing.Point(0, 0);
            this.mainMenu1.Name = "mainMenu1";
            this.mainMenu1.Size = new System.Drawing.Size(923, 28);
            this.mainMenu1.TabIndex = 2;
            // 
            // pTabControl1
            // 
            this.pTabControl1.cmd = null;
            this.pTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pTabControl1.Location = new System.Drawing.Point(0, 52);
            this.pTabControl1.Name = "pTabControl1";
            this.pTabControl1.SelectedIndex = 0;
            this.pTabControl1.Size = new System.Drawing.Size(809, 532);
            this.pTabControl1.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(923, 616);
            this.Controls.Add(this.pTabControl1);
            this.Controls.Add(this.toolBox1);
            this.Controls.Add(this.statusBar1);
            this.Controls.Add(this.toolBar1);
            this.Controls.Add(this.mainMenu1);
            this.IsMdiContainer = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion
        private MainMenu mainMenu1;
        private ToolBar.ToolBar toolBar1;
        private StatusBar.StatusBar statusBar1;
        private ToolBox.ToolBox toolBox1;
        private PTabControl pTabControl1;
    }
}

