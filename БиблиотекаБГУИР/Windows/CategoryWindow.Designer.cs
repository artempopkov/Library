
namespace БиблиотекаБГУИР
{
    partial class CategoryWindow
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
            System.Windows.Forms.Label наименовниеLabel;
            this.Delete_Button = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.SaveChanges = new System.Windows.Forms.Button();
            this.NextItem = new System.Windows.Forms.Button();
            this.PriviousItem = new System.Windows.Forms.Button();
            this.booksGrid = new System.Windows.Forms.DataGridView();
            this.наименовниеTextBox = new System.Windows.Forms.TextBox();
            наименовниеLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.booksGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // наименовниеLabel
            // 
            наименовниеLabel.AutoSize = true;
            наименовниеLabel.Location = new System.Drawing.Point(490, 12);
            наименовниеLabel.Name = "наименовниеLabel";
            наименовниеLabel.Size = new System.Drawing.Size(80, 13);
            наименовниеLabel.TabIndex = 77;
            наименовниеLabel.Text = "Наименовние:";
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
            this.label3.Location = new System.Drawing.Point(607, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 13);
            this.label3.TabIndex = 85;
            this.label3.Text = "Поиск по наименованию";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(594, 47);
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
            this.booksGrid.Location = new System.Drawing.Point(12, 12);
            this.booksGrid.Name = "booksGrid";
            this.booksGrid.Size = new System.Drawing.Size(472, 162);
            this.booksGrid.TabIndex = 79;
            this.booksGrid.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.booksGrid_ColumnHeaderMouseClick);
            // 
            // наименовниеTextBox
            // 
            this.наименовниеTextBox.Location = new System.Drawing.Point(576, 12);
            this.наименовниеTextBox.Name = "наименовниеTextBox";
            this.наименовниеTextBox.Size = new System.Drawing.Size(200, 20);
            this.наименовниеTextBox.TabIndex = 78;
            this.наименовниеTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // CategoryWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 213);
            this.Controls.Add(this.Delete_Button);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.SaveChanges);
            this.Controls.Add(this.NextItem);
            this.Controls.Add(this.PriviousItem);
            this.Controls.Add(this.booksGrid);
            this.Controls.Add(наименовниеLabel);
            this.Controls.Add(this.наименовниеTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "CategoryWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CategoryWindow";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CategoryWindow_FormClosing);
            this.Load += new System.EventHandler(this.CategoryWindow_Load);
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
        private System.Windows.Forms.TextBox наименовниеTextBox;
    }
}