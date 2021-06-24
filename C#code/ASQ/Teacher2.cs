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
            resultsTable.ReadOnly = true;
            resultsTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }

        private void button3_Click(object sender, EventArgs e)
        {
                Application.Exit(); // Закрыть прогрпмму
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }



        private void Teacher2_Load(object sender, EventArgs e)
        {
            DB db = new DB();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT users.user_name AS NAME, results.user_answer AS USER_ANSWER,question.question AS QUESTION,question.correct_answer AS CORRECT_ANSWER FROM `results`, `question`, `users` WHERE results.user_id = users.id AND results.question_id = question.id ORDER BY users.id", db.GetConnection());

            adapter.SelectCommand = command;//выбираем команду           
            adapter.Fill(table);
            resultsTable.DataSource = table;//отображение данных
        }

        private void resultsTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
