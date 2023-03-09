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

namespace Organization_of_storage
{
    public partial class FormRegistration : Form
    {
        Pogreb podval = new Pogreb();
        public FormRegistration()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void FormRegistration_Load(object sender, EventArgs e)
        {
            textBox2_password.PasswordChar = '*';
            //pictureBox1_ya.Visible = false; 
            textBox1_login.MaxLength = 50;
            textBox2_password.MaxLength = 50;

        }
        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private Boolean check_user()
        {
            var login_user = textBox1_login.Text;
            var password_user = textBox2_password.Text;

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            string new_user = $"select id_user, login_u, password_u, is_admin from Registration where login_u = '{login_user}' and password_u = '{password_user}'";

            SqlCommand command = new SqlCommand(new_user, podval.getConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Такой пользователь уже существует", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }
            else
            {
                return false;
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        /*private void pictureBox2_nein_Click(object sender, EventArgs e)
        {
            textBox2_password.UseSystemPasswordChar = true;
            pictureBox2_nein.Visible = true;
            pictureBox1_ya.Visible = false;
        }

        private void pictureBox1_ya_Click(object sender, EventArgs e)
        {
            textBox2_password.UseSystemPasswordChar = false;
            pictureBox1_ya.Visible = true;
            pictureBox2_nein.Visible = false;
        }*/

        private void button1_create_Click(object sender, EventArgs e)
        {
            // Pogreb pogreb = new Pogreb();
            var login_user = textBox1_login.Text;
            var password_user = textBox2_password.Text;

            string new_user = $"insert into Registration (login_u, password_u, is_admin) values ('{login_user}', '{password_user}', 0)";

            SqlCommand command = new SqlCommand(new_user, podval.getConnection());

            podval.open_connect();

            if (!check_user())
            {
                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Аккаунт создан!", "Удачно!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FormAutorization formAutoriz = new FormAutorization();
                    this.Hide();
                    formAutoriz.ShowDialog();
                    this.Show();
                }
                else
                {
                    MessageBox.Show("Аккаунт не создан!", "Аккаунт не создан!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                FormAutorization formAutoriz = new FormAutorization();
                this.Hide();
                formAutoriz.ShowDialog();
                this.Show();
            }

            podval.close_connect();
        }
    }
}
