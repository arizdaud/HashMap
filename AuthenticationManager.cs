using System;
using System.Collections.Generic;
using System.Text;
using System.Web;
using System.Web.Security;

namespace EduWise.Common
{
    /// <summary>
    /// Authentication manager 
    /// </summary>
    public class AuthenticationManager
    {
        /// <summary>
        /// Set Cookie for Logged User.
        /// </summary>
        /// <param name="userName"></param>
        public static void SetAuthCookie(string userName)
        {
            string userData = "," + Enum.GetName(typeof(CommonEnumerations.UserType), SessionStateManager.CurrentUserType);
            FormsAuthenticationTicket ticket = new FormsAuthenticationTicket(1, userName, DateTime.Now, DateTime.Now.AddMinutes(30), false, userData);
            FormsAuthentication.SetAuthCookie(userName, false);
            HttpContext.Current.Response.SetCookie(new HttpCookie(FormsAuthentication.FormsCookieName, FormsAuthentication.Encrypt(ticket)));
        }

        /// <summary>
        /// To Logged out from System.
        /// </summary>
        public static void SignOutCurrentUser()
        {
            SessionStateManager.ClearSessionState();
            FormsAuthentication.SignOut();
            HttpContext.Current.Response.Cookies.Remove(FormsAuthentication.FormsCookieName);
        }
    }
}
