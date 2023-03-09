
namespace Organization_of_storage
{
    partial class FormRegistration
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2_registr = new System.Windows.Forms.Label();
            this.label1_login = new System.Windows.Forms.Label();
            this.label4_password = new System.Windows.Forms.Label();
            this.textBox1_login = new System.Windows.Forms.TextBox();
            this.textBox2_password = new System.Windows.Forms.TextBox();
            this.button1_create = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2_registr
            // 
            this.label2_registr.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2_registr.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2_registr.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label2_registr.Location = new System.Drawing.Point(76, 23);
            this.label2_registr.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2_registr.Name = "label2_registr";
            this.label2_registr.Size = new System.Drawing.Size(440, 58);
            this.label2_registr.TabIndex = 0;
            this.label2_registr.Text = "Регистрация";
            this.label2_registr.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1_login
            // 
            this.label1_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1_login.Location = new System.Drawing.Point(95, 132);
            this.label1_login.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1_login.Name = "label1_login";
            this.label1_login.Size = new System.Drawing.Size(131, 37);
            this.label1_login.TabIndex = 1;
            this.label1_login.Text = "Логин:";
            this.label1_login.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.label1_login.Click += new System.EventHandler(this.label1_Click);
            // 
            // label4_password
            // 
            this.label4_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4_password.Location = new System.Drawing.Point(101, 191);
            this.label4_password.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4_password.Name = "label4_password";
            this.label4_password.Size = new System.Drawing.Size(124, 37);
            this.label4_password.TabIndex = 3;
            this.label4_password.Text = "Пароль:";
            this.label4_password.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.label4_password.Click += new System.EventHandler(this.label4_Click);
            // 
            // textBox1_login
            // 
            this.textBox1_login.Location = new System.Drawing.Point(233, 139);
            this.textBox1_login.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1_login.Name = "textBox1_login";
            this.textBox1_login.Size = new System.Drawing.Size(197, 22);
            this.textBox1_login.TabIndex = 4;
            // 
            // textBox2_password
            // 
            this.textBox2_password.Location = new System.Drawing.Point(233, 198);
            this.textBox2_password.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2_password.Name = "textBox2_password";
            this.textBox2_password.Size = new System.Drawing.Size(197, 22);
            this.textBox2_password.TabIndex = 5;
            // 
            // button1_create
            // 
            this.button1_create.AutoSize = true;
            this.button1_create.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1_create.Location = new System.Drawing.Point(233, 247);
            this.button1_create.Margin = new System.Windows.Forms.Padding(4);
            this.button1_create.Name = "button1_create";
            this.button1_create.Size = new System.Drawing.Size(131, 34);
            this.button1_create.TabIndex = 6;
            this.button1_create.Text = "Создать";
            this.button1_create.UseVisualStyleBackColor = false;
            this.button1_create.Click += new System.EventHandler(this.button1_create_Click);
            // 
            // FormRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 318);
            this.Controls.Add(this.button1_create);
            this.Controls.Add(this.textBox2_password);
            this.Controls.Add(this.textBox1_login);
            this.Controls.Add(this.label4_password);
            this.Controls.Add(this.label1_login);
            this.Controls.Add(this.label2_registr);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormRegistration";
            this.Text = "FormRegistration";
            this.Load += new System.EventHandler(this.FormRegistration_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2_registr;
        private System.Windows.Forms.Label label1_login;
        private System.Windows.Forms.Label label4_password;
        private System.Windows.Forms.TextBox textBox1_login;
        private System.Windows.Forms.TextBox textBox2_password;
        private System.Windows.Forms.Button button1_create;
    }
}