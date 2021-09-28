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
        Учёт status;
        List<Status> statuslist;
        bool sortOrder = false;
        int rowIndex = 0;
        public AccountingWindow(Form owner)
        {
            this.Owner = owner;
            InitializeComponent();
            status = DataContext.Select<Учёт>().FirstOrDefault();
            InitList();
            InitTextBox();
            InitGrid();
        }

        private void AccountingWindow_Load(object sender, EventArgs e)
        {

        }

        private void InitList()
        {
            statuslist = new List<Status>();
            var ls = DataContext.Select<Учёт>().Select(p => new
            {
                ID = p.ID,
                Наименование = p.Статус
            }).ToList();

            foreach (var item in ls)
            {
                statuslist.Add(new Status(item.ID, item.Наименование));
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
                booksGrid.DataSource = statuslist;
                booksGrid.Columns["ID"].Visible = false;
            }
        }

        private void InitTextBox()
        {
            if (status == null)
            {
                status = new Учёт();
                наименовниеTextBox.Text = "";
                return;
            }

            наименовниеTextBox.Text = status.Статус;
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

                int id = statuslist[rowIndex].Id;
                status = DataContext.Select<Учёт>().Where(o => o.ID == id).First();
            }
            catch (Exception)
            {
                rowIndex = booksGrid.Rows.Count - 1;
                status = DataContext.Select<Учёт>().ToList().Last();

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
                if (statuslist.Count <= rowIndex)
                {
                    throw new Exception();
                }

                int id = statuslist[rowIndex].Id;
                status = DataContext.Select<Учёт>().Where(o => o.ID == id).First();

            }
            catch (Exception)
            {
                rowIndex = 0;
                status = DataContext.Select<Учёт>().FirstOrDefault();
            }
            finally
            {
                booksGrid.Rows[rowIndex].Selected = true;
                InitTextBox();
            }
        }

        private void SaveChanges_Click(object sender, EventArgs e)
        {
            if (status.ID == -1)
            {
                int id = DataContext.Select<Учёт>().ToList().Last().ID;
                status.ID = id + 1;
            }

            status.Статус = наименовниеTextBox.Text;

            if (DataContext.Select<Учёт>().Where(o => o.ID == status.ID).FirstOrDefault() != null)
            {
                DataContext.Update<Учёт>(DataContext.Select<Учёт>().Where(o => o.ID == status.ID).First());
            }
            else
            {
                DataContext.Insert<Учёт>(status);
            }
            InitList();
            InitGrid();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            status = new Учёт();
            status.ID = -1;
            наименовниеTextBox.Text = "";
        }

        private void BooksWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Owner.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                booksGrid.DataSource = statuslist.Where(u => u.Наименование.ToLower().Contains(textBox1.Text.ToLower())).ToList();

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
                        InitGrid(statuslist.OrderBy(o => o.Наименование).ToList<Status>());
                        break;

                }
            }
            else
            {
                switch (columnIndex)
                {
                    case 1:
                        InitGrid(statuslist.OrderByDescending(o => o.Наименование).ToList<Status>());
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
            DataContext.Delete<Учёт>(status);
            NextItem_Click(this, e);
            InitList();
            InitTextBox();
            InitGrid();
        }
    }
    public class Accounting
    {
        int id;
        int id_book;
        int id_status;
        string наименование;

        public Accounting(int id, int id_book, int id_status, string наименование)
        {
            this.id = id;
            this.id_book = id_book;
            this.id_status = id_status;
            this.наименование = наименование;
        }
    }
}
