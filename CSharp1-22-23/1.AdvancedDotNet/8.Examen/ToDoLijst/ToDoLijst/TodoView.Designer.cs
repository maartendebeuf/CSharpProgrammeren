namespace ToDoLijst
{
    partial class TodoView
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
            this.lblTodo = new System.Windows.Forms.Label();
            this.lblActies = new System.Windows.Forms.Label();
            this.lblFilters = new System.Windows.Forms.Label();
            this.lboxTodo = new System.Windows.Forms.ListBox();
            this.btnTodoAanmaken = new System.Windows.Forms.Button();
            this.lblGeselcteerdeTodoAfwerken = new System.Windows.Forms.Button();
            this.btnTodosImporteren = new System.Windows.Forms.Button();
            this.btnGroepeerPerWeek = new System.Windows.Forms.Button();
            this.btnGroepeerPerUitvoerder = new System.Windows.Forms.Button();
            this.btnUitgevoerdeTodos = new System.Windows.Forms.Button();
            this.btnUitTeVoeren = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTodo
            // 
            this.lblTodo.AutoSize = true;
            this.lblTodo.Location = new System.Drawing.Point(12, 9);
            this.lblTodo.Name = "lblTodo";
            this.lblTodo.Size = new System.Drawing.Size(36, 15);
            this.lblTodo.TabIndex = 0;
            this.lblTodo.Text = "Todo:";
            // 
            // lblActies
            // 
            this.lblActies.AutoSize = true;
            this.lblActies.Location = new System.Drawing.Point(435, 9);
            this.lblActies.Name = "lblActies";
            this.lblActies.Size = new System.Drawing.Size(42, 15);
            this.lblActies.TabIndex = 1;
            this.lblActies.Text = "Acties:";
            // 
            // lblFilters
            // 
            this.lblFilters.AutoSize = true;
            this.lblFilters.Location = new System.Drawing.Point(435, 172);
            this.lblFilters.Name = "lblFilters";
            this.lblFilters.Size = new System.Drawing.Size(41, 15);
            this.lblFilters.TabIndex = 2;
            this.lblFilters.Text = "Filters:";
            // 
            // lboxTodo
            // 
            this.lboxTodo.FormattingEnabled = true;
            this.lboxTodo.ItemHeight = 15;
            this.lboxTodo.Location = new System.Drawing.Point(12, 27);
            this.lboxTodo.Name = "lboxTodo";
            this.lboxTodo.Size = new System.Drawing.Size(417, 409);
            this.lboxTodo.TabIndex = 3;
            // 
            // btnTodoAanmaken
            // 
            this.btnTodoAanmaken.Location = new System.Drawing.Point(435, 27);
            this.btnTodoAanmaken.Name = "btnTodoAanmaken";
            this.btnTodoAanmaken.Size = new System.Drawing.Size(353, 23);
            this.btnTodoAanmaken.TabIndex = 4;
            this.btnTodoAanmaken.Text = "Todo aanmaken";
            this.btnTodoAanmaken.UseVisualStyleBackColor = true;
            this.btnTodoAanmaken.Click += new System.EventHandler(this.btnTodoAanmaken_Click);
            // 
            // lblGeselcteerdeTodoAfwerken
            // 
            this.lblGeselcteerdeTodoAfwerken.Location = new System.Drawing.Point(435, 56);
            this.lblGeselcteerdeTodoAfwerken.Name = "lblGeselcteerdeTodoAfwerken";
            this.lblGeselcteerdeTodoAfwerken.Size = new System.Drawing.Size(353, 23);
            this.lblGeselcteerdeTodoAfwerken.TabIndex = 4;
            this.lblGeselcteerdeTodoAfwerken.Text = "Geselcteerde todo afwerken";
            this.lblGeselcteerdeTodoAfwerken.UseVisualStyleBackColor = true;
            this.lblGeselcteerdeTodoAfwerken.Click += new System.EventHandler(this.lblGeselcteerdeTodoAfwerken_Click);
            // 
            // btnTodosImporteren
            // 
            this.btnTodosImporteren.Location = new System.Drawing.Point(435, 85);
            this.btnTodosImporteren.Name = "btnTodosImporteren";
            this.btnTodosImporteren.Size = new System.Drawing.Size(353, 23);
            this.btnTodosImporteren.TabIndex = 4;
            this.btnTodosImporteren.Text = "Todo\'s importeren";
            this.btnTodosImporteren.UseVisualStyleBackColor = true;
            this.btnTodosImporteren.Click += new System.EventHandler(this.btnTodosImporteren_Click);
            // 
            // btnGroepeerPerWeek
            // 
            this.btnGroepeerPerWeek.Location = new System.Drawing.Point(435, 190);
            this.btnGroepeerPerWeek.Name = "btnGroepeerPerWeek";
            this.btnGroepeerPerWeek.Size = new System.Drawing.Size(353, 23);
            this.btnGroepeerPerWeek.TabIndex = 4;
            this.btnGroepeerPerWeek.Text = "Groepeer per week";
            this.btnGroepeerPerWeek.UseVisualStyleBackColor = true;
            this.btnGroepeerPerWeek.Click += new System.EventHandler(this.btnGroepeerPerWeek_Click);
            // 
            // btnGroepeerPerUitvoerder
            // 
            this.btnGroepeerPerUitvoerder.Location = new System.Drawing.Point(435, 219);
            this.btnGroepeerPerUitvoerder.Name = "btnGroepeerPerUitvoerder";
            this.btnGroepeerPerUitvoerder.Size = new System.Drawing.Size(353, 23);
            this.btnGroepeerPerUitvoerder.TabIndex = 4;
            this.btnGroepeerPerUitvoerder.Text = "Groepeer per uitvoerder";
            this.btnGroepeerPerUitvoerder.UseVisualStyleBackColor = true;
            this.btnGroepeerPerUitvoerder.Click += new System.EventHandler(this.btnGroepeerPerUitvoerder_Click);
            // 
            // btnUitgevoerdeTodos
            // 
            this.btnUitgevoerdeTodos.Location = new System.Drawing.Point(435, 248);
            this.btnUitgevoerdeTodos.Name = "btnUitgevoerdeTodos";
            this.btnUitgevoerdeTodos.Size = new System.Drawing.Size(353, 23);
            this.btnUitgevoerdeTodos.TabIndex = 4;
            this.btnUitgevoerdeTodos.Text = "Uitgevoerde todo\'s";
            this.btnUitgevoerdeTodos.UseVisualStyleBackColor = true;
            this.btnUitgevoerdeTodos.Click += new System.EventHandler(this.btnUitgevoerdeTodos_Click);
            // 
            // btnUitTeVoeren
            // 
            this.btnUitTeVoeren.Location = new System.Drawing.Point(435, 277);
            this.btnUitTeVoeren.Name = "btnUitTeVoeren";
            this.btnUitTeVoeren.Size = new System.Drawing.Size(353, 23);
            this.btnUitTeVoeren.TabIndex = 4;
            this.btnUitTeVoeren.Text = "Uit te voeren(7 dagen)";
            this.btnUitTeVoeren.UseVisualStyleBackColor = true;
            this.btnUitTeVoeren.Click += new System.EventHandler(this.btnUitTeVoeren_Click);
            // 
            // TodoView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnUitTeVoeren);
            this.Controls.Add(this.btnUitgevoerdeTodos);
            this.Controls.Add(this.btnGroepeerPerUitvoerder);
            this.Controls.Add(this.btnGroepeerPerWeek);
            this.Controls.Add(this.btnTodosImporteren);
            this.Controls.Add(this.lblGeselcteerdeTodoAfwerken);
            this.Controls.Add(this.btnTodoAanmaken);
            this.Controls.Add(this.lboxTodo);
            this.Controls.Add(this.lblFilters);
            this.Controls.Add(this.lblActies);
            this.Controls.Add(this.lblTodo);
            this.Name = "TodoView";
            this.Text = "Todo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblTodo;
        private Label lblActies;
        private Label lblFilters;
        private ListBox lboxTodo;
        private Button btnTodoAanmaken;
        private Button lblGeselcteerdeTodoAfwerken;
        private Button btnTodosImporteren;
        private Button btnGroepeerPerWeek;
        private Button btnGroepeerPerUitvoerder;
        private Button btnUitgevoerdeTodos;
        private Button btnUitTeVoeren;
    }
}