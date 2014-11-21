using MVPEntities;
using MVPPatternImplemetation.Presenters;
using MVPPatternImplemetation.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MVPPatternImplemetation
{
    public partial class Login : System.Web.UI.Page
    {
        #region Page_Load event

        protected void Page_Load(object sender, EventArgs e)
        {
            lblMessage.Text = string.Empty;
            ucUserDetails1.EventSaveUserDetail += new EventHandler(fdFillDetail1_EventRegister);
        }

        private void fdFillDetail1_EventRegister(object sender, EventArgs e)
        {
            ucUserDetails1.User = ucUserDetails1.FillLoggedInUserDetail();
            ucUserDetails1.Visible = true;
            ucUserDetails1.Visible = false;
            tblLogin.Visible = false;
            ucUserDetails1.DisplayUserDetail();
        }
        #endregion

        #region Login
        /// <summary>
        /// Login button Click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Button1_Click(object sender, EventArgs e)
        {
            //Check user exists in database or not on basis of LoginID and password
            bool isLoggedIn = (string.Equals(txtLoginID.Text ,"rakhi") ||string.Equals(txtLoginID.Text, "priya"))&& string.Equals(txtPassword.Text, "1234");

            if (isLoggedIn)
            {

                if (string.Equals(txtLoginID.Text, "rakhi"))
                {
                    ucUserDetails1.User = new ClsUser()
                        {
                            ID = "rakhi",
                            Name = "Rakhi Shrivastava",
                            Address = "Sec-12,Noida",
                            Contact = 8527362769
                        };
                    ucUserDetails1.Visible = true;
                    tblLogin.Visible = false;
                    ucUserDetails1.DisplayUserDetail();
                }
                else
                {
                    ucUserDetails1.LoadFillDetailControl(txtLoginID.Text);
                    ucUserDetails1.Visible = true;
                    tblLogin.Visible = false;
                }
            }
            else
            {
                ucUserDetails1.Visible = false;
                tblLogin.Visible = true;
                lblMessage.Text = "Invalid User or Password ! Please try again.";
            }
        }
        #endregion
    }
}