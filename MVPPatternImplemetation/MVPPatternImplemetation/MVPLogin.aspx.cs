using System;
using MVPPatternImplemetation.Presenters;
using MVPPatternImplemetation.Views;
using MVPEntities;

namespace MVPPatternImplemetation
{
    public partial class MVPLogin : System.Web.UI.Page, ILoginView
    {
        private LoginPresenter _loginPresenter;

        #region Page Events
        protected void Page_Load(object sender, EventArgs e)
        {
            lblMessage.Text = string.Empty;
            _loginPresenter = new LoginPresenter(this, ucUserDetails1);
            ucUserDetails1.EventSaveUserDetail += new EventHandler(fdFillDetail1_EventSaveUserDetail);
        }

        private void fdFillDetail1_EventSaveUserDetail(object sender, EventArgs e)
        {
            _loginPresenter.DisplaySavedDetail();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            _loginPresenter.UserLogin();
        }
        #endregion

        #region ILoginView implementation

        /// <summary>
        /// 
        /// </summary>
        public string LoginID
        {
            get { return txtLoginID.Text; }
            set { txtLoginID.Text = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public string Password
        {
            get { return txtPassword.Text; }
            set { txtPassword.Text = value; }
        }

        public ClsUser User
        {
            get { return ucUserDetails1.User; }
            set { ucUserDetails1.User = value; }
        }

        public void ValidInvalidUser(bool isValid, string msg)
        {
            ucUserDetails1.Visible = isValid;
            tblLogin.Visible = !isValid;
            lblMessage.Text = msg;
        }

        #endregion
    }
}