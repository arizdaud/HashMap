using EduWise.Framework;
using System;
using System.ComponentModel.DataAnnotations;
namespace EduWise.Domain
{
    [Table("Users")]
    public class Users : BaseEntity
    {
        [Identifier("UserId")]
        public int UserId { get; set; }
        [Required]
        public string UserName { get; set; }
        [Required]
        public byte[] Password { get; set; }
        public string FullName { get; set; }
        public bool IsLocked { get; set; }
        public string Mobile { get; set; }
        public DateTime? LastLoginDate { get; set; }
        public int ApplicationRoleId { get; set; }
    }
}
