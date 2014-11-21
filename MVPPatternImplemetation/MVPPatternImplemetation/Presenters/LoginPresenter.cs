using MVPEntities;
using MVPPatternImplemetation.Views;

namespace MVPPatternImplemetation.Presenters
{
    public class LoginPresenter
    {
        private ILoginView loginView;
        private IUserDetailView _userDetailView;
        public LoginPresenter(ILoginView view, IUserDetailView userDetailView)
        {
            loginView = view;
            _userDetailView = userDetailView;
        }

        public bool UserLogin()
        {
            bool isLoggedIn = (string.Equals(loginView.LoginID, "rakhi") || string.Equals(loginView.LoginID, "priya")) && string.Equals(loginView.Password, "1234");

            if (isLoggedIn)
            {
                LoggedInUser();
            }
            else
                loginView.ValidInvalidUser(false,"Invalid LoginID or Password .Please try again");

            return isLoggedIn;
        }

        private void LoggedInUser()
        {
            loginView.ValidInvalidUser(true,"");

            if (string.Equals(loginView.LoginID, "rakhi"))
            {
                loginView.User = new ClsUser()
                {
                    ID = "rakhi",
                    Name = "Rakhi Shrivastava",
                    Address = "Agra",
                    Contact = 8527362769
                };
                _userDetailView.DisplayUserDetail();
            }
            else
            {
                _userDetailView.LoadFillDetailControl(loginView.LoginID);
            }
        }
        public void DisplaySavedDetail()
        {
            _userDetailView.User = _userDetailView.FillLoggedInUserDetail();
            _userDetailView.DisplayUserDetail();
        }
    }
}
