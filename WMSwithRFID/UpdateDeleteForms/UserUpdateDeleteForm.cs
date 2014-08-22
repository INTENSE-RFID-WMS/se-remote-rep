using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WMSwithRFID.Domain_Classes;

namespace WMSwithRFID.UpdateDeleteForms
{
    public partial class UserUpdateDeleteForm : Form
    {
        public UserUpdateDeleteForm()
        {
            InitializeComponent();
            getUserDetails();
            setGridViewProperties();
        }
        public void setGridViewProperties()
        {
            this.dataGridView1.Columns[0].Width = 80;
            this.dataGridView1.Columns[1].Width = 90;
            this.dataGridView1.Columns[2].Width = 90;
            this.dataGridView1.Columns[3].Width = 90;
            this.dataGridView1.Columns[4].Width = 90;
            this.dataGridView1.Columns[5].Width = 90; 
            this.dataGridView1.Columns[6].Width = 90;
            this.dataGridView1.Columns[7].Width = 90;
            this.dataGridView1.Columns[8].Width = 90; 
        }

        public void getUserDetails()
        {
            WMScontext wms = new WMScontext();
            var q = from w in wms.Users select new
                    {
                        w.Username,
                        w.AccountType,
                        w.CompanyPosition,
                        w.FirstName,
                        w.MiddleName,
                        w.LastName,
                        w.Suffix,
                        w.Email,
                        w.ContactNumber,
                        w.Address
                    };
            dataGridView1.DataSource = q.ToList();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
            this.usenameTB.Text = row.Cells["Username"].Value.ToString();
            this.firstNameTB.Text = row.Cells["FirstName"].Value.ToString();
            this.lastNameTB.Text = row.Cells["LastName"].Value.ToString();
            this.middleNameTB.Text = row.Cells["MiddleName"].Value.ToString();
            this.accountTypeCB.Text = row.Cells["AccountType"].Value.ToString();
            this.companyPositionTB.Text = row.Cells["CompanyPosition"].Value.ToString();
            this.suffixTB.Text = row.Cells["Suffix"].Value.ToString();
            this.emailTB.Text = row.Cells["Email"].Value.ToString();
            this.addressTB.Text = row.Cells["Address"].Value.ToString();
            this.contactNoTB.Text = row.Cells["ContactNumber"].Value.ToString();
            this.usenameTB.ReadOnly = true;
        }

        private void userUpdateBtn_Click(object sender, EventArgs e)
        {
            WMScontext wms = new WMScontext();
            var update = (from c in wms.Users where c.Username == this.usenameTB.Text select c).First();

            update.FirstName = this.firstNameTB.Text;
            update.LastName = this.lastNameTB.Text;
            update.MiddleName = this.middleNameTB.Text;
            update.AccountType = (AccountType)Enum.Parse(typeof(AccountType), this.accountTypeCB.SelectedItem.ToString());
            update.CompanyPosition = this.companyPositionTB.Text;
            update.Suffix = this.suffixTB.Text;
            update.Email = this.emailTB.Text;
            update.ContactNumber = this.contactNoTB.Text;
            update.Address = this.addressTB.Text;
            update.passwordMD5(this.passwordTB.Text);
            wms.SaveChanges();
            getUserDetails();
            ClearFields();

        }

        public void ClearFields()
        {
            this.usenameTB.Clear();
            this.passwordTB.Clear();
            this.firstNameTB.Clear();
            this.middleNameTB.Clear();
            this.lastNameTB.Clear();
            this.accountTypeCB.SelectedIndex = -1;
            this.companyPositionTB.Clear();
            this.contactNoTB.Clear();
            this.emailTB.Clear();
            this.suffixTB.Clear();
            this.addressTB.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClearFields();
            AddUserForm user = new AddUserForm();
            user.ShowDialog();           
        }

        private void userDeleteBtn_Click(object sender, EventArgs e)
        {
            WMScontext wms = new WMScontext();
            var delete = from del in wms.Users where del.Username == this.usenameTB.Text select del;

            foreach (var del in delete)
            {
                wms.Users.Remove(del);
            }
            wms.SaveChanges();
            getUserDetails();
        }

    }
}
