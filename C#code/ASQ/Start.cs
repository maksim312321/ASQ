using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ASQ
{
    public partial class Start : Form
    {
        public Start()
        {
            InitializeComponent();
            this.FormClosing += MainForm_FormClosing;
        }

        public static void MainForm_FormClosing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            DialogResult ExitAnswer = MessageBox.Show("Вы действительно хотите закрыть программу?",
                    "Завершение работы", MessageBoxButtons.YesNo);

            if (ExitAnswer == DialogResult.Yes) //Если нажата “Да”
            {
                //e.Cancel = false;
                Application.ExitThread(); // Закрыть прогрпмму
            }
            else if (ExitAnswer == DialogResult.No) //Если нажата “Нет”
                e.Cancel = true; // кнопка больше не закрывает форму
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Закрыть прогрпмму
        }

        private void Yt_Button2_Click(object sender, EventArgs e)
        {
            
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            Teacher newForm = new Teacher(this);
            newForm.Show();
            this.Hide();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            StudentTests newForm = new StudentTests(this);
            newForm.Show();
            this.Hide();
        }
    }
}
