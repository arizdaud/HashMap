using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduWise.Common
{
    public static class AuthorizationManager
    {
        /// <summary>
        /// The _privileges
        /// </summary>
        private static IDictionary<int, string> _privileges;
        /// <summary>
        /// Gets the privileges.
        /// </summary>
        /// <value>
        /// The privileges.
        /// </value>
        public static IDictionary<int, string> Privileges
        {
            get
            {
                if (_privileges == null)
                {
                    _privileges = new Dictionary<int, string>();

                    _privileges.Add(1, "Security Users");
                    _privileges.Add(2, "Users Role");
                    _privileges.Add(3, "Student Details");
                    _privileges.Add(4, "Search Student");
                    _privileges.Add(5, "Add Faculty");
                    _privileges.Add(6, "Search Faculty");
                    _privileges.Add(7, "Academic Year");
                    _privileges.Add(8, "Class");
                    _privileges.Add(9, "Subjects");
                    _privileges.Add(10, "Student Notice");
                    _privileges.Add(11, "Faculty Notice");
                    _privileges.Add(12, "Security Money");
                    _privileges.Add(13, "Promotion");
                    _privileges.Add(14, "Department");
                    _privileges.Add(15, "Submit Attendance");
                    _privileges.Add(16, "View Attendance");
                    _privileges.Add(17, "Holidays");
                    _privileges.Add(18, "ClassSubject");
                    _privileges.Add(19, "Period");
                    _privileges.Add(20, "TimeTable");
                    _privileges.Add(21, "ViewTimeTable");
                    _privileges.Add(22, "ExaminationType");
                    _privileges.Add(23, "CreateExamination");
                    _privileges.Add(24, "MarksEntry");
                    _privileges.Add(25, "ViewStudentsMarks");
                    _privileges.Add(26, "AddLeave");
                    _privileges.Add(27, "LeaveDetails");
                    _privileges.Add(28, "ParticularsOfTeachers");
                    _privileges.Add(29, "FacultySalaryDetails");
                    _privileges.Add(32, "Student Concession");
                    _privileges.Add(33, "Late Fine");

                    _privileges.Add(34, "Section");
                    _privileges.Add(35, "Create Fees");
                    _privileges.Add(36, "Create Class Fees");
                    _privileges.Add(37, "Transportation Route");
                    _privileges.Add(38, "Student Transportation Route");
                    _privileges.Add(39, "Scholarship List");
                    _privileges.Add(40, "Students Fee Details");
                    _privileges.Add(41, "Total Collection Report");
                    _privileges.Add(42, "Fees Due Report");
                    _privileges.Add(43, "Fees Wise Collection Report");
                    _privileges.Add(44, "Balance Sheet");
                }
                return _privileges;
            }
        }

        /// <summary>
        /// Determines whether [is user has privilege] [the specified privilege].
        /// </summary>
        /// <param name="privilege">The privilege.</param>
        /// <param name="rolePrivileges">The role privileges.</param>
        /// <returns></returns>
        public static bool IsUserHasPrivilege(string privilege, IList<int> rolePrivileges)
        {
            bool returnValue = false;
            if (string.IsNullOrEmpty(privilege))
            {
                return false;
            }

            KeyValuePair<int, string> result = Privileges.Single(p => p.Value.Equals(privilege));

            if (rolePrivileges.Contains(result.Key))
            {
                returnValue = true;
            }

            return returnValue;
        }

        /// <summary>
        /// Determines whether [is user has privilege] [the specified privilege].
        /// </summary>
        /// <param name="privilege">The privilege.</param>
        /// <returns></returns>
        public static bool IsUserHasPrivilege(string privilege)
        {
            return IsUserHasPrivilege(privilege, SessionStateManager.UserPrivileges);
        }

        /// <summary>
        /// Determines whether [is user has privilege] [the specified privilege identifier].
        /// </summary>
        /// <param name="privilegeId">The privilege identifier.</param>
        /// <param name="rolePrivileges">The role privileges.</param>
        /// <returns></returns>
        public static bool IsUserHasPrivilege(int privilegeId, IList<int> rolePrivileges)
        {
            bool returnValue = false;
            if (privilegeId < 1)
            {
                return false;
            }

            if (rolePrivileges.Contains(privilegeId))
            {
                returnValue = true;
            }

            return returnValue;
        }

        /// <summary>
        /// Determines whether [is user has privilege] [the specified privilege].
        /// </summary>
        /// <param name="privilege">The privilege.</param>
        /// <returns></returns>
        public static bool IsUserHasPrivilege(int privilege)
        {
            return IsUserHasPrivilege(privilege, SessionStateManager.UserPrivileges);
        }
    }
}
