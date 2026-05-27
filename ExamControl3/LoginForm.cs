using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Npgsql;

namespace ExamControl3
{
    public partial class LoginForm : Form
    {

        string connectionString = "Host = localhost; Port = 5432; Username = postgres; Password = root; Database = control3";
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnAuth_Click(object sender, EventArgs e)
        {
            string sql = $"SELECT role_id, fio FROM users WHERE login='{txtLogin.Text}' AND password='{txtPassword.Text}'";

            using(NpgsqlConnection conn = new NpgsqlConnection(connectionString))
            using(NpgsqlCommand cmd = new NpgsqlCommand(sql, conn))
            {
                conn.Open();

                using(NpgsqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        string fio = reader["fio"].ToString();
                        int roleId = Convert.ToInt32(reader["role_id"]);

                        MainForm mainForm = new MainForm(fio, roleId); // передаем фио и роль
                        mainForm.Show();
                        this.Hide();
                    }

                    else
                    {
                        MessageBox.Show("Неверный логин или пароль");
                    }
                }
            }
        }

        private void btnGuest_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm("Гость", 0);
            mainForm.Show();
            this.Hide();
        }
    }
}
