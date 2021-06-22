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
            //command.Parameters.Add("@username", MySqlDbType.VarChar).Value = name.Text;
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

            //MySqlCommand command_idUser = new MySqlCommand("SELECT id FROM `users` WHERE user_name = @un", db.GetConnection());
            ////заглушки для безопасности
            ////command_idUser.Parameters.Add("@un", MySqlDbType.VarChar).Value = name.Text;//инициализация зашлушки
            //MySqlDataAdapter adapter_idUser = new MySqlDataAdapter();
            //DataTable idUser = new DataTable();
            //adapter_idUser.SelectCommand = command_idUser;//выбираем команду
            //adapter_idUser.Fill(idUser);

            //if (idUser.Rows.Count > 0)//если нашли больше, чем 0 записей совпадающих, то пользователь авторизован
            //{
            //    //id = Convert.ToInt32(idUser.Rows[0][0]);
            //    //MessageBox.Show(Convert.ToString(id));
            //}
            //else
            //{
            //    MessageBox.Show("Ошибка поиска id текущего пользователя");
            //}


            db.closeConnection();// закрываем соединение к бд
        }

        private void MathReady_Click(object sender, EventArgs e)
        {
            
            if( i == 3)
            {
                MathReady.Enabled = false;
                MessageBox.Show("Спасибо за прохождение теста по математике. Можете переходить к следующему тесту или закончить работу с программой.");
            }
            else
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
            }
        }

        private void MathInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
