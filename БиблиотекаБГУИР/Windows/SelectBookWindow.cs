using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;

namespace БиблиотекаБГУИР
{
    public partial class SelectBookWindow : Form
    {
        public static int? id = null;
        public SelectBookWindow(ReaderBook owner)
        {
            InitializeComponent();
            this.Owner = owner;
            BooksdataGridView.DataSource = DataContext.Select<Книги>().Select(s => new
            {
                ID = s.ID,
                Наименование = s.Наименовние,
                Автор = s.Авторы.ФИО,
                ДатаИздания = s.Дата_издания,
                Шифр = s.Шифр,
                Категория = s.Категории.Наименование
            }).ToList();
            BooksdataGridView.Columns["ID"].Visible = false;
        }

        private void SelectBookWindow_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dynamic a = BooksdataGridView.SelectedRows[0].DataBoundItem;
            ReaderBook.BookID = a.ID;
            this.Owner.Show();
            this.Close();
        }
    }
}
