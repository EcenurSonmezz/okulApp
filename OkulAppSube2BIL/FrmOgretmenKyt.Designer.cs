namespace OkulAppSube2BIL
{
    partial class FrmOgretmenKyt
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnKaydet = new System.Windows.Forms.Button();
            this.tbtnum = new System.Windows.Forms.TextBox();
            this.tbSurname = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbTc = new System.Windows.Forms.TextBox();
            this.lblbrnsKod = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblTc = new System.Windows.Forms.Label();
            this.rbtnGizle = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtnGizle);
            this.groupBox1.Controls.Add(this.tbtnum);
            this.groupBox1.Controls.Add(this.tbSurname);
            this.groupBox1.Controls.Add(this.tbName);
            this.groupBox1.Controls.Add(this.tbTc);
            this.groupBox1.Controls.Add(this.lblbrnsKod);
            this.groupBox1.Controls.Add(this.lblSurname);
            this.groupBox1.Controls.Add(this.lblName);
            this.groupBox1.Controls.Add(this.lblTc);
            this.groupBox1.Location = new System.Drawing.Point(24, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(277, 194);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ogretmen Kayıt";
            // 
            // BtnKaydet
            // 
            this.BtnKaydet.Location = new System.Drawing.Point(118, 230);
            this.BtnKaydet.Name = "BtnKaydet";
            this.BtnKaydet.Size = new System.Drawing.Size(75, 23);
            this.BtnKaydet.TabIndex = 8;
            this.BtnKaydet.Text = "Kaydet";
            this.BtnKaydet.UseVisualStyleBackColor = true;
            this.BtnKaydet.Click += new System.EventHandler(this.BtnKaydet_Click);
            // 
            // tbtnum
            // 
            this.tbtnum.Location = new System.Drawing.Point(153, 163);
            this.tbtnum.Name = "tbtnum";
            this.tbtnum.Size = new System.Drawing.Size(100, 20);
            this.tbtnum.TabIndex = 7;
            // 
            // tbSurname
            // 
            this.tbSurname.Location = new System.Drawing.Point(153, 126);
            this.tbSurname.Name = "tbSurname";
            this.tbSurname.Size = new System.Drawing.Size(100, 20);
            this.tbSurname.TabIndex = 6;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(153, 97);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(100, 20);
            this.tbName.TabIndex = 5;
            // 
            // tbTc
            // 
            this.tbTc.Location = new System.Drawing.Point(153, 46);
            this.tbTc.Name = "tbTc";
            this.tbTc.Size = new System.Drawing.Size(100, 20);
            this.tbTc.TabIndex = 4;
            // 
            // lblbrnsKod
            // 
            this.lblbrnsKod.AutoSize = true;
            this.lblbrnsKod.Location = new System.Drawing.Point(48, 170);
            this.lblbrnsKod.Name = "lblbrnsKod";
            this.lblbrnsKod.Size = new System.Drawing.Size(62, 13);
            this.lblbrnsKod.TabIndex = 3;
            this.lblbrnsKod.Text = "Branş Kodu";
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Location = new System.Drawing.Point(48, 133);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(37, 13);
            this.lblSurname.TabIndex = 2;
            this.lblSurname.Text = "Soyad";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(48, 104);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(20, 13);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Ad";
            // 
            // lblTc
            // 
            this.lblTc.AutoSize = true;
            this.lblTc.Location = new System.Drawing.Point(48, 53);
            this.lblTc.Name = "lblTc";
            this.lblTc.Size = new System.Drawing.Size(37, 13);
            this.lblTc.TabIndex = 0;
            this.lblTc.Text = "Tc No";
            // 
            // rbtnGizle
            // 
            this.rbtnGizle.AutoSize = true;
            this.rbtnGizle.Location = new System.Drawing.Point(207, 72);
            this.rbtnGizle.Name = "rbtnGizle";
            this.rbtnGizle.Size = new System.Drawing.Size(46, 17);
            this.rbtnGizle.TabIndex = 8;
            this.rbtnGizle.TabStop = true;
            this.rbtnGizle.Text = "gizle";
            this.rbtnGizle.UseVisualStyleBackColor = true;
            // 
            // FrmOgretmenKyt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 270);
            this.Controls.Add(this.BtnKaydet);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmOgretmenKyt";
            this.Text = "FrmOgretmenKyt";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnKaydet;
        private System.Windows.Forms.TextBox tbtnum;
        private System.Windows.Forms.TextBox tbSurname;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbTc;
        private System.Windows.Forms.Label lblbrnsKod;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblTc;
        private System.Windows.Forms.RadioButton rbtnGizle;
    }
}