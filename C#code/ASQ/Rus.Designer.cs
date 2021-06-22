namespace ASQ
{
    partial class Rus
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
            this.close = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.rusQuestion = new System.Windows.Forms.DataGridView();
            this.Question = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.RusInput = new System.Windows.Forms.TextBox();
            this.RusReady = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.rusQuestion)).BeginInit();
            this.SuspendLayout();
            // 
            // close
            // 
            this.close.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.close.Location = new System.Drawing.Point(325, 386);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(107, 25);
            this.close.TabIndex = 3;
            this.close.Text = "Закончить";
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(339, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Тест";
            // 
            // rusQuestion
            // 
            this.rusQuestion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.rusQuestion.Location = new System.Drawing.Point(12, 12);
            this.rusQuestion.Name = "rusQuestion";
            this.rusQuestion.Size = new System.Drawing.Size(10, 10);
            this.rusQuestion.TabIndex = 4;
            // 
            // Question
            // 
            this.Question.AutoSize = true;
            this.Question.Location = new System.Drawing.Point(12, 126);
            this.Question.Name = "Question";
            this.Question.Size = new System.Drawing.Size(35, 13);
            this.Question.TabIndex = 5;
            this.Question.Text = "label2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(340, 309);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Ваш ответ:";
            // 
            // RusInput
            // 
            this.RusInput.Location = new System.Drawing.Point(408, 306);
            this.RusInput.Name = "RusInput";
            this.RusInput.Size = new System.Drawing.Size(100, 20);
            this.RusInput.TabIndex = 7;
            // 
            // RusReady
            // 
            this.RusReady.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RusReady.Location = new System.Drawing.Point(408, 332);
            this.RusReady.Name = "RusReady";
            this.RusReady.Size = new System.Drawing.Size(100, 25);
            this.RusReady.TabIndex = 8;
            this.RusReady.Text = "Закончить";
            this.RusReady.UseVisualStyleBackColor = true;
            this.RusReady.Click += new System.EventHandler(this.RusReady_Click);
            // 
            // Rus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 450);
            this.Controls.Add(this.RusReady);
            this.Controls.Add(this.RusInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Question);
            this.Controls.Add(this.rusQuestion);
            this.Controls.Add(this.close);
            this.Controls.Add(this.label1);
            this.Name = "Rus";
            this.Text = "Rus";
            this.Load += new System.EventHandler(this.Rus_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rusQuestion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button close;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView rusQuestion;
        private System.Windows.Forms.Label Question;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox RusInput;
        private System.Windows.Forms.Button RusReady;
    }
}