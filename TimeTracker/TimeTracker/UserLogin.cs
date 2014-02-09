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
    public partial class frmUserLogin : Form
    {
        public frmUserLogin()
        {
            InitializeComponent();
        }

        private void lnklblcreateNewUser_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmCreateNewUser cnu = new frmCreateNewUser();
            cnu.Show();
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
          UserBO userBO=new UserBO();
          UserBL userBL = new UserBL();
          userBO.Username = txtBoxUsername.Text;
          userBO.Password = txtBoxPassword.Text;
          bool isValid= userBL.isValidUser(userBO);
          if (isValid)
          {
              //redirect to other page
          }
          else
          {
              MessageBox.Show("please check your user name and password ");
          }
        }

       
    }
}
