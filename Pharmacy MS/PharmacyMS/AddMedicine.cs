using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PharmacyMS
{
    public partial class AddMedicine : Form
    {
        function fn = new function();

        string query;
        public AddMedicine()
        {
            InitializeComponent();
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

        

        private void btnSingIn_Click(object sender, EventArgs e)
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

                query = "insert into Medicine  (Medicine_ID,Medicine_Name,Number,Quantity,mDate,eDate,Price_Per_Unit) values('" + mid + "','" + mname + "','" + number + "'," + quantity + ",'" + mdate + "','" + edate + "'," + price + ") ";
                fn.setData(query, "Medicine Adeed to Database");

                

                //query = "UPDATE Medicine (Medicine_ID, Medicine_Name, Number, Quantity, mDate,  eDate, Price_Per_Unit) VALUES (@mid, @mname, @number, @quantity, @mdate, @edate, price) WHERE Medicine_ID='004'";
                //fn.setData(query, "Updated");

                //query = "UPDATE Medicine SET Medicine_ID='" + mid + "',Medicine_Name='" + mname + "' WHERE Medicine_ID='004'";
                //fn.setData(query, "Medicine Adeed to Database");

                //query = "insert into Medicine  (Medicine_ID,Medicine_Name,Number,Quantity,mDate,eDate,Price_Per_Unit) values('" + mid + "','" + mname + "','" + number + "'," + quantity + ",'" + mdate + "','" + edate + "'," + price + ") where Medicine_ID='" + mid + "' ";
                //fn.setData(query, "Medicine Adeed to Database");
            }

            else
            {
                MessageBox.Show("Enter All data");
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtMedicineID.Clear();
            txtMedicineName.Clear();
            txtMedicineNumber.Clear();
            txtPricePerUnit.Clear();
            txtQuantity.Clear();
            dateTimePicker1.ResetText();
            dateTimePicker2.ResetText();
        }

        private void btnModifyMedicine_Click(object sender, EventArgs e)
        {
            ModifyMedicine mf = new ModifyMedicine();
            mf.Show();
            this.Close();
        }
    }
}
