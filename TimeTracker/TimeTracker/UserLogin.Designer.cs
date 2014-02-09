namespace TimeTracker
{
    partial class frmUserLogin
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
            this.lblTimeSheet = new System.Windows.Forms.Label();
            this.grpboxUserLogin = new System.Windows.Forms.GroupBox();
            this.lnklblcreateNewUser = new System.Windows.Forms.LinkLabel();
            this.txtBoxPassword = new System.Windows.Forms.TextBox();
            this.txtBoxUsername = new System.Windows.Forms.TextBox();
            this.btnSignIn = new System.Windows.Forms.Button();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUesrname = new System.Windows.Forms.Label();
            this.grpboxUserLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTimeSheet
            // 
            this.lblTimeSheet.AutoSize = true;
            this.lblTimeSheet.Font = new System.Drawing.Font("Gill Sans Ultra Bold Condensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimeSheet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTimeSheet.Location = new System.Drawing.Point(39, 9);
            this.lblTimeSheet.Name = "lblTimeSheet";
            this.lblTimeSheet.Size = new System.Drawing.Size(343, 36);
            this.lblTimeSheet.TabIndex = 0;
            this.lblTimeSheet.Text = "My company  Time  Tracker";
            // 
            // grpboxUserLogin
            // 
            this.grpboxUserLogin.BackColor = System.Drawing.Color.LightGray;
            this.grpboxUserLogin.Controls.Add(this.lnklblcreateNewUser);
            this.grpboxUserLogin.Controls.Add(this.txtBoxPassword);
            this.grpboxUserLogin.Controls.Add(this.txtBoxUsername);
            this.grpboxUserLogin.Controls.Add(this.btnSignIn);
            this.grpboxUserLogin.Controls.Add(this.lblPassword);
            this.grpboxUserLogin.Controls.Add(this.lblUesrname);
            this.grpboxUserLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpboxUserLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.grpboxUserLogin.Location = new System.Drawing.Point(45, 68);
            this.grpboxUserLogin.Name = "grpboxUserLogin";
            this.grpboxUserLogin.Size = new System.Drawing.Size(424, 227);
            this.grpboxUserLogin.TabIndex = 4;
            this.grpboxUserLogin.TabStop = false;
            this.grpboxUserLogin.Text = "User Login";
            // 
            // lnklblcreateNewUser
            // 
            this.lnklblcreateNewUser.AutoSize = true;
            this.lnklblcreateNewUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnklblcreateNewUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lnklblcreateNewUser.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lnklblcreateNewUser.Location = new System.Drawing.Point(30, 184);
            this.lnklblcreateNewUser.Name = "lnklblcreateNewUser";
            this.lnklblcreateNewUser.Size = new System.Drawing.Size(110, 16);
            this.lnklblcreateNewUser.TabIndex = 5;
            this.lnklblcreateNewUser.TabStop = true;
            this.lnklblcreateNewUser.Text = "Create New User";
            this.lnklblcreateNewUser.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnklblcreateNewUser_LinkClicked);
            // 
            // txtBoxPassword
            // 
            this.txtBoxPassword.Location = new System.Drawing.Point(110, 85);
            this.txtBoxPassword.Name = "txtBoxPassword";
            this.txtBoxPassword.Size = new System.Drawing.Size(100, 20);
            this.txtBoxPassword.TabIndex = 4;
            // 
            // txtBoxUsername
            // 
            this.txtBoxUsername.Location = new System.Drawing.Point(110, 46);
            this.txtBoxUsername.Name = "txtBoxUsername";
            this.txtBoxUsername.Size = new System.Drawing.Size(100, 20);
            this.txtBoxUsername.TabIndex = 3;
            // 
            // btnSignIn
            // 
            this.btnSignIn.Location = new System.Drawing.Point(110, 121);
            this.btnSignIn.Name = "btnSignIn";
            this.btnSignIn.Size = new System.Drawing.Size(75, 26);
            this.btnSignIn.TabIndex = 2;
            this.btnSignIn.Text = "Sign In";
            this.btnSignIn.UseVisualStyleBackColor = true;
            this.btnSignIn.Click += new System.EventHandler(this.btnSignIn_Click);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.ForeColor = System.Drawing.Color.Blue;
            this.lblPassword.Location = new System.Drawing.Point(25, 86);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(74, 16);
            this.lblPassword.TabIndex = 1;
            this.lblPassword.Text = "Password :";
            // 
            // lblUesrname
            // 
            this.lblUesrname.AutoSize = true;
            this.lblUesrname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUesrname.ForeColor = System.Drawing.Color.Blue;
            this.lblUesrname.Location = new System.Drawing.Point(25, 46);
            this.lblUesrname.Name = "lblUesrname";
            this.lblUesrname.Size = new System.Drawing.Size(77, 16);
            this.lblUesrname.TabIndex = 0;
            this.lblUesrname.Text = "Username :";
            // 
            // frmUserLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(619, 452);
            this.Controls.Add(this.grpboxUserLogin);
            this.Controls.Add(this.lblTimeSheet);
            this.Name = "frmUserLogin";
            this.Text = "Login details";
            this.grpboxUserLogin.ResumeLayout(false);
            this.grpboxUserLogin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTimeSheet;
        private System.Windows.Forms.GroupBox grpboxUserLogin;
        private System.Windows.Forms.Label lblUesrname;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Button btnSignIn;
        private System.Windows.Forms.TextBox txtBoxUsername;
        private System.Windows.Forms.TextBox txtBoxPassword;
        private System.Windows.Forms.LinkLabel lnklblcreateNewUser;
    }
}

