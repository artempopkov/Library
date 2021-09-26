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
    public partial class CategoryWindow : Form
    {
        Категории category;
        List<Category> categorylist;
        bool sortOrder = false;
        int rowIndex = 0;

        public CategoryWindow(Form owner)
        {
            this.Owner = owner;
            InitializeComponent();
            category = DataContext.Select<Категории>().FirstOrDefault();
            InitList();
            InitTextBox();
            InitGrid();
        }

        private void CategoryWindow_Load(object sender, EventArgs e)
        {

        }

        private void CategoryWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Owner.Show();
        }

        private void InitList()
        {
            categorylist = new List<Category>();
            var ls = DataContext.Select<Категории>().Select(p => new
            {
                ID = p.ID,
                Наименование = p.Наименование
            }).ToList();

            foreach (var item in ls)
            {
                categorylist.Add(new Category(item.ID, item.Наименование));
            }
        }

        private void status_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            (new StatusWindow(this)).Show();
        }
        private void InitGrid(List<Category> ls = null)
        {
            if (ls != null)
            {
                booksGrid.DataSource = ls;
                booksGrid.Columns["ID"].Visible = false;
            }
            else
            {
                booksGrid.DataSource = categorylist;
                booksGrid.Columns["ID"].Visible = false;
            }
        }

        private void InitTextBox()
        {
            if (category == null)
            {
                category = new Категории();
                наименовниеTextBox.Text = "";
                return;
            }

            наименовниеTextBox.Text = category.Наименование;
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

                int id = categorylist[rowIndex].Id;
                category = DataContext.Select<Категории>().Where(o => o.ID == id).First();
            }
            catch (Exception)
            {
                rowIndex = booksGrid.Rows.Count - 1;
                category = DataContext.Select<Категории>().ToList().Last();
                
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
            catch(Exception)
            {

            }
            
            try
            {
                rowIndex += 1;
                if (categorylist.Count <= rowIndex)
                {
                    throw new Exception();
                }

                int id = categorylist[rowIndex].Id;
                category = DataContext.Select<Категории>().Where(o => o.ID == id).First();
                
            }
            catch (Exception)
            {
                rowIndex = 0;
                category = DataContext.Select<Категории>().FirstOrDefault();
            }
            finally
            {
                booksGrid.Rows[rowIndex].Selected = true;
                InitTextBox();
            }
        }

        private void SaveChanges_Click(object sender, EventArgs e)
        {
            if (category.ID == -1)
            {
                int id = DataContext.Select<Категории>().ToList().Last().ID;
                category.ID = id + 1;
            }

            category.Наименование = наименовниеTextBox.Text;

            if (DataContext.Select<Категории>().Where(o => o.ID == category.ID).FirstOrDefault() != null)
            {
                DataContext.Update<Категории>(DataContext.Select<Категории>().Where(o => o.ID == category.ID).First());
            }
            else
            {
                DataContext.Insert<Категории>(category);
            }
            InitList();
            InitGrid();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            category = new Категории();
            category.ID = -1;
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
                booksGrid.DataSource = categorylist.Where(u => u.Наименование.ToLower().Contains(textBox1.Text.ToLower())).ToList();

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
                        InitGrid(categorylist.OrderBy(o => o.Наименование).ToList<Category>());
                        break;

                }
            }
            else
            {
                switch (columnIndex)
                {
                    case 1:
                        InitGrid(categorylist.OrderByDescending(o => o.Наименование).ToList<Category>());
                        break;
                }

            }

            sortOrder = !sortOrder;

        }

        private void Delete_Button_Click(object sender, EventArgs e)
        {
            DataContext.Delete<Категории>(category);
            InitList();
            NextItem_Click(this, e);
            InitTextBox();
            InitGrid();
        }
    }
    public class Category
    {
        int id;
        string наименование;

        public Category(int id, string наименование)
        {
            this.id = id;
            this.наименование = наименование;
        }

        public int Id { get => id; set => id = value; }
        public string Наименование { get => наименование; set => наименование = value; }
    }

}
