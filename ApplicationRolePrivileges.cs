using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EduWise.Framework;

namespace EduWise.Domain
{
    [Table("ApplicationRolePrivileges")]
    public class ApplicationRolePrivileges:BaseEntity
    {
        [Identifier("ApplicationRolePrivilegesId")]
        public int ApplicationRolePrivilegesId { get; set; }
        public int PrivilegeId { get; set; }
        public int ApplicationRoleId { get; set; }
    }
}
