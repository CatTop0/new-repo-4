﻿namespace Task_4_Library
{
    partial class LoginForm
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
            this.LoginField = new System.Windows.Forms.TextBox();
            this.PasswordField = new System.Windows.Forms.TextBox();
            this.LogInBtn = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Label();
            this.RegLabel = new System.Windows.Forms.Label();
            this.guestAuth = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LoginField
            // 
            this.LoginField.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoginField.Location = new System.Drawing.Point(41, 96);
            this.LoginField.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.LoginField.Name = "LoginField";
            this.LoginField.Size = new System.Drawing.Size(200, 26);
            this.LoginField.TabIndex = 0;
            this.LoginField.Enter += new System.EventHandler(this.LoginField_Enter);
            this.LoginField.Leave += new System.EventHandler(this.LoginField_Leave);
            // 
            // PasswordField
            // 
            this.PasswordField.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PasswordField.Location = new System.Drawing.Point(41, 142);
            this.PasswordField.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.PasswordField.Name = "PasswordField";
            this.PasswordField.Size = new System.Drawing.Size(200, 26);
            this.PasswordField.TabIndex = 1;
            this.PasswordField.Text = "Пароль";
            this.PasswordField.UseSystemPasswordChar = true;
            this.PasswordField.Enter += new System.EventHandler(this.PasswordField_Enter);
            this.PasswordField.Leave += new System.EventHandler(this.PasswordField_Leave);
            // 
            // LogInBtn
            // 
            this.LogInBtn.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.LogInBtn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LogInBtn.Location = new System.Drawing.Point(83, 198);
            this.LogInBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.LogInBtn.Name = "LogInBtn";
            this.LogInBtn.Size = new System.Drawing.Size(115, 35);
            this.LogInBtn.TabIndex = 2;
            this.LogInBtn.Text = "ВОЙТИ";
            this.LogInBtn.UseVisualStyleBackColor = false;
            this.LogInBtn.Click += new System.EventHandler(this.EntryButton_Click);
            // 
            // Exit
            // 
            this.Exit.AutoSize = true;
            this.Exit.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Exit.Location = new System.Drawing.Point(244, 9);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(20, 22);
            this.Exit.TabIndex = 55;
            this.Exit.Text = "X";
            this.Exit.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // RegLabel
            // 
            this.RegLabel.AutoSize = true;
            this.RegLabel.BackColor = System.Drawing.Color.Transparent;
            this.RegLabel.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RegLabel.ForeColor = System.Drawing.Color.Black;
            this.RegLabel.Location = new System.Drawing.Point(38, 31);
            this.RegLabel.Name = "RegLabel";
            this.RegLabel.Size = new System.Drawing.Size(203, 36);
            this.RegLabel.TabIndex = 56;
            this.RegLabel.Text = "Авторизация";
            // 
            // guestAuth
            // 
            this.guestAuth.AutoSize = true;
            this.guestAuth.BackColor = System.Drawing.Color.Transparent;
            this.guestAuth.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.guestAuth.ForeColor = System.Drawing.Color.Black;
            this.guestAuth.Location = new System.Drawing.Point(75, 244);
            this.guestAuth.Name = "guestAuth";
            this.guestAuth.Size = new System.Drawing.Size(130, 19);
            this.guestAuth.TabIndex = 57;
            this.guestAuth.Text = "Войти как гость";
            this.guestAuth.Click += new System.EventHandler(this.guestAuth_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(276, 285);
            this.Controls.Add(this.guestAuth);
            this.Controls.Add(this.RegLabel);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.LogInBtn);
            this.Controls.Add(this.PasswordField);
            this.Controls.Add(this.LoginField);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "LoginForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox LoginField;
        private System.Windows.Forms.TextBox PasswordField;
        private System.Windows.Forms.Button LogInBtn;
        private System.Windows.Forms.Label Exit;
        private System.Windows.Forms.Label RegLabel;
        private System.Windows.Forms.Label guestAuth;
    }
}

