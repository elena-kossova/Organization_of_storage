using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Organization_of_storage
{
    public partial class FormAutorization : Form
    {
        Pogreb podval = new Pogreb();
        public FormAutorization()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void FormAutorization_Load(object sender, EventArgs e)
        {
            textBoxA2_password.PasswordChar = '*';
            //pictureBoxA1_ya.Visible = false;
            textBoxA1_login.MaxLength = 50;
            textBoxA2_password.MaxLength = 50;
        }

        private void labelA2_registr_Click(object sender, EventArgs e)
        {

        }

        private void labelA1_login_Click(object sender, EventArgs e)
        {

        }

        private void textBoxA1_login_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelA4_password_Click(object sender, EventArgs e)
        {

        }

        private void textBoxA2_password_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonA1_create_Click(object sender, EventArgs e)
        {
            var login_user = textBoxA1_login.Text;
            var password_user = textBoxA2_password.Text;

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            string new_user = $"select id_user, login_u, password_u, is_admin from Registration where login_u = '{login_user}' and password_u = '{password_user}'";

            SqlCommand command = new SqlCommand(new_user, podval.getConnection());
            
            adapter.SelectCommand = command;
            adapter.Fill(table);

            if(table.Rows.Count == 1)
            {
                var user = new Check_User(table.Rows[0].ItemArray[1].ToString(), Convert.ToBoolean(table.Rows[0].ItemArray[3]));

                MessageBox.Show("Вход выполнен успешно!", "Удачно!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (user.IsAdmin)
                {
                    Form1 form1 = new Form1(user);
                    this.Hide();
                    form1.ShowDialog();
                    this.Show();
                }

                else
                {
                    User usfrm = new User(user);
                    this.Hide();
                    usfrm.ShowDialog();
                    this.Show();
                }
            }
            else
            {
                MessageBox.Show("Такого аккаунта нет или логин или пароль введены неверно!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void linkLabelA1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormRegistration formRegistr = new FormRegistration();
            formRegistr.Show();
            this.Hide();
        }
        /*private void pictureBoxA2_nein_Click_1(object sender, EventArgs e)
        {
            textBoxA2_password.UseSystemPasswordChar = true;
            pictureBoxA2_nein.Visible = false;
            pictureBoxA1_ya.Visible = true;
        }

        private void pictureBoxA1_ya_Click(object sender, EventArgs e)
        {
            textBoxA2_password.UseSystemPasswordChar = false;
            pictureBoxA1_ya.Visible = false;
            pictureBoxA2_nein.Visible = true;
        }*/
    }
}
