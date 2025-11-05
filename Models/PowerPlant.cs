using System.ComponentModel.DataAnnotations;

namespace IgnitisHomework.Models
{
    public class PowerPlant
    {
        [Required] public int Id { get; set; }
        [Required] public string Owner { get; set; } = string.Empty;
        [Required] public double Power { get; set; }
        [Required] public DateTime ValidFrom { get; set; }
        public DateTime? ValidTo { get; set; }
    }
}