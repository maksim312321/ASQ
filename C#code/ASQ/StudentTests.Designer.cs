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
            this.math = new System.Windows.Forms.RadioButton();
            this.rus = new System.Windows.Forms.RadioButton();
            this.physics = new System.Windows.Forms.RadioButton();
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
            // math
            // 
            this.math.AutoSize = true;
            this.math.BackColor = System.Drawing.Color.MediumOrchid;
            this.math.Font = new System.Drawing.Font("Book Antiqua", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.math.ForeColor = System.Drawing.SystemColors.Control;
            this.math.Location = new System.Drawing.Point(67, 53);
            this.math.Name = "math";
            this.math.Size = new System.Drawing.Size(170, 29);
            this.math.TabIndex = 3;
            this.math.TabStop = true;
            this.math.Text = "Математика";
            this.math.UseVisualStyleBackColor = false;
            // 
            // rus
            // 
            this.rus.AutoSize = true;
            this.rus.BackColor = System.Drawing.Color.MediumOrchid;
            this.rus.Font = new System.Drawing.Font("Book Antiqua", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rus.ForeColor = System.Drawing.SystemColors.Control;
            this.rus.Location = new System.Drawing.Point(295, 53);
            this.rus.Name = "rus";
            this.rus.Size = new System.Drawing.Size(163, 29);
            this.rus.TabIndex = 4;
            this.rus.TabStop = true;
            this.rus.Text = "Русский язык";
            this.rus.UseVisualStyleBackColor = false;
            // 
            // physics
            // 
            this.physics.AutoSize = true;
            this.physics.BackColor = System.Drawing.Color.MediumOrchid;
            this.physics.Font = new System.Drawing.Font("Book Antiqua", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.physics.ForeColor = System.Drawing.SystemColors.Control;
            this.physics.Location = new System.Drawing.Point(525, 53);
            this.physics.Name = "physics";
            this.physics.Size = new System.Drawing.Size(105, 29);
            this.physics.TabIndex = 5;
            this.physics.TabStop = true;
            this.physics.Text = "Физика";
            this.physics.UseVisualStyleBackColor = false;
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
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.MediumOrchid;
            this.button3.Font = new System.Drawing.Font("Book Antiqua", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.ForeColor = System.Drawing.SystemColors.Control;
            this.button3.Location = new System.Drawing.Point(609, 463);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(295, 37);
            this.button3.TabIndex = 7;
            this.button3.Text = "Завершить тестирование";
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
            this.grouptest.Controls.Add(this.math);
            this.grouptest.Controls.Add(this.rus);
            this.grouptest.Controls.Add(this.button1);
            this.grouptest.Controls.Add(this.physics);
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
        private System.Windows.Forms.RadioButton math;
        private System.Windows.Forms.RadioButton rus;
        private System.Windows.Forms.RadioButton physics;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button buttonNameConf;
        private System.Windows.Forms.GroupBox grouptest;
    }
}