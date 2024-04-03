using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kursach
{
    public partial class FormAuthorization : Form
    {
        private DataBase dataBase;

        public FormAuthorization()
        {
            InitializeComponent();

            buttonLogin.Left = (this.ClientSize.Width - buttonLogin.Width) / 2;
            this.MaximizeBox = false;

            DataBase.User = "";
            DataBase.Password = "";
            textBoxPassword.PasswordChar= '*';
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string login = textBoxLogin.Text;
            string password = textBoxPassword.Text;

            DataBase.User = login;
            DataBase.Password = password;

            dataBase = new DataBase();
            // выполнить тестовое подключение к серверу и БД для проверки правильности введенных данных

            try
            {
                dataBase.openConnection();

                using (SqlCommand command = new SqlCommand("GetUserRole", dataBase.getConnection()))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    string role = (string)command.ExecuteScalar();

                    this.Hide();

                    if (role == "BookingOperator")
                    {
                        Form1 form = new Form1();
                        form.Show();
                    }
                    else if (role == "Restorator")
                    {
                        FormStatistics form = new FormStatistics();
                        form.Show();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Неверный пользователь или пароль: {ex.Message}");
            }
            finally
            {
                dataBase.closeConnection();
            }
        }

        private void FormAuthorization_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;

                DialogResult result = MessageBox.Show("Вы уверены, что хотите выйти?", "Подтверждение выхода", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                    Application.Exit();
            }
        }

        private void textBoxLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsLetter(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true; // Если не является, игнорируем ввод
            }
        }

        private void textBoxPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) ||
                (e.KeyChar >= 'a' && e.KeyChar <= 'z') ||
                (e.KeyChar >= 'A' && e.KeyChar <= 'Z') ||
                e.KeyChar == 8))
            {
                e.Handled = true; // Если не является, игнорируем ввод
            }
        }
    }
}
