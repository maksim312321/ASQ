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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Math));
            this.close = new System.Windows.Forms.Button();
            this.MathInput = new System.Windows.Forms.TextBox();
            this.MathReady = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Question = new System.Windows.Forms.Label();
            this.mathQuestion = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.mathQuestion)).BeginInit();
            this.SuspendLayout();
            // 
            // close
            // 
            this.close.BackColor = System.Drawing.Color.MediumOrchid;
            this.close.Font = new System.Drawing.Font("Book Antiqua", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.close.ForeColor = System.Drawing.SystemColors.Control;
            this.close.Location = new System.Drawing.Point(781, 443);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(128, 36);
            this.close.TabIndex = 1;
            this.close.Text = "Закончить";
            this.close.UseVisualStyleBackColor = false;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // MathInput
            // 
            this.MathInput.Location = new System.Drawing.Point(415, 358);
            this.MathInput.Name = "MathInput";
            this.MathInput.Size = new System.Drawing.Size(100, 20);
            this.MathInput.TabIndex = 3;
            this.MathInput.TextChanged += new System.EventHandler(this.MathInput_TextChanged);
            // 
            // MathReady
            // 
            this.MathReady.BackColor = System.Drawing.Color.MediumOrchid;
            this.MathReady.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.MathReady.Font = new System.Drawing.Font("Book Antiqua", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MathReady.ForeColor = System.Drawing.SystemColors.Control;
            this.MathReady.Location = new System.Drawing.Point(415, 396);
            this.MathReady.Name = "MathReady";
            this.MathReady.Size = new System.Drawing.Size(100, 29);
            this.MathReady.TabIndex = 4;
            this.MathReady.Text = "Готово";
            this.MathReady.UseVisualStyleBackColor = false;
            this.MathReady.Click += new System.EventHandler(this.MathReady_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.MediumOrchid;
            this.label2.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(305, 358);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 20);
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
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(921, 491);
            this.Controls.Add(this.mathQuestion);
            this.Controls.Add(this.Question);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.MathReady);
            this.Controls.Add(this.MathInput);
            this.Controls.Add(this.close);
            this.Name = "Math";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Math";
            this.Load += new System.EventHandler(this.Math_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mathQuestion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.TextBox MathInput;
        private System.Windows.Forms.Button MathReady;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Question;
        private System.Windows.Forms.DataGridView mathQuestion;
    }
}