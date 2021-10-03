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
    public partial class ReadersWindow : Form
    {
        Читатели reader;
        List<Reader> readerlist;
        bool sortOrder = false;
        int rowIndex = 0;
        public ReadersWindow(Form owner)
        {
            InitializeComponent();
            this.Owner = owner;
            reader = DataContext.Select<Читатели>().FirstOrDefault();
            InitList();
            InitTextBox();
            InitGrid();
        }

        private void ReadersWindow_Load(object sender, EventArgs e)
        {
            
        }

        private void InitList()
        {
            readerlist = new List<Reader>();
            var ls = DataContext.Select<Читатели>().Select(p => new
            {
                ID = p.ID,
                Имя = p.Иия,
                Фамилия = p.Фамилия,
                Номер_телефона = p.Номер_телефона

            }).ToList();

            foreach (var item in ls)
            {
                readerlist.Add(new Reader(item.ID, item.Имя, item.Фамилия, item.Номер_телефона));
            }
        }

        private void status_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            (new StatusWindow(this)).Show();
        }
        private void InitGrid(List<Reader> ls = null)
        {
            if (ls != null)
            {
                booksGrid.DataSource = ls;
                booksGrid.Columns["ID"].Visible = false;
            }
            else
            {
                booksGrid.DataSource = readerlist;
                booksGrid.Columns["ID"].Visible = false;
            }
        }

        private void InitTextBox()
        {
            if (reader == null)
            {
                reader = new Читатели();
                наименовниеTextBox.Text = "";
                FamiliaText.Text = "";
                NumberText.Text = "";
                return;
            }

            наименовниеTextBox.Text = reader.Иия;
            FamiliaText.Text = reader.Фамилия;
            NumberText.Text = reader.Номер_телефона;
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

                int id = readerlist[rowIndex].Id;
                reader = DataContext.Select<Читатели>().Where(o => o.ID == id).First();
            }
            catch (Exception)
            {
                rowIndex = booksGrid.Rows.Count - 1;
                reader = DataContext.Select<Читатели>().ToList().Last();

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
                if (readerlist.Count <= rowIndex)
                {
                    throw new Exception();
                }

                int id = readerlist[rowIndex].Id;
                reader = DataContext.Select<Читатели>().Where(o => o.ID == id).First();

            }
            catch (Exception)
            {
                rowIndex = 0;
                reader = DataContext.Select<Читатели>().FirstOrDefault();
            }
            finally
            {
                booksGrid.Rows[rowIndex].Selected = true;
                InitTextBox();
            }
        }

        private void SaveChanges_Click(object sender, EventArgs e)
        {
            if (reader.ID == -1)
            {
                int id = DataContext.Select<Читатели>().ToList().Last().ID;
                reader.ID = id + 1;
            }

            reader.Иия = наименовниеTextBox.Text;
            reader.Фамилия = FamiliaText.Text;
            reader.Номер_телефона = NumberText.Text;

            if (DataContext.Select<Читатели>().Where(o => o.ID == reader.ID).FirstOrDefault() != null)
            {
                DataContext.Update<Читатели>(DataContext.Select<Читатели>().Where(o => o.ID == reader.ID).First());
            }
            else
            {
                DataContext.Insert<Читатели>(reader);
            }
            InitList();
            InitGrid();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            reader = new Читатели();
            reader.ID = -1;
            наименовниеTextBox.Text = "";

            FamiliaText.Text = "";
            NumberText.Text = "";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                booksGrid.DataSource = readerlist.Where(u => u.Имя.ToLower().Contains(textBox1.Text.ToLower())).ToList();

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
                        InitGrid(readerlist.OrderBy(o => o.Имя).ToList<Reader>());
                        break;
                    case 2:
                        InitGrid(readerlist.OrderBy(o => o.Фамилия).ToList<Reader>());
                        break;
                    case 3:
                        InitGrid(readerlist.OrderBy(o => o.Номер_телефона).ToList<Reader>());
                        break;

                }
            }
            else
            {
                switch (columnIndex)
                {
                    case 1:
                        InitGrid(readerlist.OrderByDescending(o => o.Имя).ToList<Reader>());
                        break;
                    case 2:
                        InitGrid(readerlist.OrderByDescending(o => o.Фамилия).ToList<Reader>());
                        break;
                    case 3:
                        InitGrid(readerlist.OrderByDescending(o => o.Номер_телефона).ToList<Reader>());
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
            DataContext.Delete<Читатели>(reader);
            NextItem_Click(this, e);
            InitList();
            InitTextBox();
            InitGrid();
        }

        private void ReadersWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Owner.Show();
        }

        private void ReaderBookButton_Click(object sender, EventArgs e)
        {
            if (reader == null)
            {
                MessageBox.Show("Выберите или добавьте читателя!");
                return;
            }
            this.Hide();
            (new ReaderBook(this, reader.ID)).Show();
        }
    }

    public class Reader
    {
        int id;
        string имя;
        string фамилия;
        string номер_телефона;

        public Reader(int id, string имя, string фамилия, string номер_телефона)
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
