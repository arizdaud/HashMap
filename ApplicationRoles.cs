using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EduWise.Framework;

namespace EduWise.Domain
{
    [Table("ApplicationRoles")]
    public class ApplicationRoles:BaseEntity
    {
        [Identifier("ApplicationRoleId")]
        public int ApplicationRoleId { get; set; }    
        public string ApplicationRoleName { get; set; }
        public string Description { get; set; }
    }
}
