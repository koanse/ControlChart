namespace ControlChart
{
    partial class PropForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.rbNS = new System.Windows.Forms.RadioButton();
            this.rbStd = new System.Windows.Forms.RadioButton();
            this.tbM = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbS = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(105, 136);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // rbNS
            // 
            this.rbNS.AutoSize = true;
            this.rbNS.Checked = true;
            this.rbNS.Location = new System.Drawing.Point(12, 12);
            this.rbNS.Name = "rbNS";
            this.rbNS.Size = new System.Drawing.Size(162, 17);
            this.rbNS.TabIndex = 1;
            this.rbNS.TabStop = true;
            this.rbNS.Text = "Без стандартных значений";
            this.rbNS.UseVisualStyleBackColor = true;
            // 
            // rbStd
            // 
            this.rbStd.AutoSize = true;
            this.rbStd.Location = new System.Drawing.Point(12, 35);
            this.rbStd.Name = "rbStd";
            this.rbStd.Size = new System.Drawing.Size(183, 17);
            this.rbStd.TabIndex = 2;
            this.rbStd.Text = "Стандартные значения заданы";
            this.rbStd.UseVisualStyleBackColor = true;
            // 
            // tbM
            // 
            this.tbM.Location = new System.Drawing.Point(12, 71);
            this.tbM.Name = "tbM";
            this.tbM.Size = new System.Drawing.Size(268, 20);
            this.tbM.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Математическое ожидание:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Ср. кв. отклонение:";
            // 
            // tbS
            // 
            this.tbS.Location = new System.Drawing.Point(12, 110);
            this.tbS.Name = "tbS";
            this.tbS.Size = new System.Drawing.Size(268, 20);
            this.tbS.TabIndex = 5;
            // 
            // PropForm
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 170);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbS);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbM);
            this.Controls.Add(this.rbStd);
            this.Controls.Add(this.rbNS);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PropForm";
            this.Text = "PropForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.RadioButton rbNS;
        public System.Windows.Forms.RadioButton rbStd;
        public System.Windows.Forms.TextBox tbM;
        public System.Windows.Forms.TextBox tbS;
    }
}