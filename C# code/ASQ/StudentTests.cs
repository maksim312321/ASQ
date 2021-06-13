﻿using System;
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
    public partial class StudentTests : Form
    {
        public StudentTests()
        {
            InitializeComponent();
            radioButton1.Checked = true; // автовыбор радиокнопки
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult ExitAnswer = MessageBox.Show("Вы действительно хотите завершить работу?",
                    "Завершение работы", MessageBoxButtons.YesNo);

            if (ExitAnswer == DialogResult.Yes) //Если нажата “Да”
                Application.Exit(); // Закрыть приложение
            else
                MessageBox.Show("Мы благодарны Вам, за то, что Вы выбрали работу с нашим приложением.");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Открытие выбранного теста
            if (radioButton1.Checked) // Математика
            {
                Math newForm = new Math();
                newForm.Show();
            }
            else if (radioButton2.Checked) // Русский
            {
                Rus newForm = new Rus();
                newForm.Show();
            }
            else if (radioButton3.Checked) // Физика
            {
                Physicscs newForm = new Physicscs();
                newForm.Show();
            }
            
        }
    }
}
