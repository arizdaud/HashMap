using System;
using System.Collections.Generic;
using System.Text;
using System.Web;

namespace EduWise.Common
{
    /// <summary>
    /// Session state manager
    /// </summary>
    public class SessionStateManager
    {
        /// <summary>
        /// Clear all Session State
        /// </summary>
        public static void ClearSessionState()
        {
            HttpContext.Current.Session.Clear();
        }

        /// <summary>
        /// Get or Set Session Variable LoggedUser
        /// </summary>
        public static int? LoggedUserId
        {
            get
            {
                return (int?)GetSessionVariable(HttpSessionVarConstant.HTTP_SESSION_LOGGEDUSER, null);
            }
            set
            {
                ResetSessionVariable(HttpSessionVarConstant.HTTP_SESSION_LOGGEDUSER, value);
            }
        }

        /// <summary>
        /// Gets or sets the logged user employee id.
        /// </summary>
        /// <value>The logged user employee id.</value>
        public static int? LoggedUserEmployeeId
        {
            get
            {
                return (int?)GetSessionVariable(HttpSessionVarConstant.HTTP_SESSION_LOGGEDUSER_EMPLOYEEID, null);
            }
            set
            {
                ResetSessionVariable(HttpSessionVarConstant.HTTP_SESSION_LOGGEDUSER_EMPLOYEEID, value);
            }
        }

        /// <summary>
        /// Gets or sets the project ID.
        /// </summary>
        /// <value>The project ID.</value>
        public static int? ProjectID
        {
            get
            {
                return (int?)GetSessionVariable(HttpSessionVarConstant.HTTP_SESSION_PROJECT_ID, null);
            }
            set
            {
                ResetSessionVariable(HttpSessionVarConstant.HTTP_SESSION_PROJECT_ID, value);
            }
        }

        /// <summary>
        /// Gets or sets the project material ID.
        /// </summary>
        /// <value>The project material ID.</value>
        public static int? ProjectMaterialID
        {
            get
            {
                return (int?)GetSessionVariable(HttpSessionVarConstant.HTTP_SESSION_PROJECT_MATERIAL_ID, null);
            }
            set
            {
                ResetSessionVariable(HttpSessionVarConstant.HTTP_SESSION_PROJECT_MATERIAL_ID, value);
            }
        }

        /// <summary>
        /// Gets or sets the project service ID.
        /// </summary>
        /// <value>The project service ID.</value>
        public static int? ProjectServiceID
        {
            get
            {
                return (int?)GetSessionVariable(HttpSessionVarConstant.HTTP_SESSION_PROJECT_SERVICE_ID, null);
            }
            set
            {
                ResetSessionVariable(HttpSessionVarConstant.HTTP_SESSION_PROJECT_SERVICE_ID, value);
            }
        }

        /// <summary>
        /// Gets or sets the worker ID.
        /// </summary>
        /// <value>The worker ID.</value>
        public static int? WorkerID
        {
            get
            {
                return (int?)GetSessionVariable(HttpSessionVarConstant.HTTP_SESSION_WORKER_ID, null);
            }
            set
            {
                ResetSessionVariable(HttpSessionVarConstant.HTTP_SESSION_WORKER_ID, value);
            }
        }

        /// <summary>
        /// Gets or sets the empoyee ID.
        /// </summary>
        /// <value>The empoyee ID.</value>
        public static int? EmployeeID
        {
            get
            {
                return (int?)GetSessionVariable(HttpSessionVarConstant.HTTP_SESSION_EMPLOYEE_ID, null);
            }
            set
            {
                ResetSessionVariable(HttpSessionVarConstant.HTTP_SESSION_EMPLOYEE_ID, value);
            }
        }

        /// <summary>
        /// Gets or sets the type of the current user.
        /// </summary>
        /// <value>The type of the current user.</value>
        public static CommonEnumerations.UserType? CurrentUserType
        {
            get
            {
                return (CommonEnumerations.UserType?)GetSessionVariable(HttpSessionVarConstant.HTTP_SESSION_CURRENT_USER_TYPE, null);
            }
            set
            {
                ResetSessionVariable(HttpSessionVarConstant.HTTP_SESSION_CURRENT_USER_TYPE, value);
            }
        }

        /// <summary>
        /// Gets or sets the name of the current user.
        /// </summary>
        /// <value>The name of the current user.</value>
        public static string CurrentUserName
        {
            get
            {
                return (string)GetSessionVariable(HttpSessionVarConstant.HTTP_SESSION_CURRENT_USER_NAME, null);
            }
            set
            {
                ResetSessionVariable(HttpSessionVarConstant.HTTP_SESSION_CURRENT_USER_NAME, value);
            }
        }

        public static string CurrentName
        {
            get
            {
                return (string)GetSessionVariable(HttpSessionVarConstant.HTTP_SESSION_CURRENT_NAME, null);
            }
            set
            {
                ResetSessionVariable(HttpSessionVarConstant.HTTP_SESSION_CURRENT_NAME, value);
            }
        }
        /// <summary>
        /// Gets or sets the last logon date time.
        /// </summary>
        /// <value>The last logon date time.</value>
        public static DateTime? LastLogonDateTime
        {
            get
            {
                return (DateTime?)GetSessionVariable(HttpSessionVarConstant.HTTP_SESSION_CURRENT_USER_LAST_LOGGED_DATE, null);
            }
            set
            {
                ResetSessionVariable(HttpSessionVarConstant.HTTP_SESSION_CURRENT_USER_LAST_LOGGED_DATE, value);
            }
        }

        /// <summary>
        /// Gets or sets the expense summary user id.
        /// </summary>
        /// <value>The expense summary user id.</value>
        public static int? ExpenseSummaryUserId
        {
            get
            {
                return (int?)GetSessionVariable(HttpSessionVarConstant.HTTP_SESSION_EXPENSE_SUMMARY_USER_ID, null);
            }
            set
            {
                ResetSessionVariable(HttpSessionVarConstant.HTTP_SESSION_EXPENSE_SUMMARY_USER_ID, value);
            }
        }

        #region Utility Methodes.

        /// <summary>
        /// Reset Session Variable by key and value.
        /// </summary>
        /// <param name="key">Session Name</param>
        /// <param name="value">Session Value</param>
        private static void ResetSessionVariable(string key, object value)
        {
            if (HttpContext.Current.Session[key] != null)
            {
                HttpContext.Current.Session.Remove(key);
            }
            HttpContext.Current.Session.Add(key, value);
        }

        /// <summary>
        /// Retrieve SessionVariable
        /// </summary>
        /// <param name="key">Session Name</param>
        /// <param name="defaultValue">Default Value</param>
        /// <returns>Session Value</returns>
        private static object GetSessionVariable(string key, object defaultValue)
        {
            if (HttpContext.Current.Session[key] == null)
            {
                return defaultValue;
            }
            else
            {
                return HttpContext.Current.Session[key];
            }
        }

        #endregion

        #region Authorization

        /// <summary>
        /// Gets or sets the user privileges.
        /// </summary>
        /// <value>
        /// The user privileges.
        /// </value>
        public static IList<int> UserPrivileges
        {
            get
            {
                return (IList<int>)GetSessionVariable(HttpSessionVarConstant.HTTP_SESSION_USER_PRIVILEGES, null);
            }
            set
            {
                ResetSessionVariable(HttpSessionVarConstant.HTTP_SESSION_USER_PRIVILEGES, value);
            }
        }

        /// <summary>
        /// Gets or sets the current user role identifier.
        /// </summary>
        /// <value>
        /// The current user role identifier.
        /// </value>
        public static int? CurrentUserRoleId
        {
            get
            {
                return (int?)GetSessionVariable(HttpSessionVarConstant.HTTP_SESSION_CURRENT_USER_ROLEID, null);
            }
            set
            {
                ResetSessionVariable(HttpSessionVarConstant.HTTP_SESSION_CURRENT_USER_ROLEID, value);
            }
        }

        #endregion
    }
}
