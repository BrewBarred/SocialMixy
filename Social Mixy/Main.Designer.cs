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
            this.buttonCopyMailingList = new System.Windows.Forms.Button();
            this.buttonStartDraw = new System.Windows.Forms.Button();
            this.panelStats = new System.Windows.Forms.Panel();
            this.buttonPrintSelected = new System.Windows.Forms.Button();
            this.buttonFilterClear = new System.Windows.Forms.Button();
            this.textBox3rdYears = new System.Windows.Forms.TextBox();
            this.buttonFilterShuttles = new System.Windows.Forms.Button();
            this.label3rdYears = new System.Windows.Forms.Label();
            this.buttonFilterDiets = new System.Windows.Forms.Button();
            this.textBox2ndYears = new System.Windows.Forms.TextBox();
            this.labelSecondYears = new System.Windows.Forms.Label();
            this.textBox1stYears = new System.Windows.Forms.TextBox();
            this.label1stYears = new System.Windows.Forms.Label();
            this.textBoxShuttlesHome = new System.Windows.Forms.TextBox();
            this.labelShuttlesHome = new System.Windows.Forms.Label();
            this.textBoxAlumni = new System.Windows.Forms.TextBox();
            this.labelAlumni = new System.Windows.Forms.Label();
            this.textBoxStaff = new System.Windows.Forms.TextBox();
            this.labelStaff = new System.Windows.Forms.Label();
            this.textBoxStudents = new System.Windows.Forms.TextBox();
            this.labelStudents = new System.Windows.Forms.Label();
            this.textBoxShuttlesCampus = new System.Windows.Forms.TextBox();
            this.labelShuttlesCampus = new System.Windows.Forms.Label();
            this.textBoxHamilton = new System.Windows.Forms.TextBox();
            this.textBoxTauranga = new System.Windows.Forms.TextBox();
            this.textBoxTotal = new System.Windows.Forms.TextBox();
            this.labelTauranga = new System.Windows.Forms.Label();
            this.labelHamilton = new System.Windows.Forms.Label();
            this.labelTotal = new System.Windows.Forms.Label();
            this.panelListView.SuspendLayout();
            this.panelStats.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelListView
            // 
            this.panelListView.AutoSize = true;
            this.panelListView.Controls.Add(this.listViewRegistrants);
            this.panelListView.Location = new System.Drawing.Point(-9, -9);
            this.panelListView.MinimumSize = new System.Drawing.Size(1151, 410);
            this.panelListView.Name = "panelListView";
            this.panelListView.Padding = new System.Windows.Forms.Padding(20);
            this.panelListView.Size = new System.Drawing.Size(1151, 419);
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
            this.listViewRegistrants.FullRowSelect = true;
            this.listViewRegistrants.HideSelection = false;
            this.listViewRegistrants.Location = new System.Drawing.Point(20, 20);
            this.listViewRegistrants.Name = "listViewRegistrants";
            this.listViewRegistrants.Size = new System.Drawing.Size(1111, 379);
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
            // buttonCopyMailingList
            // 
            this.buttonCopyMailingList.ForeColor = System.Drawing.Color.Firebrick;
            this.buttonCopyMailingList.Location = new System.Drawing.Point(1001, 3);
            this.buttonCopyMailingList.Name = "buttonCopyMailingList";
            this.buttonCopyMailingList.Size = new System.Drawing.Size(108, 23);
            this.buttonCopyMailingList.TabIndex = 1;
            this.buttonCopyMailingList.Text = "Copy Mailing List";
            this.buttonCopyMailingList.UseVisualStyleBackColor = true;
            this.buttonCopyMailingList.Click += new System.EventHandler(this.buttonEmails_Click);
            // 
            // buttonStartDraw
            // 
            this.buttonStartDraw.ForeColor = System.Drawing.Color.Firebrick;
            this.buttonStartDraw.Location = new System.Drawing.Point(887, 32);
            this.buttonStartDraw.Name = "buttonStartDraw";
            this.buttonStartDraw.Size = new System.Drawing.Size(222, 23);
            this.buttonStartDraw.TabIndex = 2;
            this.buttonStartDraw.Text = "Start Prize Draw!";
            this.buttonStartDraw.UseVisualStyleBackColor = true;
            this.buttonStartDraw.Click += new System.EventHandler(this.buttonStartDraw_Click);
            // 
            // panelStats
            // 
            this.panelStats.Controls.Add(this.buttonPrintSelected);
            this.panelStats.Controls.Add(this.buttonStartDraw);
            this.panelStats.Controls.Add(this.buttonFilterClear);
            this.panelStats.Controls.Add(this.textBox3rdYears);
            this.panelStats.Controls.Add(this.buttonCopyMailingList);
            this.panelStats.Controls.Add(this.buttonFilterShuttles);
            this.panelStats.Controls.Add(this.label3rdYears);
            this.panelStats.Controls.Add(this.buttonFilterDiets);
            this.panelStats.Controls.Add(this.textBox2ndYears);
            this.panelStats.Controls.Add(this.labelSecondYears);
            this.panelStats.Controls.Add(this.textBox1stYears);
            this.panelStats.Controls.Add(this.label1stYears);
            this.panelStats.Controls.Add(this.textBoxShuttlesHome);
            this.panelStats.Controls.Add(this.labelShuttlesHome);
            this.panelStats.Controls.Add(this.textBoxAlumni);
            this.panelStats.Controls.Add(this.labelAlumni);
            this.panelStats.Controls.Add(this.textBoxStaff);
            this.panelStats.Controls.Add(this.labelStaff);
            this.panelStats.Controls.Add(this.textBoxStudents);
            this.panelStats.Controls.Add(this.labelStudents);
            this.panelStats.Controls.Add(this.textBoxShuttlesCampus);
            this.panelStats.Controls.Add(this.labelShuttlesCampus);
            this.panelStats.Controls.Add(this.textBoxHamilton);
            this.panelStats.Controls.Add(this.textBoxTauranga);
            this.panelStats.Controls.Add(this.textBoxTotal);
            this.panelStats.Controls.Add(this.labelTauranga);
            this.panelStats.Controls.Add(this.labelHamilton);
            this.panelStats.Controls.Add(this.labelTotal);
            this.panelStats.Location = new System.Drawing.Point(13, 409);
            this.panelStats.Name = "panelStats";
            this.panelStats.Size = new System.Drawing.Size(1129, 156);
            this.panelStats.TabIndex = 3;
            // 
            // buttonPrintSelected
            // 
            this.buttonPrintSelected.ForeColor = System.Drawing.Color.Firebrick;
            this.buttonPrintSelected.Location = new System.Drawing.Point(887, 3);
            this.buttonPrintSelected.Name = "buttonPrintSelected";
            this.buttonPrintSelected.Size = new System.Drawing.Size(108, 23);
            this.buttonPrintSelected.TabIndex = 22;
            this.buttonPrintSelected.Text = "Print Selected";
            this.buttonPrintSelected.UseVisualStyleBackColor = true;
            this.buttonPrintSelected.Click += new System.EventHandler(this.buttonPrintSelected_Click);
            // 
            // buttonFilterClear
            // 
            this.buttonFilterClear.ForeColor = System.Drawing.Color.Firebrick;
            this.buttonFilterClear.Location = new System.Drawing.Point(8, 32);
            this.buttonFilterClear.Name = "buttonFilterClear";
            this.buttonFilterClear.Size = new System.Drawing.Size(108, 23);
            this.buttonFilterClear.TabIndex = 6;
            this.buttonFilterClear.Text = "Clear Filter";
            this.buttonFilterClear.UseVisualStyleBackColor = true;
            this.buttonFilterClear.Click += new System.EventHandler(this.buttonFilterClear_Click);
            // 
            // textBox3rdYears
            // 
            this.textBox3rdYears.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox3rdYears.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox3rdYears.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox3rdYears.Location = new System.Drawing.Point(415, 118);
            this.textBox3rdYears.Name = "textBox3rdYears";
            this.textBox3rdYears.ReadOnly = true;
            this.textBox3rdYears.Size = new System.Drawing.Size(125, 20);
            this.textBox3rdYears.TabIndex = 21;
            // 
            // buttonFilterShuttles
            // 
            this.buttonFilterShuttles.ForeColor = System.Drawing.Color.Firebrick;
            this.buttonFilterShuttles.Location = new System.Drawing.Point(122, 3);
            this.buttonFilterShuttles.Name = "buttonFilterShuttles";
            this.buttonFilterShuttles.Size = new System.Drawing.Size(108, 23);
            this.buttonFilterShuttles.TabIndex = 5;
            this.buttonFilterShuttles.Text = "Filter Shuttle Info";
            this.buttonFilterShuttles.UseVisualStyleBackColor = true;
            this.buttonFilterShuttles.Click += new System.EventHandler(this.buttonFilterShuttles_Click);
            // 
            // label3rdYears
            // 
            this.label3rdYears.AutoSize = true;
            this.label3rdYears.ForeColor = System.Drawing.Color.Firebrick;
            this.label3rdYears.Location = new System.Drawing.Point(324, 120);
            this.label3rdYears.Name = "label3rdYears";
            this.label3rdYears.Size = new System.Drawing.Size(82, 13);
            this.label3rdYears.TabIndex = 20;
            this.label3rdYears.Text = "Total 3rd Years:";
            // 
            // buttonFilterDiets
            // 
            this.buttonFilterDiets.ForeColor = System.Drawing.Color.Firebrick;
            this.buttonFilterDiets.Location = new System.Drawing.Point(8, 3);
            this.buttonFilterDiets.Name = "buttonFilterDiets";
            this.buttonFilterDiets.Size = new System.Drawing.Size(108, 23);
            this.buttonFilterDiets.TabIndex = 4;
            this.buttonFilterDiets.Text = "Filter Diets";
            this.buttonFilterDiets.UseVisualStyleBackColor = true;
            this.buttonFilterDiets.Click += new System.EventHandler(this.buttonFilterDiets_Click);
            // 
            // textBox2ndYears
            // 
            this.textBox2ndYears.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox2ndYears.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2ndYears.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox2ndYears.Location = new System.Drawing.Point(415, 95);
            this.textBox2ndYears.Name = "textBox2ndYears";
            this.textBox2ndYears.ReadOnly = true;
            this.textBox2ndYears.Size = new System.Drawing.Size(125, 20);
            this.textBox2ndYears.TabIndex = 19;
            // 
            // labelSecondYears
            // 
            this.labelSecondYears.AutoSize = true;
            this.labelSecondYears.ForeColor = System.Drawing.Color.Firebrick;
            this.labelSecondYears.Location = new System.Drawing.Point(324, 98);
            this.labelSecondYears.Name = "labelSecondYears";
            this.labelSecondYears.Size = new System.Drawing.Size(85, 13);
            this.labelSecondYears.TabIndex = 18;
            this.labelSecondYears.Text = "Total 2nd Years:";
            // 
            // textBox1stYears
            // 
            this.textBox1stYears.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox1stYears.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1stYears.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox1stYears.Location = new System.Drawing.Point(415, 72);
            this.textBox1stYears.Name = "textBox1stYears";
            this.textBox1stYears.ReadOnly = true;
            this.textBox1stYears.Size = new System.Drawing.Size(125, 20);
            this.textBox1stYears.TabIndex = 17;
            // 
            // label1stYears
            // 
            this.label1stYears.AutoSize = true;
            this.label1stYears.ForeColor = System.Drawing.Color.Firebrick;
            this.label1stYears.Location = new System.Drawing.Point(324, 74);
            this.label1stYears.Name = "label1stYears";
            this.label1stYears.Size = new System.Drawing.Size(81, 13);
            this.label1stYears.TabIndex = 16;
            this.label1stYears.Text = "Total 1st Years:";
            // 
            // textBoxShuttlesHome
            // 
            this.textBoxShuttlesHome.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxShuttlesHome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxShuttlesHome.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxShuttlesHome.Location = new System.Drawing.Point(710, 95);
            this.textBoxShuttlesHome.Name = "textBoxShuttlesHome";
            this.textBoxShuttlesHome.ReadOnly = true;
            this.textBoxShuttlesHome.Size = new System.Drawing.Size(125, 20);
            this.textBoxShuttlesHome.TabIndex = 15;
            // 
            // labelShuttlesHome
            // 
            this.labelShuttlesHome.AutoSize = true;
            this.labelShuttlesHome.ForeColor = System.Drawing.Color.Firebrick;
            this.labelShuttlesHome.Location = new System.Drawing.Point(587, 97);
            this.labelShuttlesHome.Name = "labelShuttlesHome";
            this.labelShuttlesHome.Size = new System.Drawing.Size(109, 13);
            this.labelShuttlesHome.TabIndex = 14;
            this.labelShuttlesHome.Text = "Total Home Shuttlers:";
            // 
            // textBoxAlumni
            // 
            this.textBoxAlumni.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxAlumni.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxAlumni.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxAlumni.Location = new System.Drawing.Point(151, 121);
            this.textBoxAlumni.Name = "textBoxAlumni";
            this.textBoxAlumni.ReadOnly = true;
            this.textBoxAlumni.Size = new System.Drawing.Size(125, 20);
            this.textBoxAlumni.TabIndex = 13;
            // 
            // labelAlumni
            // 
            this.labelAlumni.AutoSize = true;
            this.labelAlumni.ForeColor = System.Drawing.Color.Firebrick;
            this.labelAlumni.Location = new System.Drawing.Point(67, 123);
            this.labelAlumni.Name = "labelAlumni";
            this.labelAlumni.Size = new System.Drawing.Size(68, 13);
            this.labelAlumni.TabIndex = 12;
            this.labelAlumni.Text = "Total Alumni:";
            // 
            // textBoxStaff
            // 
            this.textBoxStaff.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxStaff.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxStaff.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxStaff.Location = new System.Drawing.Point(151, 98);
            this.textBoxStaff.Name = "textBoxStaff";
            this.textBoxStaff.ReadOnly = true;
            this.textBoxStaff.Size = new System.Drawing.Size(125, 20);
            this.textBoxStaff.TabIndex = 11;
            // 
            // labelStaff
            // 
            this.labelStaff.AutoSize = true;
            this.labelStaff.ForeColor = System.Drawing.Color.Firebrick;
            this.labelStaff.Location = new System.Drawing.Point(67, 100);
            this.labelStaff.Name = "labelStaff";
            this.labelStaff.Size = new System.Drawing.Size(59, 13);
            this.labelStaff.TabIndex = 10;
            this.labelStaff.Text = "Total Staff:";
            // 
            // textBoxStudents
            // 
            this.textBoxStudents.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxStudents.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxStudents.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxStudents.Location = new System.Drawing.Point(151, 75);
            this.textBoxStudents.Name = "textBoxStudents";
            this.textBoxStudents.ReadOnly = true;
            this.textBoxStudents.Size = new System.Drawing.Size(125, 20);
            this.textBoxStudents.TabIndex = 9;
            // 
            // labelStudents
            // 
            this.labelStudents.AutoSize = true;
            this.labelStudents.ForeColor = System.Drawing.Color.Firebrick;
            this.labelStudents.Location = new System.Drawing.Point(67, 77);
            this.labelStudents.Name = "labelStudents";
            this.labelStudents.Size = new System.Drawing.Size(79, 13);
            this.labelStudents.TabIndex = 8;
            this.labelStudents.Text = "Total Students:";
            // 
            // textBoxShuttlesCampus
            // 
            this.textBoxShuttlesCampus.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxShuttlesCampus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxShuttlesCampus.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxShuttlesCampus.Location = new System.Drawing.Point(710, 72);
            this.textBoxShuttlesCampus.Name = "textBoxShuttlesCampus";
            this.textBoxShuttlesCampus.ReadOnly = true;
            this.textBoxShuttlesCampus.Size = new System.Drawing.Size(125, 20);
            this.textBoxShuttlesCampus.TabIndex = 7;
            // 
            // labelShuttlesCampus
            // 
            this.labelShuttlesCampus.AutoSize = true;
            this.labelShuttlesCampus.ForeColor = System.Drawing.Color.Firebrick;
            this.labelShuttlesCampus.Location = new System.Drawing.Point(587, 74);
            this.labelShuttlesCampus.Name = "labelShuttlesCampus";
            this.labelShuttlesCampus.Size = new System.Drawing.Size(119, 13);
            this.labelShuttlesCampus.TabIndex = 6;
            this.labelShuttlesCampus.Text = "Total Campus Shuttlers:";
            // 
            // textBoxHamilton
            // 
            this.textBoxHamilton.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxHamilton.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxHamilton.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxHamilton.Location = new System.Drawing.Point(984, 70);
            this.textBoxHamilton.Name = "textBoxHamilton";
            this.textBoxHamilton.ReadOnly = true;
            this.textBoxHamilton.Size = new System.Drawing.Size(125, 20);
            this.textBoxHamilton.TabIndex = 5;
            // 
            // textBoxTauranga
            // 
            this.textBoxTauranga.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxTauranga.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxTauranga.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxTauranga.Location = new System.Drawing.Point(984, 93);
            this.textBoxTauranga.Name = "textBoxTauranga";
            this.textBoxTauranga.ReadOnly = true;
            this.textBoxTauranga.Size = new System.Drawing.Size(125, 20);
            this.textBoxTauranga.TabIndex = 4;
            // 
            // textBoxTotal
            // 
            this.textBoxTotal.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxTotal.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxTotal.Location = new System.Drawing.Point(984, 116);
            this.textBoxTotal.Name = "textBoxTotal";
            this.textBoxTotal.ReadOnly = true;
            this.textBoxTotal.Size = new System.Drawing.Size(125, 20);
            this.textBoxTotal.TabIndex = 3;
            // 
            // labelTauranga
            // 
            this.labelTauranga.AutoSize = true;
            this.labelTauranga.ForeColor = System.Drawing.Color.Firebrick;
            this.labelTauranga.Location = new System.Drawing.Point(885, 95);
            this.labelTauranga.Name = "labelTauranga";
            this.labelTauranga.Size = new System.Drawing.Size(83, 13);
            this.labelTauranga.TabIndex = 2;
            this.labelTauranga.Text = "Total Tauranga:";
            // 
            // labelHamilton
            // 
            this.labelHamilton.AutoSize = true;
            this.labelHamilton.ForeColor = System.Drawing.Color.Firebrick;
            this.labelHamilton.Location = new System.Drawing.Point(885, 72);
            this.labelHamilton.Name = "labelHamilton";
            this.labelHamilton.Size = new System.Drawing.Size(78, 13);
            this.labelHamilton.TabIndex = 1;
            this.labelHamilton.Text = "Total Hamilton:";
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.ForeColor = System.Drawing.Color.Firebrick;
            this.labelTotal.Location = new System.Drawing.Point(885, 119);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(93, 13);
            this.labelTotal.TabIndex = 0;
            this.labelTotal.Text = "Total Registrants: ";
            // 
            // Main
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1140, 588);
            this.Controls.Add(this.panelStats);
            this.Controls.Add(this.panelListView);
            this.ForeColor = System.Drawing.Color.Salmon;
            this.Name = "Main";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Social Mixy App :)";
            this.Load += new System.EventHandler(this.Main_Load);
            this.Resize += new System.EventHandler(this.Main_Resize);
            this.panelListView.ResumeLayout(false);
            this.panelStats.ResumeLayout(false);
            this.panelStats.PerformLayout();
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
        private System.Windows.Forms.Button buttonCopyMailingList;
        private System.Windows.Forms.Button buttonStartDraw;
        private System.Windows.Forms.Panel panelStats;
        private System.Windows.Forms.Label labelHamilton;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Label labelTauranga;
        private System.Windows.Forms.Label labelShuttlesCampus;
        private System.Windows.Forms.TextBox textBoxHamilton;
        private System.Windows.Forms.TextBox textBoxTauranga;
        private System.Windows.Forms.TextBox textBoxTotal;
        private System.Windows.Forms.Button buttonFilterDiets;
        private System.Windows.Forms.TextBox textBoxStaff;
        private System.Windows.Forms.Label labelStaff;
        private System.Windows.Forms.TextBox textBoxStudents;
        private System.Windows.Forms.Label labelStudents;
        private System.Windows.Forms.TextBox textBoxShuttlesCampus;
        private System.Windows.Forms.TextBox textBoxAlumni;
        private System.Windows.Forms.Label labelAlumni;
        private System.Windows.Forms.TextBox textBoxShuttlesHome;
        private System.Windows.Forms.Label labelShuttlesHome;
        private System.Windows.Forms.Button buttonFilterShuttles;
        private System.Windows.Forms.Button buttonFilterClear;
        private System.Windows.Forms.TextBox textBox3rdYears;
        private System.Windows.Forms.Label label3rdYears;
        private System.Windows.Forms.TextBox textBox2ndYears;
        private System.Windows.Forms.Label labelSecondYears;
        private System.Windows.Forms.TextBox textBox1stYears;
        private System.Windows.Forms.Label label1stYears;
        private System.Windows.Forms.Button buttonPrintSelected;
    }
}

