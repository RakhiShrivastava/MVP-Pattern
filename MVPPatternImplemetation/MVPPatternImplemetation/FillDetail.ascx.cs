using MVPEntities;
using MVPPatternImplemetation.Views;
using System;

namespace MVPPatternImplemetation
{
    public partial class FillDetail : System.Web.UI.UserControl, IFillDetailView
    {
        public string LoginId { get; set; }
        public event EventHandler EventSaveUserDetail;
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public void LoadFillDetailControl()
        {
            txtID.Text = LoginId;
        }
        protected void btnSave_Click(object sender, EventArgs e)
        {
            if (EventSaveUserDetail != null)
                EventSaveUserDetail(this, e);
        }
        public ClsUser FillLoggedInUserDetail()
        {
            return new ClsUser() { ID = txtID.Text,Name =txtName.Text,Contact = Convert.ToInt64(txtContact.Text),Address = txtAddress.Text};
        }
    }
}