using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorLearningApp.Models
{
    public class Item
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Name is required")]
        [StringLength(100, MinimumLength = 1, ErrorMessage = "Name must be between 1 and 100 characters")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Location is required")]
        [StringLength(200, MinimumLength = 1, ErrorMessage = "Location must be between 1 and 200 characters")]
        public string Location { get; set; }

        [Range(0, int.MaxValue, ErrorMessage = "Amount must be non-negative")]
        public int? Amount { get; set; }

        [Range(0.0f, float.MaxValue, ErrorMessage = "Kilograms must be non-negative")]
        public float? Kilograms { get; set; }
    }
}
