namespace OefeningenLes6
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
            this.pbar1 = new System.Windows.Forms.ProgressBar();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnDoeIets = new System.Windows.Forms.Button();
            this.lblCalculatedValue1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pbar1
            // 
            this.pbar1.Location = new System.Drawing.Point(15, 103);
            this.pbar1.Name = "pbar1";
            this.pbar1.Size = new System.Drawing.Size(776, 39);
            this.pbar1.TabIndex = 0;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(12, 57);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(128, 40);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnDoeIets
            // 
            this.btnDoeIets.Location = new System.Drawing.Point(642, 57);
            this.btnDoeIets.Name = "btnDoeIets";
            this.btnDoeIets.Size = new System.Drawing.Size(146, 40);
            this.btnDoeIets.TabIndex = 2;
            this.btnDoeIets.Text = "Doe iets";
            this.btnDoeIets.UseVisualStyleBackColor = true;
            this.btnDoeIets.Click += new System.EventHandler(this.btnDoeIets_Click);
            // 
            // lblCalculatedValue1
            // 
            this.lblCalculatedValue1.AutoSize = true;
            this.lblCalculatedValue1.Location = new System.Drawing.Point(12, 9);
            this.lblCalculatedValue1.Name = "lblCalculatedValue1";
            this.lblCalculatedValue1.Size = new System.Drawing.Size(0, 13);
            this.lblCalculatedValue1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 159);
            this.Controls.Add(this.lblCalculatedValue1);
            this.Controls.Add(this.btnDoeIets);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.pbar1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar pbar1;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnDoeIets;
        private System.Windows.Forms.Label lblCalculatedValue1;
    }
}

