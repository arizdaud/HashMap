using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EduWise.Common
{
    public class CommonEnumerations
    {
        public enum MOM
        {
            Number = 1,
            Piece,
            Meter,
            Feet,
            Kilo_Meter,
            Kg,
            Quintel,
            Pack,
            Truck
        };

        ///// <summary>
        ///// Task status enumerator
        ///// </summary>
        //public enum TaskStatus : int
        //{
        //    /// <summary>
        //    /// Not yet defined
        //    /// </summary>
        //    NotDefined = 0,

        //    /// <summary>
        //    /// Task is started
        //    /// </summary>
        //    Started = 1,

        //    /// <summary>
        //    /// Task is finished
        //    /// </summary>
        //    Finished = 2,
        //}

        /// <summary>
        /// User Type
        /// </summary>
        public enum UserType
        {
            /// <summary>
            /// NotDefined
            /// </summary>
            NotDefined = -1,
            /// <summary>
            /// 
            /// </summary>
            Employee = 0,
            /// <summary>
            /// 
            /// </summary>
            Admin = 1
        }

        /// <summary>
        /// Task Status constants
        /// </summary>
        public enum TaskStatus : short
        {
            /// <summary>
            /// Assign new task 
            /// </summary>
            Assigned = 1,
            /// <summary>
            /// Resolved the task
            /// </summary>
            Resolved,
            /// <summary>
            /// Closed the task
            /// </summary>
            Closed,
            /// <summary>
            /// Reopen the task
            /// </summary>
            Reopen
        }

        /// <summary>
        /// Time Sheet constants
        /// </summary>
        public enum TimeSheetStatus : short
        {
            /// <summary>
            /// Pending status
            /// </summary>
            Pending = 1,

            /// <summary>
            /// Approved status
            /// </summary>
            Approved,

            /// <summary>
            /// Rejected status
            /// </summary>
            Rejected
        }

        /// <summary>
        /// Exception Types
        /// </summary>
        public enum ExceptionType : short
        {
            /// <summary>
            /// Information
            /// </summary>
            Information,

            /// <summary>
            /// Warning
            /// </summary>
            Warning,

            /// <summary>
            /// Error
            /// </summary>
            Error,

            /// <summary>
            /// FatalError
            /// </summary>
            FatalError
        }
    }
}
