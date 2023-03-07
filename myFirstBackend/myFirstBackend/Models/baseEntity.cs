using Microsoft.Build.Construction;
using System.ComponentModel.DataAnnotations;
namespace myFirstBackend.Models
{
    public class baseEntity
    {
        [Required]
        [Key]
        public int Id { get; set; }

        public string createdBy { get; set; } = string.Empty;

        public DateTime createdAt { get; set; }

        public bool isDeleted { get; set; }
    }
}
