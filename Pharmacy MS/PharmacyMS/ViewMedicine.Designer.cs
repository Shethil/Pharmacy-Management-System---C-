
namespace PharmacyMS
{
    partial class ViewMedicine
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewMedicine));
            this.butLogout = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSellMedicine = new System.Windows.Forms.Button();
            this.btnMedicineVelidityCkeck = new System.Windows.Forms.Button();
            this.btnModifyMedicine = new System.Windows.Forms.Button();
            this.btnViewMedicine = new System.Windows.Forms.Button();
            this.btnAddMedicine = new System.Windows.Forms.Button();
            this.btnDashbord = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.dtMedicines = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtMedicines)).BeginInit();
            this.SuspendLayout();
            // 
            // butLogout
            // 
            this.butLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.butLogout.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            this.butLogout.Location = new System.Drawing.Point(45, 408);
            this.butLogout.Name = "butLogout";
            this.butLogout.Size = new System.Drawing.Size(156, 28);
            this.butLogout.TabIndex = 11;
            this.butLogout.Text = "Log out";
            this.butLogout.UseVisualStyleBackColor = false;
            this.butLogout.Click += new System.EventHandler(this.butLogout_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.butLogout);
            this.panel1.Controls.Add(this.btnSellMedicine);
            this.panel1.Controls.Add(this.btnMedicineVelidityCkeck);
            this.panel1.Controls.Add(this.btnModifyMedicine);
            this.panel1.Controls.Add(this.btnViewMedicine);
            this.panel1.Controls.Add(this.btnAddMedicine);
            this.panel1.Controls.Add(this.btnDashbord);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, -10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(246, 515);
            this.panel1.TabIndex = 4;
            // 
            // btnSellMedicine
            // 
            this.btnSellMedicine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnSellMedicine.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnSellMedicine.Location = new System.Drawing.Point(45, 375);
            this.btnSellMedicine.Name = "btnSellMedicine";
            this.btnSellMedicine.Size = new System.Drawing.Size(156, 28);
            this.btnSellMedicine.TabIndex = 10;
            this.btnSellMedicine.Text = "Sell Medicine";
            this.btnSellMedicine.UseVisualStyleBackColor = false;
            // 
            // btnMedicineVelidityCkeck
            // 
            this.btnMedicineVelidityCkeck.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnMedicineVelidityCkeck.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnMedicineVelidityCkeck.Location = new System.Drawing.Point(45, 342);
            this.btnMedicineVelidityCkeck.Name = "btnMedicineVelidityCkeck";
            this.btnMedicineVelidityCkeck.Size = new System.Drawing.Size(156, 28);
            this.btnMedicineVelidityCkeck.TabIndex = 9;
            this.btnMedicineVelidityCkeck.Text = "Medicine velidity check";
            this.btnMedicineVelidityCkeck.UseVisualStyleBackColor = false;
            // 
            // btnModifyMedicine
            // 
            this.btnModifyMedicine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnModifyMedicine.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnModifyMedicine.Location = new System.Drawing.Point(45, 309);
            this.btnModifyMedicine.Name = "btnModifyMedicine";
            this.btnModifyMedicine.Size = new System.Drawing.Size(156, 28);
            this.btnModifyMedicine.TabIndex = 8;
            this.btnModifyMedicine.Text = "Modify Medicine";
            this.btnModifyMedicine.UseVisualStyleBackColor = false;
            this.btnModifyMedicine.Click += new System.EventHandler(this.btnModifyMedicine_Click);
            // 
            // btnViewMedicine
            // 
            this.btnViewMedicine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnViewMedicine.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnViewMedicine.Location = new System.Drawing.Point(45, 276);
            this.btnViewMedicine.Name = "btnViewMedicine";
            this.btnViewMedicine.Size = new System.Drawing.Size(156, 28);
            this.btnViewMedicine.TabIndex = 7;
            this.btnViewMedicine.Text = "View Medicine";
            this.btnViewMedicine.UseVisualStyleBackColor = false;
            this.btnViewMedicine.Click += new System.EventHandler(this.btnViewMedicine_Click);
            // 
            // btnAddMedicine
            // 
            this.btnAddMedicine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnAddMedicine.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnAddMedicine.Location = new System.Drawing.Point(45, 244);
            this.btnAddMedicine.Name = "btnAddMedicine";
            this.btnAddMedicine.Size = new System.Drawing.Size(156, 28);
            this.btnAddMedicine.TabIndex = 6;
            this.btnAddMedicine.Text = "Add Medicine";
            this.btnAddMedicine.UseVisualStyleBackColor = false;
            this.btnAddMedicine.Click += new System.EventHandler(this.btnAddMedicine_Click);
            // 
            // btnDashbord
            // 
            this.btnDashbord.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnDashbord.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnDashbord.Location = new System.Drawing.Point(45, 211);
            this.btnDashbord.Name = "btnDashbord";
            this.btnDashbord.Size = new System.Drawing.Size(156, 28);
            this.btnDashbord.TabIndex = 5;
            this.btnDashbord.Text = "Dashbord";
            this.btnDashbord.UseVisualStyleBackColor = false;
            this.btnDashbord.Click += new System.EventHandler(this.btnDashbord_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(42, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(156, 117);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(69, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pharmacist";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.dtMedicines);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(244, -10);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(552, 515);
            this.panel2.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.button1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(257, 420);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(74, 28);
            this.button1.TabIndex = 12;
            this.button1.Text = "Load";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // dtMedicines
            // 
            this.dtMedicines.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.dtMedicines.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtMedicines.Location = new System.Drawing.Point(38, 89);
            this.dtMedicines.Name = "dtMedicines";
            this.dtMedicines.Size = new System.Drawing.Size(497, 314);
            this.dtMedicines.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(33, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 29);
            this.label2.TabIndex = 6;
            this.label2.Text = "View Medicine";
            // 
            // ViewMedicine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 497);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ViewMedicine";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewMedicine";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtMedicines)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button butLogout;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSellMedicine;
        private System.Windows.Forms.Button btnMedicineVelidityCkeck;
        private System.Windows.Forms.Button btnModifyMedicine;
        private System.Windows.Forms.Button btnViewMedicine;
        private System.Windows.Forms.Button btnAddMedicine;
        private System.Windows.Forms.Button btnDashbord;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dtMedicines;
    }
}