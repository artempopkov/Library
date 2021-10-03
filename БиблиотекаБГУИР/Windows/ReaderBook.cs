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
    public partial class ReaderBook : Form
    {
        Карта_Читателя reader_book;
        List<ReaderBooks> reader_booklist;
        bool sortOrder = false;
        int rowIndex = 0;
        int ReaderId;
        public static int BookID;
        public ReaderBook(Form owner, int reader)
        {
            InitializeComponent();
            this.Owner = owner;
            ReaderId = reader;
            try
            {
                reader_book = DataContext.Select<Карта_Читателя>().Where(o => o.Читатель_ID == ReaderId).FirstOrDefault();
            }
            catch(Exception)
            {
                MessageBox.Show("Читальная книжка пуста!");
            }

            InitList();
            InitTextBox();
            InitGrid();
        }


        private void ReaderBook_Load(object sender, EventArgs e)
        {

        }

        private void LibrarianWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Owner.Show();
        }


        private void InitList()
        {
            List<Книги> c = DataContext.Select<Книги>().ToList();
            reader_booklist = new List<ReaderBooks>();
            var ls = DataContext.Select<Карта_Читателя>().Where(o => o.Читатель_ID == ReaderId).Select(p => new
            {
                ID = p.ID,
                Книга = p.Книга_ID,
                Дата_Получения = p.Дата_заказа,
                Дата_Возврата = p.Дата_возврата

            }).ToList();

            foreach (var item in ls)
            {
                reader_booklist.Add(new ReaderBooks(item.ID, DataContext.Select<Книги>().Where(o => o.ID == item.Книга).First().Наименовние, item.Книга, item.Дата_Получения, item.Дата_Возврата));
            }
        }

        private void status_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            (new StatusWindow(this)).Show();
        }
        private void InitGrid(List<ReaderBooks> ls = null)
        {
            if (ls != null)
            {
                booksGrid.DataSource = ls;
                booksGrid.Columns["ID"].Visible = false;
            }
            else
            {
                booksGrid.DataSource = reader_booklist;
                booksGrid.Columns["ID"].Visible = false;
            }
        }

        private void InitTextBox()
        {
            if (reader_book == null)
            {
                reader_book = new Карта_Читателя();
                наименовниеTextBox.Text = "";
                GetDateText.Text = "";
                return;
            }

            наименовниеTextBox.Text = DataContext.Select<Книги>().Where(o => o.ID == reader_book.Книга_ID).First().Наименовние;
            GetDateText.Text = reader_book.Дата_заказа.ToString();
            if (reader_book.Дата_возврата == null)
            {
                BackdateTimePicker.Value = BackdateTimePicker.MinDate;
            }
            else
            {
                BackdateTimePicker.Value = (DateTime)reader_book.Дата_возврата;
            }
        }

        private void PriviousItem_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    booksGrid.Rows[rowIndex].Selected = false;
            //}
            //catch (Exception)
            //{

            //}

            //try
            //{
            //    rowIndex -= 1;
            //    if (rowIndex < 0)
            //    {
            //        throw new Exception();
            //    }

            //    int id = reader_booklist[rowIndex].Id;
            //    reader_book = DataContext.Select<Карта_Читателя>().Where(o => o.ID == id).First();
            //}
            //catch (Exception)
            //{
            //    rowIndex = booksGrid.Rows.Count - 1;
            //    reader_book = DataContext.Select<Карта_Читателя>().ToList().Last();

            //}
            //finally
            //{
            //    booksGrid.Rows[rowIndex].Selected = true;
            //    InitTextBox();
            //}
        }

        private void наименовниеTextBox_Click(object sender, EventArgs e)
        {
            this.Hide();
            (new SelectBookWindow(this)).Show();
        }

        //private void NextItem_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        booksGrid.Rows[rowIndex].Selected = false;
        //    }
        //    catch (Exception)
        //    {

        //    }

        //    try
        //    {
        //        rowIndex += 1;
        //        if (reader_booklist.Count <= rowIndex)
        //        {
        //            throw new Exception();
        //        }

        //        int id = reader_booklist[rowIndex].Id;
        //        reader_book = DataContext.Select<Карта_Читателя>().Where(o => o.ID == id).First();

        //    }
        //    catch (Exception)
        //    {
        //        rowIndex = 0;
        //        reader_book = DataContext.Select<Карта_Читателя>().FirstOrDefault();
        //    }
        //    finally
        //    {
        //        booksGrid.Rows[rowIndex].Selected = true;
        //        InitTextBox();
        //    }
        //}

        private void SaveChanges_Click(object sender, EventArgs e)
        {
        //    if (reader_book.ID == -1)
        //    {
        //        int id = DataContext.Select<Карта_Читателя>().ToList().Last().ID;
        //        reader_book.ID = id + 1;
        //    }

        //    reader_book.Имя = наименовниеTextBox.Text;
        //    reader_book.Фамилия = FamiliaText.Text;
        //    reader_book.Номер_телефона = NumberText.Text;

        //    if (DataContext.Select<Карта_Читателя>().Where(o => o.ID == reader_book.ID).FirstOrDefault() != null)
        //    {
        //        DataContext.Update<Карта_Читателя>(DataContext.Select<Карта_Читателя>().Where(o => o.ID == reader_book.ID).First());
        //    }
        //    else
        //    {
        //        DataContext.Insert<Карта_Читателя>(reader_book);
        //    }
        //    InitList();
        //    InitGrid();
        }

        //private void AddButton_Click(object sender, EventArgs e)
        //{
        //    reader_book = new Карта_Читателя();
        //    reader_book.ID = -1;
        //    наименовниеTextBox.Text = "";

        //    FamiliaText.Text = "";
        //    NumberText.Text = "";
        //}

        //private void BooksWindow_FormClosing(object sender, FormClosingEventArgs e)
        //{
        //    this.Owner.Show();
        //}

        //private void textBox1_TextChanged(object sender, EventArgs e)
        //{
        //    if (textBox1.Text != "")
        //    {
        //        booksGrid.DataSource = reader_booklist.Where(u => u.Имя.ToLower().Contains(textBox1.Text.ToLower())).ToList();

        //    }
        //    else
        //    {
        //        InitGrid();
        //    }
        //}

        //private void booksGrid_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        //{
        //    int columnIndex = e.ColumnIndex;
        //    if (sortOrder)
        //    {
        //        switch (columnIndex)
        //        {
        //            case 1:
        //                InitGrid(reader_booklist.OrderBy(o => o.Имя).ToList<ReaderBooks>());
        //                break;
        //            case 2:
        //                InitGrid(reader_booklist.OrderBy(o => o.Фамилия).ToList<ReaderBooks>());
        //                break;
        //            case 3:
        //                InitGrid(reader_booklist.OrderBy(o => o.Номер_телефона).ToList<ReaderBooks>());
        //                break;

        //        }
        //    }
        //    else
        //    {
        //        switch (columnIndex)
        //        {
        //            case 1:
        //                InitGrid(reader_booklist.OrderByDescending(o => o.Имя).ToList<ReaderBooks>());
        //                break;
        //            case 2:
        //                InitGrid(reader_booklist.OrderByDescending(o => o.Фамилия).ToList<ReaderBooks>());
        //                break;
        //            case 3:
        //                InitGrid(reader_booklist.OrderByDescending(o => o.Номер_телефона).ToList<ReaderBooks>());
        //                break;
        //        }

        //    }

        //    sortOrder = !sortOrder;

        //}

        //private void StatusWindow_Load(object sender, EventArgs e)
        //{

        //}

        //private void StatusWindow_FormClosing(object sender, FormClosingEventArgs e)
        //{
        //    this.Owner.Show();
        //}

        //private void Delete_Button_Click(object sender, EventArgs e)
        //{
        //    DataContext.Delete<Карта_Читателя>(reader_book);
        //    NextItem_Click(this, e);
        //    InitList();
        //    InitTextBox();
        //    InitGrid();
        //}
    }

    public class ReaderBooks
    {
        string id;
        string книга;
        int книгаID;
        DateTime датаПолучения;
        DateTime? возврата;

        public ReaderBooks(string id, string книга, int книгаID, DateTime датаПолучения, DateTime? возврата)
        {
            this.id = id;
            this.книга = книга;
            this.КнигаID = книгаID;
            this.датаПолучения = датаПолучения;
            this.возврата = возврата;
        }

        public string Id { get => id; set => id = value; }
        public string Книга { get => книга; set => книга = value; }
        public DateTime ДатаПолучения { get => датаПолучения; set => датаПолучения = value; }
        public DateTime? Возврата { get => возврата; set => возврата = value; }
        public int КнигаID { get => книгаID; set => книгаID = value; }
    }
}
