namespace ASQ
{
    partial class Physicscs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Physicscs));
            this.close = new System.Windows.Forms.Button();
            this.physicscsQuestion = new System.Windows.Forms.DataGridView();
            this.Question = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PhysicscsInput = new System.Windows.Forms.TextBox();
            this.PhysicscsReady = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.physicscsQuestion)).BeginInit();
            this.SuspendLayout();
            // 
            // close
            // 
            this.close.BackColor = System.Drawing.Color.MediumOrchid;
            this.close.Font = new System.Drawing.Font("Book Antiqua", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.close.ForeColor = System.Drawing.SystemColors.Control;
            this.close.Location = new System.Drawing.Point(782, 438);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(125, 34);
            this.close.TabIndex = 3;
            this.close.Text = "Закончить";
            this.close.UseVisualStyleBackColor = false;
            this.close.Click += new System.EventHandler(this.button1_Click);
            // 
            // physicscsQuestion
            // 
            this.physicscsQuestion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.physicscsQuestion.Location = new System.Drawing.Point(12, 12);
            this.physicscsQuestion.Name = "physicscsQuestion";
            this.physicscsQuestion.Size = new System.Drawing.Size(10, 10);
            this.physicscsQuestion.TabIndex = 4;
            // 
            // Question
            // 
            this.Question.AutoSize = true;
            this.Question.Font = new System.Drawing.Font("Book Antiqua", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Question.Location = new System.Drawing.Point(35, 176);
            this.Question.Name = "Question";
            this.Question.Size = new System.Drawing.Size(72, 26);
            this.Question.TabIndex = 5;
            this.Question.Text = "label2";
            this.Question.Click += new System.EventHandler(this.Question_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.MediumOrchid;
            this.label2.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(310, 374);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Ваш ответ:";
            // 
            // PhysicscsInput
            // 
            this.PhysicscsInput.Location = new System.Drawing.Point(420, 374);
            this.PhysicscsInput.Name = "PhysicscsInput";
            this.PhysicscsInput.Size = new System.Drawing.Size(100, 20);
            this.PhysicscsInput.TabIndex = 7;
            // 
            // PhysicscsReady
            // 
            this.PhysicscsReady.BackColor = System.Drawing.Color.MediumOrchid;
            this.PhysicscsReady.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.PhysicscsReady.Font = new System.Drawing.Font("Book Antiqua", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PhysicscsReady.ForeColor = System.Drawing.SystemColors.Control;
            this.PhysicscsReady.Location = new System.Drawing.Point(420, 414);
            this.PhysicscsReady.Name = "PhysicscsReady";
            this.PhysicscsReady.Size = new System.Drawing.Size(100, 33);
            this.PhysicscsReady.TabIndex = 8;
            this.PhysicscsReady.Text = "Готово";
            this.PhysicscsReady.UseVisualStyleBackColor = false;
            this.PhysicscsReady.Click += new System.EventHandler(this.PhysicscsReady_Click);
            // 
            // Physicscs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(919, 484);
            this.Controls.Add(this.PhysicscsReady);
            this.Controls.Add(this.PhysicscsInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Question);
            this.Controls.Add(this.physicscsQuestion);
            this.Controls.Add(this.close);
            this.Name = "Physicscs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Physicscs";
            this.Load += new System.EventHandler(this.Physicscs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.physicscsQuestion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button close;
        private System.Windows.Forms.DataGridView physicscsQuestion;
        private System.Windows.Forms.Label Question;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox PhysicscsInput;
        private System.Windows.Forms.Button PhysicscsReady;
    }
}