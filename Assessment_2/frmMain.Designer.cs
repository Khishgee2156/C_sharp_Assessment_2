namespace Assessment_2
{
    partial class frmMain
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
            this.btnTask1 = new System.Windows.Forms.Button();
            this.btnTask2 = new System.Windows.Forms.Button();
            this.btnNestedClass = new System.Windows.Forms.Button();
            this.btnOpenComparatorFrm = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(489, 308);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(101, 48);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnTask1
            // 
            this.btnTask1.Location = new System.Drawing.Point(45, 128);
            this.btnTask1.Name = "btnTask1";
            this.btnTask1.Size = new System.Drawing.Size(114, 55);
            this.btnTask1.TabIndex = 1;
            this.btnTask1.Text = "2D Graphics";
            this.btnTask1.UseVisualStyleBackColor = true;
            this.btnTask1.Click += new System.EventHandler(this.btnTask1_Click);
            // 
            // btnTask2
            // 
            this.btnTask2.Location = new System.Drawing.Point(185, 128);
            this.btnTask2.Name = "btnTask2";
            this.btnTask2.Size = new System.Drawing.Size(104, 55);
            this.btnTask2.TabIndex = 2;
            this.btnTask2.Text = "Drag and Drop";
            this.btnTask2.UseVisualStyleBackColor = true;
            this.btnTask2.Click += new System.EventHandler(this.btnTask2_Click);
            // 
            // btnNestedClass
            // 
            this.btnNestedClass.Location = new System.Drawing.Point(315, 128);
            this.btnNestedClass.Name = "btnNestedClass";
            this.btnNestedClass.Size = new System.Drawing.Size(107, 55);
            this.btnNestedClass.TabIndex = 3;
            this.btnNestedClass.Text = "Nested class";
            this.btnNestedClass.UseVisualStyleBackColor = true;
            this.btnNestedClass.Click += new System.EventHandler(this.btnNestedClass_Click);
            // 
            // btnOpenComparatorFrm
            // 
            this.btnOpenComparatorFrm.Location = new System.Drawing.Point(443, 128);
            this.btnOpenComparatorFrm.Name = "btnOpenComparatorFrm";
            this.btnOpenComparatorFrm.Size = new System.Drawing.Size(105, 55);
            this.btnOpenComparatorFrm.TabIndex = 4;
            this.btnOpenComparatorFrm.Text = "Comparator";
            this.btnOpenComparatorFrm.UseVisualStyleBackColor = true;
            this.btnOpenComparatorFrm.Click += new System.EventHandler(this.btnOpenComparatorFrm_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(68, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 22);
            this.label1.TabIndex = 5;
            this.label1.Text = "Task 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(207, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 22);
            this.label2.TabIndex = 6;
            this.label2.Text = "Task 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(335, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 22);
            this.label3.TabIndex = 7;
            this.label3.Text = "Task 4";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(465, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 22);
            this.label4.TabIndex = 8;
            this.label4.Text = "Task 5";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 368);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOpenComparatorFrm);
            this.Controls.Add(this.btnNestedClass);
            this.Controls.Add(this.btnTask2);
            this.Controls.Add(this.btnTask1);
            this.Controls.Add(this.btnExit);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main window";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnTask1;
        private System.Windows.Forms.Button btnTask2;
        private System.Windows.Forms.Button btnNestedClass;
        private System.Windows.Forms.Button btnOpenComparatorFrm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

