using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;

namespace LibraryApp
{
    public partial class Books_main2 : Form
    {
        public Books_main2()
        {
            InitializeComponent();
        }

        private void Books_main2_Load(object sender, EventArgs e)
        {
            DB.DataBase.Books.Load();
            DB.DataBase.Books.Include(t => t.Author).Load();
            DB.DataBase.Books.Include(t => t.Genre).Load();
            DB.DataBase.Books.Include(t => t.Publisher).Load();
            dataGridView1.DataSource = DB.DataBase.Books.Local.ToBindingList();
        }
    }
}
