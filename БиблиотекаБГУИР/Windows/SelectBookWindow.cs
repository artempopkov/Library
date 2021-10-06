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
            
            var ls = DataContext.Select<Книги>().Select(s => new
            {
                ID = s.ID,
                Наименование = s.Наименовние,
                Автор = s.Авторы.ФИО,
                ДатаИздания = s.Дата_издания,
                Шифр = s.Шифр,
                Категория = s.Категории.Наименование
            }).ToList();
            var status = DataContext.Select<Учёт>();

            for(int i = 0; i< ls.Count();i++)
            {
                int id = ls[i].ID;
                var a = status.Where(o => o.Книга_ID == id).First();
                if (a.Статус_ID == 2 || a.Статус_ID == 3)
                {
                    ls.Remove(ls[i]);
                    i--;
                }
            }

            BooksdataGridView.DataSource = ls;


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
