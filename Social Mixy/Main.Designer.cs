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
            this.panel1 = new System.Windows.Forms.Panel();
            this.listviewRegistrants = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(484, 172);
            this.panel1.TabIndex = 0;
            // 
            // listviewRegistrants
            // 
            this.listviewRegistrants.HideSelection = false;
            this.listviewRegistrants.Location = new System.Drawing.Point(142, 229);
            this.listviewRegistrants.Name = "listviewRegistrants";
            this.listviewRegistrants.Size = new System.Drawing.Size(467, 151);
            this.listviewRegistrants.TabIndex = 0;
            this.listviewRegistrants.UseCompatibleStateImageBehavior = false;
            this.listviewRegistrants.View = System.Windows.Forms.View.Details;
            // 
            // Main
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listviewRegistrants);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.Salmon;
            this.Name = "Main";
            this.Text = "Social Mixy App :)";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListView listviewRegistrants;
    }
}

