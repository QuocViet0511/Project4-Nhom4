using System.ComponentModel.DataAnnotations;

namespace DomainLayer.Models
{
    public class Role
    {
        [Key]
        public int Id { get; set; }
        public string RoleName { get; set; }

    }
}
