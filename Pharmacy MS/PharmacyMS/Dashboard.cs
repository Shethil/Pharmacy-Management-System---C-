using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PharmacyMS
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void btnDashbord_Click(object sender, EventArgs e)
        {
            Dashboard db = new Dashboard();
            db.Show();
            this.Hide();
        }

        private void btnAddMedicine_Click(object sender, EventArgs e)
        {
            AddMedicine am = new AddMedicine();
            am.Show();
            this.Hide();
        }

        private void btnViewMedicine_Click(object sender, EventArgs e)
        {
            ViewMedicine vm = new ViewMedicine();
            vm.Show();
            this.Close();
        }

        private void btnModifyMedicine_Click(object sender, EventArgs e)
        {
            ModifyMedicine mf = new ModifyMedicine();
            mf.Show();
            this.Close();
        }

        private void butLogout_Click(object sender, EventArgs e)
        {
            Form1 fm = new Form1();
            fm.Show();
            this.Hide();
        }
    }
}
