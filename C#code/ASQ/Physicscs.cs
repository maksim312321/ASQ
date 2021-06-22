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

namespace ASQ
{
    public partial class Physicscs : Form
    {
        public Physicscs()
        {
            InitializeComponent();
            physicscsQuestion.Hide();
            Question.MaximumSize = new Size(800, 100);
        }

        int i = 0;
        int quesId; //id текущего вопроса
        DB db = new DB();
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Physicscs_Load(object sender, EventArgs e)
        {
            DataTable Physicscs = new DataTable();
            MySqlCommand command = new MySqlCommand("SELECT id,question FROM `question` WHERE id_subject = 3", db.GetConnection());
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            adapter.SelectCommand = command;//выбираем команду
            adapter.Fill(Physicscs);
            db.openConnection();//открываем соединение к бд

            if (Physicscs.Rows.Count > 0)//если нашли больше, чем 0 записей совпадающих, то пользователь авторизован
            {
                physicscsQuestion.DataSource = Physicscs;
                Question.Text = Convert.ToString(physicscsQuestion.Rows[i].Cells[1].Value);
                quesId = Convert.ToInt32(physicscsQuestion.Rows[i].Cells[0].Value);
                i++;
            }
            else
            {
                MessageBox.Show("Пользователь не зарегистрирован!");
            }
            db.closeConnection();// закрываем соединение к бд
        }

        private void Question_Click(object sender, EventArgs e)
        {

        }

        private void PhysicscsReady_Click(object sender, EventArgs e)
        {
            if (i == 3)
            {
                PhysicscsReady.Enabled = false;
                MessageBox.Show("Спасибо за прохождение теста по математике. Можете переходить к следующему тесту или закончить работу с программой.");
            }
            else
            {
                db.openConnection();//открываем соединение к бд
                MySqlCommand command = new MySqlCommand("INSERT INTO `results`(`id`,`user_id`,`question_id`,`user_answer`) VALUES (NULL,@userid,@quesId,@userAnswer)", db.GetConnection());
                command.Parameters.Add("@userAnswer", MySqlDbType.VarChar).Value = PhysicscsInput.Text;
                PhysicscsInput.Text = "";
                command.Parameters.Add("@userid", MySqlDbType.VarChar).Value = StudentTests.id;
                command.Parameters.Add("@quesId", MySqlDbType.VarChar).Value = quesId;


                if (command.ExecuteNonQuery() == 1)
                {
                    DataTable Physicscs = new DataTable();
                    MySqlCommand command1 = new MySqlCommand("SELECT id,question FROM `question` WHERE id_subject = 3", db.GetConnection());
                    MySqlDataAdapter adapter = new MySqlDataAdapter();
                    adapter.SelectCommand = command1;//выбираем команду
                    adapter.Fill(Physicscs);
                    db.openConnection();//открываем соединение к бд

                    if (Physicscs.Rows.Count > 0)//если нашли больше, чем 0 записей совпадающих, то пользователь авторизован
                    {
                        physicscsQuestion.DataSource = Physicscs;
                        Question.Text = Convert.ToString(physicscsQuestion.Rows[i].Cells[1].Value);
                        quesId = Convert.ToInt32(physicscsQuestion.Rows[i].Cells[0].Value);
                        i++;
                    }
                    else
                    {
                        MessageBox.Show("Пользователь не зарегистрирован!");
                    }
                    db.closeConnection();// закрываем соединение к бд

                }
                else
                {
                    MessageBox.Show("Пользователь не зарегистрирован!");
                }
                db.closeConnection();//открываем соединение к бд
            }
        }
    }
}
