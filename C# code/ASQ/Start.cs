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
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            DialogResult ExitAnswer = MessageBox.Show("Вы действительно хотите завершить работу?",
                    "Завершение работы", MessageBoxButtons.YesNo);

            if (ExitAnswer == DialogResult.Yes) //Если нажата “Да”
                Application.Exit(); // Закрыть приложение
            else
                MessageBox.Show("Мы благодарны Вам, за то, что Вы выбрали работу с нашим приложением.");

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Teacher newForm = new Teacher();
            newForm.Show();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            StudentTests newForm = new StudentTests();
            newForm.Show();
        }
    }
}
