
namespace ASQ
{
    partial class Start
    {
        /// <summary>
        /// Обязательная переменная конструктора.
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
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.teacher_btn = new System.Windows.Forms.Button();
            this.student_btn = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(35, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(703, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "ДОБРО ПОЖАЛОВАТЬ В ПРОГРАММУ ДЛЯ ПРОХОЖДЕНИЯ ТЕСТОВ!";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // teacher_btn
            // 
            this.teacher_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.teacher_btn.Location = new System.Drawing.Point(111, 174);
            this.teacher_btn.Name = "teacher_btn";
            this.teacher_btn.Size = new System.Drawing.Size(211, 75);
            this.teacher_btn.TabIndex = 1;
            this.teacher_btn.Text = "Продолжить, как преподаватель";
            this.teacher_btn.UseVisualStyleBackColor = true;
            this.teacher_btn.Click += new System.EventHandler(this.Button1_Click);
            // 
            // student_btn
            // 
            this.student_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.student_btn.Location = new System.Drawing.Point(450, 174);
            this.student_btn.Name = "student_btn";
            this.student_btn.Size = new System.Drawing.Size(211, 75);
            this.student_btn.TabIndex = 2;
            this.student_btn.Text = "Продолжить, как ученик";
            this.student_btn.UseVisualStyleBackColor = true;
            this.student_btn.Click += new System.EventHandler(this.Button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(642, 343);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(146, 37);
            this.button3.TabIndex = 3;
            this.button3.Text = "ВЫХОД";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 399);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.student_btn);
            this.Controls.Add(this.teacher_btn);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button teacher_btn;
        private System.Windows.Forms.Button student_btn;
        private System.Windows.Forms.Button button3;
    }
}

