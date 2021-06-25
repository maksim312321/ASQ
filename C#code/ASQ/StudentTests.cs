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
    public partial class StudentTests : Form
    {
        Start StartHide;
        public StudentTests(Start ForHide)
        {
            InitializeComponent();
            StartHide = ForHide;
            grouptest.BackColor = Color.Transparent;
            grouptest.Enabled = false;
            this.FormClosing += Start.MainForm_FormClosing; // обработка выхода по крестику

        }
        public static int id;//idтекущего пользователя
        private void Button3_Click(object sender, EventArgs e)
        {
            if (name.Text != "")
            {
                DialogResult ExitAnswer = MessageBox.Show("Вы действительно хотите вернуться?",
                    "Завершение работы", MessageBoxButtons.YesNo);

                if (ExitAnswer == DialogResult.Yes) //Если нажата “Да”
                {
                    StartHide.Show();
                    this.Hide();
                }
            }
            else
            {
                StartHide.Show();
                this.Hide();
            }
        }

        private void StudentTests_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        public void button2_Click(object sender, EventArgs e)
        {
            if((name.Text != "") && (name.Text.Length <=30) ) 
            {
                name.ReadOnly = true;
                DB db = new DB();
                MySqlCommand command = new MySqlCommand("INSERT INTO `users`(`id`, `user_name`) VALUES (NULL, @username)", db.GetConnection());
                command.Parameters.Add("@username", MySqlDbType.VarChar).Value = name.Text;

                db.openConnection();//открываем соединение к бд

                if(command.ExecuteNonQuery() == 1)
                {
                    grouptest.Enabled = true;
                    buttonNameConf.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Пользователь не зарегистрирован!");
                }

                MySqlCommand command_idUser = new MySqlCommand("SELECT id FROM `users` WHERE user_name = @un", db.GetConnection());
                //заглушки для безопасности
                command_idUser.Parameters.Add("@un", MySqlDbType.VarChar).Value = name.Text;//инициализация зашлушки
                MySqlDataAdapter adapter_idUser = new MySqlDataAdapter();
                DataTable idUser = new DataTable();
                adapter_idUser.SelectCommand = command_idUser;//выбираем команду
                adapter_idUser.Fill(idUser);

                if (idUser.Rows.Count > 0)//если нашли больше, чем 0 записей совпадающих, то пользователь авторизован
                {
                    id = Convert.ToInt32(idUser.Rows[0][0]);
                }
                else
                {
                    MessageBox.Show("Ошибка поиска id текущего пользователя");
                }


                db.closeConnection();// закрываем соединение к бд



            }
        }

        bool mathPassed = false;
        bool rusPassed = false;
        bool physicsPassed = false;
        private void button1_Click(object sender, EventArgs e)
        {

            if (math.Checked)
            {
                if (mathPassed == false)
                {
                    mathPassed = true;
                    Math math = new Math(this);
                    math.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Тест по данной дисциплине уже был пройден вами.");
                }
            }
            if (rus.Checked)
            {
                if (rusPassed == false)
                {
                    rusPassed = true;
                    Rus rus = new Rus(this);
                    rus.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Тест по данной дисциплине уже был пройден вами.");
                }
            }
            if (physics.Checked)
            {
                if (physicsPassed == false)
                {
                    physicsPassed = true;
                    Physicscs physicscs = new Physicscs(this);
                    physicscs.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Тест по данной дисциплине уже был пройден вами.");
                }
            }
        }
    }
}
