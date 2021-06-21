namespace ASQ
{
    partial class StudentTests
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentTests));
            this.name = new System.Windows.Forms.TextBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.buttonNameConf = new System.Windows.Forms.Button();
            this.grouptest = new System.Windows.Forms.GroupBox();
            this.grouptest.SuspendLayout();
            this.SuspendLayout();
            // 
            // name
            // 
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.name.Location = new System.Drawing.Point(338, 30);
            this.name.Multiline = true;
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(297, 42);
            this.name.TabIndex = 0;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.BackColor = System.Drawing.Color.MediumOrchid;
            this.radioButton1.Font = new System.Drawing.Font("Book Antiqua", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton1.ForeColor = System.Drawing.SystemColors.Control;
            this.radioButton1.Location = new System.Drawing.Point(67, 53);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(170, 29);
            this.radioButton1.TabIndex = 3;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Математика";
            this.radioButton1.UseVisualStyleBackColor = false;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.BackColor = System.Drawing.Color.MediumOrchid;
            this.radioButton2.Font = new System.Drawing.Font("Book Antiqua", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton2.ForeColor = System.Drawing.SystemColors.Control;
            this.radioButton2.Location = new System.Drawing.Point(295, 53);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(163, 29);
            this.radioButton2.TabIndex = 4;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Русский язык";
            this.radioButton2.UseVisualStyleBackColor = false;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.BackColor = System.Drawing.Color.MediumOrchid;
            this.radioButton3.Font = new System.Drawing.Font("Book Antiqua", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton3.ForeColor = System.Drawing.SystemColors.Control;
            this.radioButton3.Location = new System.Drawing.Point(525, 53);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(105, 29);
            this.radioButton3.TabIndex = 5;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Физика";
            this.radioButton3.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MediumOrchid;
            this.button1.Font = new System.Drawing.Font("Book Antiqua", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(200, 152);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(333, 68);
            this.button1.TabIndex = 6;
            this.button1.Text = "Начать прохождение теста";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.MediumOrchid;
            this.button3.Font = new System.Drawing.Font("Book Antiqua", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.ForeColor = System.Drawing.SystemColors.Control;
            this.button3.Location = new System.Drawing.Point(751, 463);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(153, 37);
            this.button3.TabIndex = 7;
            this.button3.Text = "ВЕРНУТЬСЯ";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // buttonNameConf
            // 
            this.buttonNameConf.BackColor = System.Drawing.Color.MediumOrchid;
            this.buttonNameConf.Font = new System.Drawing.Font("Book Antiqua", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonNameConf.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonNameConf.Location = new System.Drawing.Point(657, 30);
            this.buttonNameConf.Name = "buttonNameConf";
            this.buttonNameConf.Size = new System.Drawing.Size(171, 42);
            this.buttonNameConf.TabIndex = 8;
            this.buttonNameConf.Text = "Подтвердить";
            this.buttonNameConf.UseVisualStyleBackColor = false;
            this.buttonNameConf.Click += new System.EventHandler(this.button2_Click);
            // 
            // grouptest
            // 
            this.grouptest.Controls.Add(this.radioButton1);
            this.grouptest.Controls.Add(this.radioButton2);
            this.grouptest.Controls.Add(this.button1);
            this.grouptest.Controls.Add(this.radioButton3);
            this.grouptest.ForeColor = System.Drawing.Color.White;
            this.grouptest.Location = new System.Drawing.Point(120, 182);
            this.grouptest.Name = "grouptest";
            this.grouptest.Size = new System.Drawing.Size(708, 260);
            this.grouptest.TabIndex = 9;
            this.grouptest.TabStop = false;
            this.grouptest.Text = "Тестирование";
            this.grouptest.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // StudentTests
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(916, 512);
            this.Controls.Add(this.buttonNameConf);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.name);
            this.Controls.Add(this.grouptest);
            this.Name = "StudentTests";
            this.Text = "StudentTests";
            this.Load += new System.EventHandler(this.StudentTests_Load);
            this.grouptest.ResumeLayout(false);
            this.grouptest.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button buttonNameConf;
        private System.Windows.Forms.GroupBox grouptest;
    }
}