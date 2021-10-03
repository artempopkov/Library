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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void BooksWindow_Click(object sender, EventArgs e)
        {
            this.Hide();
            BooksWindow window = new BooksWindow(this);
            window.Show();
            
        }

        private void ReadersWindow_Click(object sender, EventArgs e)
        {
            this.Hide();
            (new ReadersWindow(this)).Show();
        }
    }
}
