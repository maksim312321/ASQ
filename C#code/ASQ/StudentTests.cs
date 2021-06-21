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
        public StudentTests()
        {
            InitializeComponent();
            grouptest.BackColor = Color.Transparent;
            grouptest.Enabled = false;

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void StudentTests_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if((name.Text != "") && (name.Text.Length <=30) ) 
            {
                DB db = new DB();
                MySqlCommand command = new MySqlCommand("INSERT INTO `users`(`id`, `user_name`) VALUES (NULL,@username)", db.GetConnection());
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

                db.closeConnection();// закрываем соединение к бд
            }
        }
    }
}
