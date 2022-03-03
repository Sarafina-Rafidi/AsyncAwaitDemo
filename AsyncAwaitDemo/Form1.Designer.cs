namespace AsyncAwaitDemo
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnProcessFile = new System.Windows.Forms.Button();
            this.lblCount = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnProcessFile
            // 
            this.btnProcessFile.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnProcessFile.Location = new System.Drawing.Point(308, 117);
            this.btnProcessFile.Name = "btnProcessFile";
            this.btnProcessFile.Size = new System.Drawing.Size(136, 67);
            this.btnProcessFile.TabIndex = 0;
            this.btnProcessFile.Text = "Process File";
            this.btnProcessFile.UseVisualStyleBackColor = true;
            this.btnProcessFile.Click += new System.EventHandler(this.btnProcessFile_Click);
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCount.Location = new System.Drawing.Point(308, 200);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(0, 23);
            this.lblCount.TabIndex = 1;
            this.lblCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.btnProcessFile);
            this.Name = "Form1";
            this.Text = "Count Characters in a File";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnProcessFile;
        private Label lblCount;
    }
}