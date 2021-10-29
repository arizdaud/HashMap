using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduWise.Domain
{
    public class ApplicationRolePrivilegesBusiness:ApplicationRolePrivileges
    {
        public string PrivilegesName { get; set; }
        public string ApplicationName { get; set; }
        public string Description { get; set; }
    }
}
