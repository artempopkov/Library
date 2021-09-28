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
    public partial class AccountingWindow : Form
    {
        Учёт accounting;
        List<Accounting> accountinglist;
        bool sortOrder = false;
        int rowIndex = 0;
        public AccountingWindow(Form owner)
        {
            this.Owner = owner;
            InitializeComponent();
            accounting = DataContext.Select<Учёт>().FirstOrDefault();
            InitList();
            //InitTextBox();
            InitGrid();
            InitComboBox();
        }

        private void AccountingWindow_Load(object sender, EventArgs e)
        {

        }

        private void InitList()
        {
            accountinglist = new List<Accounting>();
            var ls = DataContext.Select<Учёт>().Select(p => new
            {
                ID = p.ID,
                Книга = p.Книги,
                Статус = p.Статусы
            }).ToList();

            foreach (var item in ls)
            {
                accountinglist.Add(new Accounting(item.ID, item.Книга.Наименовние, item.Статус.Статус));
            }
        }

        private void status_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            (new StatusWindow(this)).Show();
        }
        private void InitGrid(List<Status> ls = null)
        {
            if (ls != null)
            {
                booksGrid.DataSource = ls;
                booksGrid.Columns["ID"].Visible = false;
            }
            else
            {
                booksGrid.DataSource = accountinglist;
                booksGrid.Columns["ID"].Visible = false;
            }
        }

        private void InitComboBox()
        {
            var listBook = DataContext.Select<Книги>();
            var listStatus= DataContext.Select<Статусы>();
            //if (listBook != null)
            //{
            //    foreach (var item in listBook)
            //    {
            //        КнигаComboBox.Items.Add(item);

            //    }
            //}

            КнигаComboBox.DataSource = DataContext.Select<Книги>().Select(p => new
            {
                Книга = p.Наименовние,
                Шифр = p.Шифр
            }).ToList();

            //if (listStatus != null)
            //{
            //    foreach (var item in listStatus)
            //    {
            //        СтатусComboBox.Items.Add(item);
            //    }
            //}
            СтатусComboBox.DataSource = DataContext.Select<Статусы>().Select(p => new
            {
                Статус = p.Статус
            }).ToList();


        }

        private void InitTextBox()
        {
            if (accounting == null)
            {
                accounting = new Учёт();
                return;
            }

            foreach (var item in КнигаComboBox.Items)
            {
                if (item.GetHashCode() == accounting.Книги.Шифр.GetHashCode())
                    КнигаComboBox.SelectedItem = item;
            }
            foreach (var item in СтатусComboBox.Items)
            {
                if (item.GetHashCode() == accounting.Статусы.GetHashCode())
                    СтатусComboBox.SelectedItem = item;
            }

            // наименовниеTextBox.Text = accounting.Статус;
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

                int id = accountinglist[rowIndex].Id;
                accounting = DataContext.Select<Учёт>().Where(o => o.ID == id).First();
            }
            catch (Exception)
            {
                rowIndex = booksGrid.Rows.Count - 1;
                accounting = DataContext.Select<Учёт>().ToList().Last();

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
                if (accountinglist.Count <= rowIndex)
                {
                    throw new Exception();
                }

                int id = accountinglist[rowIndex].Id;
                accounting = DataContext.Select<Учёт>().Where(o => o.ID == id).First();

            }
            catch (Exception)
            {
                rowIndex = 0;
                accounting = DataContext.Select<Учёт>().FirstOrDefault();
            }
            finally
            {
                booksGrid.Rows[rowIndex].Selected = true;
                InitTextBox();
            }
        }

        private void SaveChanges_Click(object sender, EventArgs e)
        {
            if (accounting.ID == -1)
            {
                int id = DataContext.Select<Учёт>().ToList().Last().ID;
                accounting.ID = id + 1;
            }

           // accounting.Статус = наименовниеTextBox.Text;

            if (DataContext.Select<Учёт>().Where(o => o.ID == accounting.ID).FirstOrDefault() != null)
            {
                DataContext.Update<Учёт>(DataContext.Select<Учёт>().Where(o => o.ID == accounting.ID).First());
            }
            else
            {
                DataContext.Insert<Учёт>(accounting);
            }
            InitList();
            InitGrid();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            accounting = new Учёт();
            accounting.ID = -1;
        }

        private void BooksWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Owner.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                //booksGrid.DataSource = accountinglist.Where(u => u.Наименование.ToLower().Contains(textBox1.Text.ToLower())).ToList();

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
                        //InitGrid(accountinglist.OrderBy(o => o.Наименование).ToList<Status>());
                        break;

                }
            }
            else
            {
                switch (columnIndex)
                {
                    case 1:
                       // InitGrid(accountinglist.OrderByDescending(o => o.Наименование).ToList<Status>());
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
            DataContext.Delete<Учёт>(accounting);
            NextItem_Click(this, e);
            InitList();
            InitTextBox();
            InitGrid();
        }
    }
    public class Accounting
    {
        int id;
        string book;
        string status;

        public Accounting(int id, string id_book, string id_status)
        {
            this.Id = id;
            this.Book = id_book;
            this.Status = id_status;
        }

        public int Id { get => id; set => id = value; }
        public string Book { get => book; set => book = value; }
        public string Status { get => status; set => status = value; }
    }
}
