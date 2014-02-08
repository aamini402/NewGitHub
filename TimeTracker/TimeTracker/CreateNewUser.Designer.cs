namespace TimeTracker
{
    partial class frmCreateNewUser
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
            this.grpboxUserDetails = new System.Windows.Forms.GroupBox();
            this.rdoBtnEmployee = new System.Windows.Forms.RadioButton();
            this.rdoBtnAdministrator = new System.Windows.Forms.RadioButton();
            this.lblRoleName = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtboxContactNumber = new System.Windows.Forms.TextBox();
            this.txtboxEmailid = new System.Windows.Forms.TextBox();
            this.txtboxConfirmPassword = new System.Windows.Forms.TextBox();
            this.txtboxPassword = new System.Windows.Forms.TextBox();
            this.txtboxUsername = new System.Windows.Forms.TextBox();
            this.lblContactNumber = new System.Windows.Forms.Label();
            this.lblEmailid = new System.Windows.Forms.Label();
            this.lblConfirmPassword = new System.Windows.Forms.Label();
            this.lblPasword = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.grpboxUserDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTimeSheet
            // 
            this.lblTimeSheet.AutoSize = true;
            this.lblTimeSheet.Font = new System.Drawing.Font("Gill Sans Ultra Bold Condensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimeSheet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTimeSheet.Location = new System.Drawing.Point(33, 9);
            this.lblTimeSheet.Name = "lblTimeSheet";
            this.lblTimeSheet.Size = new System.Drawing.Size(343, 36);
            this.lblTimeSheet.TabIndex = 1;
            this.lblTimeSheet.Text = "My company  Time  Tracker";
            // 
            // grpboxUserDetails
            // 
            this.grpboxUserDetails.BackColor = System.Drawing.Color.LightGray;
            this.grpboxUserDetails.Controls.Add(this.rdoBtnEmployee);
            this.grpboxUserDetails.Controls.Add(this.rdoBtnAdministrator);
            this.grpboxUserDetails.Controls.Add(this.lblRoleName);
            this.grpboxUserDetails.Controls.Add(this.btnSave);
            this.grpboxUserDetails.Controls.Add(this.txtboxContactNumber);
            this.grpboxUserDetails.Controls.Add(this.txtboxEmailid);
            this.grpboxUserDetails.Controls.Add(this.txtboxConfirmPassword);
            this.grpboxUserDetails.Controls.Add(this.txtboxPassword);
            this.grpboxUserDetails.Controls.Add(this.txtboxUsername);
            this.grpboxUserDetails.Controls.Add(this.lblContactNumber);
            this.grpboxUserDetails.Controls.Add(this.lblEmailid);
            this.grpboxUserDetails.Controls.Add(this.lblConfirmPassword);
            this.grpboxUserDetails.Controls.Add(this.lblPasword);
            this.grpboxUserDetails.Controls.Add(this.lblUsername);
            this.grpboxUserDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpboxUserDetails.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.grpboxUserDetails.Location = new System.Drawing.Point(39, 87);
            this.grpboxUserDetails.Name = "grpboxUserDetails";
            this.grpboxUserDetails.Size = new System.Drawing.Size(337, 356);
            this.grpboxUserDetails.TabIndex = 2;
            this.grpboxUserDetails.TabStop = false;
            this.grpboxUserDetails.Text = "User Details";
            // 
            // rdoBtnEmployee
            // 
            this.rdoBtnEmployee.AutoSize = true;
            this.rdoBtnEmployee.Location = new System.Drawing.Point(201, 197);
            this.rdoBtnEmployee.Name = "rdoBtnEmployee";
            this.rdoBtnEmployee.Size = new System.Drawing.Size(79, 17);
            this.rdoBtnEmployee.TabIndex = 13;
            this.rdoBtnEmployee.Text = "Employee";
            this.rdoBtnEmployee.UseVisualStyleBackColor = true;
            // 
            // rdoBtnAdministrator
            // 
            this.rdoBtnAdministrator.AutoSize = true;
            this.rdoBtnAdministrator.Checked = true;
            this.rdoBtnAdministrator.Location = new System.Drawing.Point(201, 174);
            this.rdoBtnAdministrator.Name = "rdoBtnAdministrator";
            this.rdoBtnAdministrator.Size = new System.Drawing.Size(98, 17);
            this.rdoBtnAdministrator.TabIndex = 12;
            this.rdoBtnAdministrator.TabStop = true;
            this.rdoBtnAdministrator.Text = "Administrator";
            this.rdoBtnAdministrator.UseVisualStyleBackColor = true;
            // 
            // lblRoleName
            // 
            this.lblRoleName.AutoSize = true;
            this.lblRoleName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoleName.ForeColor = System.Drawing.Color.Blue;
            this.lblRoleName.Location = new System.Drawing.Point(65, 176);
            this.lblRoleName.Name = "lblRoleName";
            this.lblRoleName.Size = new System.Drawing.Size(80, 16);
            this.lblRoleName.TabIndex = 11;
            this.lblRoleName.Text = "Role Name:";
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(226, 284);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 26);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "save ";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtboxContactNumber
            // 
            this.txtboxContactNumber.Location = new System.Drawing.Point(201, 237);
            this.txtboxContactNumber.Name = "txtboxContactNumber";
            this.txtboxContactNumber.Size = new System.Drawing.Size(100, 20);
            this.txtboxContactNumber.TabIndex = 9;
            // 
            // txtboxEmailid
            // 
            this.txtboxEmailid.Location = new System.Drawing.Point(201, 141);
            this.txtboxEmailid.Name = "txtboxEmailid";
            this.txtboxEmailid.Size = new System.Drawing.Size(100, 20);
            this.txtboxEmailid.TabIndex = 8;
            // 
            // txtboxConfirmPassword
            // 
            this.txtboxConfirmPassword.Location = new System.Drawing.Point(201, 108);
            this.txtboxConfirmPassword.Name = "txtboxConfirmPassword";
            this.txtboxConfirmPassword.Size = new System.Drawing.Size(100, 20);
            this.txtboxConfirmPassword.TabIndex = 7;
            // 
            // txtboxPassword
            // 
            this.txtboxPassword.Location = new System.Drawing.Point(201, 70);
            this.txtboxPassword.Name = "txtboxPassword";
            this.txtboxPassword.Size = new System.Drawing.Size(100, 20);
            this.txtboxPassword.TabIndex = 6;
            // 
            // txtboxUsername
            // 
            this.txtboxUsername.Location = new System.Drawing.Point(201, 37);
            this.txtboxUsername.Name = "txtboxUsername";
            this.txtboxUsername.Size = new System.Drawing.Size(100, 20);
            this.txtboxUsername.TabIndex = 5;
            // 
            // lblContactNumber
            // 
            this.lblContactNumber.AutoSize = true;
            this.lblContactNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContactNumber.ForeColor = System.Drawing.Color.Blue;
            this.lblContactNumber.Location = new System.Drawing.Point(65, 241);
            this.lblContactNumber.Name = "lblContactNumber";
            this.lblContactNumber.Size = new System.Drawing.Size(107, 16);
            this.lblContactNumber.TabIndex = 4;
            this.lblContactNumber.Text = "Contact Number:";
            // 
            // lblEmailid
            // 
            this.lblEmailid.AutoSize = true;
            this.lblEmailid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmailid.ForeColor = System.Drawing.Color.Blue;
            this.lblEmailid.Location = new System.Drawing.Point(65, 141);
            this.lblEmailid.Name = "lblEmailid";
            this.lblEmailid.Size = new System.Drawing.Size(59, 16);
            this.lblEmailid.TabIndex = 3;
            this.lblEmailid.Text = "Email Id:";
            // 
            // lblConfirmPassword
            // 
            this.lblConfirmPassword.AutoSize = true;
            this.lblConfirmPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmPassword.ForeColor = System.Drawing.Color.Blue;
            this.lblConfirmPassword.Location = new System.Drawing.Point(65, 108);
            this.lblConfirmPassword.Name = "lblConfirmPassword";
            this.lblConfirmPassword.Size = new System.Drawing.Size(122, 16);
            this.lblConfirmPassword.TabIndex = 2;
            this.lblConfirmPassword.Text = "Confirm Password :";
            // 
            // lblPasword
            // 
            this.lblPasword.AutoSize = true;
            this.lblPasword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPasword.ForeColor = System.Drawing.Color.Blue;
            this.lblPasword.Location = new System.Drawing.Point(65, 74);
            this.lblPasword.Name = "lblPasword";
            this.lblPasword.Size = new System.Drawing.Size(74, 16);
            this.lblPasword.TabIndex = 1;
            this.lblPasword.Text = "Password :";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.ForeColor = System.Drawing.Color.Blue;
            this.lblUsername.Location = new System.Drawing.Point(65, 37);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(77, 16);
            this.lblUsername.TabIndex = 0;
            this.lblUsername.Text = "Username :";
            // 
            // frmCreateNewUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(664, 485);
            this.Controls.Add(this.grpboxUserDetails);
            this.Controls.Add(this.lblTimeSheet);
            this.Name = "frmCreateNewUser";
            this.Text = "CreateNewUser";
            this.grpboxUserDetails.ResumeLayout(false);
            this.grpboxUserDetails.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTimeSheet;
        private System.Windows.Forms.GroupBox grpboxUserDetails;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblEmailid;
        private System.Windows.Forms.Label lblConfirmPassword;
        private System.Windows.Forms.Label lblPasword;
        private System.Windows.Forms.Label lblContactNumber;
        private System.Windows.Forms.TextBox txtboxContactNumber;
        private System.Windows.Forms.TextBox txtboxEmailid;
        private System.Windows.Forms.TextBox txtboxConfirmPassword;
        private System.Windows.Forms.TextBox txtboxPassword;
        private System.Windows.Forms.TextBox txtboxUsername;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblRoleName;
        private System.Windows.Forms.RadioButton rdoBtnEmployee;
        private System.Windows.Forms.RadioButton rdoBtnAdministrator;
    }
}