using MVPEntities;
using MVPPatternImplemetation.Views;
using System;

namespace MVPPatternImplemetation
{
    public partial class UserDetails : System.Web.UI.UserControl,IUserDetailView
    {
        public ClsUser User { get; set; }
        public event EventHandler EventSaveUserDetail;

        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnSave_Click(object sender, EventArgs e)
        {
            if (EventSaveUserDetail != null)
                EventSaveUserDetail(this, e);
        }
        public void DisplayUserDetail()
        {
            tblView.Visible = true;
            tblEdit.Visible = false;
            lblUser.Text = "Welcome To 3PillarGlobal  " + User.Name;
            lblUserID.Text = User.ID;
            lblUserName.Text = User.Name;
            lblAddress.Text = User.Address;
            lblContact.Text = User.Contact.ToString();
        }
        public ClsUser FillLoggedInUserDetail()
        {
            return new ClsUser() { ID = txtID.Text, Name = txtName.Text, Contact = Convert.ToInt64(txtContact.Text), Address = txtAddress.Text };
        }
        public void LoadFillDetailControl(string loginID)
        {
            txtID.Text = loginID;
            tblView.Visible = false;
            tblEdit.Visible = true;
        }
    }
}