namespace OefeningenLes7
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
            this.tbNumber1 = new System.Windows.Forms.TextBox();
            this.tbNumber2 = new System.Windows.Forms.TextBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.btnstart = new System.Windows.Forms.Button();
            this.btnDoeIets = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbNumber1
            // 
            this.tbNumber1.Location = new System.Drawing.Point(12, 12);
            this.tbNumber1.Name = "tbNumber1";
            this.tbNumber1.Size = new System.Drawing.Size(100, 23);
            this.tbNumber1.TabIndex = 0;
            // 
            // tbNumber2
            // 
            this.tbNumber2.Location = new System.Drawing.Point(12, 41);
            this.tbNumber2.Name = "tbNumber2";
            this.tbNumber2.Size = new System.Drawing.Size(100, 23);
            this.tbNumber2.TabIndex = 1;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(12, 67);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 15);
            this.lblResult.TabIndex = 2;
            // 
            // btnstart
            // 
            this.btnstart.Location = new System.Drawing.Point(329, 171);
            this.btnstart.Name = "btnstart";
            this.btnstart.Size = new System.Drawing.Size(75, 23);
            this.btnstart.TabIndex = 3;
            this.btnstart.Text = "Start";
            this.btnstart.UseVisualStyleBackColor = true;
            this.btnstart.Click += new System.EventHandler(this.btnstart_Click);
            // 
            // btnDoeIets
            // 
            this.btnDoeIets.Location = new System.Drawing.Point(12, 171);
            this.btnDoeIets.Name = "btnDoeIets";
            this.btnDoeIets.Size = new System.Drawing.Size(75, 23);
            this.btnDoeIets.TabIndex = 4;
            this.btnDoeIets.Text = "Doe iets";
            this.btnDoeIets.UseVisualStyleBackColor = true;
            this.btnDoeIets.Click += new System.EventHandler(this.btnDoeIets_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 206);
            this.Controls.Add(this.btnDoeIets);
            this.Controls.Add(this.btnstart);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.tbNumber2);
            this.Controls.Add(this.tbNumber1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox tbNumber1;
        private TextBox tbNumber2;
        private Label lblResult;
        private Button btnstart;
        private Button btnDoeIets;
    }
}