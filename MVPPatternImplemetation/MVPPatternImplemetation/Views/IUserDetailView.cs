using MVPEntities;

namespace MVPPatternImplemetation.Views
{
    public interface IUserDetailView
    {
        ClsUser User { get; set; }
        ClsUser FillLoggedInUserDetail();
        void LoadFillDetailControl(string loginID);
        void DisplayUserDetail();
    }
}