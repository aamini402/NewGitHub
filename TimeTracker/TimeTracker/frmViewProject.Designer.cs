namespace TimeTracker
{
    partial class frmViewProject
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Projectname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProjectCreationdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Projectdescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Projectestimatedate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Projectcomplietiondate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblProjectDetails = new System.Windows.Forms.Label();
            this.lblTimeSheet = new System.Windows.Forms.Label();
            this.btnCreateProject = new System.Windows.Forms.Button();
            this.btnViewProject = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btTimeSheet = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Projectname,
            this.ProjectCreationdate,
            this.Projectdescription,
            this.Projectestimatedate,
            this.Projectcomplietiondate});
            this.dataGridView1.Location = new System.Drawing.Point(69, 187);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(546, 284);
            this.dataGridView1.TabIndex = 0;
            // 
            // Projectname
            // 
            this.Projectname.HeaderText = "Project Name";
            this.Projectname.MinimumWidth = 15;
            this.Projectname.Name = "Projectname";
            // 
            // ProjectCreationdate
            // 
            this.ProjectCreationdate.HeaderText = "Project creation date";
            this.ProjectCreationdate.Name = "ProjectCreationdate";
            // 
            // Projectdescription
            // 
            this.Projectdescription.HeaderText = "ProjectDescription";
            this.Projectdescription.Name = "Projectdescription";
            // 
            // Projectestimatedate
            // 
            this.Projectestimatedate.HeaderText = "Project Estimate date";
            this.Projectestimatedate.Name = "Projectestimatedate";
            // 
            // Projectcomplietiondate
            // 
            this.Projectcomplietiondate.HeaderText = "Project complition date";
            this.Projectcomplietiondate.Name = "Projectcomplietiondate";
            // 
            // lblProjectDetails
            // 
            this.lblProjectDetails.AutoSize = true;
            this.lblProjectDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProjectDetails.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblProjectDetails.Location = new System.Drawing.Point(66, 136);
            this.lblProjectDetails.Name = "lblProjectDetails";
            this.lblProjectDetails.Size = new System.Drawing.Size(108, 18);
            this.lblProjectDetails.TabIndex = 1;
            this.lblProjectDetails.Text = "Project Details:";
            // 
            // lblTimeSheet
            // 
            this.lblTimeSheet.AutoSize = true;
            this.lblTimeSheet.Font = new System.Drawing.Font("Gill Sans Ultra Bold Condensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimeSheet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTimeSheet.Location = new System.Drawing.Point(63, 23);
            this.lblTimeSheet.Name = "lblTimeSheet";
            this.lblTimeSheet.Size = new System.Drawing.Size(343, 36);
            this.lblTimeSheet.TabIndex = 2;
            this.lblTimeSheet.Text = "My company  Time  Tracker";
            // 
            // btnCreateProject
            // 
            this.btnCreateProject.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnCreateProject.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateProject.Location = new System.Drawing.Point(69, 75);
            this.btnCreateProject.Name = "btnCreateProject";
            this.btnCreateProject.Size = new System.Drawing.Size(101, 32);
            this.btnCreateProject.TabIndex = 15;
            this.btnCreateProject.Text = "Create Project";
            this.btnCreateProject.UseVisualStyleBackColor = false;
            // 
            // btnViewProject
            // 
            this.btnViewProject.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnViewProject.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewProject.Location = new System.Drawing.Point(176, 75);
            this.btnViewProject.Name = "btnViewProject";
            this.btnViewProject.Size = new System.Drawing.Size(87, 32);
            this.btnViewProject.TabIndex = 16;
            this.btnViewProject.Text = "View Project";
            this.btnViewProject.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(269, 75);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 32);
            this.button1.TabIndex = 17;
            this.button1.Text = "View Report";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // btTimeSheet
            // 
            this.btTimeSheet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btTimeSheet.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTimeSheet.Location = new System.Drawing.Point(362, 75);
            this.btTimeSheet.Name = "btTimeSheet";
            this.btTimeSheet.Size = new System.Drawing.Size(91, 32);
            this.btTimeSheet.TabIndex = 18;
            this.btTimeSheet.Text = "Time Sheet";
            this.btTimeSheet.UseVisualStyleBackColor = false;
            // 
            // frmViewProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(757, 483);
            this.Controls.Add(this.btTimeSheet);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnViewProject);
            this.Controls.Add(this.btnCreateProject);
            this.Controls.Add(this.lblTimeSheet);
            this.Controls.Add(this.lblProjectDetails);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmViewProject";
            this.Text = "ViewProject";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblProjectDetails;
        private System.Windows.Forms.DataGridViewTextBoxColumn Projectname;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProjectCreationdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Projectdescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn Projectestimatedate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Projectcomplietiondate;
        private System.Windows.Forms.Label lblTimeSheet;
        private System.Windows.Forms.Button btnCreateProject;
        private System.Windows.Forms.Button btnViewProject;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btTimeSheet;
    }
}