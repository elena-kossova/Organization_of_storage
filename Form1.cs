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
    public partial class Form1 : Form
    {
        private readonly Check_User _user;
        Pogreb pogreb = new Pogreb();

        public Form1(Check_User user)
        {
            _user = user;
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void IsAdmin()
        {

        }
        private void createColumns(DataGridView dgv)
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
        private void ReadSingleRow(DataGridView dgv, IDataRecord record)
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
        private void RefreshDataGrid(DataGridView dgv)
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
                ReadSingleRow(dgv, reader);
            }
            reader.Close();
        }
        private string[] getListStr(string query)
        {
            var list = new List<string>();
            using (var command = new SqlCommand(query, pogreb.getConnection()))
            {
                using(var reader = command.ExecuteReader())
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
        private void fillComboBox()
        {
            pogreb.open_connect();

            comboBox1_name.Items.Clear();
            comboBox2_year.Items.Clear();
            comboBox3_place.Items.Clear();
            comboBox4_component.Items.Clear();
            comboBox5_cap.Items.Clear();
            comboBox6_volume.Items.Clear();
            comboBox7_type.Items.Clear();

            var queryName = $"select distinct Name from dbo.Product";
            var queryYear = $"select distinct Year from dbo.Product where Year is not NULL";
            var queryPlace = $"select distinct Place from dbo.Location";
            var queryComponent = $"select distinct Component from dbo.Ingredients";
            var queryCap = $"select distinct Cap from dbo.Container";
            var queryVolume = $"select distinct Volume from dbo.Container";
            var queryType = $"select distinct Type_of_cons from Type_of_conservation";

            comboBox1_name.Items.AddRange(getListStr(queryName));
            comboBox2_year.Items.AddRange(getListInt(queryYear));
            comboBox3_place.Items.AddRange(getListStr(queryPlace));
            comboBox4_component.Items.AddRange(getListStr(queryComponent));
            comboBox5_cap.Items.AddRange(getListStr(queryCap));
            comboBox6_volume.Items.AddRange(getListDouble(queryVolume));
            comboBox7_type.Items.AddRange(getListStr(queryType));

            pogreb.close_connect();
        }

        private void fillComboBoxSort()
        {
            pogreb.open_connect();

            comboBox1_admin_type.Items.Clear();
            comboBox2_admin_product.Items.Clear();

            var queryType = $"select distinct Type_of_cons from dbo.Type_of_conservation";
            var queryComponent = $"select distinct Component from dbo.Ingredients";
            //var queryName = $"select distinct Name from dbo.Product";

            comboBox1_admin_type.Items.Add("Все типы");
            comboBox2_admin_product.Items.Add("Все ингредиенты");

            comboBox1_admin_type.Items.AddRange(getListStr(queryType));
            comboBox2_admin_product.Items.AddRange(getListStr(queryComponent));

            comboBox1_admin_type.SelectedIndex = 0;
            comboBox2_admin_product.SelectedIndex = 0;

            pogreb.close_connect();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "погребDataSet2.Type_of_conservation". При необходимости она может быть перемещена или удалена.
            this.type_of_conservationTableAdapter1.Fill(this.погребDataSet2.Type_of_conservation);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "погребDataSet2.Container". При необходимости она может быть перемещена или удалена.
            this.containerTableAdapter.Fill(this.погребDataSet2.Container);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "погребDataSet2.Ingredients". При необходимости она может быть перемещена или удалена.
            this.ingredientsTableAdapter1.Fill(this.погребDataSet2.Ingredients);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "погребDataSet2.Location". При необходимости она может быть перемещена или удалена.
            this.locationTableAdapter.Fill(this.погребDataSet2.Location);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "погребDataSet1.Ingredients". При необходимости она может быть перемещена или удалена.
            this.ingredientsTableAdapter.Fill(this.погребDataSet1.Ingredients);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "погребDataSet1.Type_of_conservation". При необходимости она может быть перемещена или удалена.
            this.type_of_conservationTableAdapter.Fill(this.погребDataSet1.Type_of_conservation);
            createColumns(dataGridView1_admin_table);
            createColumnsStat(dataGridView2);
            createColumnsBasket(dataGridView3);
            fillComboBoxSort();
            RefreshDataGrid(dataGridView1_admin_table);
            RefreshDataGridStat(dataGridView2);
            RefreshDataGridBasket(dataGridView3);

            // TODO: данная строка кода позволяет загрузить данные в таблицу "погребDataSet.Product". При необходимости она может быть перемещена или удалена.
            this.productTableAdapter.Fill(this.погребDataSet.Product);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "погребDataSet.InBasket". При необходимости она может быть перемещена или удалена.
            //this.productTableAdapter.Fill(this.погребDataSet.InBasket);
            fillComboBox();
            //dataGridView1_admin_table.Columns[0].Visible = false;
        }
        

        private void sort_rows(DataGridView dgv)
        {
            dgv.Rows.Clear();
            string query = $"select P.ID_Name, P.Name, P.Year, L.Place, I.Component, C.Cap, C.Volume, T.Type_of_cons, P.Count, P.Recipe " +
                $"from [dbo].[Product] P " +
                $"join [dbo].[Location] L on  P.ID_Place = L.ID_Place " +
                $"join [dbo].[Ingredients] I on P.ID_Component = I.ID_Component " +
                $"join [dbo].[Container] C on P.ID_Container = C.ID_Container " +
                $"join [dbo].[Type_of_conservation] T on P.ID_Type = T.ID_Type " +
                $"where P.Name like '%{textBox1_admin_search.Text}%'";

            if (comboBox1_admin_type.Text != "Все типы")
            {
                query += $" and T.Type_of_cons = '{comboBox1_admin_type.Text}'";
            }
            if (comboBox2_admin_product.Text != "Все ингредиенты")
            {
                query += $" and I.Component = '{comboBox2_admin_product.Text}'";
            }

            SqlCommand command = new SqlCommand(query, pogreb.getConnection());
            pogreb.open_connect();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                ReadSingleRow(dgv, reader);
            }
            reader.Close();
        }

        private void createColumnsStat(DataGridView dgv)
        {
            dgv.Columns.Add("Component", "Ингредиент");
            dgv.Columns.Add("Volume", "Общий объем  в литрах");
            dgv.Columns.Add("Count", "Общее количество");
        }

        private void ReadSingleRowStat(DataGridView dgv, IDataRecord record)
        {
            dgv.Rows.Add(
                record.IsDBNull(0) ? "" : record.GetString(0),
                record.IsDBNull(1) ? 0 : record.GetDouble(1),
                record.IsDBNull(2) ? 0 : record.GetInt32(2));
        }

        private void RefreshDataGridStat (DataGridView dgv)
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
                ReadSingleRowStat(dgv, reader);
            }
            reader.Close();
        }

        private void createColumnsBasket(DataGridView dgv)
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
        private void RefreshDataGridBasket(DataGridView dgv)
        {
            dgv.Rows.Clear();
            string query = $"select R.login_u, B.ID_Name, B.CountB, P.Count, P.Name, P.Year, L.Place,  I.Component, C.Cap, C.Volume, T.Type_of_cons, P.Recipe " +
                $"from[dbo].[InBasket] B join[dbo].[Registration] R on B.id_user = R.id_user " +
                $"join[dbo].[Product] P on B.ID_Name = P.ID_Name " +
                $"join[dbo].[Location] L on P.ID_Place = L.ID_Place " +
                $"join[dbo].[Ingredients] I on P.ID_Component = I.ID_Component " +
                $"join[dbo].[Container] C on P.ID_Container = C.ID_Container " +
                $"join[dbo].[Type_of_conservation] T on P.ID_Type = T.ID_Type " +
                $"where P.Name like '%{textBox1_admin_search_basket.Text}%'";
            
            SqlCommand command = new SqlCommand(query, pogreb.getConnection());
            pogreb.open_connect();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                ReadSingleRowBasket(dgv, reader);
            }
            reader.Close();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Pogreb_Click(object sender, EventArgs e)
        {

        }

        private void tabPage4_basket_Click(object sender, EventArgs e)
        {

        }

        private void label1_pogreb_type_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            sort_rows(dataGridView1_admin_table);
        }

        private void label1_pogreb_product_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            sort_rows(dataGridView1_admin_table);
        }

        private void label1_pogreb_search_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_admin_search_TextChanged(object sender, EventArgs e)
        {
            sort_rows(dataGridView1_admin_table);
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void addInBasket() 
        {
            pogreb.open_connect();

            int index = dataGridView1_admin_table.CurrentCell.RowIndex;
            int id_name = Int32.Parse(dataGridView1_admin_table.Rows[index].Cells[0].Value.ToString());
            int Count = Int32.Parse(dataGridView1_admin_table.Rows[index].Cells[8].Value.ToString());

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
            RefreshDataGridBasket(dataGridView3);
        }
        private void button1_pogreb_add_Click(object sender, EventArgs e)
        {
            addInBasket();
        } 

        private void label2_add_Click(object sender, EventArgs e)
        {

        }

        private void label1_ID_name_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_ID_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_name_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_name_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_year_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_year_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_place_Click(object sender, EventArgs e)
        {

        }

        private void comboBox3_place_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label5_component_Click(object sender, EventArgs e)
        {

        }

        private void comboBox4_component_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label6_cap_Click(object sender, EventArgs e)
        {

        }

        private void comboBox5_cap_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label7_volume_Click(object sender, EventArgs e)
        {

        }

        private void comboBox6_volume_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label8_type_Click(object sender, EventArgs e)
        {

        }

        private void comboBox7_type_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label9_count_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_count_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_recipe_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_recipe_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_add_Click(object sender, EventArgs e)
        {
            pogreb.open_connect();

            bool flag = true;
            var id_name = textBox1_ID.Text;
            var name = comboBox1_name.Text;
            var year = comboBox2_year.Text;
            var place = comboBox3_place.Text;
            var component = comboBox4_component.Text;
            var cap = comboBox5_cap.Text;
            var volume = comboBox6_volume.Text;
            var type = comboBox7_type.Text;
            int count;
            var recipe = textBox3_recipe.Text;

            var volumeN = volume;
            if (volume.Length >= 3)
            {
               volumeN = volume.Remove(1, 1).Insert(1, '.'.ToString());
            }

            if (int.TryParse(textBox2_count.Text, out count))
            {
                var place_id = $"select ID_Place from dbo.Location where Place like '%{place}%'";
                var command = new SqlCommand(place_id, pogreb.getConnection());
                int placeID = 0;
                if (command.ExecuteScalar() is null)
                {
                    flag = false;
                    MessageBox.Show("Такого места хранения нет в базе данных!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    placeID = int.Parse(command.ExecuteScalar().ToString());
                }

                var component_id = $"select ID_Component from dbo.Ingredients where Component like '%{component}%'";
                var command1 = new SqlCommand(component_id, pogreb.getConnection());
                int componentID = 0;
                if (command1.ExecuteScalar() is null)
                {
                    flag = false;
                    MessageBox.Show("Такого продукта нет в базе данных!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    componentID = int.Parse(command1.ExecuteScalar().ToString());
                }

                var container_id = $"select ID_Container from dbo.Container where Cap like '%{cap}%' and Volume = Try_convert(float, '{volumeN}')"; 
                var command2 = new SqlCommand(container_id, pogreb.getConnection());
                int containerID = 0;
                if (command2.ExecuteScalar() is null)
                {
                    flag = false;
                    MessageBox.Show("Емкости такого типа нет в базе данных!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    containerID = int.Parse(command2.ExecuteScalar().ToString());
                }

                var type_id = $"select ID_Type from dbo.Type_of_conservation where Type_of_cons like '%{type}%'";
                var command3 = new SqlCommand(type_id, pogreb.getConnection());
                int typeID = 0;
                if (command3.ExecuteScalar() is null)
                {
                    flag = false;
                    MessageBox.Show("Такого типа консервации нет в базе данных!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else
                {
                    typeID = int.Parse(command3.ExecuteScalar().ToString());
                }

                var id_id = $"select ID_Name from dbo.Product where ID_Name like '%{id_name}%'";
                var command4 = new SqlCommand(id_id, pogreb.getConnection());
                if (command4.ExecuteScalar() is null && flag == true)
                {
                    var addProduct = $"insert into dbo.Product([ID_Name], [Name], [Year], [ID_Place], [ID_Component], [ID_Container], [ID_Type], [Count], [Recipe])" +
                        $"values ('{id_name}', '{name}', '{year}', '{placeID}', '{componentID}', '{containerID}', '{typeID}', '{count}', '{recipe}')";
                    var command_Product = new SqlCommand(addProduct, pogreb.getConnection());
                    command_Product.ExecuteNonQuery();

                    MessageBox.Show("Запись успешно добавлена!", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if (flag == false)
                    {
                        MessageBox.Show("Запись добавить не удалось!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        MessageBox.Show("Такой ID уже существует! Запись добавить не удалось!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }

            }
            else
            {
                MessageBox.Show("Поле 'Количество' должно иметь числовой формат! Запись добавить не удалось!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            pogreb.close_connect();
            RefreshDataGrid(dataGridView1_admin_table);
            fillComboBox();
            fillComboBoxSort();
        }

        private void label2_stat_product_Click(object sender, EventArgs e)
        {

        }

        private void label3_stat_type_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dellFromBase()
        {
            pogreb.open_connect();

            int index = dataGridView3.CurrentCell.RowIndex;
            int id_name = Int32.Parse(dataGridView3.Rows[index].Cells[1].Value.ToString());
            int CountB = Int32.Parse(dataGridView3.Rows[index].Cells[2].Value.ToString());

            var count_product = $"select Count from dbo.Product where ID_Name like '%{id_name}%'";
            var command = new SqlCommand(count_product, pogreb.getConnection());
            int CountP = int.Parse(command.ExecuteScalar().ToString());
            if (CountB == CountP)
            {
                var deleteQueryFromBasket = $"delete from dbo.InBasket where ID_Name = {id_name}";
                var commandDellFromBasket = new SqlCommand(deleteQueryFromBasket, pogreb.getConnection());
                commandDellFromBasket.ExecuteNonQuery();

                var deleteQueryFromProduct = $"delete from dbo.Product where ID_Name = {id_name}";
                var commandDellFromProduct = new SqlCommand(deleteQueryFromProduct, pogreb.getConnection());
                commandDellFromProduct.ExecuteNonQuery();

                MessageBox.Show("Позиция успешно удалена из погреба!", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                var deleteQueryFromBasket = $"delete from dbo.InBasket where ID_Name = {id_name}";
                var commandDellFromBasket = new SqlCommand(deleteQueryFromBasket, pogreb.getConnection());
                commandDellFromBasket.ExecuteNonQuery();

                var deleteQueryFromProduct = $"UPDATE dbo.Product SET Count = Count-{CountB} WHERE ID_Name={id_name}";
                var commandDellFromProduct = new SqlCommand(deleteQueryFromProduct, pogreb.getConnection());
                commandDellFromProduct.ExecuteNonQuery();

                MessageBox.Show("Позиция успешно изменена!", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            pogreb.close_connect();
            RefreshDataGrid(dataGridView1_admin_table);
            RefreshDataGridBasket(dataGridView3);
        }
        private void button1_admin_del_Click(object sender, EventArgs e)
        {
            dellFromBase();
        }

        private void returnOnShelf()
        {
            pogreb.open_connect();

            int index = dataGridView3.CurrentCell.RowIndex;
            int id_name = Int32.Parse(dataGridView3.Rows[index].Cells[1].Value.ToString());
            int Count = Int32.Parse(dataGridView3.Rows[index].Cells[2].Value.ToString());

            if(Count > 1)
            {
                var deleteQuery = $"UPDATE dbo.InBasket SET CountB = CountB-1 WHERE ID_Name={id_name}";
                var command = new SqlCommand(deleteQuery, pogreb.getConnection());
                command.ExecuteNonQuery();

                MessageBox.Show("Один экземпляр продукта успешно удален из корзины!", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if(Count == 1)
                {
                    var deleteQuery = $"delete from dbo.InBasket where ID_Name = {id_name}";
                    var command = new SqlCommand(deleteQuery, pogreb.getConnection());
                    command.ExecuteNonQuery();

                    MessageBox.Show("Позиция успешно удалена из корзины!", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            pogreb.close_connect();
            RefreshDataGridBasket(dataGridView3);
        }
        private void button2_admin_return_Click(object sender, EventArgs e)
        {
            returnOnShelf();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int index = dataGridView1_admin_table.CurrentCell.RowIndex;
            int id_name = Int32.Parse(dataGridView1_admin_table.Rows[index].Cells[0].Value.ToString());
            string name = dataGridView1_admin_table.Rows[index].Cells[1].Value.ToString();
            int year = Int32.Parse(dataGridView1_admin_table.Rows[index].Cells[2].Value.ToString());
            string place = dataGridView1_admin_table.Rows[index].Cells[3].Value.ToString();
            string component = dataGridView1_admin_table.Rows[index].Cells[4].Value.ToString();
            string cap = dataGridView1_admin_table.Rows[index].Cells[5].Value.ToString();
            float volume = float.Parse(dataGridView1_admin_table.Rows[index].Cells[6].Value.ToString());
            string type = dataGridView1_admin_table.Rows[index].Cells[7].Value.ToString();
            int count = Int32.Parse(dataGridView1_admin_table.Rows[index].Cells[8].Value.ToString());
            string recipe = dataGridView1_admin_table.Rows[index].Cells[9].Value.ToString();

            Change_product change_Product = new Change_product(id_name, name, year, place, component,
                cap, volume, type, count, recipe);
            this.Hide();
            change_Product.ShowDialog();

            RefreshDataGrid(dataGridView1_admin_table);
            fillComboBox();
            fillComboBoxSort();
            this.Show();
        }

        private void textBox1_admin_search_basket_TextChanged(object sender, EventArgs e)
        {
            RefreshDataGridBasket(dataGridView3);
        }
    }
}
