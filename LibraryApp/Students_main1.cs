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
    public partial class Students_main1 : Form
    {
        public Students_main1()
        {
            InitializeComponent();
        }

        private void Students_main1_Load(object sender, EventArgs e)
        {
            group_combo.DataSource = DB.DataBase.Groups.ToList();
            group_combo.DisplayMember = "Group";
            group_combo.ValueMember = "id";

            gender_combo.DataSource = DB.DataBase.Genders.ToList();
            gender_combo.DisplayMember = "Gender";
            gender_combo.ValueMember = "id";

            group_combo2.DataSource = DB.DataBase.Groups.ToList();
            group_combo2.DisplayMember = "Group";
            group_combo2.ValueMember = "id";

            gender_combo2.DataSource = DB.DataBase.Genders.ToList();
            gender_combo2.DisplayMember = "Gender";
            gender_combo2.ValueMember = "id";
        }
    }
}
