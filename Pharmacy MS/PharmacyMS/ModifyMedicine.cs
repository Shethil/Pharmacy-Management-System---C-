using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PharmacyMS
{
    public partial class ModifyMedicine : Form
    {
        function fn = new function();

        string query;  
        public ModifyMedicine()
        {
            InitializeComponent();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            if (txtMedicineID.Text != " " && txtMedicineName.Text != "" && txtMedicineNumber.Text != "" && txtPricePerUnit.Text != "" && txtQuantity.Text != " ")

            {
                String mid = txtMedicineID.Text;
                String mname = txtMedicineName.Text;
                String number = txtMedicineNumber.Text;
                Int64 quantity = Int64.Parse(txtQuantity.Text);
                String mdate = dateTimePicker1.Text;
                String edate = dateTimePicker2.Text;
                Int64 price = Int64.Parse(txtPricePerUnit.Text);

                query = "update  Medicine set Medicine_ID='" + mid + "',Medicine_Name='" + mname + "',Number='" + number + "',Quantity=" + quantity + ",mDate='" + mdate + "',eDate'" + edate + "',Price_Per_Unit=" + price + " where Medicine_ID='" + mid + "' ";
                fn.setData2(query, "Updated");


            }

            else
            {
                MessageBox.Show("Enter All data");
            }
        }

        private void btnModifyMedicine_Click(object sender, EventArgs e)
        {
            ModifyMedicine mf = new ModifyMedicine();
            mf.Show();
            this.Close();
        }

        private void btnViewMedicine_Click(object sender, EventArgs e)
        {
            ViewMedicine vm = new ViewMedicine();
            vm.Show();
            this.Close();
        }

        private void btnAddMedicine_Click(object sender, EventArgs e)
        {
            AddMedicine am = new AddMedicine();
            am.Show();
            this.Hide();
        }

        private void butLogout_Click(object sender, EventArgs e)
        {
            Form1 fm = new Form1();
            fm.Show();
            this.Hide();
        }

        private void btnDashbord_Click(object sender, EventArgs e)
        {
            Dashboard db = new Dashboard();
            db.Show();
            this.Hide();
        }
    }
}
