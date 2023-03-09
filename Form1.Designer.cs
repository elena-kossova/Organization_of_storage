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
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.погребDataSet = new Organization_of_storage.ПогребDataSet();
            this.productTableAdapter = new Organization_of_storage.ПогребDataSetTableAdapters.ProductTableAdapter();
            this.tabControl1_admin_add = new System.Windows.Forms.TabControl();
            this.tabPage1_Pogreb = new System.Windows.Forms.TabPage();
            this.button1_change = new System.Windows.Forms.Button();
            this.button1_pogreb_add = new System.Windows.Forms.Button();
            this.textBox1_admin_search = new System.Windows.Forms.TextBox();
            this.label1_pogreb_search = new System.Windows.Forms.Label();
            this.comboBox2_admin_product = new System.Windows.Forms.ComboBox();
            this.ingredientsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.погребDataSet1 = new Organization_of_storage.ПогребDataSet1();
            this.label1_pogreb_product = new System.Windows.Forms.Label();
            this.comboBox1_admin_type = new System.Windows.Forms.ComboBox();
            this.typeofconservationBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.label1_pogreb_type = new System.Windows.Forms.Label();
            this.dataGridView1_admin_table = new System.Windows.Forms.DataGridView();
            this.tabPage2_add = new System.Windows.Forms.TabPage();
            this.button1_add = new System.Windows.Forms.Button();
            this.comboBox7_type = new System.Windows.Forms.ComboBox();
            this.typeofconservationBindingSource6 = new System.Windows.Forms.BindingSource(this.components);
            this.погребDataSet2 = new Organization_of_storage.ПогребDataSet2();
            this.comboBox6_volume = new System.Windows.Forms.ComboBox();
            this.containerBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox5_cap = new System.Windows.Forms.ComboBox();
            this.containerBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox4_component = new System.Windows.Forms.ComboBox();
            this.ingredientsBindingSource5 = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox3_place = new System.Windows.Forms.ComboBox();
            this.locationBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox2_year = new System.Windows.Forms.ComboBox();
            this.comboBox1_name = new System.Windows.Forms.ComboBox();
            this.textBox3_recipe = new System.Windows.Forms.TextBox();
            this.textBox2_count = new System.Windows.Forms.TextBox();
            this.textBox1_ID = new System.Windows.Forms.TextBox();
            this.label10_recipe = new System.Windows.Forms.Label();
            this.label9_count = new System.Windows.Forms.Label();
            this.label8_type = new System.Windows.Forms.Label();
            this.label7_volume = new System.Windows.Forms.Label();
            this.label6_cap = new System.Windows.Forms.Label();
            this.label5_component = new System.Windows.Forms.Label();
            this.label4_place = new System.Windows.Forms.Label();
            this.label3_year = new System.Windows.Forms.Label();
            this.label2_name = new System.Windows.Forms.Label();
            this.label1_ID_name = new System.Windows.Forms.Label();
            this.label2_add = new System.Windows.Forms.Label();
            this.tabPage3_stat = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.tabPage4_basket = new System.Windows.Forms.TabPage();
            this.label2_admin_basket = new System.Windows.Forms.Label();
            this.textBox1_admin_search_basket = new System.Windows.Forms.TextBox();
            this.button2_admin_return = new System.Windows.Forms.Button();
            this.button1_admin_del = new System.Windows.Forms.Button();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.typeofconservationBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.ingredientsBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.typeofconservationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.type_of_conservationTableAdapter = new Organization_of_storage.ПогребDataSet1TableAdapters.Type_of_conservationTableAdapter();
            this.typeofconservationBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.ingredientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ingredientsTableAdapter = new Organization_of_storage.ПогребDataSet1TableAdapters.IngredientsTableAdapter();
            this.ingredientsBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.typeofconservationBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.locationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.locationTableAdapter = new Organization_of_storage.ПогребDataSet2TableAdapters.LocationTableAdapter();
            this.ingredientsBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.ingredientsTableAdapter1 = new Organization_of_storage.ПогребDataSet2TableAdapters.IngredientsTableAdapter();
            this.containerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.containerTableAdapter = new Organization_of_storage.ПогребDataSet2TableAdapters.ContainerTableAdapter();
            this.containerBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.typeofconservationBindingSource5 = new System.Windows.Forms.BindingSource(this.components);
            this.type_of_conservationTableAdapter1 = new Organization_of_storage.ПогребDataSet2TableAdapters.Type_of_conservationTableAdapter();
            this.typeofconservationBindingSource7 = new System.Windows.Forms.BindingSource(this.components);
            this.ingredientsBindingSource6 = new System.Windows.Forms.BindingSource(this.components);
            this.typeofconservationBindingSource8 = new System.Windows.Forms.BindingSource(this.components);
            this.ingredientsBindingSource7 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.погребDataSet)).BeginInit();
            this.tabControl1_admin_add.SuspendLayout();
            this.tabPage1_Pogreb.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ingredientsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.погребDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeofconservationBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1_admin_table)).BeginInit();
            this.tabPage2_add.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.typeofconservationBindingSource6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.погребDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.containerBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.containerBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ingredientsBindingSource5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.locationBindingSource1)).BeginInit();
            this.tabPage3_stat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.tabPage4_basket.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeofconservationBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ingredientsBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeofconservationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeofconservationBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ingredientsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ingredientsBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeofconservationBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.locationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ingredientsBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.containerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.containerBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeofconservationBindingSource5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeofconservationBindingSource7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ingredientsBindingSource6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeofconservationBindingSource8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ingredientsBindingSource7)).BeginInit();
            this.SuspendLayout();
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataMember = "Product";
            this.productBindingSource.DataSource = this.погребDataSet;
            // 
            // погребDataSet
            // 
            this.погребDataSet.DataSetName = "ПогребDataSet";
            this.погребDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productTableAdapter
            // 
            this.productTableAdapter.ClearBeforeFill = true;
            // 
            // tabControl1_admin_add
            // 
            this.tabControl1_admin_add.Controls.Add(this.tabPage1_Pogreb);
            this.tabControl1_admin_add.Controls.Add(this.tabPage2_add);
            this.tabControl1_admin_add.Controls.Add(this.tabPage3_stat);
            this.tabControl1_admin_add.Controls.Add(this.tabPage4_basket);
            this.tabControl1_admin_add.Location = new System.Drawing.Point(-1, 2);
            this.tabControl1_admin_add.Name = "tabControl1_admin_add";
            this.tabControl1_admin_add.SelectedIndex = 0;
            this.tabControl1_admin_add.Size = new System.Drawing.Size(1145, 610);
            this.tabControl1_admin_add.TabIndex = 1;
            // 
            // tabPage1_Pogreb
            // 
            this.tabPage1_Pogreb.Controls.Add(this.button1_change);
            this.tabPage1_Pogreb.Controls.Add(this.button1_pogreb_add);
            this.tabPage1_Pogreb.Controls.Add(this.textBox1_admin_search);
            this.tabPage1_Pogreb.Controls.Add(this.label1_pogreb_search);
            this.tabPage1_Pogreb.Controls.Add(this.comboBox2_admin_product);
            this.tabPage1_Pogreb.Controls.Add(this.label1_pogreb_product);
            this.tabPage1_Pogreb.Controls.Add(this.comboBox1_admin_type);
            this.tabPage1_Pogreb.Controls.Add(this.label1_pogreb_type);
            this.tabPage1_Pogreb.Controls.Add(this.dataGridView1_admin_table);
            this.tabPage1_Pogreb.Location = new System.Drawing.Point(4, 25);
            this.tabPage1_Pogreb.Name = "tabPage1_Pogreb";
            this.tabPage1_Pogreb.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1_Pogreb.Size = new System.Drawing.Size(1137, 581);
            this.tabPage1_Pogreb.TabIndex = 0;
            this.tabPage1_Pogreb.Text = "Погреб";
            this.tabPage1_Pogreb.UseVisualStyleBackColor = true;
            this.tabPage1_Pogreb.Click += new System.EventHandler(this.tabPage1_Pogreb_Click);
            // 
            // button1_change
            // 
            this.button1_change.Location = new System.Drawing.Point(764, 544);
            this.button1_change.Name = "button1_change";
            this.button1_change.Size = new System.Drawing.Size(166, 31);
            this.button1_change.TabIndex = 9;
            this.button1_change.Text = "Изменить";
            this.button1_change.UseVisualStyleBackColor = true;
            this.button1_change.Click += new System.EventHandler(this.button1_Click);
            // 
            // button1_pogreb_add
            // 
            this.button1_pogreb_add.Location = new System.Drawing.Point(952, 544);
            this.button1_pogreb_add.Name = "button1_pogreb_add";
            this.button1_pogreb_add.Size = new System.Drawing.Size(166, 31);
            this.button1_pogreb_add.TabIndex = 8;
            this.button1_pogreb_add.Text = "Добавить в корзину";
            this.button1_pogreb_add.UseVisualStyleBackColor = true;
            this.button1_pogreb_add.Click += new System.EventHandler(this.button1_pogreb_add_Click);
            // 
            // textBox1_admin_search
            // 
            this.textBox1_admin_search.Location = new System.Drawing.Point(904, 32);
            this.textBox1_admin_search.Name = "textBox1_admin_search";
            this.textBox1_admin_search.Size = new System.Drawing.Size(214, 22);
            this.textBox1_admin_search.TabIndex = 7;
            this.textBox1_admin_search.TextChanged += new System.EventHandler(this.textBox1_admin_search_TextChanged);
            // 
            // label1_pogreb_search
            // 
            this.label1_pogreb_search.AutoSize = true;
            this.label1_pogreb_search.Location = new System.Drawing.Point(901, 12);
            this.label1_pogreb_search.Name = "label1_pogreb_search";
            this.label1_pogreb_search.Size = new System.Drawing.Size(136, 17);
            this.label1_pogreb_search.TabIndex = 6;
            this.label1_pogreb_search.Text = "Поиск по названию";
            this.label1_pogreb_search.Click += new System.EventHandler(this.label1_pogreb_search_Click);
            // 
            // comboBox2_admin_product
            // 
            this.comboBox2_admin_product.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.ingredientsBindingSource1, "Component", true));
            this.comboBox2_admin_product.FormattingEnabled = true;
            this.comboBox2_admin_product.Location = new System.Drawing.Point(212, 32);
            this.comboBox2_admin_product.Name = "comboBox2_admin_product";
            this.comboBox2_admin_product.Size = new System.Drawing.Size(148, 24);
            this.comboBox2_admin_product.TabIndex = 5;
            this.comboBox2_admin_product.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // ingredientsBindingSource1
            // 
            this.ingredientsBindingSource1.DataMember = "Ingredients";
            this.ingredientsBindingSource1.DataSource = this.погребDataSet1;
            // 
            // погребDataSet1
            // 
            this.погребDataSet1.DataSetName = "ПогребDataSet1";
            this.погребDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1_pogreb_product
            // 
            this.label1_pogreb_product.AutoSize = true;
            this.label1_pogreb_product.Location = new System.Drawing.Point(209, 12);
            this.label1_pogreb_product.Name = "label1_pogreb_product";
            this.label1_pogreb_product.Size = new System.Drawing.Size(86, 17);
            this.label1_pogreb_product.TabIndex = 4;
            this.label1_pogreb_product.Text = "Ингредиент";
            this.label1_pogreb_product.Click += new System.EventHandler(this.label1_pogreb_product_Click);
            // 
            // comboBox1_admin_type
            // 
            this.comboBox1_admin_type.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.typeofconservationBindingSource2, "Type_of_cons", true));
            this.comboBox1_admin_type.FormattingEnabled = true;
            this.comboBox1_admin_type.Location = new System.Drawing.Point(19, 32);
            this.comboBox1_admin_type.Name = "comboBox1_admin_type";
            this.comboBox1_admin_type.Size = new System.Drawing.Size(148, 24);
            this.comboBox1_admin_type.TabIndex = 3;
            this.comboBox1_admin_type.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // typeofconservationBindingSource2
            // 
            this.typeofconservationBindingSource2.DataMember = "Type_of_conservation";
            this.typeofconservationBindingSource2.DataSource = this.погребDataSet1;
            // 
            // label1_pogreb_type
            // 
            this.label1_pogreb_type.AutoSize = true;
            this.label1_pogreb_type.Location = new System.Drawing.Point(18, 12);
            this.label1_pogreb_type.Name = "label1_pogreb_type";
            this.label1_pogreb_type.Size = new System.Drawing.Size(122, 17);
            this.label1_pogreb_type.TabIndex = 2;
            this.label1_pogreb_type.Text = "Тип консервации";
            this.label1_pogreb_type.Click += new System.EventHandler(this.label1_pogreb_type_Click);
            // 
            // dataGridView1_admin_table
            // 
            this.dataGridView1_admin_table.AllowUserToAddRows = false;
            this.dataGridView1_admin_table.AllowUserToDeleteRows = false;
            this.dataGridView1_admin_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1_admin_table.Location = new System.Drawing.Point(0, 78);
            this.dataGridView1_admin_table.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1_admin_table.Name = "dataGridView1_admin_table";
            this.dataGridView1_admin_table.ReadOnly = true;
            this.dataGridView1_admin_table.RowHeadersWidth = 51;
            this.dataGridView1_admin_table.RowTemplate.Height = 24;
            this.dataGridView1_admin_table.Size = new System.Drawing.Size(1137, 457);
            this.dataGridView1_admin_table.TabIndex = 1;
            this.dataGridView1_admin_table.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // tabPage2_add
            // 
            this.tabPage2_add.Controls.Add(this.button1_add);
            this.tabPage2_add.Controls.Add(this.comboBox7_type);
            this.tabPage2_add.Controls.Add(this.comboBox6_volume);
            this.tabPage2_add.Controls.Add(this.comboBox5_cap);
            this.tabPage2_add.Controls.Add(this.comboBox4_component);
            this.tabPage2_add.Controls.Add(this.comboBox3_place);
            this.tabPage2_add.Controls.Add(this.comboBox2_year);
            this.tabPage2_add.Controls.Add(this.comboBox1_name);
            this.tabPage2_add.Controls.Add(this.textBox3_recipe);
            this.tabPage2_add.Controls.Add(this.textBox2_count);
            this.tabPage2_add.Controls.Add(this.textBox1_ID);
            this.tabPage2_add.Controls.Add(this.label10_recipe);
            this.tabPage2_add.Controls.Add(this.label9_count);
            this.tabPage2_add.Controls.Add(this.label8_type);
            this.tabPage2_add.Controls.Add(this.label7_volume);
            this.tabPage2_add.Controls.Add(this.label6_cap);
            this.tabPage2_add.Controls.Add(this.label5_component);
            this.tabPage2_add.Controls.Add(this.label4_place);
            this.tabPage2_add.Controls.Add(this.label3_year);
            this.tabPage2_add.Controls.Add(this.label2_name);
            this.tabPage2_add.Controls.Add(this.label1_ID_name);
            this.tabPage2_add.Controls.Add(this.label2_add);
            this.tabPage2_add.Location = new System.Drawing.Point(4, 25);
            this.tabPage2_add.Name = "tabPage2_add";
            this.tabPage2_add.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2_add.Size = new System.Drawing.Size(1137, 581);
            this.tabPage2_add.TabIndex = 1;
            this.tabPage2_add.Text = "Добавление";
            this.tabPage2_add.UseVisualStyleBackColor = true;
            this.tabPage2_add.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // button1_add
            // 
            this.button1_add.Location = new System.Drawing.Point(539, 529);
            this.button1_add.Name = "button1_add";
            this.button1_add.Size = new System.Drawing.Size(117, 33);
            this.button1_add.TabIndex = 21;
            this.button1_add.Text = "Добавить";
            this.button1_add.UseVisualStyleBackColor = true;
            this.button1_add.Click += new System.EventHandler(this.button1_add_Click);
            // 
            // comboBox7_type
            // 
            this.comboBox7_type.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.typeofconservationBindingSource6, "Type_of_cons", true));
            this.comboBox7_type.FormattingEnabled = true;
            this.comboBox7_type.Location = new System.Drawing.Point(454, 394);
            this.comboBox7_type.Name = "comboBox7_type";
            this.comboBox7_type.Size = new System.Drawing.Size(340, 24);
            this.comboBox7_type.TabIndex = 20;
            this.comboBox7_type.SelectedIndexChanged += new System.EventHandler(this.comboBox7_type_SelectedIndexChanged);
            // 
            // typeofconservationBindingSource6
            // 
            this.typeofconservationBindingSource6.DataMember = "Type_of_conservation";
            this.typeofconservationBindingSource6.DataSource = this.погребDataSet2;
            // 
            // погребDataSet2
            // 
            this.погребDataSet2.DataSetName = "ПогребDataSet2";
            this.погребDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBox6_volume
            // 
            this.comboBox6_volume.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.containerBindingSource3, "Volume", true));
            this.comboBox6_volume.FormattingEnabled = true;
            this.comboBox6_volume.Location = new System.Drawing.Point(454, 349);
            this.comboBox6_volume.Name = "comboBox6_volume";
            this.comboBox6_volume.Size = new System.Drawing.Size(340, 24);
            this.comboBox6_volume.TabIndex = 19;
            this.comboBox6_volume.SelectedIndexChanged += new System.EventHandler(this.comboBox6_volume_SelectedIndexChanged);
            // 
            // containerBindingSource3
            // 
            this.containerBindingSource3.DataMember = "Container";
            this.containerBindingSource3.DataSource = this.погребDataSet2;
            // 
            // comboBox5_cap
            // 
            this.comboBox5_cap.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.containerBindingSource1, "Cap", true));
            this.comboBox5_cap.FormattingEnabled = true;
            this.comboBox5_cap.Location = new System.Drawing.Point(454, 306);
            this.comboBox5_cap.Name = "comboBox5_cap";
            this.comboBox5_cap.Size = new System.Drawing.Size(340, 24);
            this.comboBox5_cap.TabIndex = 18;
            this.comboBox5_cap.SelectedIndexChanged += new System.EventHandler(this.comboBox5_cap_SelectedIndexChanged);
            // 
            // containerBindingSource1
            // 
            this.containerBindingSource1.DataMember = "Container";
            this.containerBindingSource1.DataSource = this.погребDataSet2;
            // 
            // comboBox4_component
            // 
            this.comboBox4_component.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.ingredientsBindingSource5, "Component", true));
            this.comboBox4_component.FormattingEnabled = true;
            this.comboBox4_component.Location = new System.Drawing.Point(454, 261);
            this.comboBox4_component.Name = "comboBox4_component";
            this.comboBox4_component.Size = new System.Drawing.Size(340, 24);
            this.comboBox4_component.TabIndex = 17;
            this.comboBox4_component.SelectedIndexChanged += new System.EventHandler(this.comboBox4_component_SelectedIndexChanged);
            // 
            // ingredientsBindingSource5
            // 
            this.ingredientsBindingSource5.DataMember = "Ingredients";
            this.ingredientsBindingSource5.DataSource = this.погребDataSet2;
            // 
            // comboBox3_place
            // 
            this.comboBox3_place.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.locationBindingSource1, "Place", true));
            this.comboBox3_place.FormattingEnabled = true;
            this.comboBox3_place.Location = new System.Drawing.Point(454, 217);
            this.comboBox3_place.Name = "comboBox3_place";
            this.comboBox3_place.Size = new System.Drawing.Size(340, 24);
            this.comboBox3_place.TabIndex = 16;
            this.comboBox3_place.SelectedIndexChanged += new System.EventHandler(this.comboBox3_place_SelectedIndexChanged);
            // 
            // locationBindingSource1
            // 
            this.locationBindingSource1.DataMember = "Location";
            this.locationBindingSource1.DataSource = this.погребDataSet2;
            // 
            // comboBox2_year
            // 
            this.comboBox2_year.FormattingEnabled = true;
            this.comboBox2_year.Location = new System.Drawing.Point(454, 172);
            this.comboBox2_year.Name = "comboBox2_year";
            this.comboBox2_year.Size = new System.Drawing.Size(340, 24);
            this.comboBox2_year.TabIndex = 15;
            this.comboBox2_year.SelectedIndexChanged += new System.EventHandler(this.comboBox2_year_SelectedIndexChanged);
            // 
            // comboBox1_name
            // 
            this.comboBox1_name.FormattingEnabled = true;
            this.comboBox1_name.Location = new System.Drawing.Point(454, 126);
            this.comboBox1_name.Name = "comboBox1_name";
            this.comboBox1_name.Size = new System.Drawing.Size(340, 24);
            this.comboBox1_name.TabIndex = 14;
            this.comboBox1_name.SelectedIndexChanged += new System.EventHandler(this.comboBox1_name_SelectedIndexChanged);
            // 
            // textBox3_recipe
            // 
            this.textBox3_recipe.Location = new System.Drawing.Point(454, 482);
            this.textBox3_recipe.Name = "textBox3_recipe";
            this.textBox3_recipe.Size = new System.Drawing.Size(340, 22);
            this.textBox3_recipe.TabIndex = 13;
            this.textBox3_recipe.TextChanged += new System.EventHandler(this.textBox3_recipe_TextChanged);
            // 
            // textBox2_count
            // 
            this.textBox2_count.Location = new System.Drawing.Point(454, 440);
            this.textBox2_count.Name = "textBox2_count";
            this.textBox2_count.Size = new System.Drawing.Size(340, 22);
            this.textBox2_count.TabIndex = 12;
            this.textBox2_count.TextChanged += new System.EventHandler(this.textBox2_count_TextChanged);
            // 
            // textBox1_ID
            // 
            this.textBox1_ID.Location = new System.Drawing.Point(454, 85);
            this.textBox1_ID.Name = "textBox1_ID";
            this.textBox1_ID.Size = new System.Drawing.Size(340, 22);
            this.textBox1_ID.TabIndex = 11;
            this.textBox1_ID.TextChanged += new System.EventHandler(this.textBox1_ID_TextChanged);
            // 
            // label10_recipe
            // 
            this.label10_recipe.AutoSize = true;
            this.label10_recipe.Location = new System.Drawing.Point(381, 485);
            this.label10_recipe.Name = "label10_recipe";
            this.label10_recipe.Size = new System.Drawing.Size(56, 17);
            this.label10_recipe.TabIndex = 10;
            this.label10_recipe.Text = "Рецепт";
            this.label10_recipe.Click += new System.EventHandler(this.label10_recipe_Click);
            // 
            // label9_count
            // 
            this.label9_count.AutoSize = true;
            this.label9_count.Location = new System.Drawing.Point(351, 443);
            this.label9_count.Name = "label9_count";
            this.label9_count.Size = new System.Drawing.Size(86, 17);
            this.label9_count.TabIndex = 9;
            this.label9_count.Text = "Количество";
            this.label9_count.Click += new System.EventHandler(this.label9_count_Click);
            // 
            // label8_type
            // 
            this.label8_type.AutoSize = true;
            this.label8_type.Location = new System.Drawing.Point(315, 397);
            this.label8_type.Name = "label8_type";
            this.label8_type.Size = new System.Drawing.Size(122, 17);
            this.label8_type.TabIndex = 8;
            this.label8_type.Text = "Тип консервации";
            this.label8_type.Click += new System.EventHandler(this.label8_type_Click);
            // 
            // label7_volume
            // 
            this.label7_volume.AutoSize = true;
            this.label7_volume.Location = new System.Drawing.Point(341, 352);
            this.label7_volume.Name = "label7_volume";
            this.label7_volume.Size = new System.Drawing.Size(96, 17);
            this.label7_volume.TabIndex = 7;
            this.label7_volume.Text = "Объем банки";
            this.label7_volume.Click += new System.EventHandler(this.label7_volume_Click);
            // 
            // label6_cap
            // 
            this.label6_cap.AutoSize = true;
            this.label6_cap.Location = new System.Drawing.Point(376, 309);
            this.label6_cap.Name = "label6_cap";
            this.label6_cap.Size = new System.Drawing.Size(61, 17);
            this.label6_cap.TabIndex = 6;
            this.label6_cap.Text = "Крышка";
            this.label6_cap.Click += new System.EventHandler(this.label6_cap_Click);
            // 
            // label5_component
            // 
            this.label5_component.AutoSize = true;
            this.label5_component.Location = new System.Drawing.Point(351, 264);
            this.label5_component.Name = "label5_component";
            this.label5_component.Size = new System.Drawing.Size(86, 17);
            this.label5_component.TabIndex = 5;
            this.label5_component.Text = "Ингредиент";
            this.label5_component.Click += new System.EventHandler(this.label5_component_Click);
            // 
            // label4_place
            // 
            this.label4_place.AutoSize = true;
            this.label4_place.Location = new System.Drawing.Point(332, 220);
            this.label4_place.Name = "label4_place";
            this.label4_place.Size = new System.Drawing.Size(105, 17);
            this.label4_place.TabIndex = 4;
            this.label4_place.Text = "Расположение";
            this.label4_place.Click += new System.EventHandler(this.label4_place_Click);
            // 
            // label3_year
            // 
            this.label3_year.AutoSize = true;
            this.label3_year.Location = new System.Drawing.Point(405, 175);
            this.label3_year.Name = "label3_year";
            this.label3_year.Size = new System.Drawing.Size(32, 17);
            this.label3_year.TabIndex = 3;
            this.label3_year.Text = "Год";
            this.label3_year.Click += new System.EventHandler(this.label3_year_Click);
            // 
            // label2_name
            // 
            this.label2_name.AutoSize = true;
            this.label2_name.Location = new System.Drawing.Point(365, 129);
            this.label2_name.Name = "label2_name";
            this.label2_name.Size = new System.Drawing.Size(72, 17);
            this.label2_name.TabIndex = 2;
            this.label2_name.Text = "Название";
            this.label2_name.Click += new System.EventHandler(this.label2_name_Click);
            // 
            // label1_ID_name
            // 
            this.label1_ID_name.AutoSize = true;
            this.label1_ID_name.Location = new System.Drawing.Point(350, 88);
            this.label1_ID_name.Name = "label1_ID_name";
            this.label1_ID_name.Size = new System.Drawing.Size(87, 17);
            this.label1_ID_name.TabIndex = 1;
            this.label1_ID_name.Text = "ID названия";
            this.label1_ID_name.Click += new System.EventHandler(this.label1_ID_name_Click);
            // 
            // label2_add
            // 
            this.label2_add.BackColor = System.Drawing.Color.YellowGreen;
            this.label2_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2_add.Location = new System.Drawing.Point(378, 12);
            this.label2_add.Name = "label2_add";
            this.label2_add.Size = new System.Drawing.Size(427, 49);
            this.label2_add.TabIndex = 0;
            this.label2_add.Text = "Добавление продукта";
            this.label2_add.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2_add.Click += new System.EventHandler(this.label2_add_Click);
            // 
            // tabPage3_stat
            // 
            this.tabPage3_stat.Controls.Add(this.label1);
            this.tabPage3_stat.Controls.Add(this.dataGridView2);
            this.tabPage3_stat.Location = new System.Drawing.Point(4, 25);
            this.tabPage3_stat.Name = "tabPage3_stat";
            this.tabPage3_stat.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3_stat.Size = new System.Drawing.Size(1137, 581);
            this.tabPage3_stat.TabIndex = 2;
            this.tabPage3_stat.Text = "Статистика";
            this.tabPage3_stat.UseVisualStyleBackColor = true;
            this.tabPage3_stat.Click += new System.EventHandler(this.tabPage3_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Salmon;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(272, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(614, 58);
            this.label1.TabIndex = 3;
            this.label1.Text = "Общий объем продукции по ингредиентам";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(228, 85);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(704, 457);
            this.dataGridView2.TabIndex = 2;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // tabPage4_basket
            // 
            this.tabPage4_basket.Controls.Add(this.label2_admin_basket);
            this.tabPage4_basket.Controls.Add(this.textBox1_admin_search_basket);
            this.tabPage4_basket.Controls.Add(this.button2_admin_return);
            this.tabPage4_basket.Controls.Add(this.button1_admin_del);
            this.tabPage4_basket.Controls.Add(this.dataGridView3);
            this.tabPage4_basket.Location = new System.Drawing.Point(4, 25);
            this.tabPage4_basket.Name = "tabPage4_basket";
            this.tabPage4_basket.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4_basket.Size = new System.Drawing.Size(1137, 581);
            this.tabPage4_basket.TabIndex = 3;
            this.tabPage4_basket.Text = "Корзина";
            this.tabPage4_basket.UseVisualStyleBackColor = true;
            this.tabPage4_basket.Click += new System.EventHandler(this.tabPage4_basket_Click);
            // 
            // label2_admin_basket
            // 
            this.label2_admin_basket.AutoSize = true;
            this.label2_admin_basket.Location = new System.Drawing.Point(840, 6);
            this.label2_admin_basket.Name = "label2_admin_basket";
            this.label2_admin_basket.Size = new System.Drawing.Size(136, 17);
            this.label2_admin_basket.TabIndex = 7;
            this.label2_admin_basket.Text = "Поиск по названию";
            // 
            // textBox1_admin_search_basket
            // 
            this.textBox1_admin_search_basket.Location = new System.Drawing.Point(843, 26);
            this.textBox1_admin_search_basket.Name = "textBox1_admin_search_basket";
            this.textBox1_admin_search_basket.Size = new System.Drawing.Size(265, 22);
            this.textBox1_admin_search_basket.TabIndex = 6;
            this.textBox1_admin_search_basket.TextChanged += new System.EventHandler(this.textBox1_admin_search_basket_TextChanged);
            // 
            // button2_admin_return
            // 
            this.button2_admin_return.Location = new System.Drawing.Point(942, 524);
            this.button2_admin_return.Name = "button2_admin_return";
            this.button2_admin_return.Size = new System.Drawing.Size(177, 45);
            this.button2_admin_return.TabIndex = 5;
            this.button2_admin_return.Text = "Вернуть на полку";
            this.button2_admin_return.UseVisualStyleBackColor = true;
            this.button2_admin_return.Click += new System.EventHandler(this.button2_admin_return_Click);
            // 
            // button1_admin_del
            // 
            this.button1_admin_del.Location = new System.Drawing.Point(737, 524);
            this.button1_admin_del.Name = "button1_admin_del";
            this.button1_admin_del.Size = new System.Drawing.Size(177, 45);
            this.button1_admin_del.TabIndex = 4;
            this.button1_admin_del.Text = "Удалить из базы";
            this.button1_admin_del.UseVisualStyleBackColor = true;
            this.button1_admin_del.Click += new System.EventHandler(this.button1_admin_del_Click);
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(0, 62);
            this.dataGridView3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.RowHeadersWidth = 51;
            this.dataGridView3.RowTemplate.Height = 24;
            this.dataGridView3.Size = new System.Drawing.Size(1137, 457);
            this.dataGridView3.TabIndex = 3;
            this.dataGridView3.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView3_CellContentClick);
            // 
            // typeofconservationBindingSource4
            // 
            this.typeofconservationBindingSource4.DataMember = "Type_of_conservation";
            this.typeofconservationBindingSource4.DataSource = this.погребDataSet1;
            // 
            // ingredientsBindingSource3
            // 
            this.ingredientsBindingSource3.DataMember = "Ingredients";
            this.ingredientsBindingSource3.DataSource = this.погребDataSet1;
            // 
            // typeofconservationBindingSource
            // 
            this.typeofconservationBindingSource.DataMember = "Type_of_conservation";
            this.typeofconservationBindingSource.DataSource = this.погребDataSet1;
            // 
            // type_of_conservationTableAdapter
            // 
            this.type_of_conservationTableAdapter.ClearBeforeFill = true;
            // 
            // typeofconservationBindingSource1
            // 
            this.typeofconservationBindingSource1.DataMember = "Type_of_conservation";
            this.typeofconservationBindingSource1.DataSource = this.погребDataSet1;
            // 
            // ingredientsBindingSource
            // 
            this.ingredientsBindingSource.DataMember = "Ingredients";
            this.ingredientsBindingSource.DataSource = this.погребDataSet1;
            // 
            // ingredientsTableAdapter
            // 
            this.ingredientsTableAdapter.ClearBeforeFill = true;
            // 
            // ingredientsBindingSource2
            // 
            this.ingredientsBindingSource2.DataMember = "Ingredients";
            this.ingredientsBindingSource2.DataSource = this.погребDataSet1;
            // 
            // typeofconservationBindingSource3
            // 
            this.typeofconservationBindingSource3.DataMember = "Type_of_conservation";
            this.typeofconservationBindingSource3.DataSource = this.погребDataSet1;
            // 
            // locationBindingSource
            // 
            this.locationBindingSource.DataMember = "Location";
            this.locationBindingSource.DataSource = this.погребDataSet2;
            // 
            // locationTableAdapter
            // 
            this.locationTableAdapter.ClearBeforeFill = true;
            // 
            // ingredientsBindingSource4
            // 
            this.ingredientsBindingSource4.DataMember = "Ingredients";
            this.ingredientsBindingSource4.DataSource = this.погребDataSet2;
            // 
            // ingredientsTableAdapter1
            // 
            this.ingredientsTableAdapter1.ClearBeforeFill = true;
            // 
            // containerBindingSource
            // 
            this.containerBindingSource.DataMember = "Container";
            this.containerBindingSource.DataSource = this.погребDataSet2;
            // 
            // containerTableAdapter
            // 
            this.containerTableAdapter.ClearBeforeFill = true;
            // 
            // containerBindingSource2
            // 
            this.containerBindingSource2.DataMember = "Container";
            this.containerBindingSource2.DataSource = this.погребDataSet2;
            // 
            // typeofconservationBindingSource5
            // 
            this.typeofconservationBindingSource5.DataMember = "Type_of_conservation";
            this.typeofconservationBindingSource5.DataSource = this.погребDataSet2;
            // 
            // type_of_conservationTableAdapter1
            // 
            this.type_of_conservationTableAdapter1.ClearBeforeFill = true;
            // 
            // typeofconservationBindingSource7
            // 
            this.typeofconservationBindingSource7.DataMember = "Type_of_conservation";
            this.typeofconservationBindingSource7.DataSource = this.погребDataSet2;
            // 
            // ingredientsBindingSource6
            // 
            this.ingredientsBindingSource6.DataMember = "Ingredients";
            this.ingredientsBindingSource6.DataSource = this.погребDataSet2;
            // 
            // typeofconservationBindingSource8
            // 
            this.typeofconservationBindingSource8.DataMember = "Type_of_conservation";
            this.typeofconservationBindingSource8.DataSource = this.погребDataSet2;
            // 
            // ingredientsBindingSource7
            // 
            this.ingredientsBindingSource7.DataMember = "Ingredients";
            this.ingredientsBindingSource7.DataSource = this.погребDataSet2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1156, 610);
            this.Controls.Add(this.tabControl1_admin_add);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.погребDataSet)).EndInit();
            this.tabControl1_admin_add.ResumeLayout(false);
            this.tabPage1_Pogreb.ResumeLayout(false);
            this.tabPage1_Pogreb.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ingredientsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.погребDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeofconservationBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1_admin_table)).EndInit();
            this.tabPage2_add.ResumeLayout(false);
            this.tabPage2_add.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.typeofconservationBindingSource6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.погребDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.containerBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.containerBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ingredientsBindingSource5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.locationBindingSource1)).EndInit();
            this.tabPage3_stat.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.tabPage4_basket.ResumeLayout(false);
            this.tabPage4_basket.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeofconservationBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ingredientsBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeofconservationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeofconservationBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ingredientsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ingredientsBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeofconservationBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.locationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ingredientsBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.containerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.containerBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeofconservationBindingSource5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeofconservationBindingSource7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ingredientsBindingSource6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeofconservationBindingSource8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ingredientsBindingSource7)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private ПогребDataSet погребDataSet;
        private System.Windows.Forms.BindingSource productBindingSource;
        private ПогребDataSetTableAdapters.ProductTableAdapter productTableAdapter;
        private System.Windows.Forms.TabControl tabControl1_admin_add;
        private System.Windows.Forms.TabPage tabPage1_Pogreb;
        private System.Windows.Forms.TabPage tabPage2_add;
        private System.Windows.Forms.DataGridView dataGridView1_admin_table;
        private System.Windows.Forms.TabPage tabPage3_stat;
        private System.Windows.Forms.TabPage tabPage4_basket;
        private System.Windows.Forms.Label label2_add;
        private System.Windows.Forms.Label label1_ID_name;
        private System.Windows.Forms.Label label10_recipe;
        private System.Windows.Forms.Label label9_count;
        private System.Windows.Forms.Label label8_type;
        private System.Windows.Forms.Label label7_volume;
        private System.Windows.Forms.Label label6_cap;
        private System.Windows.Forms.Label label5_component;
        private System.Windows.Forms.Label label4_place;
        private System.Windows.Forms.Label label3_year;
        private System.Windows.Forms.Label label2_name;
        private System.Windows.Forms.TextBox textBox1_ID;
        private System.Windows.Forms.ComboBox comboBox7_type;
        private System.Windows.Forms.ComboBox comboBox6_volume;
        private System.Windows.Forms.ComboBox comboBox5_cap;
        private System.Windows.Forms.ComboBox comboBox4_component;
        private System.Windows.Forms.ComboBox comboBox3_place;
        private System.Windows.Forms.ComboBox comboBox2_year;
        private System.Windows.Forms.ComboBox comboBox1_name;
        private System.Windows.Forms.TextBox textBox3_recipe;
        private System.Windows.Forms.TextBox textBox2_count;
        private System.Windows.Forms.Button button1_pogreb_add;
        private System.Windows.Forms.TextBox textBox1_admin_search;
        private System.Windows.Forms.Label label1_pogreb_search;
        private System.Windows.Forms.ComboBox comboBox2_admin_product;
        private System.Windows.Forms.Label label1_pogreb_product;
        private System.Windows.Forms.ComboBox comboBox1_admin_type;
        private System.Windows.Forms.Label label1_pogreb_type;
        private System.Windows.Forms.Button button1_add;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button button2_admin_return;
        private System.Windows.Forms.Button button1_admin_del;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Button button1_change;
        private ПогребDataSet1 погребDataSet1;
        private BindingSource typeofconservationBindingSource;
        private ПогребDataSet1TableAdapters.Type_of_conservationTableAdapter type_of_conservationTableAdapter;
        private BindingSource typeofconservationBindingSource2;
        private BindingSource typeofconservationBindingSource1;
        private BindingSource ingredientsBindingSource;
        private ПогребDataSet1TableAdapters.IngredientsTableAdapter ingredientsTableAdapter;
        private BindingSource ingredientsBindingSource1;
        private BindingSource typeofconservationBindingSource4;
        private BindingSource typeofconservationBindingSource3;
        private BindingSource ingredientsBindingSource3;
        private BindingSource ingredientsBindingSource2;
        private ПогребDataSet2 погребDataSet2;
        private BindingSource locationBindingSource;
        private ПогребDataSet2TableAdapters.LocationTableAdapter locationTableAdapter;
        private BindingSource locationBindingSource1;
        private BindingSource ingredientsBindingSource4;
        private ПогребDataSet2TableAdapters.IngredientsTableAdapter ingredientsTableAdapter1;
        private BindingSource ingredientsBindingSource5;
        private BindingSource containerBindingSource;
        private ПогребDataSet2TableAdapters.ContainerTableAdapter containerTableAdapter;
        private BindingSource containerBindingSource3;
        private BindingSource containerBindingSource2;
        private BindingSource containerBindingSource1;
        private BindingSource typeofconservationBindingSource5;
        private ПогребDataSet2TableAdapters.Type_of_conservationTableAdapter type_of_conservationTableAdapter1;
        private BindingSource typeofconservationBindingSource6;
        private BindingSource typeofconservationBindingSource7;
        private BindingSource ingredientsBindingSource6;
        private BindingSource typeofconservationBindingSource8;
        private BindingSource ingredientsBindingSource7;
        private Label label1;
        private Label label2_admin_basket;
        private System.Windows.Forms.TextBox textBox1_admin_search_basket;
    }
}

