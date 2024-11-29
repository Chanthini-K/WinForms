using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessAccessLayer;

//namespace WinForms
//{
//    public partial class Dashboard : Form
//    {
//        private SecurityCodeBAL bal = new SecurityCodeBAL();

//        public Dashboard()
//        {
//            InitializeComponent();
//            InitializeCustomComponents();
//        }

//        private void InitializeCustomComponents()
//        {
//            // Initialize your form components here
//            cmbSecurityCode.Visible = true;
//            List<string> codes = bal.GetAllSecurityCodes();
//            cmbSecurityCode.DataSource = codes;
//            txtSC.Visible = false;
//            btnSave.Visible = false;
//            btnCancel.Visible = false;
//            btnAddConfirm.Visible = false;
//            lblCreateForm.Visible = false;
//            lblDashboard.Visible = true;
//            lblUpdate.Visible = false;

//            cmbSecurityCode.Items.Add("Select a security code");
//        }


//        private void btnAdd_Click(object sender, EventArgs e)
//        {
//            // Switch to add mode
//            cmbSecurityCode.Visible = false;
//            txtSC.Visible = true;
//            btnAddConfirm.Visible = true;
//            btnUpdate.Visible = false;
//            btnSave.Visible = false;
//            btnCancel.Visible = true;
//            lblCreateForm.Visible = true;
//            lblDashboard.Visible = false;
//            lblUpdate.Visible = false;
//        }
//        private void btnAddConfirm_Click(object sender, EventArgs e)
//        {
//            try
//            {
//                if (string.IsNullOrWhiteSpace(txtSC.Text) || string.IsNullOrWhiteSpace(txtDesc.Text))
//                {
//                    MessageBox.Show("Both fields are required.");
//                    return;
//                }

//                bal.AddSecurityCode(txtSC.Text, txtDesc.Text);
//                MessageBox.Show("Security code added successfully.");
//                ClearFields();
//                RevertToOriginalState();
//            }
//            catch (Exception ex)
//            {
//                MessageBox.Show(ex.Message);
//            }
//        }



//        private void btnUpdate_Click(object sender, EventArgs e)
//        {
//            try
//            {
//                List<string> codes = bal.GetAllSecurityCodes();
//                cmbSecurityCode.DataSource = codes;
//                cmbSecurityCode.Visible = true;
//                txtSC.Visible = false;
//                btnAdd.Visible = false;
//                btnAddConfirm.Visible = false;
//                btnUpdate.Visible = false;
//                btnSave.Visible = true;
//                btnCancel.Visible = true;
//                lblCreateForm.Visible = false;
//                lblDashboard.Visible = false;
//                lblUpdate.Visible = true;
//            }
//            catch (Exception ex)
//            {
//                MessageBox.Show(ex.Message);
//            }
//        }


//        private void btnSave_Click(object sender, EventArgs e)
//        {
//            try
//            {
//                if (cmbSecurityCode.SelectedItem == null || string.IsNullOrWhiteSpace(txtDesc.Text))
//                {
//                    MessageBox.Show("Both fields are required.");
//                    return;
//                }

//                bal.UpdateSecurityCode(cmbSecurityCode.SelectedItem.ToString(), txtDesc.Text);
//                MessageBox.Show("Security code updated successfully.");
//                RevertToOriginalState();
//            }
//            catch (Exception ex)
//            {
//                MessageBox.Show(ex.Message);
//            }
//        }

//        private void btnCancel_Click(object sender, EventArgs e)
//        {
//            RevertToOriginalState();
//        }

//        private void RevertToOriginalState()
//        {
//            cmbSecurityCode.Visible = true;
//            txtSC.Visible = true;
//            txtSC.Clear();
//            txtDesc.Clear();
//            btnAdd.Visible = true;
//            btnAddConfirm.Visible = false;
//            btnUpdate.Visible = true;
//            btnSave.Visible = false;
//            btnCancel.Visible = false;
//            lblCreateForm.Visible = false;
//            lblDashboard.Visible = true;
//            lblUpdate.Visible = false;
//        }

//        private void ClearFields()
//        {
//            txtSC.Clear();
//            txtDesc.Clear();
//        }

//        private void btnNext_Click(object sender, EventArgs e)
//        {
//            cmbSecurityCode.Visible = false;
//            txtSC.Visible = false;
//            lblDesc.Visible = false;
//            lblSC.Visible = false;
//            txtDesc.Visible = false;
//            txtSC.Clear();
//            txtDesc.Clear();
//            btnAdd.Visible = false;
//            btnUpdate.Visible = false;
//            btnSave.Visible = false;
//            btnCancel.Visible = false;
//            btnAddConfirm.Visible = false;
//            lblCreateForm.Visible = false;
//            lblDashboard.Visible = false;
//            lblUpdate.Visible = false;


//        }

//        private void btnSecurityCode_Click(object sender, EventArgs e)
//        {
//            RevertToOriginalState();
//            lblSC.Visible = true;
//            lblDesc.Visible=true;
//            txtDesc.Visible=true;
//            cmbSecurityCode.Visible=true;

//        }

//        private void Dashboard_Load(object sender, EventArgs e)
//        {

//        }

//        private void cmbSecurityCode_SelectedIndexChanged(object sender, EventArgs e)
//        {

//        }
//    }
//}
namespace WinForms
{
    public partial class Dashboard : Form
    {
        private SecurityCodeBAL bal = new SecurityCodeBAL();

        public Dashboard()
        {
            InitializeComponent();
            InitializeCustomComponents();
        }

        private void InitializeCustomComponents()
        {
            // Initialize your form components here
            cmbSecurityCode.Visible = true;
            List<string> codes = bal.GetAllSecurityCodes();
            cmbSecurityCode.Items.Clear();
            cmbSecurityCode.Items.Add("security code");
            cmbSecurityCode.SelectedIndex = 0;
            foreach (var code in codes)
            {
                cmbSecurityCode.Items.Add(code);
            }
            txtSC.Visible = false;
            btnSave.Visible = false;
            btnCancel.Visible = false;
            btnAddConfirm.Visible = false;
            lblCreateForm.Visible = false;
            lblDashboard.Visible = true;
            lblUpdate.Visible = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Switch to add mode
            cmbSecurityCode.Visible = false;
            txtSC.Visible = true;
            btnAddConfirm.Visible = true;
            btnUpdate.Visible = false;
            btnSave.Visible = false;
            btnCancel.Visible = true;
            lblCreateForm.Visible = true;
            lblDashboard.Visible = false;
            lblUpdate.Visible = false;
        }

        private void btnAddConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtSC.Text) || string.IsNullOrWhiteSpace(txtDesc.Text))
                {
                    MessageBox.Show("Both fields are required.");
                    return;
                }

                bal.AddSecurityCode(txtSC.Text, txtDesc.Text);
                MessageBox.Show("Security code added successfully.");
                ClearFields();
                RevertToOriginalState();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                List<string> codes = bal.GetAllSecurityCodes();
                cmbSecurityCode.Items.Clear();
                cmbSecurityCode.Items.Add("security code");
                cmbSecurityCode.SelectedIndex = 0;
                foreach (var code in codes)
                {
                    cmbSecurityCode.Items.Add(code);
                }
                cmbSecurityCode.Visible = true;
                txtSC.Visible = false;
                btnAdd.Visible = false;
                btnAddConfirm.Visible = false;
                btnUpdate.Visible = false;
                btnSave.Visible = true;
                btnCancel.Visible = true;
                lblCreateForm.Visible = false;
                lblDashboard.Visible = false;
                lblUpdate.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbSecurityCode.SelectedIndex == 0 || string.IsNullOrWhiteSpace(txtDesc.Text))
                {
                    MessageBox.Show("Both fields are required.");
                    return;
                }

                bal.UpdateSecurityCode(cmbSecurityCode.SelectedItem.ToString(), txtDesc.Text);
                MessageBox.Show("Security code updated successfully.");
                RevertToOriginalState();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            RevertToOriginalState();
        }

        private void RevertToOriginalState()
        {
            cmbSecurityCode.Visible = true;
            txtSC.Visible = false;
            txtSC.Clear();
            txtDesc.Clear();
            cmbSecurityCode.Items.Clear();
            cmbSecurityCode.Items.Add("security code");
            cmbSecurityCode.SelectedIndex = 0;
            List<string> codes = bal.GetAllSecurityCodes();
            foreach (var code in codes)
            {
                cmbSecurityCode.Items.Add(code);
            }
            btnAdd.Visible = true;
            btnAddConfirm.Visible = false;
            btnUpdate.Visible = true;
            btnSave.Visible = false;
            btnCancel.Visible = false;
            lblCreateForm.Visible = false;
            lblDashboard.Visible = true;
            lblUpdate.Visible = false;
        }

        private void ClearFields()
        {
            txtSC.Clear();
            txtDesc.Clear();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            cmbSecurityCode.Visible = false;
            txtSC.Visible = false;
            lblDesc.Visible = false;
            lblSC.Visible = false;
            txtDesc.Visible = false;
            txtSC.Clear();
            txtDesc.Clear();
            btnAdd.Visible = false;
            btnUpdate.Visible = false;
            btnSave.Visible = false;
            btnCancel.Visible = false;
            btnAddConfirm.Visible = false;
            lblCreateForm.Visible = false;
            lblDashboard.Visible = false;
            lblUpdate.Visible = false;
        }

        private void btnSecurityCode_Click(object sender, EventArgs e)
        {
            RevertToOriginalState();
            lblSC.Visible = true;
            lblDesc.Visible = true;
            txtDesc.Visible = true;
            cmbSecurityCode.Visible = true;
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            
        }

        private void cmbSecurityCode_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
