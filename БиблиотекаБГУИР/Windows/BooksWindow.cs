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
    public partial class BooksWindow : Form
    {
        Книги book;
        List<BOOK> bookslist;
        bool sortOrder = false;
        int rowIndex = 0;
        public BooksWindow(Form owner)
        {
            this.Owner = owner;
            InitializeComponent();
            book = DataContext.Select<Книги>().FirstOrDefault();
            InitList();
            InitComboBox();
            InitTextBox();
            InitGrid();
        }

        private void BooksWindow_Load(object sender, EventArgs e)
        {

        }

        private void InitList()
        {
            bookslist = new List<BOOK>();
            var ls = DataContext.Select<Книги>().Select(p => new
            {
                ID = p.ID,
                Наименование = p.Наименовние,
                ДатаИздания = p.Дата_издания,
                Автор = p.Авторы.ФИО,
                Шифр = p.Шифр,
                Категория = p.Категории.Наименование
            }).ToList();

            foreach (var item in ls)
            {
                bookslist.Add(new BOOK(item.ID, item.Наименование, item.ДатаИздания, item.Автор, Convert.ToInt32(item.Шифр), item.Категория));
            }
        }

        private void status_button_Click(object sender, EventArgs e)
        {
            this.Hide();
           (new StatusWindow(this)).Show();
        }
        private void InitGrid(List<BOOK> ls = null)
        {
            if (ls != null)
            {
                booksGrid.DataSource = ls;
                booksGrid.Columns["ID"].Visible = false;
            }
            else
            {
                booksGrid.DataSource = bookslist;
                booksGrid.Columns["ID"].Visible = false;
            }
        }

        private void InitComboBox()
        {
            var listAutor = DataContext.Select<Авторы>();
            var listCateg = DataContext.Select<Категории>();
            if (listCateg != null)
            {
                foreach (var item in listCateg)
                {
                    КатегорияcomboBox1.Items.Add(item.Наименование);
                }
            }
            if (listAutor != null)
            {
                foreach (var item in listAutor)
                {
                    АвторComboBox.Items.Add(item.ФИО);
                }
            }

        }

        private void InitTextBox()
        {
            if (book == null)
            {
                book = new Книги();
                наименовниеTextBox.Text = "";
                return;
            }

            foreach (var item in АвторComboBox.Items)
            {
                if (item.GetHashCode() == book.Авторы.ФИО.GetHashCode())
                    АвторComboBox.SelectedItem = item;
            }
            foreach (var item in КатегорияcomboBox1.Items)
            {
                if (item.GetHashCode() == book.Категории.Наименование.GetHashCode())
                    КатегорияcomboBox1.SelectedItem = item;
            }

            наименовниеTextBox.Text = book.Наименовние;

            if (book.Дата_издания != null)
            {
                дата_изданияDateTimePicker.Value = (DateTime)book.Дата_издания;
            }
            ШифрTextBox.Text = book.Шифр.ToString();


        }

        private void PriviousItem_Click(object sender, EventArgs e)
        {
            booksGrid.Rows[rowIndex].Selected = false;
            try
            {
                book = DataContext.Select<Книги>().Where(o => o.ID == book.ID - 1).First();
                rowIndex -= 1;
            }
            catch (Exception)
            {
                book = DataContext.Select<Книги>().ToList().Last();
                rowIndex = booksGrid.Rows.Count - 1;
            }
            finally
            {
                booksGrid.Rows[rowIndex].Selected = true;
                InitTextBox();
            }
        }

        private void NextItem_Click(object sender, EventArgs e)
        {
            booksGrid.Rows[rowIndex].Selected = false;
            try
            {
                book = DataContext.Select<Книги>().Where(o => o.ID == book.ID + 1).First();
                rowIndex += 1;
            }
            catch (Exception)
            {
                book = DataContext.Select<Книги>().FirstOrDefault();
                rowIndex = 0;
            }
            finally
            {
                booksGrid.Rows[rowIndex].Selected = true;
                InitTextBox();
            }
        }

        private void SaveChanges_Click(object sender, EventArgs e)
        {
            if (book.ID == -1)
            {
                int id = DataContext.Select<Книги>().ToList().Last().ID;
                book.ID = id + 1;
            }

            book.Наименовние = наименовниеTextBox.Text;
            book.Авторы = DataContext.Select<Авторы>().Where(o => o.ФИО == АвторComboBox.SelectedItem.ToString()).FirstOrDefault();
            book.Категории = DataContext.Select<Категории>().Where(o => o.Наименование == КатегорияcomboBox1.SelectedItem.ToString()).FirstOrDefault();
            book.Шифр = Convert.ToInt32(ШифрTextBox.Text);
            book.Дата_издания = дата_изданияDateTimePicker.Value;
           // DataContext.Update<Книги_Категории>(DataContext.Select<Книги_Категории>().Where(o => o.Книга_ID == book.ID).FirstOrDefault());
            if (DataContext.Select<Книги>().Where(o => o.ID == book.ID).FirstOrDefault() != null)
            {
                DataContext.Update<Книги>(DataContext.Select<Книги>().Where(o => o.ID == book.ID).First());
            }
            else
            {
                DataContext.Insert<Книги>(book);
            }
            InitList();
            InitGrid();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            book = new Книги();
            book.ID = -1;
            АвторComboBox.SelectedItem = null;
            КатегорияcomboBox1.SelectedItem = null;
            наименовниеTextBox.Text = "";
            ШифрTextBox.Text = "";
        }

        private void BooksWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Owner.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                booksGrid.DataSource = bookslist.Where(u => u.Наименование.ToLower().Contains(textBox1.Text.ToLower())).ToList();

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
                        InitGrid(bookslist.OrderBy(o => o.Наименование).ToList<BOOK>());
                        break;
                    case 2:
                        InitGrid(bookslist.OrderBy(o => o.ДатаИздания).ToList<BOOK>());
                        break;
                    case 3:
                        InitGrid(bookslist.OrderBy(o => o.Автор).ToList<BOOK>());
                        break;
                    case 4:
                        InitGrid(bookslist.OrderBy(o => o.Шифр).ToList<BOOK>());
                        break;
                    case 5:
                        InitGrid(bookslist.OrderBy(o => o.Категория).ToList<BOOK>());
                        break;

                }
            }
            else
            {
                switch (columnIndex)
                {
                    case 1:
                        InitGrid(bookslist.OrderByDescending(o => o.Наименование).ToList<BOOK>());
                        break;
                    case 2:
                        InitGrid(bookslist.OrderByDescending(o => o.ДатаИздания).ToList<BOOK>());
                        break;
                    case 3:
                        InitGrid(bookslist.OrderByDescending(o => o.Автор).ToList<BOOK>());
                        break;
                    case 4:
                        InitGrid(bookslist.OrderByDescending(o => o.Шифр).ToList<BOOK>());
                        break;
                    case 5:
                        InitGrid(bookslist.OrderByDescending(o => o.Категория).ToList<BOOK>());
                        break;
                }

            }

            sortOrder = !sortOrder;

        }

        private void CategoryButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            (new CategoryWindow(this)).Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            (new AuthorWindow(this)).Show();
        }

        private void accounting_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            (new AccountingWindow(this)).Show();
        }
    }
    public class BOOK
    {
        int id;
        string наименование;
        DateTime? датаИздания;
        string автор;
        int шифр;
        string категория;

        public BOOK(int id, string наименование, DateTime? датаИздания, string автор, int шифр, string категория)
        {
            this.id = id;
            this.наименование = наименование;
            this.датаИздания = датаИздания;
            this.автор = автор;
            this.шифр = шифр;
            this.категория = категория;
        }

        public int Id { get => id; set => id = value; }
        public string Наименование { get => наименование; set => наименование = value; }
        public DateTime? ДатаИздания { get => датаИздания; set => датаИздания = value; }
        public string Автор { get => автор; set => автор = value; }
        public int Шифр { get => шифр; set => шифр = value; }
        public string Категория { get => категория; set => категория = value; }
    }
}
