namespace Social_Mixy
{
    partial class FormDraw
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
            this.labelDisplay = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelDisplay
            // 
            this.labelDisplay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelDisplay.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDisplay.ForeColor = System.Drawing.SystemColors.Control;
            this.labelDisplay.Location = new System.Drawing.Point(0, 0);
            this.labelDisplay.Name = "labelDisplay";
            this.labelDisplay.Size = new System.Drawing.Size(800, 450);
            this.labelDisplay.TabIndex = 0;
            this.labelDisplay.Text = "Drawing a random winner... \r\n\r\n(Drum roll please...)";
            this.labelDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelDisplay.MouseClick += new System.Windows.Forms.MouseEventHandler(this.labelDisplay_MouseClick);
            // 
            // FormDraw
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelDisplay);
            this.Name = "FormDraw";
            this.Text = "Prize Draw";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormDraw_KeyDown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelDisplay;
    }
}