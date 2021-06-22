using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;

namespace ASQ
{
    public partial class Teacher2 : Form
    {
        public Teacher2()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }



        private void Teacher2_Load(object sender, EventArgs e)
        {
            DB db = new DB();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT users.user_name, results.user_answer, question.question, question.correct_answer FROM `results`, `question`, `users`", db.GetConnection());

            adapter.SelectCommand = command;//выбираем команду           
            adapter.Fill(table);
            resultsTable.DataSource = table;//отображение данных
        }
    }
}
