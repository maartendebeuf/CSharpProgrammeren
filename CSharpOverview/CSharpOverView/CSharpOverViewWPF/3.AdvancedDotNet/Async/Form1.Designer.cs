namespace CSharpOverViewWPF._3.AdvancedDotNet.Async
{
    partial class Form1
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
            this.pbarProgress = new System.Windows.Forms.ProgressBar();
            this.btnTest = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pbarProgress
            // 
            this.pbarProgress.Location = new System.Drawing.Point(2, -1);
            this.pbarProgress.Name = "pbarProgress";
            this.pbarProgress.Size = new System.Drawing.Size(541, 23);
            this.pbarProgress.TabIndex = 0;
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(12, 113);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(75, 23);
            this.btnTest.TabIndex = 1;
            this.btnTest.Text = "button1";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(506, 113);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "button2";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 148);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.pbarProgress);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ProgressBar pbarProgress;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.Button btnStart;
    }
}