//
// Title: Whale Class
// Purpose: This class represents a species of whale, including an id, common
//          name, scientific name, description, lifespan, migration distance,
//          population, conservation status, and which oceans the species is
//          found in. It also has a read-only property for generating a url slug
//          based on the common name.
//

using System.ComponentModel.DataAnnotations;

namespace WhaleApp.Models
{
    public class Whale
    {
        public int? Id { get; set; }

        [Required(ErrorMessage = "Please enter a common name.")]
        public string? CommonName { get; set; }

        public string? ScientificName { get; set; }

        public string? Description { get; set; }

        [Range(0, 1000, ErrorMessage = "Lifespan must be between 0 and 1,000 years.")]
        public int? Lifespan { get; set; }

        [Range(0, 10000, ErrorMessage = "Migration distance must be between 0 and 10,000 miles.")]
        public int? MigrationDistance { get; set; }

        [Range(0, 1000000, ErrorMessage = "Population must be between 0 and 1,000,000.")]
        public int? Population { get; set; }

        public int? ConservationStatusId { get; set; }

        public ConservationStatus? ConservationStatus { get; set; }

        public bool IsInArcticOcean { get; set; }

        public bool IsInAtlanticOcean { get; set; }

        public bool IsInIndianOcean { get; set; }

        public bool IsInPacificOcean { get; set; }

        public bool IsInSouthernOcean { get; set; }

        public string? Slug => CommonName?.Replace(" ", "-");
    }
}
