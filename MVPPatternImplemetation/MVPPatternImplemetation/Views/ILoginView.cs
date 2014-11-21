using MVPEntities;

namespace MVPPatternImplemetation.Views
{
    public interface ILoginView
    {
        string LoginID { get; set; }
        string Password { get; set; }
        ClsUser User { get; set; }
        void ValidInvalidUser(bool isValid, string msg);
    }
}
