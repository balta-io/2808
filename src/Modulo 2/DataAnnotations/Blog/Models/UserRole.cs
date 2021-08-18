using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Blog.Models
{
    public class UserRole
    {
        [ForeignKey("PostId")] public int UserId { get; set; }

        [ForeignKey("PostId")] public int RoleId { get; set; }
    }
}