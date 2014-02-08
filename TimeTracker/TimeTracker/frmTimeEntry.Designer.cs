namespace TimeTracker
{
    partial class frmTimeEntry
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
            this.lblTimeEntry = new System.Windows.Forms.Label();
            this.lblProgramName = new System.Windows.Forms.Label();
            this.lblDay = new System.Windows.Forms.Label();
            this.lblTimeHr = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtboxProjectName = new System.Windows.Forms.TextBox();
            this.txtboxProjectDay = new System.Windows.Forms.TextBox();
            this.txtBoxProjectTime = new System.Windows.Forms.TextBox();
            this.txtBoxProjectDescription = new System.Windows.Forms.TextBox();
            this.btnCreateProject = new System.Windows.Forms.Button();
            this.btnViewProject = new System.Windows.Forms.Button();
            this.btnViewReport = new System.Windows.Forms.Button();
            this.btTimeSheet = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTimeSheet
            // 
            this.lblTimeSheet.AutoSize = true;
            this.lblTimeSheet.Font = new System.Drawing.Font("Gill Sans Ultra Bold Condensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimeSheet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTimeSheet.Location = new System.Drawing.Point(47, 20);
            this.lblTimeSheet.Name = "lblTimeSheet";
            this.lblTimeSheet.Size = new System.Drawing.Size(343, 36);
            this.lblTimeSheet.TabIndex = 1;
            this.lblTimeSheet.Text = "My company  Time  Tracker";
            // 
            // lblTimeEntry
            // 
            this.lblTimeEntry.AutoSize = true;
            this.lblTimeEntry.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimeEntry.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblTimeEntry.Location = new System.Drawing.Point(53, 152);
            this.lblTimeEntry.Name = "lblTimeEntry";
            this.lblTimeEntry.Size = new System.Drawing.Size(96, 20);
            this.lblTimeEntry.TabIndex = 3;
            this.lblTimeEntry.Text = "Time  Entry :";
            // 
            // lblProgramName
            // 
            this.lblProgramName.AutoSize = true;
            this.lblProgramName.Location = new System.Drawing.Point(50, 212);
            this.lblProgramName.Name = "lblProgramName";
            this.lblProgramName.Size = new System.Drawing.Size(71, 13);
            this.lblProgramName.TabIndex = 4;
            this.lblProgramName.Text = "Project Name";
            // 
            // lblDay
            // 
            this.lblDay.AutoSize = true;
            this.lblDay.Location = new System.Drawing.Point(181, 212);
            this.lblDay.Name = "lblDay";
            this.lblDay.Size = new System.Drawing.Size(62, 13);
            this.lblDay.TabIndex = 5;
            this.lblDay.Text = "Project Day";
            // 
            // lblTimeHr
            // 
            this.lblTimeHr.AutoSize = true;
            this.lblTimeHr.Location = new System.Drawing.Point(319, 212);
            this.lblTimeHr.Name = "lblTimeHr";
            this.lblTimeHr.Size = new System.Drawing.Size(97, 13);
            this.lblTimeHr.TabIndex = 6;
            this.lblTimeHr.Text = "Project Time(in hrs)";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(466, 212);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(96, 13);
            this.lblDescription.TabIndex = 7;
            this.lblDescription.Text = "Project Description";
            // 
            // txtboxProjectName
            // 
            this.txtboxProjectName.Location = new System.Drawing.Point(49, 255);
            this.txtboxProjectName.Name = "txtboxProjectName";
            this.txtboxProjectName.Size = new System.Drawing.Size(100, 20);
            this.txtboxProjectName.TabIndex = 8;
            // 
            // txtboxProjectDay
            // 
            this.txtboxProjectDay.Location = new System.Drawing.Point(184, 255);
            this.txtboxProjectDay.Name = "txtboxProjectDay";
            this.txtboxProjectDay.Size = new System.Drawing.Size(100, 20);
            this.txtboxProjectDay.TabIndex = 9;
            // 
            // txtBoxProjectTime
            // 
            this.txtBoxProjectTime.Location = new System.Drawing.Point(322, 255);
            this.txtBoxProjectTime.Name = "txtBoxProjectTime";
            this.txtBoxProjectTime.Size = new System.Drawing.Size(100, 20);
            this.txtBoxProjectTime.TabIndex = 10;
            // 
            // txtBoxProjectDescription
            // 
            this.txtBoxProjectDescription.Location = new System.Drawing.Point(469, 255);
            this.txtBoxProjectDescription.Name = "txtBoxProjectDescription";
            this.txtBoxProjectDescription.Size = new System.Drawing.Size(100, 20);
            this.txtBoxProjectDescription.TabIndex = 11;
            // 
            // btnCreateProject
            // 
            this.btnCreateProject.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnCreateProject.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateProject.Location = new System.Drawing.Point(57, 76);
            this.btnCreateProject.Name = "btnCreateProject";
            this.btnCreateProject.Size = new System.Drawing.Size(101, 32);
            this.btnCreateProject.TabIndex = 12;
            this.btnCreateProject.Text = "Create Project";
            this.btnCreateProject.UseVisualStyleBackColor = false;
            // 
            // btnViewProject
            // 
            this.btnViewProject.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnViewProject.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewProject.Location = new System.Drawing.Point(164, 76);
            this.btnViewProject.Name = "btnViewProject";
            this.btnViewProject.Size = new System.Drawing.Size(87, 32);
            this.btnViewProject.TabIndex = 16;
            this.btnViewProject.Text = "View Project";
            this.btnViewProject.UseVisualStyleBackColor = false;
            // 
            // btnViewReport
            // 
            this.btnViewReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnViewReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewReport.Location = new System.Drawing.Point(257, 76);
            this.btnViewReport.Name = "btnViewReport";
            this.btnViewReport.Size = new System.Drawing.Size(87, 32);
            this.btnViewReport.TabIndex = 17;
            this.btnViewReport.Text = "View Report";
            this.btnViewReport.UseVisualStyleBackColor = false;
            // 
            // btTimeSheet
            // 
            this.btTimeSheet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btTimeSheet.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTimeSheet.Location = new System.Drawing.Point(350, 76);
            this.btTimeSheet.Name = "btTimeSheet";
            this.btTimeSheet.Size = new System.Drawing.Size(91, 32);
            this.btTimeSheet.TabIndex = 18;
            this.btTimeSheet.Text = "Time Sheet";
            this.btTimeSheet.UseVisualStyleBackColor = false;
            // 
            // frmTimeEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(736, 471);
            this.Controls.Add(this.btTimeSheet);
            this.Controls.Add(this.btnViewReport);
            this.Controls.Add(this.btnViewProject);
            this.Controls.Add(this.btnCreateProject);
            this.Controls.Add(this.txtBoxProjectDescription);
            this.Controls.Add(this.txtBoxProjectTime);
            this.Controls.Add(this.txtboxProjectDay);
            this.Controls.Add(this.txtboxProjectName);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblTimeHr);
            this.Controls.Add(this.lblDay);
            this.Controls.Add(this.lblProgramName);
            this.Controls.Add(this.lblTimeEntry);
            this.Controls.Add(this.lblTimeSheet);
            this.Name = "frmTimeEntry";
            this.Text = "v";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTimeSheet;
        private System.Windows.Forms.Label lblTimeEntry;
        private System.Windows.Forms.Label lblProgramName;
        private System.Windows.Forms.Label lblDay;
        private System.Windows.Forms.Label lblTimeHr;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtboxProjectName;
        private System.Windows.Forms.TextBox txtboxProjectDay;
        private System.Windows.Forms.TextBox txtBoxProjectTime;
        private System.Windows.Forms.TextBox txtBoxProjectDescription;
        private System.Windows.Forms.Button btnCreateProject;
        private System.Windows.Forms.Button btnViewProject;
        private System.Windows.Forms.Button btnViewReport;
        private System.Windows.Forms.Button btTimeSheet;
    }
}