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
    public partial class Math : Form
    {
        public Math()
        {
            InitializeComponent();
            mathQuestion.Hide();
            Question.MaximumSize = new Size(800, 100);
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        int i = 0;
        int quesId; //id текущего вопроса
        DB db = new DB();
        private void Math_Load(object sender, EventArgs e)
        {  
            DataTable math = new DataTable();
            MySqlCommand command = new MySqlCommand("SELECT id,question FROM `question` WHERE id_subject = 1", db.GetConnection());
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            adapter.SelectCommand = command;//выбираем команду
            adapter.Fill(math);
            db.openConnection();//открываем соединение к бд

            if (math.Rows.Count > 0)//если нашли больше, чем 0 записей совпадающих, то пользователь авторизован
            {
                mathQuestion.DataSource = math;
                Question.Text = Convert.ToString(mathQuestion.Rows[i].Cells[1].Value);
                quesId = Convert.ToInt32(mathQuestion.Rows[i].Cells[0].Value);
                i++;
            }
            else
            {
                MessageBox.Show("Пользователь не зарегистрирован!");
            }
            db.closeConnection();// закрываем соединение к бд
        }

        private void MathReady_Click(object sender, EventArgs e)
        {
            db.openConnection();//открываем соединение к бд
            MySqlCommand command = new MySqlCommand("INSERT INTO `results`(`id`,`user_id`,`question_id`,`user_answer`) VALUES (NULL,@userid,@quesId,@userAnswer)", db.GetConnection());
            command.Parameters.Add("@userAnswer", MySqlDbType.VarChar).Value = MathInput.Text;
            MathInput.Text = "";
            command.Parameters.Add("@userid", MySqlDbType.VarChar).Value = StudentTests.id;
            command.Parameters.Add("@quesId", MySqlDbType.VarChar).Value = quesId;


            if (command.ExecuteNonQuery() == 1)
            {
                DataTable math = new DataTable();
                MySqlCommand command1 = new MySqlCommand("SELECT id,question FROM `question` WHERE id_subject = 1", db.GetConnection());
                //command.Parameters.Add("@username", MySqlDbType.VarChar).Value = name.Text;
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                adapter.SelectCommand = command1;//выбираем команду
                adapter.Fill(math);

                if (math.Rows.Count > 0)//если нашли больше, чем 0 записей совпадающих, то пользователь авторизован
                {
                    mathQuestion.DataSource = math;
                    Question.Text = Convert.ToString(mathQuestion.Rows[i].Cells[1].Value);
                    quesId = Convert.ToInt32(mathQuestion.Rows[i].Cells[0].Value);
                    i++;
                }
                else
                {
                    MessageBox.Show("Пользователь не зарегистрирован!");
                }

            }
            else
            {
                MessageBox.Show("Пользователь не зарегистрирован!");
            }
            db.closeConnection();//открываем соединение к бд

            if (i == 4)
            {
                MathReady.Enabled = false;
                MessageBox.Show("Спасибо за прохождение теста по математике. Можете переходить к следующему тесту или закончить работу с программой.");
            }
        }

        private void MathInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Question_Click(object sender, EventArgs e)
        {

        }
    }
}
