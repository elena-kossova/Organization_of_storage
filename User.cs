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
using System.Text.RegularExpressions;
using System.Runtime.Remoting.Contexts;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Data.Entity;

namespace Organization_of_storage
{
    public partial class User : Form
    {
        private readonly Check_User _user;
        Pogreb pogreb = new Pogreb();
        public User(Check_User user)
        {
            _user = user;
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void createColumnsUser(DataGridView dgv)
        {
            dgv.Columns.Add("ID_Name", "ID_названия");
            dgv.Columns.Add("Name", "Название");
            dgv.Columns.Add("Year", "Год");
            dgv.Columns.Add("Place", "Расположение");
            dgv.Columns.Add("Component", "Ингредиент");
            dgv.Columns.Add("Cap", "Крышка");
            dgv.Columns.Add("Volume", "Объем банки");
            dgv.Columns.Add("Type_of_cons", "Тип консервации");
            dgv.Columns.Add("Count", "Количество");
            dgv.Columns.Add("Recipe", "Рецепт");
        }

        private void ReadSingleRowUser(DataGridView dgv, IDataRecord record)
        {
            dgv.Rows.Add(record.IsDBNull(0) ? 0 : record.GetInt32(0),
                record.IsDBNull(1) ? "" : record.GetString(1),
                record.IsDBNull(2) ? 0 : record.GetInt32(2),
                record.IsDBNull(3) ? "" : record.GetString(3),
                record.IsDBNull(4) ? "" : record.GetString(4),
                record.IsDBNull(5) ? "" : record.GetString(5),
                record.IsDBNull(6) ? 0 : record.GetDouble(6),
                record.IsDBNull(7) ? "" : record.GetString(7),
                record.IsDBNull(8) ? 0 : record.GetInt32(8),
                record.IsDBNull(9) ? "" : record.GetString(9));
        }

        private void RefreshDataGridUser(DataGridView dgv)
        {
            dgv.Rows.Clear();

            string query = $"select P.ID_Name, P.Name, P.Year, L.Place,  I.Component, " +
                $"C.Cap, C.Volume, T.Type_of_cons, P.Count, P.Recipe " +
                $"from[dbo].[Product] P join[dbo].[Location] L on  P.ID_Place = L.ID_Place " +
                $"join[dbo].[Ingredients] I on P.ID_Component = I.ID_Component " +
                $"join[dbo].[Container] C on P.ID_Container = C.ID_Container " +
                $"join[dbo].[Type_of_conservation] T on P.ID_Type = T.ID_Type";
            SqlCommand command = new SqlCommand(query, pogreb.getConnection());
            pogreb.open_connect();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                ReadSingleRowUser(dgv, reader);
            }
            reader.Close();
        }

        private string[] getListStr(string query)
        {
            var list = new List<string>();
            using (var command = new SqlCommand(query, pogreb.getConnection()))
            {
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(reader.GetString(0));
                    }
                }
            }
            return list.ToArray();
        }
        private object[] getListInt(string query)
        {
            var list = new List<object>();
            using (var command = new SqlCommand(query, pogreb.getConnection()))
            {
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(reader.GetInt32(0));
                    }
                }
            }
            return list.ToArray();
        }
        private object[] getListDouble(string query)
        {
            var list = new List<object>();
            using (var command = new SqlCommand(query, pogreb.getConnection()))
            {
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(reader.GetDouble(0));
                    }
                }
            }
            return list.ToArray();
        }

        private void createColumnsUserStat(DataGridView dgv)
        {
            dgv.Columns.Add("Component", "Ингредиент");
            dgv.Columns.Add("Volume", "Общий объем в литрах");
            dgv.Columns.Add("Count", "Общее количество");
        }

        private void ReadSingleRowUserStat(DataGridView dgv, IDataRecord record)
        {
            dgv.Rows.Add(
                record.IsDBNull(0) ? "" : record.GetString(0),
                record.IsDBNull(1) ? 0 : record.GetDouble(1),
                record.IsDBNull(2) ? 0 : record.GetInt32(2));
        }

        private void RefreshDataGridUserStat(DataGridView dgv)
        {
            dgv.Rows.Clear();
            string query = $"select I.Component, sum(C.Volume * P.Count) as All_volume, sum(P.Count) as All_count " +
                $"from [dbo].[Product] P " +
                $"join [dbo].[Container] C on P.ID_Container = C.ID_Container " +
                $"join [dbo].[Ingredients] I on P.ID_Component = I.ID_Component " +
                $"group by I.Component";

            SqlCommand command = new SqlCommand(query, pogreb.getConnection());
            pogreb.open_connect();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                ReadSingleRowUserStat(dgv, reader);
            }
            reader.Close();
        }

        private void createColumnsUserBasket(DataGridView dgv)
        {
            dgv.Columns.Add("login_u", "Имя пользователя");
            dgv.Columns.Add("ID_Name", "ID_названия");
            dgv.Columns.Add("CountB", "Взятое количество");
            dgv.Columns.Add("Count", "Общее количество");
            dgv.Columns.Add("Name", "Название");
            dgv.Columns.Add("Year", "Год");
            dgv.Columns.Add("Place", "Расположение");
            dgv.Columns.Add("Component", "Ингредиент");
            dgv.Columns.Add("Cap", "Крышка");
            dgv.Columns.Add("Volume", "Объем банки");
            dgv.Columns.Add("Type_of_cons", "Тип консервации");
            dgv.Columns.Add("Recipe", "Рецепт");
        }

        private void ReadSingleRowBasket(DataGridView dgv, IDataRecord record)
        {
            dgv.Rows.Add(record.IsDBNull(0) ? "" : record.GetString(0),
                record.IsDBNull(1) ? 0 : record.GetInt32(1),
                record.IsDBNull(2) ? 0 : record.GetInt32(2),
                record.IsDBNull(3) ? 0 : record.GetInt32(3),
                record.IsDBNull(4) ? "" : record.GetString(4),
                record.IsDBNull(5) ? 0 : record.GetInt32(5),
                record.IsDBNull(6) ? "" : record.GetString(6),
                record.IsDBNull(7) ? "" : record.GetString(7),
                record.IsDBNull(8) ? "" : record.GetString(8),
                record.IsDBNull(9) ? 0 : record.GetDouble(9),
                record.IsDBNull(10) ? "" : record.GetString(10),
                record.IsDBNull(11) ? "" : record.GetString(11));
        }
        private void RefreshDataGridUserBasket(DataGridView dgv)
        {
            dgv.Rows.Clear();
            string query = $"select R.login_u, B.ID_Name, B.CountB, P.Count, P.Name, P.Year, L.Place,  I.Component, C.Cap, C.Volume, T.Type_of_cons, P.Recipe " +
                $"from[dbo].[InBasket] B join[dbo].[Registration] R on B.id_user = R.id_user " +
                $"join[dbo].[Product] P on B.ID_Name = P.ID_Name " +
                $"join[dbo].[Location] L on P.ID_Place = L.ID_Place " +
                $"join[dbo].[Ingredients] I on P.ID_Component = I.ID_Component " +
                $"join[dbo].[Container] C on P.ID_Container = C.ID_Container " +
                $"join[dbo].[Type_of_conservation] T on P.ID_Type = T.ID_Type " +
                $"where P.Name like '%{textBox1_basket_search.Text}%'";

            SqlCommand command = new SqlCommand(query, pogreb.getConnection());
            pogreb.open_connect();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                ReadSingleRowBasket(dgv, reader);
            }
            reader.Close();
        }

        private void fillComboBoxSort()
        {
            pogreb.open_connect();

            comboBox1_user_type.Items.Clear();
            comboBox2_user_product.Items.Clear();

            var queryType = $"select distinct Type_of_cons from dbo.Type_of_conservation";
            var queryComponent = $"select distinct Component from dbo.Ingredients";

            comboBox1_user_type.Items.Add("Все типы");
            comboBox2_user_product.Items.Add("Все ингредиенты");

            comboBox1_user_type.Items.AddRange(getListStr(queryType));
            comboBox2_user_product.Items.AddRange(getListStr(queryComponent));

            comboBox1_user_type.SelectedIndex = 0;
            comboBox2_user_product.SelectedIndex = 0;

            pogreb.close_connect();
        }

        private void User_Load(object sender, EventArgs e)
        {
            
        }

        private void sort_rows(DataGridView dgv)
        { 
            dgv.Rows.Clear();
            string query = $"select P.ID_Name, P.Name, P.Year, L.Place, I.Component, C.Cap, C.Volume, T.Type_of_cons, P.Count, P.Recipe " +
                $"from [dbo].[Product] P " +
                $"join [dbo].[Location] L on  P.ID_Place = L.ID_Place " +
                $"join [dbo].[Ingredients] I on P.ID_Component = I.ID_Component " +
                $"join [dbo].[Container] C on P.ID_Container = C.ID_Container " +
                $"join [dbo].[Type_of_conservation] T on P.ID_Type = T.ID_Type where P.Name like '%{textBox1_user_search.Text}%'";

            if (comboBox1_user_type.Text != "Все типы")
            {
                query += $" and T.Type_of_cons = '{comboBox1_user_type.Text}'";
            }
            if (comboBox2_user_product.Text != "Все ингредиенты")
            {
                query += $" and I.Component = '{comboBox2_user_product.Text}'";
            }
            

            SqlCommand command = new SqlCommand(query, pogreb.getConnection());
            pogreb.open_connect();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                ReadSingleRowUser(dgv, reader);
            }
            reader.Close();
        }
        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void label1_user_type_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_user_type_SelectedIndexChanged(object sender, EventArgs e)
        {
            sort_rows(dataGridView3_user);
        }

        private void label2_user_product_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_user_product_SelectedIndexChanged(object sender, EventArgs e)
        {
            sort_rows(dataGridView3_user);
        }

        private void label3_user_search_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_user_search_TextChanged(object sender, EventArgs e)
        {
            sort_rows(dataGridView3_user);
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void userAddInBasket()
        {
            pogreb.open_connect();

            int index = dataGridView3_user.CurrentCell.RowIndex;
            int id_name = Int32.Parse(dataGridView3_user.Rows[index].Cells[0].Value.ToString());
            int Count = Int32.Parse(dataGridView3_user.Rows[index].Cells[8].Value.ToString());

            var ID_User = $"select id_user from dbo.Registration where login_u = '{_user.Login}'";
            var command_ID_U = new SqlCommand(ID_User, pogreb.getConnection());
            int id_user = int.Parse(command_ID_U.ExecuteScalar().ToString());

            var id_basket = $"select ID_Name from dbo.InBasket where ID_Name like '%{id_name}%'";
            var command = new SqlCommand(id_basket, pogreb.getConnection());
            // если такого продукта еще не было в корзине
            if (command.ExecuteScalar() is null)
            {
                int cnt = 1;
                var addQuery = $"INSERT INTO dbo.InBasket(id_user, ID_Name, CountB) VALUES('{id_user}', '{id_name}', '{cnt}')";
                var commandAddQuery = new SqlCommand(addQuery, pogreb.getConnection());
                commandAddQuery.ExecuteNonQuery();
                MessageBox.Show("Продукт успешно добавлен в корзину!", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            // если такой продукт уже есть в корзине
            else
            {
                var CountBasket = $"select CountB from dbo.InBasket where ID_Name = '{id_name}'";
                var command_In_B = new SqlCommand(CountBasket, pogreb.getConnection());
                int CountInBasket = int.Parse(command_In_B.ExecuteScalar().ToString());
                if (CountInBasket + 1 <= Count)
                {
                    var addQuery = $"UPDATE dbo.InBasket SET CountB = CountB+1 WHERE ID_Name={id_name}";
                    var commandAdd = new SqlCommand(addQuery, pogreb.getConnection());
                    commandAdd.ExecuteNonQuery();
                    MessageBox.Show("Количество продукта в корзине увеличено!", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("В погребе больше нет продуктов такого типа!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

            pogreb.close_connect();
            RefreshDataGridUserBasket(dataGridView2_user);
        }

        private void button1_user_add_Click(object sender, EventArgs e)
        {
            userAddInBasket();
        }

        private void tabPage2_user_stat_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_user_stat_name_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_user_stat_name_SelectedIndexChanged(object sender, EventArgs e)
        {
            //sort_rows(comboBox1_user_stat_name.Text, comboBox2_user_stat_product.Text, comboBox3_user_stat_type.Text, dataGridView1);
        }

        private void label2_user_stat_product_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_user_stat_product_SelectedIndexChanged(object sender, EventArgs e)
        {
            //sort_rows(comboBox1_user_stat_name.Text, comboBox2_user_stat_product.Text, comboBox3_user_stat_type.Text, dataGridView1);
        }

        private void label3_user_stat_type_Click(object sender, EventArgs e)
        {

        }

        private void comboBox3_user_stat_type_SelectedIndexChanged(object sender, EventArgs e)
        {
            //sort_rows(comboBox1_user_stat_name.Text, comboBox2_user_stat_product.Text, comboBox3_user_stat_type.Text, dataGridView1);
        }

        private void tabPage3_user_basket_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void userReturnOnShelf()
        {
            pogreb.open_connect();

            int index = dataGridView2_user.CurrentCell.RowIndex;
            int id_name = Int32.Parse(dataGridView2_user.Rows[index].Cells[1].Value.ToString());
            int Count = Int32.Parse(dataGridView2_user.Rows[index].Cells[2].Value.ToString());

            if (Count > 1)
            {
                var deleteQuery = $"UPDATE dbo.InBasket SET CountB = CountB-1 WHERE ID_Name={id_name}";
                var command = new SqlCommand(deleteQuery, pogreb.getConnection());
                command.ExecuteNonQuery();

                MessageBox.Show("Один экземпляр продукта успешно удален из корзины!", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (Count == 1)
                {
                    var deleteQuery = $"delete from dbo.InBasket where ID_Name = {id_name}";
                    var command = new SqlCommand(deleteQuery, pogreb.getConnection());
                    command.ExecuteNonQuery();

                    MessageBox.Show("Позиция успешно удалена из корзины!", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            pogreb.close_connect();
            RefreshDataGridUserBasket(dataGridView2_user);
        }

        private void button1_user_basket_return_Click(object sender, EventArgs e)
        {
            userReturnOnShelf();
        }

        private void User_Load_1(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "погребDataSet2.Ingredients". При необходимости она может быть перемещена или удалена.
            this.ingredientsTableAdapter.Fill(this.погребDataSet2.Ingredients);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "погребDataSet2.Type_of_conservation". При необходимости она может быть перемещена или удалена.
            this.type_of_conservationTableAdapter.Fill(this.погребDataSet2.Type_of_conservation);

            createColumnsUser(dataGridView3_user);
            createColumnsUserStat(dataGridView1_user);
            createColumnsUserBasket(dataGridView2_user);
            fillComboBoxSort();
            RefreshDataGridUser(dataGridView3_user);
            RefreshDataGridUserStat(dataGridView1_user);
            RefreshDataGridUserBasket(dataGridView2_user); // заполняет столбцы данными
            dataGridView3_user.Columns[0].Visible = false;
            dataGridView2_user.Columns[0].Visible = false;
            dataGridView2_user.Columns[1].Visible = false;
        }

        private void textBox1_basket_search_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
