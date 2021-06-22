namespace ASQ
{
    partial class Math
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
            this.close = new System.Windows.Forms.Button();
            this.MathInput = new System.Windows.Forms.TextBox();
            this.MathReady = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Question = new System.Windows.Forms.Label();
            this.mathQuestion = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.mathQuestion)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(345, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Тест";
            // 
            // close
            // 
            this.close.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.close.Location = new System.Drawing.Point(334, 406);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(107, 25);
            this.close.TabIndex = 1;
            this.close.Text = "Закончить";
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // MathInput
            // 
            this.MathInput.Location = new System.Drawing.Point(583, 304);
            this.MathInput.Name = "MathInput";
            this.MathInput.Size = new System.Drawing.Size(100, 20);
            this.MathInput.TabIndex = 3;
            this.MathInput.TextChanged += new System.EventHandler(this.MathInput_TextChanged);
            // 
            // MathReady
            // 
            this.MathReady.Location = new System.Drawing.Point(608, 330);
            this.MathReady.Name = "MathReady";
            this.MathReady.Size = new System.Drawing.Size(75, 23);
            this.MathReady.TabIndex = 4;
            this.MathReady.Text = "Готово";
            this.MathReady.UseVisualStyleBackColor = true;
            this.MathReady.Click += new System.EventHandler(this.MathReady_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(515, 307);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ваш ответ:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Question
            // 
            this.Question.AutoSize = true;
            this.Question.Location = new System.Drawing.Point(23, 138);
            this.Question.Name = "Question";
            this.Question.Size = new System.Drawing.Size(0, 13);
            this.Question.TabIndex = 6;
            this.Question.Click += new System.EventHandler(this.Question_Click);
            // 
            // mathQuestion
            // 
            this.mathQuestion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mathQuestion.Location = new System.Drawing.Point(12, 12);
            this.mathQuestion.Name = "mathQuestion";
            this.mathQuestion.Size = new System.Drawing.Size(10, 10);
            this.mathQuestion.TabIndex = 7;
            // 
            // Math
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 491);
            this.Controls.Add(this.mathQuestion);
            this.Controls.Add(this.Question);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.MathReady);
            this.Controls.Add(this.MathInput);
            this.Controls.Add(this.close);
            this.Controls.Add(this.label1);
            this.Name = "Math";
            this.Text = "Math";
            this.Load += new System.EventHandler(this.Math_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mathQuestion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.TextBox MathInput;
        private System.Windows.Forms.Button MathReady;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Question;
        private System.Windows.Forms.DataGridView mathQuestion;
    }
}