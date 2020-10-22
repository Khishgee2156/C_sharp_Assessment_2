namespace Assessment_2
{
    partial class frmChild_nested_class
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
            this.btnExit = new System.Windows.Forms.Button();
            this.btnDisplayStudents = new System.Windows.Forms.Button();
            this.lstStudents = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(493, 204);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(85, 42);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnDisplayStudents
            // 
            this.btnDisplayStudents.Location = new System.Drawing.Point(477, 40);
            this.btnDisplayStudents.Name = "btnDisplayStudents";
            this.btnDisplayStudents.Size = new System.Drawing.Size(101, 55);
            this.btnDisplayStudents.TabIndex = 2;
            this.btnDisplayStudents.Text = "Display Students";
            this.btnDisplayStudents.UseVisualStyleBackColor = true;
            this.btnDisplayStudents.Click += new System.EventHandler(this.btnDisplayStudents_Click);
            // 
            // lstStudents
            // 
            this.lstStudents.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstStudents.FormattingEnabled = true;
            this.lstStudents.ItemHeight = 20;
            this.lstStudents.Location = new System.Drawing.Point(39, 40);
            this.lstStudents.Name = "lstStudents";
            this.lstStudents.Size = new System.Drawing.Size(318, 144);
            this.lstStudents.TabIndex = 1;
            // 
            // frmChild_nested_class
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 257);
            this.Controls.Add(this.btnDisplayStudents);
            this.Controls.Add(this.lstStudents);
            this.Controls.Add(this.btnExit);
            this.Name = "frmChild_nested_class";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Demonstrating nested class";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnDisplayStudents;
        private System.Windows.Forms.ListBox lstStudents;
    }
}