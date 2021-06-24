using MySql.Data.MySqlClient;
using System.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ASQ
{
    public partial class Teacher : Form
    {
        Start StartHide;
        public Teacher(Start ForHide)
        {
            InitializeComponent();
            StartHide = ForHide;
            this.FormClosing += Start.MainForm_FormClosing; // обработка выхода по крестику
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void teacher_login_Click(object sender, EventArgs e)
        {
            string loginUser = loginField.Text;
            string passUser = passField.Text;

            DB db = new DB();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `admin` WHERE `login` = @uL AND `password` = @uP ", db.GetConnection());
            //заглушки для безопасности
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = loginUser;//инициализация зашлушек
            command.Parameters.Add("@uP", MySqlDbType.VarChar).Value = passUser;//инициализация зашлушек

            adapter.SelectCommand = command;//выбираем команду
            adapter.Fill(table);

            if(table.Rows.Count > 0)//если нашли больше, чем 0 записей совпадающих, то пользователь авторизован
            {
                Teacher2 results = new Teacher2();
                results.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            StartHide.Show();
            this.Hide();
        }

        private void Teacher_Load(object sender, EventArgs e)
        {

        }
    }
}
