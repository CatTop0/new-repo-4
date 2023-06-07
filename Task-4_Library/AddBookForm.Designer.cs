namespace Task_4_Library
{
    partial class AddBookForm
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
            this.Close = new System.Windows.Forms.Label();
            this.RegLabel = new System.Windows.Forms.Label();
            this.NameField = new System.Windows.Forms.TextBox();
            this.BookNameLabel = new System.Windows.Forms.Label();
            this.AuthorLabel = new System.Windows.Forms.Label();
            this.AuthorField = new System.Windows.Forms.TextBox();
            this.InventoryNumber = new System.Windows.Forms.Label();
            this.NumberField = new System.Windows.Forms.TextBox();
            this.Save = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Close
            // 
            this.Close.AutoSize = true;
            this.Close.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Close.Location = new System.Drawing.Point(238, 9);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(20, 22);
            this.Close.TabIndex = 55;
            this.Close.Text = "X";
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // RegLabel
            // 
            this.RegLabel.AutoSize = true;
            this.RegLabel.BackColor = System.Drawing.Color.Transparent;
            this.RegLabel.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RegLabel.ForeColor = System.Drawing.Color.Black;
            this.RegLabel.Location = new System.Drawing.Point(23, 40);
            this.RegLabel.Name = "RegLabel";
            this.RegLabel.Size = new System.Drawing.Size(223, 32);
            this.RegLabel.TabIndex = 50;
            this.RegLabel.Text = "Добавить книгу";
            // 
            // NameField
            // 
            this.NameField.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameField.Location = new System.Drawing.Point(13, 117);
            this.NameField.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.NameField.Name = "NameField";
            this.NameField.Size = new System.Drawing.Size(243, 29);
            this.NameField.TabIndex = 57;
            // 
            // BookNameLabel
            // 
            this.BookNameLabel.AutoSize = true;
            this.BookNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.BookNameLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BookNameLabel.ForeColor = System.Drawing.Color.Black;
            this.BookNameLabel.Location = new System.Drawing.Point(13, 95);
            this.BookNameLabel.Name = "BookNameLabel";
            this.BookNameLabel.Size = new System.Drawing.Size(125, 19);
            this.BookNameLabel.TabIndex = 51;
            this.BookNameLabel.Text = "Название книги";
            // 
            // AuthorLabel
            // 
            this.AuthorLabel.AutoSize = true;
            this.AuthorLabel.BackColor = System.Drawing.Color.Transparent;
            this.AuthorLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AuthorLabel.ForeColor = System.Drawing.Color.Black;
            this.AuthorLabel.Location = new System.Drawing.Point(13, 155);
            this.AuthorLabel.Name = "AuthorLabel";
            this.AuthorLabel.Size = new System.Drawing.Size(100, 19);
            this.AuthorLabel.TabIndex = 58;
            this.AuthorLabel.Text = "Автор книги";
            // 
            // AuthorField
            // 
            this.AuthorField.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AuthorField.Location = new System.Drawing.Point(13, 177);
            this.AuthorField.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.AuthorField.Name = "AuthorField";
            this.AuthorField.Size = new System.Drawing.Size(243, 29);
            this.AuthorField.TabIndex = 59;
            // 
            // InventoryNumber
            // 
            this.InventoryNumber.AutoSize = true;
            this.InventoryNumber.BackColor = System.Drawing.Color.Transparent;
            this.InventoryNumber.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InventoryNumber.ForeColor = System.Drawing.Color.Black;
            this.InventoryNumber.Location = new System.Drawing.Point(13, 217);
            this.InventoryNumber.Name = "InventoryNumber";
            this.InventoryNumber.Size = new System.Drawing.Size(159, 19);
            this.InventoryNumber.TabIndex = 60;
            this.InventoryNumber.Text = "Инвентарный номер";
            // 
            // NumberField
            // 
            this.NumberField.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NumberField.Location = new System.Drawing.Point(13, 239);
            this.NumberField.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.NumberField.Name = "NumberField";
            this.NumberField.Size = new System.Drawing.Size(243, 29);
            this.NumberField.TabIndex = 61;

            // 
            // Save
            // 
            this.Save.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Save.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Save.Location = new System.Drawing.Point(13, 292);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(140, 29);
            this.Save.TabIndex = 62;
            this.Save.Text = "Сохранить данные";
            this.Save.UseVisualStyleBackColor = false;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Cancel
            // 
            this.Cancel.BackColor = System.Drawing.Color.Transparent;
            this.Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cancel.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Cancel.Location = new System.Drawing.Point(172, 292);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(84, 29);
            this.Cancel.TabIndex = 63;
            this.Cancel.Text = "Отмена";
            this.Cancel.UseVisualStyleBackColor = false;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // AddBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(270, 342);
            this.Controls.Add(this.RegLabel);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.InventoryNumber);
            this.Controls.Add(this.NumberField);
            this.Controls.Add(this.AuthorLabel);
            this.Controls.Add(this.AuthorField);
            this.Controls.Add(this.BookNameLabel);
            this.Controls.Add(this.NameField);
            this.Controls.Add(this.Close);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddBookForm";
            this.Text = "AddBookForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Close;
        private System.Windows.Forms.Label RegLabel;
        private System.Windows.Forms.TextBox NameField;
        private System.Windows.Forms.Label BookNameLabel;
        private System.Windows.Forms.Label AuthorLabel;
        private System.Windows.Forms.TextBox AuthorField;
        private System.Windows.Forms.Label InventoryNumber;
        private System.Windows.Forms.TextBox NumberField;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Button Cancel;
    }
}