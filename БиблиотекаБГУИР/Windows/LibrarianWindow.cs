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
    public partial class LibrarianWindow : Form
    {
        Библиотекари librarian;
        List<Librarian> librarianlist;
        bool sortOrder = false;
        int rowIndex = 0;
        public LibrarianWindow(Form owner)
        {
            InitializeComponent();
            this.Owner = owner;
            librarian = DataContext.Select<Библиотекари>().FirstOrDefault();
            InitList();
            InitTextBox();
            InitGrid();
        }

        private void LibrarianWindow_Load(object sender, EventArgs e)
        {

        }

        private void LibrarianWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Owner.Show();
        }


        private void InitList()
        {
            librarianlist = new List<Librarian>();
            var ls = DataContext.Select<Библиотекари>().Select(p => new
            {
                ID = p.ID,
                Имя = p.Имя,
                Фамилия = p.Фамилия,
                Номер_телефона = p.Номер_телефона

            }).ToList();

            foreach (var item in ls)
            {
                librarianlist.Add(new Librarian(item.ID, item.Имя, item.Фамилия, item.Номер_телефона));
            }
        }

        private void status_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            (new StatusWindow(this)).Show();
        }
        private void InitGrid(List<Librarian> ls = null)
        {
            if (ls != null)
            {
                booksGrid.DataSource = ls;
                booksGrid.Columns["ID"].Visible = false;
            }
            else
            {
                booksGrid.DataSource = librarianlist;
                booksGrid.Columns["ID"].Visible = false;
            }
        }

        private void InitTextBox()
        {
            if (librarian == null)
            {
                librarian = new Библиотекари();
                наименовниеTextBox.Text = "";
                FamiliaText.Text = "";
                NumberText.Text = "";
                return;
            }

            наименовниеTextBox.Text = librarian.Имя;
            FamiliaText.Text = librarian.Фамилия;
            NumberText.Text = librarian.Номер_телефона;
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

                int id = librarianlist[rowIndex].Id;
                librarian = DataContext.Select<Библиотекари>().Where(o => o.ID == id).First();
            }
            catch (Exception)
            {
                rowIndex = booksGrid.Rows.Count - 1;
                librarian = DataContext.Select<Библиотекари>().ToList().Last();

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
                if (librarianlist.Count <= rowIndex)
                {
                    throw new Exception();
                }

                int id = librarianlist[rowIndex].Id;
                librarian = DataContext.Select<Библиотекари>().Where(o => o.ID == id).First();

            }
            catch (Exception)
            {
                rowIndex = 0;
                librarian = DataContext.Select<Библиотекари>().FirstOrDefault();
            }
            finally
            {
                booksGrid.Rows[rowIndex].Selected = true;
                InitTextBox();
            }
        }

        private void SaveChanges_Click(object sender, EventArgs e)
        {
            if (librarian.ID == -1)
            {
                int id = DataContext.Select<Библиотекари>().ToList().Last().ID;
                librarian.ID = id + 1;
            }

            librarian.Имя = наименовниеTextBox.Text;
            librarian.Фамилия = FamiliaText.Text;
            librarian.Номер_телефона = NumberText.Text;

            if (DataContext.Select<Библиотекари>().Where(o => o.ID == librarian.ID).FirstOrDefault() != null)
            {
                DataContext.Update<Библиотекари>(DataContext.Select<Библиотекари>().Where(o => o.ID == librarian.ID).First());
            }
            else
            {
                DataContext.Insert<Библиотекари>(librarian);
            }
            InitList();
            InitGrid();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            librarian = new Библиотекари();
            librarian.ID = -1;
            наименовниеTextBox.Text = "";

            FamiliaText.Text = "";
            NumberText.Text = "";
        }

        private void BooksWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Owner.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                booksGrid.DataSource = librarianlist.Where(u => u.Имя.ToLower().Contains(textBox1.Text.ToLower())).ToList();

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
                        InitGrid(librarianlist.OrderBy(o => o.Имя).ToList<Librarian>());
                        break;

                }
            }
            else
            {
                switch (columnIndex)
                {
                    case 1:
                        InitGrid(librarianlist.OrderByDescending(o => o.Имя).ToList<Librarian>());
                        break;
                }

            }

            sortOrder = !sortOrder;

        }

        private void StatusWindow_Load(object sender, EventArgs e)
        {

        }

        private void StatusWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Owner.Show();
        }

        private void Delete_Button_Click(object sender, EventArgs e)
        {
            DataContext.Delete<Библиотекари>(librarian);
            NextItem_Click(this, e);
            InitList();
            InitTextBox();
            InitGrid();
        }
    }

    public class Librarian
    {
        int id;
        string имя;
        string фамилия;
        string номер_телефона;

        public Librarian(int id, string имя,string фамилия, string номер_телефона)
        {
            this.id = id;
            this.имя = имя;

            this.Фамилия = фамилия;
            this.номер_телефона = номер_телефона;
        }

        public int Id { get => id; set => id = value; }
        public string Имя { get => имя; set => имя = value; }

        public string Фамилия { get => фамилия; set => фамилия = value; }
        public string Номер_телефона { get => номер_телефона; set => номер_телефона = value; }
    }
}
