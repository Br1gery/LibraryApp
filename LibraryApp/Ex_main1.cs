using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryApp
{
    public partial class Ex_main1 : Form
    {
        public Ex_main1()
        {
            InitializeComponent();
        }

        private void Ex_main1_Load(object sender, EventArgs e)
        {
            loc_combo.DataSource = DB.DataBase.Locations.ToList();
            loc_combo.DisplayMember = "Location";
            loc_combo.ValueMember = "id";

            book_combo.DataSource = DB.DataBase.Books.ToList();
            book_combo.DisplayMember = "Name";
            book_combo.ValueMember = "id";

            loc__combo2.DataSource = DB.DataBase.Locations.ToList();
            loc__combo2.DisplayMember = "Location";
            loc__combo2.ValueMember = "id";

            book_combo2.DataSource = DB.DataBase.Books.ToList();
            book_combo2.DisplayMember = "Name";
            book_combo2.ValueMember = "id";

        }
    }
}
