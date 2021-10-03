
namespace БиблиотекаБГУИР
{
    partial class Main
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
            this.BooksWindow = new System.Windows.Forms.Button();
            this.ReadersWindow = new System.Windows.Forms.Button();
            this.ReportsWindow = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BooksWindow
            // 
            this.BooksWindow.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BooksWindow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BooksWindow.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BooksWindow.Location = new System.Drawing.Point(12, 12);
            this.BooksWindow.Name = "BooksWindow";
            this.BooksWindow.Size = new System.Drawing.Size(109, 47);
            this.BooksWindow.TabIndex = 0;
            this.BooksWindow.Text = "Книги";
            this.BooksWindow.UseVisualStyleBackColor = false;
            this.BooksWindow.Click += new System.EventHandler(this.BooksWindow_Click);
            // 
            // ReadersWindow
            // 
            this.ReadersWindow.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ReadersWindow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ReadersWindow.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ReadersWindow.Location = new System.Drawing.Point(127, 12);
            this.ReadersWindow.Name = "ReadersWindow";
            this.ReadersWindow.Size = new System.Drawing.Size(109, 47);
            this.ReadersWindow.TabIndex = 1;
            this.ReadersWindow.Text = "Читатели";
            this.ReadersWindow.UseVisualStyleBackColor = false;
            this.ReadersWindow.Click += new System.EventHandler(this.ReadersWindow_Click);
            // 
            // ReportsWindow
            // 
            this.ReportsWindow.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ReportsWindow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ReportsWindow.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ReportsWindow.Location = new System.Drawing.Point(71, 65);
            this.ReportsWindow.Name = "ReportsWindow";
            this.ReportsWindow.Size = new System.Drawing.Size(109, 47);
            this.ReportsWindow.TabIndex = 2;
            this.ReportsWindow.Text = "Отчёты";
            this.ReportsWindow.UseVisualStyleBackColor = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(248, 120);
            this.Controls.Add(this.ReportsWindow);
            this.Controls.Add(this.ReadersWindow);
            this.Controls.Add(this.BooksWindow);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "dg";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BooksWindow;
        private System.Windows.Forms.Button ReadersWindow;
        private System.Windows.Forms.Button ReportsWindow;
    }
}

