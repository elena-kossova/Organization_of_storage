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
    public partial class Change_product : Form
    {
        int program_id;
        Pogreb pogreb = new Pogreb();

        private string[] getListStr(string query)
        {
            var list = new List<string>();
            using(var command = new SqlCommand(query, pogreb.getConnection()))
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

            comboBox1.Items.Clear();
            comboBox2.Items.Clear();
            comboBox3.Items.Clear();
            comboBox4.Items.Clear();
            comboBox5.Items.Clear();
            comboBox6.Items.Clear();
            comboBox7.Items.Clear();

            var queryName = $"select distinct Name from dbo.Product";
            var queryYear = $"select distinct Year from dbo.Product where Year<>'' and Year is not NULL";
            var queryPlace = $"select distinct Place from dbo.Location";
            var queryComponent = $"select distinct Component from dbo.Ingredients";
            var queryCap = $"select distinct Cap from dbo.Container";
            var queryVolume = $"select distinct Volume from dbo.Container";
            var queryType = $"select distinct Type_of_cons from Type_of_conservation";

            comboBox1.Items.AddRange(getListStr(queryName));
            comboBox2.Items.AddRange(getListInt(queryYear));
            comboBox3.Items.AddRange(getListStr(queryPlace));
            comboBox4.Items.AddRange(getListStr(queryComponent));
            comboBox5.Items.AddRange(getListStr(queryCap));
            comboBox6.Items.AddRange(getListDouble(queryVolume));
            comboBox7.Items.AddRange(getListStr(queryType));

            pogreb.close_connect();
        }
        
        public Change_product(int id_name, string name, int year, string place, string component, string cap, float volume, string type, int count, string recipe)
        {
            this.program_id = id_name;
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;

            textBox3.Text = id_name.ToString();
            comboBox1.Text = name;
            comboBox2.Text = year.ToString();
            comboBox3.Text = place;
            comboBox4.Text = component;
            comboBox5.Text = cap;
            comboBox6.Text = volume.ToString();
            comboBox7.Text = type;
            textBox1.Text = count.ToString();
            textBox2.Text = recipe;

        }

        private void Change_product_Load (object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "погребDataSet2.Container". При необходимости она может быть перемещена или удалена.
            this.containerTableAdapter.Fill(this.погребDataSet2.Container);
            fillComboBox();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_ID_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_year_Click(object sender, EventArgs e)
        {

        }

        private void label1_place_Click(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_ingredient_Click(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_cap_Click(object sender, EventArgs e)
        {

        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_volume_Click(object sender, EventArgs e)
        {

        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_type_of_Click(object sender, EventArgs e)
        {

        }

        private void comboBox7_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_count_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_recipe_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_add_Click(object sender, EventArgs e)
        {
            pogreb.open_connect();
        }

        private void button1_change_Click(object sender, EventArgs e)
        {
            
            pogreb.open_connect();

            bool flag = true;
            var id_name = textBox3.Text;
            var id = id_name;
            var name = comboBox1.Text;
            var year = comboBox2.Text;
            var place = comboBox3.Text;
            var component = comboBox4.Text;
            var cap = comboBox5.Text;
            var volume = comboBox6.Text;
            var type = comboBox7.Text;
            int count;
            var recipe = textBox2.Text;

            var volumeN = volume;
            if (volume.Length >= 3)
            {
                volumeN = volume.Remove(1, 1).Insert(1, '.'.ToString());
            }

            if (int.TryParse(textBox1.Text, out count))
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
                
                if(flag == false)
                {
                    MessageBox.Show("Запись изменить не удалось!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if(id == id_name)
                    {
                        var addProduct = $"update dbo.Product set [ID_Name]='{id_name}', [Name]='{name}', [Year]='{year}', [ID_Place]='{placeID}', " +
                        $"[ID_Component]='{componentID}', [ID_Container]='{containerID}', [ID_Type]='{typeID}', [Count]='{count}', [Recipe]='{recipe}'" +
                        $"where ID_Name = '{id_name}'";
                        var command_Product = new SqlCommand(addProduct, pogreb.getConnection());
                        command_Product.ExecuteNonQuery();

                        MessageBox.Show("Запись успешно изменена!", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Запись изменить не удалось!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            else
            {
                MessageBox.Show("Поле 'Количество' должно иметь числовой формат!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            pogreb.close_connect();
            fillComboBox();
            
        }

        private void Change_product_Load_1(object sender, EventArgs e)
        {
            
        }

        private void listBox1_volume_change_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
