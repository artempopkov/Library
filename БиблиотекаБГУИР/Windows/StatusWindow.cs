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
    public partial class StatusWindow : Form
    {
        Статусы status;
        List<Status> statuslist;
        bool sortOrder = false;
        int rowIndex = 0;
        public StatusWindow(Form owner)
        {
            this.Owner = owner;
            InitializeComponent();
            status = DataContext.Select<Статусы>().FirstOrDefault();
            InitList();
            InitTextBox();
            InitGrid();
        }


        private void BooksWindow_Load(object sender, EventArgs e)
        {

        }

        private void InitList()
        {
            statuslist = new List<Status>();
            var ls = DataContext.Select<Статусы>().Select(p => new
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
                status = new Статусы();
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
                status = DataContext.Select<Статусы>().Where(o => o.ID == id).First();
            }
            catch (Exception)
            {
                rowIndex = booksGrid.Rows.Count - 1;
                status = DataContext.Select<Статусы>().ToList().Last();

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
                status = DataContext.Select<Статусы>().Where(o => o.ID == id).First();

            }
            catch (Exception)
            {
                rowIndex = 0;
                status = DataContext.Select<Статусы>().FirstOrDefault();
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
                int id = DataContext.Select<Статусы>().ToList().Last().ID;
                status.ID = id + 1;
            }

            status.Статус = наименовниеTextBox.Text;
           
            if (DataContext.Select<Статусы>().Where(o => o.ID == status.ID).FirstOrDefault() != null)
            {
                DataContext.Update<Статусы>(DataContext.Select<Статусы>().Where(o => o.ID == status.ID).First());
            }
            else
            {
                DataContext.Insert<Статусы>(status);
            }
            InitList();
            InitGrid();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            status = new Статусы();
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
            DataContext.Delete<Статусы>(status);
            NextItem_Click(this, e);
            InitList();
            InitTextBox();
            InitGrid();
        }

    }

    public class Status
    {
        int id;
        string наименование;

        public Status(int id, string наименование)
        {
            this.id = id;
            this.наименование = наименование;
        }

        public int Id { get => id; set => id = value; }
        public string Наименование { get => наименование; set => наименование = value; }
    }
}
