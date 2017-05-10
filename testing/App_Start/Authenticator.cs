using System.Web.Security;

namespace testing
{
    public interface IAuthentication
    {
        void DoAuthentication(string userName, bool remember);
        void SignOut();

    }
    public class Authenticator : IAuthentication
    {

        public void DoAuthentication(string userName, bool remember)
        {
            FormsAuthentication.SetAuthCookie(userName, remember);
        }
        public void SignOut()
        {
            FormsAuthentication.SignOut();
        }
    }
}