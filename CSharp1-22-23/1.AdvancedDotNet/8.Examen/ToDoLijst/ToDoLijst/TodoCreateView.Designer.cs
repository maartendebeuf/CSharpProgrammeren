namespace ToDoLijst
{
    partial class TodoCreateView
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
            this.lblType = new System.Windows.Forms.Label();
            this.lblNaam = new System.Windows.Forms.Label();
            this.lblUitvoerder = new System.Windows.Forms.Label();
            this.lblUitvoerDatum = new System.Windows.Forms.Label();
            this.lblLocatie = new System.Windows.Forms.Label();
            this.coboxType = new System.Windows.Forms.ComboBox();
            this.tboxNaam = new System.Windows.Forms.TextBox();
            this.tboxUitvoerder = new System.Windows.Forms.TextBox();
            this.tbLocatie = new System.Windows.Forms.TextBox();
            this.dtpUitvoerDatum = new System.Windows.Forms.DateTimePicker();
            this.lblOmschrijving = new System.Windows.Forms.Label();
            this.rtboxOmschrijving = new System.Windows.Forms.RichTextBox();
            this.btnAnnuleren = new System.Windows.Forms.Button();
            this.btnAanmakenEnSluiten = new System.Windows.Forms.Button();
            this.btnAanmaken = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(12, 9);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(34, 15);
            this.lblType.TabIndex = 0;
            this.lblType.Text = "Type:";
            // 
            // lblNaam
            // 
            this.lblNaam.AutoSize = true;
            this.lblNaam.Location = new System.Drawing.Point(12, 39);
            this.lblNaam.Name = "lblNaam";
            this.lblNaam.Size = new System.Drawing.Size(42, 15);
            this.lblNaam.TabIndex = 1;
            this.lblNaam.Text = "Naam:";
            // 
            // lblUitvoerder
            // 
            this.lblUitvoerder.AutoSize = true;
            this.lblUitvoerder.Location = new System.Drawing.Point(12, 69);
            this.lblUitvoerder.Name = "lblUitvoerder";
            this.lblUitvoerder.Size = new System.Drawing.Size(65, 15);
            this.lblUitvoerder.TabIndex = 1;
            this.lblUitvoerder.Text = "Uitvoerder:";
            // 
            // lblUitvoerDatum
            // 
            this.lblUitvoerDatum.AutoSize = true;
            this.lblUitvoerDatum.Location = new System.Drawing.Point(12, 99);
            this.lblUitvoerDatum.Name = "lblUitvoerDatum";
            this.lblUitvoerDatum.Size = new System.Drawing.Size(86, 15);
            this.lblUitvoerDatum.TabIndex = 1;
            this.lblUitvoerDatum.Text = "Uitvoer datum:";
            // 
            // lblLocatie
            // 
            this.lblLocatie.AutoSize = true;
            this.lblLocatie.Location = new System.Drawing.Point(12, 129);
            this.lblLocatie.Name = "lblLocatie";
            this.lblLocatie.Size = new System.Drawing.Size(48, 15);
            this.lblLocatie.TabIndex = 1;
            this.lblLocatie.Text = "Locatie:";
            // 
            // coboxType
            // 
            this.coboxType.FormattingEnabled = true;
            this.coboxType.Location = new System.Drawing.Point(109, 6);
            this.coboxType.Name = "coboxType";
            this.coboxType.Size = new System.Drawing.Size(288, 23);
            this.coboxType.TabIndex = 2;
            // 
            // tboxNaam
            // 
            this.tboxNaam.Location = new System.Drawing.Point(109, 36);
            this.tboxNaam.Name = "tboxNaam";
            this.tboxNaam.Size = new System.Drawing.Size(288, 23);
            this.tboxNaam.TabIndex = 3;
            // 
            // tboxUitvoerder
            // 
            this.tboxUitvoerder.Location = new System.Drawing.Point(109, 66);
            this.tboxUitvoerder.Name = "tboxUitvoerder";
            this.tboxUitvoerder.Size = new System.Drawing.Size(288, 23);
            this.tboxUitvoerder.TabIndex = 3;
            // 
            // tbLocatie
            // 
            this.tbLocatie.Location = new System.Drawing.Point(109, 126);
            this.tbLocatie.Name = "tbLocatie";
            this.tbLocatie.Size = new System.Drawing.Size(288, 23);
            this.tbLocatie.TabIndex = 3;
            // 
            // dtpUitvoerDatum
            // 
            this.dtpUitvoerDatum.Location = new System.Drawing.Point(109, 95);
            this.dtpUitvoerDatum.Name = "dtpUitvoerDatum";
            this.dtpUitvoerDatum.Size = new System.Drawing.Size(288, 23);
            this.dtpUitvoerDatum.TabIndex = 4;
            // 
            // lblOmschrijving
            // 
            this.lblOmschrijving.AutoSize = true;
            this.lblOmschrijving.Location = new System.Drawing.Point(403, 9);
            this.lblOmschrijving.Name = "lblOmschrijving";
            this.lblOmschrijving.Size = new System.Drawing.Size(81, 15);
            this.lblOmschrijving.TabIndex = 0;
            this.lblOmschrijving.Text = "Omschrijving:";
            // 
            // rtboxOmschrijving
            // 
            this.rtboxOmschrijving.Location = new System.Drawing.Point(403, 27);
            this.rtboxOmschrijving.Name = "rtboxOmschrijving";
            this.rtboxOmschrijving.Size = new System.Drawing.Size(385, 122);
            this.rtboxOmschrijving.TabIndex = 5;
            this.rtboxOmschrijving.Text = "";
            // 
            // btnAnnuleren
            // 
            this.btnAnnuleren.Location = new System.Drawing.Point(12, 155);
            this.btnAnnuleren.Name = "btnAnnuleren";
            this.btnAnnuleren.Size = new System.Drawing.Size(146, 47);
            this.btnAnnuleren.TabIndex = 6;
            this.btnAnnuleren.Text = "Annuleren";
            this.btnAnnuleren.UseVisualStyleBackColor = true;
            this.btnAnnuleren.Click += new System.EventHandler(this.btnAnnuleren_Click);
            // 
            // btnAanmakenEnSluiten
            // 
            this.btnAanmakenEnSluiten.Location = new System.Drawing.Point(490, 155);
            this.btnAanmakenEnSluiten.Name = "btnAanmakenEnSluiten";
            this.btnAanmakenEnSluiten.Size = new System.Drawing.Size(146, 47);
            this.btnAanmakenEnSluiten.TabIndex = 6;
            this.btnAanmakenEnSluiten.Text = "Aanmaken en sluiten";
            this.btnAanmakenEnSluiten.UseVisualStyleBackColor = true;
            this.btnAanmakenEnSluiten.Click += new System.EventHandler(this.btnAanmakenEnSluiten_Click);
            // 
            // btnAanmaken
            // 
            this.btnAanmaken.Location = new System.Drawing.Point(642, 155);
            this.btnAanmaken.Name = "btnAanmaken";
            this.btnAanmaken.Size = new System.Drawing.Size(146, 47);
            this.btnAanmaken.TabIndex = 6;
            this.btnAanmaken.Text = "Aanmaken";
            this.btnAanmaken.UseVisualStyleBackColor = true;
            this.btnAanmaken.Click += new System.EventHandler(this.btnAanmaken_Click);
            // 
            // TodoCreateView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 214);
            this.Controls.Add(this.btnAanmaken);
            this.Controls.Add(this.btnAanmakenEnSluiten);
            this.Controls.Add(this.btnAnnuleren);
            this.Controls.Add(this.rtboxOmschrijving);
            this.Controls.Add(this.dtpUitvoerDatum);
            this.Controls.Add(this.tbLocatie);
            this.Controls.Add(this.tboxUitvoerder);
            this.Controls.Add(this.tboxNaam);
            this.Controls.Add(this.coboxType);
            this.Controls.Add(this.lblLocatie);
            this.Controls.Add(this.lblUitvoerDatum);
            this.Controls.Add(this.lblUitvoerder);
            this.Controls.Add(this.lblNaam);
            this.Controls.Add(this.lblOmschrijving);
            this.Controls.Add(this.lblType);
            this.Name = "TodoCreateView";
            this.Text = "Aanmaken todo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblType;
        private Label lblNaam;
        private Label lblUitvoerder;
        private Label lblUitvoerDatum;
        private Label lblLocatie;
        private ComboBox coboxType;
        private TextBox tboxNaam;
        private TextBox tboxUitvoerder;
        private TextBox tbLocatie;
        private DateTimePicker dtpUitvoerDatum;
        private Label lblOmschrijving;
        private RichTextBox rtboxOmschrijving;
        private Button btnAnnuleren;
        private Button btnAanmakenEnSluiten;
        private Button btnAanmaken;
    }
}