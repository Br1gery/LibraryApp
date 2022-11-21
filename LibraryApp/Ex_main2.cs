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
    public partial class Ex_main2 : Form
    {
        public Ex_main2()
        {
            InitializeComponent();
        }

        private void Ex_main2_Load(object sender, EventArgs e)
        {
            DB.DataBase.Examples.Load();
            dataGridView1.DataSource = DB.DataBase.Examples.Local.ToBindingList();
        }
    }
}
