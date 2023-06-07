namespace Task_4_Library
{
    partial class BookListForm
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
            this.Header = new System.Windows.Forms.Panel();
            this.RegLabel = new System.Windows.Forms.Label();
            this.FullName = new System.Windows.Forms.Label();
            this.Close = new System.Windows.Forms.Label();
            this.LogInBtn = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.sort = new System.Windows.Forms.ComboBox();
            this.addBtn = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.RightBtn = new System.Windows.Forms.Label();
            this.leftBtn = new System.Windows.Forms.Label();
            this.Header.SuspendLayout();
            this.SuspendLayout();
            // 
            // Header
            // 
            this.Header.BackColor = System.Drawing.SystemColors.HighlightText;
            this.Header.Controls.Add(this.RegLabel);
            this.Header.Location = new System.Drawing.Point(12, 30);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(661, 50);
            this.Header.TabIndex = 0;
            // 
            // RegLabel
            // 
            this.RegLabel.AutoSize = true;
            this.RegLabel.BackColor = System.Drawing.Color.Transparent;
            this.RegLabel.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RegLabel.ForeColor = System.Drawing.Color.Black;
            this.RegLabel.Location = new System.Drawing.Point(3, 8);
            this.RegLabel.Name = "RegLabel";
            this.RegLabel.Size = new System.Drawing.Size(207, 36);
            this.RegLabel.TabIndex = 50;
            this.RegLabel.Text = "Список книг ";
            // 
            // FullName
            // 
            this.FullName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.FullName.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FullName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FullName.Location = new System.Drawing.Point(426, 88);
            this.FullName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.FullName.Name = "FullName";
            this.FullName.Size = new System.Drawing.Size(156, 21);
            this.FullName.TabIndex = 51;
            this.FullName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Close
            // 
            this.Close.AutoSize = true;
            this.Close.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Close.Location = new System.Drawing.Point(653, 5);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(20, 22);
            this.Close.TabIndex = 54;
            this.Close.Text = "X";
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // LogInBtn
            // 
            this.LogInBtn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.LogInBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogInBtn.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LogInBtn.Location = new System.Drawing.Point(587, 85);
            this.LogInBtn.Name = "LogInBtn";
            this.LogInBtn.Size = new System.Drawing.Size(84, 29);
            this.LogInBtn.TabIndex = 55;
            this.LogInBtn.Text = "Выйти";
            this.LogInBtn.UseVisualStyleBackColor = false;
            this.LogInBtn.Click += new System.EventHandler(this.LogInBtn_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 118);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.58678F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.41322F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 83F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(659, 244);
            this.tableLayoutPanel1.TabIndex = 55;
            // 
            // sort
            // 
            this.sort.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.sort.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sort.ForeColor = System.Drawing.SystemColors.WindowText;
            this.sort.FormattingEnabled = true;
            this.sort.Location = new System.Drawing.Point(12, 90);
            this.sort.Margin = new System.Windows.Forms.Padding(2);
            this.sort.Name = "sort";
            this.sort.Size = new System.Drawing.Size(158, 22);
            this.sort.TabIndex = 56;
            this.sort.SelectedIndexChanged += new System.EventHandler(this.sort_SelectedIndexChanged);
            // 
            // addBtn
            // 
            this.addBtn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.addBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addBtn.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addBtn.Location = new System.Drawing.Point(12, 368);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(128, 29);
            this.addBtn.TabIndex = 57;
            this.addBtn.Text = "Добавить книгу";
            this.addBtn.UseVisualStyleBackColor = false;
            this.addBtn.Click += new System.EventHandler(this.IsAdd_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(174, 89);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(136, 25);
            this.textBox1.TabIndex = 60;
            this.textBox1.TextChanged += new System.EventHandler(this.Search_TextChanged);
            // 
            // RightBtn
            // 
            this.RightBtn.AutoSize = true;
            this.RightBtn.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.RightBtn.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RightBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.RightBtn.Location = new System.Drawing.Point(645, 368);
            this.RightBtn.Name = "RightBtn";
            this.RightBtn.Size = new System.Drawing.Size(26, 30);
            this.RightBtn.TabIndex = 62;
            this.RightBtn.Text = ">";
            this.RightBtn.Click += new System.EventHandler(this.RightBtn_Click);
            // 
            // leftBtn
            // 
            this.leftBtn.AutoSize = true;
            this.leftBtn.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.leftBtn.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.leftBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.leftBtn.Location = new System.Drawing.Point(604, 368);
            this.leftBtn.Name = "leftBtn";
            this.leftBtn.Size = new System.Drawing.Size(26, 30);
            this.leftBtn.TabIndex = 61;
            this.leftBtn.Text = "<";
            this.leftBtn.Click += new System.EventHandler(this.leftBtn_Click);
            // 
            // BookListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(685, 419);
            this.Controls.Add(this.RightBtn);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.leftBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.sort);
            this.Controls.Add(this.LogInBtn);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.FullName);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.Header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BookListForm";
            this.Text = "BookListForm";
            this.Load += new System.EventHandler(this.BookListForm_Load);
            this.Header.ResumeLayout(false);
            this.Header.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Header;
        private System.Windows.Forms.Label RegLabel;
        private System.Windows.Forms.Label FullName;
        private System.Windows.Forms.Label Close;
        private System.Windows.Forms.Button LogInBtn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ComboBox sort;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label RightBtn;
        private System.Windows.Forms.Label leftBtn;
    }
}