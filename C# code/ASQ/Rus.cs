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
    public partial class Rus : Form
    {
        public Rus()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult ExitAnswer = MessageBox.Show("Вы действительно хотите закрыть окно?",
                    "Завершение работы", MessageBoxButtons.YesNo);

            if (ExitAnswer == DialogResult.Yes) //Если нажата “Да”
                this.Close(); // Закрыть окно
        }
    }
}
