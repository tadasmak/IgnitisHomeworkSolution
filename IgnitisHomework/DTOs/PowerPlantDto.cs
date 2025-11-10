using System.ComponentModel.DataAnnotations;
using IgnitisHomework.Models;

namespace IgnitisHomework.DTOs
{
    public class PowerPlantDto
    {
        public int Id { get; set; }

        private string _owner = string.Empty;

        [Required]
        [TwoWordLettersOnly]
        public string Owner
        {
            get => _owner;
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    var parts = value!.Trim().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                    _owner = string.Join(" ", parts);
                }
                else
                {
                    _owner = string.Empty;
                }
            }
        }

        [Required]
        [Range(0.0, 200.0, ErrorMessage = "Power must be between 0 and 200.")]
        public double? Power { get; set; }

        [Required] public DateTime? ValidFrom { get; set; }
        public DateTime? ValidTo { get; set; }

        public static PowerPlantDto FromEntity(PowerPlant entity)
        {
            return new PowerPlantDto
            {
                Id = entity.Id,
                Owner = entity.Owner,
                Power = entity.Power,
                ValidFrom = entity.ValidFrom,
                ValidTo = entity.ValidTo
            };
        }
    }
}