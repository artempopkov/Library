using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace БиблиотекаБГУИР
{
    public partial class AuthorWindow : Form
    {
        Авторы author;
        List<Author> authorlist;
        bool sortOrder = false;
        int rowIndex = 0;
        public AuthorWindow(Form owner)
        {
            this.Owner = owner;
            InitializeComponent();
            author = DataContext.Select<Авторы>().FirstOrDefault();
            InitList();
            InitTextBox();
            InitGrid();
        }

        private void AuthorWindow_Load(object sender, EventArgs e)
        {

        }

        private void InitList()
        {
            authorlist = new List<Author>();
            var ls = DataContext.Select<Авторы>().Select(p => new
            {
                ID = p.ID,
                Наименование = p.ФИО
            }).ToList();

            foreach (var item in ls)
            {
                authorlist.Add(new Author(item.ID, item.Наименование));
            }
        }

        private void status_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            (new StatusWindow(this)).Show();
        }
        private void InitGrid(List<Author> ls = null)
        {
            if (ls != null)
            {
                booksGrid.DataSource = ls;
                booksGrid.Columns["ID"].Visible = false;
            }
            else
            {
                booksGrid.DataSource = authorlist;
                booksGrid.Columns["ID"].Visible = false;
            }
        }

        private void InitTextBox()
        {
            if (author == null)
            {
                author = new Авторы();
                наименовниеTextBox.Text = "";
                return;
            }

            наименовниеTextBox.Text = author.ФИО;
        }

        private void PriviousItem_Click(object sender, EventArgs e)
        {
            try
            {
                booksGrid.Rows[rowIndex].Selected = false;
            }
            catch (Exception)
            {

            }

            try
            {
                rowIndex -= 1;
                if (rowIndex < 0)
                {
                    throw new Exception();
                }

                int id = authorlist[rowIndex].Id;
                author = DataContext.Select<Авторы>().Where(o => o.ID == id).First();
            }
            catch (Exception)
            {
                rowIndex = booksGrid.Rows.Count - 1;
                author = DataContext.Select<Авторы>().ToList().Last();

            }
            finally
            {
                booksGrid.Rows[rowIndex].Selected = true;
                InitTextBox();
            }
        }

        private void NextItem_Click(object sender, EventArgs e)
        {
            try
            {
                booksGrid.Rows[rowIndex].Selected = false;
            }
            catch (Exception)
            {

            }

            try
            {
                rowIndex += 1;
                if (authorlist.Count <= rowIndex)
                {
                    throw new Exception();
                }

                int id = authorlist[rowIndex].Id;
                author = DataContext.Select<Авторы>().Where(o => o.ID == id).First();

            }
            catch (Exception)
            {
                rowIndex = 0;
                author = DataContext.Select<Авторы>().FirstOrDefault();
            }
            finally
            {
                booksGrid.Rows[rowIndex].Selected = true;
                InitTextBox();
            }
        }

        private void SaveChanges_Click(object sender, EventArgs e)
        {
            if (author.ID == -1)
            {
                int id = DataContext.Select<Авторы>().ToList().Last().ID;
                author.ID = id + 1;
            }

            author.ФИО = наименовниеTextBox.Text;

            if (DataContext.Select<Авторы>().Where(o => o.ID == author.ID).FirstOrDefault() != null)
            {
                DataContext.Update<Авторы>(DataContext.Select<Авторы>().Where(o => o.ID == author.ID).First());
            }
            else
            {
                DataContext.Insert<Авторы>(author);
            }
            InitList();
            InitGrid();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            author = new Авторы();
            author.ID = -1;
            наименовниеTextBox.Text = "";
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                booksGrid.DataSource = authorlist.Where(u => u.Наименование.ToLower().Contains(textBox1.Text.ToLower())).ToList();

            }
            else
            {
                InitGrid();
            }
        }

        private void booksGrid_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int columnIndex = e.ColumnIndex;
            if (sortOrder)
            {
                switch (columnIndex)
                {
                    case 1:
                        InitGrid(authorlist.OrderBy(o => o.Наименование).ToList<Author>());
                        break;

                }
            }
            else
            {
                switch (columnIndex)
                {
                    case 1:
                        InitGrid(authorlist.OrderByDescending(o => o.Наименование).ToList<Author>());
                        break;
                }

            }

            sortOrder = !sortOrder;

        }

        private void StatusWindow_Load(object sender, EventArgs e)
        {

        }

        private void Delete_Button_Click(object sender, EventArgs e)
        {
            DataContext.Delete<Авторы>(author);
            NextItem_Click(this, e);
            InitList();
            InitTextBox();
            InitGrid();
        }

        private void AuthorWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Owner.Show();
        }
    }

    public class Author
    {
        int id;
        string наименование;

        public Author(int id, string наименование)
        {
            this.id = id;
            this.наименование = наименование;
        }

        public int Id { get => id; set => id = value; }
        public string Наименование { get => наименование; set => наименование = value; }
    }
}
