namespace ControlChart
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.genToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.genToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.makeCCToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.свойстваToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.psM = new NPlot.Windows.PlotSurface2D();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.psS = new NPlot.Windows.PlotSurface2D();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1.SuspendLayout();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.genToolStripMenuItem,
            this.cCToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(497, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.fileToolStripMenuItem.Text = "Файл";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.newToolStripMenuItem.Text = "Создать...";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.openToolStripMenuItem.Text = "Открыть...";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Выход";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // genToolStripMenuItem
            // 
            this.genToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.genToolStripMenuItem1});
            this.genToolStripMenuItem.Name = "genToolStripMenuItem";
            this.genToolStripMenuItem.Size = new System.Drawing.Size(112, 20);
            this.genToolStripMenuItem.Text = "Исходные данные";
            // 
            // genToolStripMenuItem1
            // 
            this.genToolStripMenuItem1.Name = "genToolStripMenuItem1";
            this.genToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.genToolStripMenuItem1.Text = "Генерация...";
            this.genToolStripMenuItem1.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // cCToolStripMenuItem
            // 
            this.cCToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.makeCCToolStripMenuItem1,
            this.свойстваToolStripMenuItem});
            this.cCToolStripMenuItem.Name = "cCToolStripMenuItem";
            this.cCToolStripMenuItem.Size = new System.Drawing.Size(117, 20);
            this.cCToolStripMenuItem.Text = "Конрольные карты";
            // 
            // makeCCToolStripMenuItem1
            // 
            this.makeCCToolStripMenuItem1.Name = "makeCCToolStripMenuItem1";
            this.makeCCToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.makeCCToolStripMenuItem1.Text = "Построить...";
            this.makeCCToolStripMenuItem1.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // свойстваToolStripMenuItem
            // 
            this.свойстваToolStripMenuItem.Name = "свойстваToolStripMenuItem";
            this.свойстваToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.свойстваToolStripMenuItem.Text = "Свойства...";
            this.свойстваToolStripMenuItem.Click += new System.EventHandler(this.propToolStripMenuItem_Click);
            // 
            // psM
            // 
            this.psM.AutoScaleAutoGeneratedAxes = false;
            this.psM.AutoScaleTitle = false;
            this.psM.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.psM.DateTimeToolTip = false;
            this.psM.Dock = System.Windows.Forms.DockStyle.Fill;
            this.psM.Legend = null;
            this.psM.LegendZOrder = -1;
            this.psM.Location = new System.Drawing.Point(0, 0);
            this.psM.Name = "psM";
            this.psM.RightMenu = null;
            this.psM.ShowCoordinates = true;
            this.psM.Size = new System.Drawing.Size(497, 110);
            this.psM.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.None;
            this.psM.TabIndex = 1;
            this.psM.Text = "plotSurface2D1";
            this.psM.Title = "";
            this.psM.TitleFont = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.psM.XAxis1 = null;
            this.psM.XAxis2 = null;
            this.psM.YAxis1 = null;
            this.psM.YAxis2 = null;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.psM);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.psS);
            this.splitContainer1.Size = new System.Drawing.Size(497, 230);
            this.splitContainer1.SplitterDistance = 110;
            this.splitContainer1.TabIndex = 2;
            // 
            // psS
            // 
            this.psS.AutoScaleAutoGeneratedAxes = false;
            this.psS.AutoScaleTitle = false;
            this.psS.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.psS.DateTimeToolTip = false;
            this.psS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.psS.Legend = null;
            this.psS.LegendZOrder = -1;
            this.psS.Location = new System.Drawing.Point(0, 0);
            this.psS.Name = "psS";
            this.psS.RightMenu = null;
            this.psS.ShowCoordinates = true;
            this.psS.Size = new System.Drawing.Size(497, 116);
            this.psS.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.None;
            this.psS.TabIndex = 2;
            this.psS.Text = "plotSurface2D1";
            this.psS.Title = "";
            this.psS.TitleFont = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.psS.XAxis1 = null;
            this.psS.XAxis2 = null;
            this.psS.YAxis1 = null;
            this.psS.YAxis2 = null;
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "*.txt|*.txt";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "data1.txt";
            this.openFileDialog1.Filter = "*.txt|*.txt";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 254);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Эмулятор системы построения и анализа контрольных карт";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private NPlot.Windows.PlotSurface2D psM;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private NPlot.Windows.PlotSurface2D psS;
        private System.Windows.Forms.ToolStripMenuItem genToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cCToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem genToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem makeCCToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem свойстваToolStripMenuItem;
    }
}

