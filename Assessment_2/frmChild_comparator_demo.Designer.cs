namespace Assessment_2
{
    partial class frmChild_comparator_demo
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
            this.label1 = new System.Windows.Forms.Label();
            this.lstBox_students = new System.Windows.Forms.ListBox();
            this.btnSortByAge = new System.Windows.Forms.Button();
            this.btnSortByName = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "List of students";
            // 
            // lstBox_students
            // 
            this.lstBox_students.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstBox_students.FormattingEnabled = true;
            this.lstBox_students.ItemHeight = 20;
            this.lstBox_students.Location = new System.Drawing.Point(17, 63);
            this.lstBox_students.Name = "lstBox_students";
            this.lstBox_students.Size = new System.Drawing.Size(409, 244);
            this.lstBox_students.TabIndex = 1;
            // 
            // btnSortByAge
            // 
            this.btnSortByAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSortByAge.Location = new System.Drawing.Point(459, 63);
            this.btnSortByAge.Name = "btnSortByAge";
            this.btnSortByAge.Size = new System.Drawing.Size(123, 62);
            this.btnSortByAge.TabIndex = 2;
            this.btnSortByAge.Text = "Sort students by their age";
            this.btnSortByAge.UseVisualStyleBackColor = true;
            this.btnSortByAge.Click += new System.EventHandler(this.btnSortByAge_Click);
            // 
            // btnSortByName
            // 
            this.btnSortByName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSortByName.Location = new System.Drawing.Point(459, 151);
            this.btnSortByName.Name = "btnSortByName";
            this.btnSortByName.Size = new System.Drawing.Size(123, 58);
            this.btnSortByName.TabIndex = 3;
            this.btnSortByName.Text = "Sort students by their name";
            this.btnSortByName.UseVisualStyleBackColor = true;
            this.btnSortByName.Click += new System.EventHandler(this.btnSortByName_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(486, 342);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(96, 35);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmChild_comparator_demo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 389);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSortByName);
            this.Controls.Add(this.btnSortByAge);
            this.Controls.Add(this.lstBox_students);
            this.Controls.Add(this.label1);
            this.Name = "frmChild_comparator_demo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Comparator demo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstBox_students;
        private System.Windows.Forms.Button btnSortByAge;
        private System.Windows.Forms.Button btnSortByName;
        private System.Windows.Forms.Button btnExit;
    }
}