namespace Arithmetic_Progressions
{
    partial class Progressions
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.richTextBox_Output = new System.Windows.Forms.RichTextBox();
            this.button_Simple_Numbers = new System.Windows.Forms.Button();
            this.button_Fibonacci = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_Boundary = new System.Windows.Forms.TextBox();
            this.button_Lucas = new System.Windows.Forms.Button();
            this.button_Catalan = new System.Windows.Forms.Button();
            this.button_Factorials = new System.Windows.Forms.Button();
            this.button_Squares = new System.Windows.Forms.Button();
            this.button_Central = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBox_Output
            // 
            this.richTextBox_Output.Location = new System.Drawing.Point(12, 88);
            this.richTextBox_Output.Name = "richTextBox_Output";
            this.richTextBox_Output.Size = new System.Drawing.Size(1123, 589);
            this.richTextBox_Output.TabIndex = 0;
            this.richTextBox_Output.Text = "";
            // 
            // button_Simple_Numbers
            // 
            this.button_Simple_Numbers.Location = new System.Drawing.Point(12, 12);
            this.button_Simple_Numbers.Name = "button_Simple_Numbers";
            this.button_Simple_Numbers.Size = new System.Drawing.Size(140, 23);
            this.button_Simple_Numbers.TabIndex = 1;
            this.button_Simple_Numbers.Text = "The prime numbers";
            this.button_Simple_Numbers.UseVisualStyleBackColor = true;
            this.button_Simple_Numbers.Click += new System.EventHandler(this.button_Simple_Numbers_Click);
            // 
            // button_Fibonacci
            // 
            this.button_Fibonacci.Location = new System.Drawing.Point(12, 41);
            this.button_Fibonacci.Name = "button_Fibonacci";
            this.button_Fibonacci.Size = new System.Drawing.Size(140, 23);
            this.button_Fibonacci.TabIndex = 2;
            this.button_Fibonacci.Text = "Fibonacci Numbers";
            this.button_Fibonacci.UseVisualStyleBackColor = true;
            this.button_Fibonacci.Click += new System.EventHandler(this.button_Fibonacci_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(803, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Boundary of values";
            // 
            // textBox_Boundary
            // 
            this.textBox_Boundary.Location = new System.Drawing.Point(907, 11);
            this.textBox_Boundary.Name = "textBox_Boundary";
            this.textBox_Boundary.Size = new System.Drawing.Size(216, 20);
            this.textBox_Boundary.TabIndex = 4;
            // 
            // button_Lucas
            // 
            this.button_Lucas.Location = new System.Drawing.Point(159, 11);
            this.button_Lucas.Name = "button_Lucas";
            this.button_Lucas.Size = new System.Drawing.Size(137, 23);
            this.button_Lucas.TabIndex = 5;
            this.button_Lucas.Text = "Lucas numbers";
            this.button_Lucas.UseVisualStyleBackColor = true;
            this.button_Lucas.Click += new System.EventHandler(this.button_Lucas_Click);
            // 
            // button_Catalan
            // 
            this.button_Catalan.Location = new System.Drawing.Point(159, 41);
            this.button_Catalan.Name = "button_Catalan";
            this.button_Catalan.Size = new System.Drawing.Size(137, 23);
            this.button_Catalan.TabIndex = 6;
            this.button_Catalan.Text = "Catalan numbers";
            this.button_Catalan.UseVisualStyleBackColor = true;
            this.button_Catalan.Click += new System.EventHandler(this.button_Catalan_Click);
            // 
            // button_Factorials
            // 
            this.button_Factorials.Location = new System.Drawing.Point(303, 10);
            this.button_Factorials.Name = "button_Factorials";
            this.button_Factorials.Size = new System.Drawing.Size(139, 23);
            this.button_Factorials.TabIndex = 7;
            this.button_Factorials.Text = "Factorials";
            this.button_Factorials.UseVisualStyleBackColor = true;
            this.button_Factorials.Click += new System.EventHandler(this.button_Factorials_Click);
            // 
            // button_Squares
            // 
            this.button_Squares.Location = new System.Drawing.Point(303, 41);
            this.button_Squares.Name = "button_Squares";
            this.button_Squares.Size = new System.Drawing.Size(139, 23);
            this.button_Squares.TabIndex = 8;
            this.button_Squares.Text = "Squares";
            this.button_Squares.UseVisualStyleBackColor = true;
            this.button_Squares.Click += new System.EventHandler(this.button_Squares_Click);
            // 
            // button_Central
            // 
            this.button_Central.Location = new System.Drawing.Point(448, 9);
            this.button_Central.Name = "button_Central";
            this.button_Central.Size = new System.Drawing.Size(166, 23);
            this.button_Central.TabIndex = 9;
            this.button_Central.Text = "\tCentral polygonal numbers";
            this.button_Central.UseVisualStyleBackColor = true;
            this.button_Central.Click += new System.EventHandler(this.button_Central_Click);
            // 
            // Progressions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1147, 689);
            this.Controls.Add(this.button_Central);
            this.Controls.Add(this.button_Squares);
            this.Controls.Add(this.button_Factorials);
            this.Controls.Add(this.button_Catalan);
            this.Controls.Add(this.button_Lucas);
            this.Controls.Add(this.textBox_Boundary);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_Fibonacci);
            this.Controls.Add(this.button_Simple_Numbers);
            this.Controls.Add(this.richTextBox_Output);
            this.Name = "Progressions";
            this.Text = "Different Progressions";
            this.Load += new System.EventHandler(this.Progressions_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void Progressions_Load(object sender, System.EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox_Output;
        private System.Windows.Forms.Button button_Simple_Numbers;
        private System.Windows.Forms.Button button_Fibonacci;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_Boundary;
        private System.Windows.Forms.Button button_Lucas;
        private System.Windows.Forms.Button button_Catalan;
        private System.Windows.Forms.Button button_Factorials;
        private System.Windows.Forms.Button button_Squares;
        private System.Windows.Forms.Button button_Central;
       
    }
}

