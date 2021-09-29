
namespace БиблиотекаБГУИР
{
    partial class AccountingWindow
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
            System.Windows.Forms.Label автор_IDLabel;
            System.Windows.Forms.Label label1;
            this.Delete_Button = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.SaveChanges = new System.Windows.Forms.Button();
            this.NextItem = new System.Windows.Forms.Button();
            this.PriviousItem = new System.Windows.Forms.Button();
            this.booksGrid = new System.Windows.Forms.DataGridView();
            this.КнигаComboBox = new System.Windows.Forms.ComboBox();
            this.СтатусComboBox = new System.Windows.Forms.ComboBox();
            this.BooksdataGridView = new System.Windows.Forms.DataGridView();
            this.StatusdataGridView = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            автор_IDLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.booksGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BooksdataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StatusdataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // автор_IDLabel
            // 
            автор_IDLabel.AutoSize = true;
            автор_IDLabel.Location = new System.Drawing.Point(490, 12);
            автор_IDLabel.Name = "автор_IDLabel";
            автор_IDLabel.Size = new System.Drawing.Size(37, 13);
            автор_IDLabel.TabIndex = 87;
            автор_IDLabel.Text = "Книга";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(490, 62);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(41, 13);
            label1.TabIndex = 89;
            label1.Text = "Статус";
            // 
            // Delete_Button
            // 
            this.Delete_Button.Location = new System.Drawing.Point(395, 180);
            this.Delete_Button.Name = "Delete_Button";
            this.Delete_Button.Size = new System.Drawing.Size(89, 23);
            this.Delete_Button.TabIndex = 86;
            this.Delete_Button.Text = "Удалить";
            this.Delete_Button.UseVisualStyleBackColor = true;
            this.Delete_Button.Click += new System.EventHandler(this.Delete_Button_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(597, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 13);
            this.label3.TabIndex = 85;
            this.label3.Text = "Поиск по наименованию";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(578, 136);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(162, 20);
            this.textBox1.TabIndex = 84;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(300, 180);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(89, 23);
            this.AddButton.TabIndex = 83;
            this.AddButton.Text = "Добавить";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // SaveChanges
            // 
            this.SaveChanges.Location = new System.Drawing.Point(205, 180);
            this.SaveChanges.Name = "SaveChanges";
            this.SaveChanges.Size = new System.Drawing.Size(89, 23);
            this.SaveChanges.TabIndex = 82;
            this.SaveChanges.Text = "Сохранить";
            this.SaveChanges.UseVisualStyleBackColor = true;
            this.SaveChanges.Click += new System.EventHandler(this.SaveChanges_Click);
            // 
            // NextItem
            // 
            this.NextItem.Location = new System.Drawing.Point(110, 181);
            this.NextItem.Name = "NextItem";
            this.NextItem.Size = new System.Drawing.Size(89, 23);
            this.NextItem.TabIndex = 81;
            this.NextItem.Text = "Следующий";
            this.NextItem.UseVisualStyleBackColor = true;
            this.NextItem.Click += new System.EventHandler(this.NextItem_Click);
            // 
            // PriviousItem
            // 
            this.PriviousItem.Location = new System.Drawing.Point(15, 181);
            this.PriviousItem.Name = "PriviousItem";
            this.PriviousItem.Size = new System.Drawing.Size(89, 23);
            this.PriviousItem.TabIndex = 80;
            this.PriviousItem.Text = "Предыдущий";
            this.PriviousItem.UseVisualStyleBackColor = true;
            this.PriviousItem.Click += new System.EventHandler(this.PriviousItem_Click);
            // 
            // booksGrid
            // 
            this.booksGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.booksGrid.Location = new System.Drawing.Point(15, 13);
            this.booksGrid.Name = "booksGrid";
            this.booksGrid.Size = new System.Drawing.Size(472, 162);
            this.booksGrid.TabIndex = 79;
            this.booksGrid.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.booksGrid_ColumnHeaderMouseClick);
            // 
            // КнигаComboBox
            // 
            this.КнигаComboBox.FormattingEnabled = true;
            this.КнигаComboBox.Location = new System.Drawing.Point(559, 12);
            this.КнигаComboBox.Name = "КнигаComboBox";
            this.КнигаComboBox.Size = new System.Drawing.Size(198, 21);
            this.КнигаComboBox.TabIndex = 88;
            // 
            // СтатусComboBox
            // 
            this.СтатусComboBox.FormattingEnabled = true;
            this.СтатусComboBox.Location = new System.Drawing.Point(559, 62);
            this.СтатусComboBox.Name = "СтатусComboBox";
            this.СтатусComboBox.Size = new System.Drawing.Size(198, 21);
            this.СтатусComboBox.TabIndex = 90;
            // 
            // BooksdataGridView
            // 
            this.BooksdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BooksdataGridView.Location = new System.Drawing.Point(15, 247);
            this.BooksdataGridView.Name = "BooksdataGridView";
            this.BooksdataGridView.Size = new System.Drawing.Size(240, 150);
            this.BooksdataGridView.TabIndex = 91;
            // 
            // StatusdataGridView
            // 
            this.StatusdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StatusdataGridView.Location = new System.Drawing.Point(276, 247);
            this.StatusdataGridView.Name = "StatusdataGridView";
            this.StatusdataGridView.Size = new System.Drawing.Size(240, 150);
            this.StatusdataGridView.TabIndex = 92;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(106, 220);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 24);
            this.label2.TabIndex = 93;
            this.label2.Text = "Книги";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(352, 220);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 24);
            this.label4.TabIndex = 94;
            this.label4.Text = "Статусы";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(597, 211);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 13);
            this.label5.TabIndex = 96;
            this.label5.Text = "Поиск по наименованию";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(578, 184);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(162, 20);
            this.textBox2.TabIndex = 95;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // AccountingWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 422);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.StatusdataGridView);
            this.Controls.Add(this.BooksdataGridView);
            this.Controls.Add(this.СтатусComboBox);
            this.Controls.Add(label1);
            this.Controls.Add(this.КнигаComboBox);
            this.Controls.Add(автор_IDLabel);
            this.Controls.Add(this.Delete_Button);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.SaveChanges);
            this.Controls.Add(this.NextItem);
            this.Controls.Add(this.PriviousItem);
            this.Controls.Add(this.booksGrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AccountingWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AccountingWindow";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AccountingWindow_FormClosing);
            this.Load += new System.EventHandler(this.AccountingWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.booksGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BooksdataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StatusdataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Delete_Button;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button SaveChanges;
        private System.Windows.Forms.Button NextItem;
        private System.Windows.Forms.Button PriviousItem;
        private System.Windows.Forms.DataGridView booksGrid;
        private System.Windows.Forms.ComboBox КнигаComboBox;
        private System.Windows.Forms.ComboBox СтатусComboBox;
        private System.Windows.Forms.DataGridView BooksdataGridView;
        private System.Windows.Forms.DataGridView StatusdataGridView;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox2;
    }
}