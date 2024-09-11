namespace Social_Mixy
{
    partial class Main
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
            this.panelListView = new System.Windows.Forms.Panel();
            this.listViewRegistrants = new System.Windows.Forms.ListView();
            this.colRegId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colFirstName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colLastName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colStudentId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colEmail = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colReceiveUpdates = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colCampus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colRideRequired = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colRideRequiredHome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colStudyLevel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colFirstMajor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDietPref = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonEmails = new System.Windows.Forms.Button();
            this.buttonStartDraw = new System.Windows.Forms.Button();
            this.panelListView.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelListView
            // 
            this.panelListView.AutoSize = true;
            this.panelListView.Controls.Add(this.listViewRegistrants);
            this.panelListView.Location = new System.Drawing.Point(-9, -9);
            this.panelListView.Name = "panelListView";
            this.panelListView.Padding = new System.Windows.Forms.Padding(20);
            this.panelListView.Size = new System.Drawing.Size(1185, 209);
            this.panelListView.TabIndex = 0;
            // 
            // listViewRegistrants
            // 
            this.listViewRegistrants.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colRegId,
            this.colFirstName,
            this.colLastName,
            this.colStudentId,
            this.colEmail,
            this.colReceiveUpdates,
            this.colCampus,
            this.colRideRequired,
            this.colRideRequiredHome,
            this.colStudyLevel,
            this.colFirstMajor,
            this.colDietPref});
            this.listViewRegistrants.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewRegistrants.HideSelection = false;
            this.listViewRegistrants.Location = new System.Drawing.Point(20, 20);
            this.listViewRegistrants.Name = "listViewRegistrants";
            this.listViewRegistrants.Size = new System.Drawing.Size(1145, 169);
            this.listViewRegistrants.TabIndex = 0;
            this.listViewRegistrants.UseCompatibleStateImageBehavior = false;
            this.listViewRegistrants.View = System.Windows.Forms.View.Details;
            // 
            // colRegId
            // 
            this.colRegId.Text = "No.";
            this.colRegId.Width = 30;
            // 
            // colFirstName
            // 
            this.colFirstName.Text = "First Name:";
            this.colFirstName.Width = 100;
            // 
            // colLastName
            // 
            this.colLastName.Text = "Last Name";
            this.colLastName.Width = 100;
            // 
            // colStudentId
            // 
            this.colStudentId.Text = "Student Id:";
            this.colStudentId.Width = 90;
            // 
            // colEmail
            // 
            this.colEmail.Text = "Email:";
            this.colEmail.Width = 180;
            // 
            // colReceiveUpdates
            // 
            this.colReceiveUpdates.Text = "Reminder:";
            this.colReceiveUpdates.Width = 90;
            // 
            // colCampus
            // 
            this.colCampus.Text = "Campus:";
            this.colCampus.Width = 90;
            // 
            // colRideRequired
            // 
            this.colRideRequired.Text = "Shuttle:";
            this.colRideRequired.Width = 80;
            // 
            // colRideRequiredHome
            // 
            this.colRideRequiredHome.Text = "Shuttle Home:";
            this.colRideRequiredHome.Width = 90;
            // 
            // colStudyLevel
            // 
            this.colStudyLevel.Text = "Study Level:";
            this.colStudyLevel.Width = 90;
            // 
            // colFirstMajor
            // 
            this.colFirstMajor.Text = "First Major:";
            this.colFirstMajor.Width = 150;
            // 
            // colDietPref
            // 
            this.colDietPref.Text = "Dietary Preferences:";
            this.colDietPref.Width = 250;
            // 
            // buttonEmails
            // 
            this.buttonEmails.ForeColor = System.Drawing.Color.Black;
            this.buttonEmails.Location = new System.Drawing.Point(1048, 206);
            this.buttonEmails.Name = "buttonEmails";
            this.buttonEmails.Size = new System.Drawing.Size(108, 23);
            this.buttonEmails.TabIndex = 1;
            this.buttonEmails.Text = "Copy Emails";
            this.buttonEmails.UseVisualStyleBackColor = true;
            this.buttonEmails.Click += new System.EventHandler(this.buttonEmails_Click);
            // 
            // buttonStartDraw
            // 
            this.buttonStartDraw.ForeColor = System.Drawing.Color.Black;
            this.buttonStartDraw.Location = new System.Drawing.Point(1048, 235);
            this.buttonStartDraw.Name = "buttonStartDraw";
            this.buttonStartDraw.Size = new System.Drawing.Size(108, 23);
            this.buttonStartDraw.TabIndex = 2;
            this.buttonStartDraw.Text = "Start Draw";
            this.buttonStartDraw.UseVisualStyleBackColor = true;
            this.buttonStartDraw.Click += new System.EventHandler(this.buttonStartDraw_Click);
            // 
            // Main
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1184, 561);
            this.Controls.Add(this.buttonStartDraw);
            this.Controls.Add(this.buttonEmails);
            this.Controls.Add(this.panelListView);
            this.ForeColor = System.Drawing.Color.Salmon;
            this.MinimumSize = new System.Drawing.Size(1200, 600);
            this.Name = "Main";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Social Mixy App :)";
            this.Load += new System.EventHandler(this.Main_Load);
            this.Resize += new System.EventHandler(this.Main_Resize);
            this.panelListView.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelListView;
        private System.Windows.Forms.ListView listViewRegistrants;
        private System.Windows.Forms.ColumnHeader colFirstName;
        private System.Windows.Forms.ColumnHeader colRegId;
        private System.Windows.Forms.ColumnHeader colLastName;
        private System.Windows.Forms.ColumnHeader colStudentId;
        private System.Windows.Forms.ColumnHeader colEmail;
        private System.Windows.Forms.ColumnHeader colReceiveUpdates;
        private System.Windows.Forms.ColumnHeader colCampus;
        private System.Windows.Forms.ColumnHeader colRideRequired;
        private System.Windows.Forms.ColumnHeader colRideRequiredHome;
        private System.Windows.Forms.ColumnHeader colStudyLevel;
        private System.Windows.Forms.ColumnHeader colFirstMajor;
        private System.Windows.Forms.ColumnHeader colDietPref;
        private System.Windows.Forms.Button buttonEmails;
        private System.Windows.Forms.Button buttonStartDraw;
    }
}

