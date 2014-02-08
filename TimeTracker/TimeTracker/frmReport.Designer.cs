namespace TimeTracker
{
    partial class frmReport
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblProjectName = new System.Windows.Forms.Label();
            this.btnViewReport = new System.Windows.Forms.Button();
            this.lblProjectName2 = new System.Windows.Forms.Label();
            this.txtBoxProjectName = new System.Windows.Forms.TextBox();
            this.lblEstHour = new System.Windows.Forms.Label();
            this.txtBoxEstimateHour = new System.Windows.Forms.TextBox();
            this.lblActualHour = new System.Windows.Forms.Label();
            this.lblEstCompletion = new System.Windows.Forms.Label();
            this.txtBoxActualHour = new System.Windows.Forms.TextBox();
            this.txtBoxEstimateCompletion = new System.Windows.Forms.TextBox();
            this.btnCreateProject = new System.Windows.Forms.Button();
            this.btnViewProject = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btTimeSheet = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTimeSheet
            // 
            this.lblTimeSheet.AutoSize = true;
            this.lblTimeSheet.Font = new System.Drawing.Font("Gill Sans Ultra Bold Condensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimeSheet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTimeSheet.Location = new System.Drawing.Point(58, 19);
            this.lblTimeSheet.Name = "lblTimeSheet";
            this.lblTimeSheet.Size = new System.Drawing.Size(343, 36);
            this.lblTimeSheet.TabIndex = 2;
            this.lblTimeSheet.Text = "My company  Time  Tracker";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(184, 158);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(179, 21);
            this.comboBox1.TabIndex = 3;
            // 
            // lblProjectName
            // 
            this.lblProjectName.AutoSize = true;
            this.lblProjectName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProjectName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblProjectName.Location = new System.Drawing.Point(61, 159);
            this.lblProjectName.Name = "lblProjectName";
            this.lblProjectName.Size = new System.Drawing.Size(96, 16);
            this.lblProjectName.TabIndex = 4;
            this.lblProjectName.Text = "Project Name :";
            // 
            // btnViewReport
            // 
            this.btnViewReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewReport.Location = new System.Drawing.Point(431, 149);
            this.btnViewReport.Name = "btnViewReport";
            this.btnViewReport.Size = new System.Drawing.Size(75, 30);
            this.btnViewReport.TabIndex = 5;
            this.btnViewReport.Text = "View Report";
            this.btnViewReport.UseVisualStyleBackColor = true;
            // 
            // lblProjectName2
            // 
            this.lblProjectName2.AutoSize = true;
            this.lblProjectName2.Location = new System.Drawing.Point(61, 206);
            this.lblProjectName2.Name = "lblProjectName2";
            this.lblProjectName2.Size = new System.Drawing.Size(69, 13);
            this.lblProjectName2.TabIndex = 6;
            this.lblProjectName2.Text = "Project name";
            // 
            // txtBoxProjectName
            // 
            this.txtBoxProjectName.Location = new System.Drawing.Point(64, 242);
            this.txtBoxProjectName.Name = "txtBoxProjectName";
            this.txtBoxProjectName.Size = new System.Drawing.Size(100, 20);
            this.txtBoxProjectName.TabIndex = 7;
            // 
            // lblEstHour
            // 
            this.lblEstHour.AutoSize = true;
            this.lblEstHour.Location = new System.Drawing.Point(217, 206);
            this.lblEstHour.Name = "lblEstHour";
            this.lblEstHour.Size = new System.Drawing.Size(71, 13);
            this.lblEstHour.TabIndex = 8;
            this.lblEstHour.Text = "Estimate hour";
            // 
            // txtBoxEstimateHour
            // 
            this.txtBoxEstimateHour.Location = new System.Drawing.Point(220, 242);
            this.txtBoxEstimateHour.Name = "txtBoxEstimateHour";
            this.txtBoxEstimateHour.Size = new System.Drawing.Size(100, 20);
            this.txtBoxEstimateHour.TabIndex = 9;
            // 
            // lblActualHour
            // 
            this.lblActualHour.AutoSize = true;
            this.lblActualHour.Location = new System.Drawing.Point(358, 206);
            this.lblActualHour.Name = "lblActualHour";
            this.lblActualHour.Size = new System.Drawing.Size(61, 13);
            this.lblActualHour.TabIndex = 10;
            this.lblActualHour.Text = "Actual hour";
            // 
            // lblEstCompletion
            // 
            this.lblEstCompletion.AutoSize = true;
            this.lblEstCompletion.Location = new System.Drawing.Point(490, 206);
            this.lblEstCompletion.Name = "lblEstCompletion";
            this.lblEstCompletion.Size = new System.Drawing.Size(102, 13);
            this.lblEstCompletion.TabIndex = 11;
            this.lblEstCompletion.Text = "Estimate Completion";
            // 
            // txtBoxActualHour
            // 
            this.txtBoxActualHour.Location = new System.Drawing.Point(361, 242);
            this.txtBoxActualHour.Name = "txtBoxActualHour";
            this.txtBoxActualHour.Size = new System.Drawing.Size(100, 20);
            this.txtBoxActualHour.TabIndex = 12;
            // 
            // txtBoxEstimateCompletion
            // 
            this.txtBoxEstimateCompletion.Location = new System.Drawing.Point(493, 242);
            this.txtBoxEstimateCompletion.Name = "txtBoxEstimateCompletion";
            this.txtBoxEstimateCompletion.Size = new System.Drawing.Size(100, 20);
            this.txtBoxEstimateCompletion.TabIndex = 13;
            // 
            // btnCreateProject
            // 
            this.btnCreateProject.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnCreateProject.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateProject.Location = new System.Drawing.Point(63, 75);
            this.btnCreateProject.Name = "btnCreateProject";
            this.btnCreateProject.Size = new System.Drawing.Size(101, 32);
            this.btnCreateProject.TabIndex = 14;
            this.btnCreateProject.Text = "Create Project";
            this.btnCreateProject.UseVisualStyleBackColor = false;
            // 
            // btnViewProject
            // 
            this.btnViewProject.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnViewProject.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewProject.Location = new System.Drawing.Point(170, 75);
            this.btnViewProject.Name = "btnViewProject";
            this.btnViewProject.Size = new System.Drawing.Size(87, 32);
            this.btnViewProject.TabIndex = 15;
            this.btnViewProject.Text = "View Project";
            this.btnViewProject.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(263, 75);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 32);
            this.button1.TabIndex = 16;
            this.button1.Text = "View Report";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // btTimeSheet
            // 
            this.btTimeSheet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btTimeSheet.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTimeSheet.Location = new System.Drawing.Point(356, 75);
            this.btTimeSheet.Name = "btTimeSheet";
            this.btTimeSheet.Size = new System.Drawing.Size(91, 32);
            this.btTimeSheet.TabIndex = 17;
            this.btTimeSheet.Text = "Time Sheet";
            this.btTimeSheet.UseVisualStyleBackColor = false;
            // 
            // frmReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(769, 439);
            this.Controls.Add(this.btTimeSheet);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnViewProject);
            this.Controls.Add(this.btnCreateProject);
            this.Controls.Add(this.txtBoxEstimateCompletion);
            this.Controls.Add(this.txtBoxActualHour);
            this.Controls.Add(this.lblEstCompletion);
            this.Controls.Add(this.lblActualHour);
            this.Controls.Add(this.txtBoxEstimateHour);
            this.Controls.Add(this.lblEstHour);
            this.Controls.Add(this.txtBoxProjectName);
            this.Controls.Add(this.lblProjectName2);
            this.Controls.Add(this.btnViewReport);
            this.Controls.Add(this.lblProjectName);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lblTimeSheet);
            this.Name = "frmReport";
            this.Text = "frmReport";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTimeSheet;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblProjectName;
        private System.Windows.Forms.Button btnViewReport;
        private System.Windows.Forms.Label lblProjectName2;
        private System.Windows.Forms.TextBox txtBoxProjectName;
        private System.Windows.Forms.Label lblEstHour;
        private System.Windows.Forms.TextBox txtBoxEstimateHour;
        private System.Windows.Forms.Label lblActualHour;
        private System.Windows.Forms.Label lblEstCompletion;
        private System.Windows.Forms.TextBox txtBoxActualHour;
        private System.Windows.Forms.TextBox txtBoxEstimateCompletion;
        private System.Windows.Forms.Button btnCreateProject;
        private System.Windows.Forms.Button btnViewProject;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btTimeSheet;
    }
}