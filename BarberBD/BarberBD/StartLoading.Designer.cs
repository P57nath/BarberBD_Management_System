namespace BarberBD
{
    partial class StartLoading
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartLoading));
            this.Pnl_Start_LG_NM_SGN = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pbxLogo = new System.Windows.Forms.PictureBox();
            this.prgbrStart = new System.Windows.Forms.ProgressBar();
            this.Tmr_Pb = new System.Windows.Forms.Timer(this.components);
            this.lblPercent = new System.Windows.Forms.Label();
            this.labelLoding = new System.Windows.Forms.Label();
            this.Pnl_Start_LG_NM_SGN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // Pnl_Start_LG_NM_SGN
            // 
            this.Pnl_Start_LG_NM_SGN.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Pnl_Start_LG_NM_SGN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Pnl_Start_LG_NM_SGN.Controls.Add(this.label2);
            this.Pnl_Start_LG_NM_SGN.Controls.Add(this.label1);
            this.Pnl_Start_LG_NM_SGN.Controls.Add(this.pbxLogo);
            this.Pnl_Start_LG_NM_SGN.Location = new System.Drawing.Point(148, 22);
            this.Pnl_Start_LG_NM_SGN.Name = "Pnl_Start_LG_NM_SGN";
            this.Pnl_Start_LG_NM_SGN.Size = new System.Drawing.Size(511, 182);
            this.Pnl_Start_LG_NM_SGN.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Stencil", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Peru;
            this.label2.Location = new System.Drawing.Point(151, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(196, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Change The System";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Stencil", 25.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Peru;
            this.label1.Location = new System.Drawing.Point(112, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 51);
            this.label1.TabIndex = 4;
            this.label1.Text = "BARBER BD";
            // 
            // pbxLogo
            // 
            this.pbxLogo.Image = global::BarberBD.Properties.Resources.barber__1_;
            this.pbxLogo.Location = new System.Drawing.Point(197, 3);
            this.pbxLogo.Name = "pbxLogo";
            this.pbxLogo.Size = new System.Drawing.Size(100, 73);
            this.pbxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxLogo.TabIndex = 1;
            this.pbxLogo.TabStop = false;
            // 
            // prgbrStart
            // 
            this.prgbrStart.BackColor = System.Drawing.Color.Indigo;
            this.prgbrStart.ForeColor = System.Drawing.Color.Peru;
            this.prgbrStart.Location = new System.Drawing.Point(148, 376);
            this.prgbrStart.Name = "prgbrStart";
            this.prgbrStart.Size = new System.Drawing.Size(511, 23);
            this.prgbrStart.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.prgbrStart.TabIndex = 1;
            // 
            // Tmr_Pb
            // 
            this.Tmr_Pb.Enabled = true;
            this.Tmr_Pb.Tick += new System.EventHandler(this.Tmr_Pb_Tick);
            // 
            // lblPercent
            // 
            this.lblPercent.AutoSize = true;
            this.lblPercent.BackColor = System.Drawing.Color.Transparent;
            this.lblPercent.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPercent.ForeColor = System.Drawing.Color.Peru;
            this.lblPercent.Location = new System.Drawing.Point(577, 319);
            this.lblPercent.Name = "lblPercent";
            this.lblPercent.Size = new System.Drawing.Size(34, 37);
            this.lblPercent.TabIndex = 2;
            this.lblPercent.Text = "0";
            // 
            // labelLoding
            // 
            this.labelLoding.AutoSize = true;
            this.labelLoding.BackColor = System.Drawing.Color.Transparent;
            this.labelLoding.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLoding.ForeColor = System.Drawing.Color.Peru;
            this.labelLoding.Location = new System.Drawing.Point(151, 319);
            this.labelLoding.Name = "labelLoding";
            this.labelLoding.Size = new System.Drawing.Size(178, 37);
            this.labelLoding.TabIndex = 3;
            this.labelLoding.Text = "Loading......";
            // 
            // StartLoading
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(54)))), ((int)(((byte)(79)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelLoding);
            this.Controls.Add(this.lblPercent);
            this.Controls.Add(this.prgbrStart);
            this.Controls.Add(this.Pnl_Start_LG_NM_SGN);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StartLoading";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BarberBD";
            this.Pnl_Start_LG_NM_SGN.ResumeLayout(false);
            this.Pnl_Start_LG_NM_SGN.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Pnl_Start_LG_NM_SGN;
        private System.Windows.Forms.PictureBox pbxLogo;
        private System.Windows.Forms.ProgressBar prgbrStart;
        private System.Windows.Forms.Timer Tmr_Pb;
        private System.Windows.Forms.Label lblPercent;
        private System.Windows.Forms.Label labelLoding;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

