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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Rus));
            this.close = new System.Windows.Forms.Button();
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
            this.close.BackColor = System.Drawing.Color.MediumOrchid;
            this.close.Font = new System.Drawing.Font("Book Antiqua", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.close.ForeColor = System.Drawing.SystemColors.Control;
            this.close.Location = new System.Drawing.Point(777, 418);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(119, 32);
            this.close.TabIndex = 3;
            this.close.Text = "Закончить";
            this.close.UseVisualStyleBackColor = false;
            this.close.Click += new System.EventHandler(this.close_Click);
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
            this.Question.BackColor = System.Drawing.Color.Transparent;
            this.Question.Font = new System.Drawing.Font("Book Antiqua", 15.75F, System.Drawing.FontStyle.Bold);
            this.Question.ForeColor = System.Drawing.Color.White;
            this.Question.Location = new System.Drawing.Point(12, 164);
            this.Question.Name = "Question";
            this.Question.Size = new System.Drawing.Size(72, 26);
            this.Question.TabIndex = 5;
            this.Question.Text = "label2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.MediumOrchid;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label2.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(297, 340);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 21);
            this.label2.TabIndex = 6;
            this.label2.Text = "Ваш ответ:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // RusInput
            // 
            this.RusInput.Location = new System.Drawing.Point(417, 340);
            this.RusInput.Name = "RusInput";
            this.RusInput.Size = new System.Drawing.Size(100, 20);
            this.RusInput.TabIndex = 7;
            // 
            // RusReady
            // 
            this.RusReady.BackColor = System.Drawing.Color.MediumOrchid;
            this.RusReady.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.RusReady.Font = new System.Drawing.Font("Book Antiqua", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RusReady.ForeColor = System.Drawing.SystemColors.Control;
            this.RusReady.Location = new System.Drawing.Point(417, 378);
            this.RusReady.Name = "RusReady";
            this.RusReady.Size = new System.Drawing.Size(100, 36);
            this.RusReady.TabIndex = 8;
            this.RusReady.Text = "Готово";
            this.RusReady.UseVisualStyleBackColor = false;
            this.RusReady.Click += new System.EventHandler(this.RusReady_Click);
            // 
            // Rus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(908, 462);
            this.Controls.Add(this.RusReady);
            this.Controls.Add(this.RusInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Question);
            this.Controls.Add(this.rusQuestion);
            this.Controls.Add(this.close);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Rus";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rus";
            this.Load += new System.EventHandler(this.Rus_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rusQuestion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button close;
        private System.Windows.Forms.DataGridView rusQuestion;
        private System.Windows.Forms.Label Question;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox RusInput;
        private System.Windows.Forms.Button RusReady;
    }
}