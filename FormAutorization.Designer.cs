
namespace Organization_of_storage
{
    partial class FormAutorization
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
            this.labelA2_registr = new System.Windows.Forms.Label();
            this.buttonA1_create = new System.Windows.Forms.Button();
            this.textBoxA2_password = new System.Windows.Forms.TextBox();
            this.textBoxA1_login = new System.Windows.Forms.TextBox();
            this.labelA4_password = new System.Windows.Forms.Label();
            this.labelA1_login = new System.Windows.Forms.Label();
            this.linkLabelA1 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // labelA2_registr
            // 
            this.labelA2_registr.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelA2_registr.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelA2_registr.ForeColor = System.Drawing.SystemColors.InfoText;
            this.labelA2_registr.Location = new System.Drawing.Point(99, 27);
            this.labelA2_registr.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelA2_registr.Name = "labelA2_registr";
            this.labelA2_registr.Size = new System.Drawing.Size(440, 58);
            this.labelA2_registr.TabIndex = 1;
            this.labelA2_registr.Text = "Авторизация";
            this.labelA2_registr.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelA2_registr.Click += new System.EventHandler(this.labelA2_registr_Click);
            // 
            // buttonA1_create
            // 
            this.buttonA1_create.AutoSize = true;
            this.buttonA1_create.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonA1_create.Location = new System.Drawing.Point(256, 238);
            this.buttonA1_create.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonA1_create.Name = "buttonA1_create";
            this.buttonA1_create.Size = new System.Drawing.Size(131, 34);
            this.buttonA1_create.TabIndex = 14;
            this.buttonA1_create.Text = "Войти";
            this.buttonA1_create.UseVisualStyleBackColor = false;
            this.buttonA1_create.Click += new System.EventHandler(this.buttonA1_create_Click);
            // 
            // textBoxA2_password
            // 
            this.textBoxA2_password.Location = new System.Drawing.Point(256, 182);
            this.textBoxA2_password.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxA2_password.Name = "textBoxA2_password";
            this.textBoxA2_password.Size = new System.Drawing.Size(197, 22);
            this.textBoxA2_password.TabIndex = 13;
            this.textBoxA2_password.TextChanged += new System.EventHandler(this.textBoxA2_password_TextChanged);
            // 
            // textBoxA1_login
            // 
            this.textBoxA1_login.Location = new System.Drawing.Point(256, 132);
            this.textBoxA1_login.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxA1_login.Name = "textBoxA1_login";
            this.textBoxA1_login.Size = new System.Drawing.Size(197, 22);
            this.textBoxA1_login.TabIndex = 12;
            this.textBoxA1_login.TextChanged += new System.EventHandler(this.textBoxA1_login_TextChanged);
            // 
            // labelA4_password
            // 
            this.labelA4_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelA4_password.Location = new System.Drawing.Point(124, 175);
            this.labelA4_password.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelA4_password.Name = "labelA4_password";
            this.labelA4_password.Size = new System.Drawing.Size(124, 37);
            this.labelA4_password.TabIndex = 11;
            this.labelA4_password.Text = "Пароль:";
            this.labelA4_password.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.labelA4_password.Click += new System.EventHandler(this.labelA4_password_Click);
            // 
            // labelA1_login
            // 
            this.labelA1_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelA1_login.Location = new System.Drawing.Point(117, 124);
            this.labelA1_login.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelA1_login.Name = "labelA1_login";
            this.labelA1_login.Size = new System.Drawing.Size(131, 37);
            this.labelA1_login.TabIndex = 10;
            this.labelA1_login.Text = "Логин:";
            this.labelA1_login.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.labelA1_login.Click += new System.EventHandler(this.labelA1_login_Click);
            // 
            // linkLabelA1
            // 
            this.linkLabelA1.AutoSize = true;
            this.linkLabelA1.Location = new System.Drawing.Point(239, 303);
            this.linkLabelA1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabelA1.Name = "linkLabelA1";
            this.linkLabelA1.Size = new System.Drawing.Size(163, 17);
            this.linkLabelA1.TabIndex = 17;
            this.linkLabelA1.TabStop = true;
            this.linkLabelA1.Text = "Создать новый аккаунт";
            this.linkLabelA1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelA1_LinkClicked);
            // 
            // FormAutorization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 352);
            this.Controls.Add(this.linkLabelA1);
            this.Controls.Add(this.buttonA1_create);
            this.Controls.Add(this.textBoxA2_password);
            this.Controls.Add(this.textBoxA1_login);
            this.Controls.Add(this.labelA4_password);
            this.Controls.Add(this.labelA1_login);
            this.Controls.Add(this.labelA2_registr);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormAutorization";
            this.Text = "FormAutorization";
            this.Load += new System.EventHandler(this.FormAutorization_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelA2_registr;
        private System.Windows.Forms.Button buttonA1_create;
        private System.Windows.Forms.TextBox textBoxA2_password;
        private System.Windows.Forms.TextBox textBoxA1_login;
        private System.Windows.Forms.Label labelA4_password;
        private System.Windows.Forms.Label labelA1_login;
        private System.Windows.Forms.LinkLabel linkLabelA1;
    }
}