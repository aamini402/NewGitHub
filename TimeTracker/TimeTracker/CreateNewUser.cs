using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BusinessLogicLayer;
using BusinessObject;

namespace TimeTracker
{
    public partial class frmCreateNewUser : Form
    {
        public frmCreateNewUser()
        {
            InitializeComponent();
        }
        

       
        private void btnSave_Click(object sender, EventArgs e)
        {
            UserBO userBO = new UserBO();
            userBO.RoleBO = new RoleBO();
            UserBL USerBL = new UserBL();
            userBO.Username = txtboxUsername.Text;
             userBO.Password= txtboxPassword.Text;
             userBO.PhnNo = Convert.ToInt64(txtboxContactNumber.Text);
             userBO.RoleBO.RoleName = rdoBtnAdministrator.Checked ? "administrator" : "employee";
             USerBL.CreatUser(userBO);

 

        }
    }
}
