
namespace БиблиотекаБГУИР
{
    partial class BooksWindow
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
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label автор_IDLabel;
            System.Windows.Forms.Label дата_изданияLabel;
            System.Windows.Forms.Label наименовниеLabel;
            this.КатегорияcomboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ШифрTextBox = new System.Windows.Forms.TextBox();
            this.АвторComboBox = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.SaveChanges = new System.Windows.Forms.Button();
            this.NextItem = new System.Windows.Forms.Button();
            this.PriviousItem = new System.Windows.Forms.Button();
            this.booksGrid = new System.Windows.Forms.DataGridView();
            this.LibrarianButton = new System.Windows.Forms.Button();
            this.CategoryButton = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.status_button = new System.Windows.Forms.Button();
            this.accounting_button = new System.Windows.Forms.Button();
            this.дата_изданияDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.наименовниеTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            автор_IDLabel = new System.Windows.Forms.Label();
            дата_изданияLabel = new System.Windows.Forms.Label();
            наименовниеLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.booksGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(488, 96);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(39, 13);
            label1.TabIndex = 55;
            label1.Text = "Шифр:";
            // 
            // автор_IDLabel
            // 
            автор_IDLabel.AutoSize = true;
            автор_IDLabel.Location = new System.Drawing.Point(488, 17);
            автор_IDLabel.Name = "автор_IDLabel";
            автор_IDLabel.Size = new System.Drawing.Size(40, 13);
            автор_IDLabel.TabIndex = 36;
            автор_IDLabel.Text = "Автор:";
            // 
            // дата_изданияLabel
            // 
            дата_изданияLabel.AutoSize = true;
            дата_изданияLabel.Location = new System.Drawing.Point(488, 44);
            дата_изданияLabel.Name = "дата_изданияLabel";
            дата_изданияLabel.Size = new System.Drawing.Size(81, 13);
            дата_изданияLabel.TabIndex = 37;
            дата_изданияLabel.Text = "Дата издания:";
            // 
            // наименовниеLabel
            // 
            наименовниеLabel.AutoSize = true;
            наименовниеLabel.Location = new System.Drawing.Point(488, 69);
            наименовниеLabel.Name = "наименовниеLabel";
            наименовниеLabel.Size = new System.Drawing.Size(80, 13);
            наименовниеLabel.TabIndex = 39;
            наименовниеLabel.Text = "Наименовние:";
            // 
            // КатегорияcomboBox1
            // 
            this.КатегорияcomboBox1.FormattingEnabled = true;
            this.КатегорияcomboBox1.Location = new System.Drawing.Point(575, 124);
            this.КатегорияcomboBox1.Name = "КатегорияcomboBox1";
            this.КатегорияcomboBox1.Size = new System.Drawing.Size(198, 21);
            this.КатегорияcomboBox1.TabIndex = 57;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(488, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 56;
            this.label2.Text = "Категория";
            // 
            // ШифрTextBox
            // 
            this.ШифрTextBox.Location = new System.Drawing.Point(575, 93);
            this.ШифрTextBox.Name = "ШифрTextBox";
            this.ШифрTextBox.Size = new System.Drawing.Size(200, 20);
            this.ШифрTextBox.TabIndex = 54;
            // 
            // АвторComboBox
            // 
            this.АвторComboBox.FormattingEnabled = true;
            this.АвторComboBox.Location = new System.Drawing.Point(575, 13);
            this.АвторComboBox.Name = "АвторComboBox";
            this.АвторComboBox.Size = new System.Drawing.Size(198, 21);
            this.АвторComboBox.TabIndex = 53;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(591, 183);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(162, 20);
            this.textBox1.TabIndex = 52;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(342, 179);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(89, 23);
            this.AddButton.TabIndex = 50;
            this.AddButton.Text = "Добавить";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // SaveChanges
            // 
            this.SaveChanges.Location = new System.Drawing.Point(247, 179);
            this.SaveChanges.Name = "SaveChanges";
            this.SaveChanges.Size = new System.Drawing.Size(89, 23);
            this.SaveChanges.TabIndex = 49;
            this.SaveChanges.Text = "Сохранить";
            this.SaveChanges.UseVisualStyleBackColor = true;
            this.SaveChanges.Click += new System.EventHandler(this.SaveChanges_Click);
            // 
            // NextItem
            // 
            this.NextItem.Location = new System.Drawing.Point(152, 180);
            this.NextItem.Name = "NextItem";
            this.NextItem.Size = new System.Drawing.Size(89, 23);
            this.NextItem.TabIndex = 48;
            this.NextItem.Text = "Следующий";
            this.NextItem.UseVisualStyleBackColor = true;
            this.NextItem.Click += new System.EventHandler(this.NextItem_Click);
            // 
            // PriviousItem
            // 
            this.PriviousItem.Location = new System.Drawing.Point(57, 180);
            this.PriviousItem.Name = "PriviousItem";
            this.PriviousItem.Size = new System.Drawing.Size(89, 23);
            this.PriviousItem.TabIndex = 47;
            this.PriviousItem.Text = "Предыдущий";
            this.PriviousItem.UseVisualStyleBackColor = true;
            this.PriviousItem.Click += new System.EventHandler(this.PriviousItem_Click);
            // 
            // booksGrid
            // 
            this.booksGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.booksGrid.Location = new System.Drawing.Point(12, 12);
            this.booksGrid.Name = "booksGrid";
            this.booksGrid.Size = new System.Drawing.Size(472, 162);
            this.booksGrid.TabIndex = 46;
            this.booksGrid.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.booksGrid_ColumnHeaderMouseClick);
            // 
            // LibrarianButton
            // 
            this.LibrarianButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LibrarianButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LibrarianButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LibrarianButton.Location = new System.Drawing.Point(368, 219);
            this.LibrarianButton.Name = "LibrarianButton";
            this.LibrarianButton.Size = new System.Drawing.Size(89, 33);
            this.LibrarianButton.TabIndex = 45;
            this.LibrarianButton.Text = "Библиотекари";
            this.LibrarianButton.UseVisualStyleBackColor = false;
            this.LibrarianButton.Click += new System.EventHandler(this.LibrarianButton_Click);
            // 
            // CategoryButton
            // 
            this.CategoryButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.CategoryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CategoryButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.CategoryButton.Location = new System.Drawing.Point(280, 219);
            this.CategoryButton.Name = "CategoryButton";
            this.CategoryButton.Size = new System.Drawing.Size(82, 33);
            this.CategoryButton.TabIndex = 44;
            this.CategoryButton.Text = "Категории";
            this.CategoryButton.UseVisualStyleBackColor = false;
            this.CategoryButton.Click += new System.EventHandler(this.CategoryButton_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button3.Location = new System.Drawing.Point(192, 219);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(82, 33);
            this.button3.TabIndex = 43;
            this.button3.Text = "Авторы";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // status_button
            // 
            this.status_button.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.status_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.status_button.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.status_button.Location = new System.Drawing.Point(104, 219);
            this.status_button.Name = "status_button";
            this.status_button.Size = new System.Drawing.Size(82, 33);
            this.status_button.TabIndex = 42;
            this.status_button.Text = "Статусы";
            this.status_button.UseVisualStyleBackColor = false;
            this.status_button.Click += new System.EventHandler(this.status_button_Click);
            // 
            // accounting_button
            // 
            this.accounting_button.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.accounting_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.accounting_button.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.accounting_button.Location = new System.Drawing.Point(16, 219);
            this.accounting_button.Name = "accounting_button";
            this.accounting_button.Size = new System.Drawing.Size(82, 33);
            this.accounting_button.TabIndex = 41;
            this.accounting_button.Text = "Учёт";
            this.accounting_button.UseVisualStyleBackColor = false;
            this.accounting_button.Click += new System.EventHandler(this.accounting_button_Click);
            // 
            // дата_изданияDateTimePicker
            // 
            this.дата_изданияDateTimePicker.Location = new System.Drawing.Point(575, 40);
            this.дата_изданияDateTimePicker.Name = "дата_изданияDateTimePicker";
            this.дата_изданияDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.дата_изданияDateTimePicker.TabIndex = 38;
            // 
            // наименовниеTextBox
            // 
            this.наименовниеTextBox.Location = new System.Drawing.Point(575, 66);
            this.наименовниеTextBox.Name = "наименовниеTextBox";
            this.наименовниеTextBox.Size = new System.Drawing.Size(200, 20);
            this.наименовниеTextBox.TabIndex = 40;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(608, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 13);
            this.label3.TabIndex = 58;
            this.label3.Text = "Поиск по наименованию";
            // 
            // BooksWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 272);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.КатегорияcomboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(label1);
            this.Controls.Add(this.ШифрTextBox);
            this.Controls.Add(this.АвторComboBox);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.SaveChanges);
            this.Controls.Add(this.NextItem);
            this.Controls.Add(this.PriviousItem);
            this.Controls.Add(this.booksGrid);
            this.Controls.Add(this.LibrarianButton);
            this.Controls.Add(this.CategoryButton);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.status_button);
            this.Controls.Add(this.accounting_button);
            this.Controls.Add(автор_IDLabel);
            this.Controls.Add(дата_изданияLabel);
            this.Controls.Add(this.дата_изданияDateTimePicker);
            this.Controls.Add(наименовниеLabel);
            this.Controls.Add(this.наименовниеTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "BooksWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BooksWindow";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BooksWindow_FormClosing);
            this.Load += new System.EventHandler(this.BooksWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.booksGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox КатегорияcomboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ШифрTextBox;
        private System.Windows.Forms.ComboBox АвторComboBox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button SaveChanges;
        private System.Windows.Forms.Button NextItem;
        private System.Windows.Forms.Button PriviousItem;
        private System.Windows.Forms.DataGridView booksGrid;
        private System.Windows.Forms.Button LibrarianButton;
        private System.Windows.Forms.Button CategoryButton;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button status_button;
        private System.Windows.Forms.Button accounting_button;
        private System.Windows.Forms.DateTimePicker дата_изданияDateTimePicker;
        private System.Windows.Forms.TextBox наименовниеTextBox;
        private System.Windows.Forms.Label label3;
    }
}