namespace BarberBD
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.pbxLogo = new System.Windows.Forms.PictureBox();
            this.pbxLogin = new System.Windows.Forms.Label();
            this.pbxUser = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pbxLock = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblClear = new System.Windows.Forms.Label();
            this.lblExit = new System.Windows.Forms.Label();
            this.txtUserID = new System.Windows.Forms.TextBox();
            this.txtPasswordName = new System.Windows.Forms.TextBox();
            this.pbxEye = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxEye)).BeginInit();
            this.SuspendLayout();
            // 
            // pbxLogo
            // 
            this.pbxLogo.Image = global::BarberBD.Properties.Resources.barber__1_;
            this.pbxLogo.Location = new System.Drawing.Point(180, 37);
            this.pbxLogo.Name = "pbxLogo";
            this.pbxLogo.Size = new System.Drawing.Size(112, 74);
            this.pbxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxLogo.TabIndex = 1;
            this.pbxLogo.TabStop = false;
            // 
            // pbxLogin
            // 
            this.pbxLogin.AutoSize = true;
            this.pbxLogin.BackColor = System.Drawing.Color.Transparent;
            this.pbxLogin.Font = new System.Drawing.Font("Mistral", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pbxLogin.ForeColor = System.Drawing.Color.SandyBrown;
            this.pbxLogin.Location = new System.Drawing.Point(171, 124);
            this.pbxLogin.Name = "pbxLogin";
            this.pbxLogin.Size = new System.Drawing.Size(128, 52);
            this.pbxLogin.TabIndex = 2;
            this.pbxLogin.Text = "LOG IN";
            // 
            // pbxUser
            // 
            this.pbxUser.BackColor = System.Drawing.Color.Transparent;
            this.pbxUser.Image = global::BarberBD.Properties.Resources.icons8_user_80;
            this.pbxUser.Location = new System.Drawing.Point(40, 199);
            this.pbxUser.Name = "pbxUser";
            this.pbxUser.Size = new System.Drawing.Size(34, 40);
            this.pbxUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxUser.TabIndex = 3;
            this.pbxUser.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(53, 245);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 1);
            this.panel1.TabIndex = 4;
            // 
            // pbxLock
            // 
            this.pbxLock.BackColor = System.Drawing.Color.Transparent;
            this.pbxLock.Image = global::BarberBD.Properties.Resources.icons8_password_48;
            this.pbxLock.Location = new System.Drawing.Point(40, 288);
            this.pbxLock.Name = "pbxLock";
            this.pbxLock.Size = new System.Drawing.Size(34, 40);
            this.pbxLock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxLock.TabIndex = 3;
            this.pbxLock.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Location = new System.Drawing.Point(53, 334);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(400, 1);
            this.panel2.TabIndex = 4;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(54)))), ((int)(((byte)(79)))));
            this.btnLogin.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(53, 390);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(403, 48);
            this.btnLogin.TabIndex = 5;
            this.btnLogin.Text = "LOG IN";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // lblClear
            // 
            this.lblClear.AutoSize = true;
            this.lblClear.BackColor = System.Drawing.Color.Transparent;
            this.lblClear.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClear.ForeColor = System.Drawing.Color.SandyBrown;
            this.lblClear.Location = new System.Drawing.Point(320, 354);
            this.lblClear.Name = "lblClear";
            this.lblClear.Size = new System.Drawing.Size(118, 22);
            this.lblClear.TabIndex = 6;
            this.lblClear.Text = "Clear Fields";
            this.lblClear.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblExit
            // 
            this.lblExit.AutoSize = true;
            this.lblExit.BackColor = System.Drawing.Color.Peru;
            this.lblExit.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExit.ForeColor = System.Drawing.Color.Black;
            this.lblExit.Location = new System.Drawing.Point(226, 453);
            this.lblExit.Name = "lblExit";
            this.lblExit.Size = new System.Drawing.Size(50, 22);
            this.lblExit.TabIndex = 7;
            this.lblExit.Text = "Exit";
            this.lblExit.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtUserID
            // 
            this.txtUserID.BackColor = System.Drawing.Color.PeachPuff;
            this.txtUserID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUserID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserID.Location = new System.Drawing.Point(93, 201);
            this.txtUserID.Multiline = true;
            this.txtUserID.Name = "txtUserID";
            this.txtUserID.Size = new System.Drawing.Size(360, 38);
            this.txtUserID.TabIndex = 8;
            // 
            // txtPasswordName
            // 
            this.txtPasswordName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtPasswordName.BackColor = System.Drawing.Color.PeachPuff;
            this.txtPasswordName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPasswordName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPasswordName.Location = new System.Drawing.Point(93, 290);
            this.txtPasswordName.Multiline = true;
            this.txtPasswordName.Name = "txtPasswordName";
            this.txtPasswordName.PasswordChar = '*';
            this.txtPasswordName.Size = new System.Drawing.Size(360, 38);
            this.txtPasswordName.TabIndex = 9;
            // 
            // pbxEye
            // 
            this.pbxEye.BackColor = System.Drawing.Color.Transparent;
            this.pbxEye.Image = global::BarberBD.Properties.Resources.eye;
            this.pbxEye.Location = new System.Drawing.Point(459, 290);
            this.pbxEye.Name = "pbxEye";
            this.pbxEye.Size = new System.Drawing.Size(31, 38);
            this.pbxEye.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxEye.TabIndex = 10;
            this.pbxEye.TabStop = false;
            this.pbxEye.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(54)))), ((int)(((byte)(79)))));
            this.ClientSize = new System.Drawing.Size(494, 513);
            this.Controls.Add(this.pbxEye);
            this.Controls.Add(this.txtPasswordName);
            this.Controls.Add(this.txtUserID);
            this.Controls.Add(this.lblExit);
            this.Controls.Add(this.lblClear);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pbxLock);
            this.Controls.Add(this.pbxUser);
            this.Controls.Add(this.pbxLogin);
            this.Controls.Add(this.pbxLogo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BarberBD";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Login_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxEye)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pbxLogo;
        private System.Windows.Forms.Label pbxLogin;
        private System.Windows.Forms.PictureBox pbxUser;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pbxLock;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblClear;
        private System.Windows.Forms.Label lblExit;
        private System.Windows.Forms.TextBox txtUserID;
        private System.Windows.Forms.TextBox txtPasswordName;
        private System.Windows.Forms.PictureBox pbxEye;
    }
}