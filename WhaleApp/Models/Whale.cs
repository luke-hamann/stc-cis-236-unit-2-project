using System.ComponentModel.DataAnnotations;

namespace WhaleApp.Models
{
    public class Whale
    {
        public int? Id { get; set; }

        /* General Info */

        [Required(ErrorMessage = "Please enter a common name.")]
        public string? CommonName { get; set; }

        [Required(ErrorMessage = "Please enter a scientific name.")]
        public string? ScientificName { get; set; }

        public string? Description { get; set; }

        [Range(0, 1000, ErrorMessage = "Lifespan must be between 0 and 1,000 years.")]
        public int? Lifespan { get; set; }

        [Range(0, 50000, ErrorMessage = "Migration distance must be between 0 and 10,000 miles.")]
        public int? MigrationDistance { get; set; }

        /* Species Status */

        [Range(0, 1000000, ErrorMessage = "Population must be between 0 and 1,000,000.")]
        public int? Population { get; set; }

        [Range(0, 7, ErrorMessage = "Invalid conservation status.")]
        public int? ConservationStatus { get; set; }

        /* Location */

        public bool? IsInArcticOcean { get; set; }

        public bool? IsInAtlanticOcean { get; set; }

        public bool? IsInIndianOcean { get; set; }

        public bool? IsInPacificOcean { get; set; }

        public bool? IsInSouthernOcean { get; set; }
    }
}
