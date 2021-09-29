
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
            автор_IDLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.booksGrid)).BeginInit();
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
            this.label3.Location = new System.Drawing.Point(578, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 13);
            this.label3.TabIndex = 85;
            this.label3.Text = "Поиск по наименованию";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(559, 180);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(162, 20);
            this.textBox1.TabIndex = 84;
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
            // AccountingWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 240);
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
            this.Load += new System.EventHandler(this.AccountingWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.booksGrid)).EndInit();
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
    }
}