//
// Title: Whale Database Context
// Purpose: This class provides a database context for storing whales and
//          conservation statuses. It also populates the database with sample
//          data. (The statuses are modeled after the IUCN Red List
//          <https://www.iucnredlist.org/en>.)
//

using Microsoft.EntityFrameworkCore;

namespace WhaleApp.Models
{
    public class WhaleContext : DbContext
    {
        public WhaleContext(DbContextOptions<WhaleContext> options)
            : base(options)
        { }

        public DbSet<Whale> Whales { get; set; }

        public DbSet<ConservationStatus> ConservationStatuses { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<ConservationStatus>().HasData(
                new ConservationStatus
                {
                    Id = 1,
                    Name = "Extinct"
                },
                new ConservationStatus
                {
                    Id = 2,
                    Name = "Extinct in the Wild"
                },
                new ConservationStatus
                {
                    Id = 3,
                    Name = "Critically Endangered"
                },
                new ConservationStatus
                {
                    Id = 4,
                    Name = "Endangered"
                },
                new ConservationStatus
                {
                    Id = 5,
                    Name = "Vulnerable"
                },
                new ConservationStatus
                {
                    Id = 6,
                    Name = "Near Threatened"
                },
                new ConservationStatus
                {
                    Id = 7,
                    Name = "Least Concern"
                }
            );

            modelBuilder.Entity<Whale>().HasData(
                new Whale
                {
                    Id = 1,
                    CommonName = "Blue whale",
                    ScientificName = "Heloderma horridum",
                    Description = "odio cras mi pede malesuada in imperdiet et commodo vulputate justo in blandit ultrices enim lorem ipsum dolor",
                    Lifespan = 241,
                    MigrationDistance = 874,
                    Population = 7270,
                    ConservationStatusId = 2,
                    IsInArcticOcean = true,
                    IsInAtlanticOcean = false,
                    IsInIndianOcean = true,
                    IsInPacificOcean = true,
                    IsInSouthernOcean = false
                },
                new Whale
                {
                    Id = 2,
                    CommonName = "Humpback whale",
                    ScientificName = "Phalaropus lobatus",
                    Description = "integer ac leo pellentesque ultrices mattis odio donec vitae nisi nam",
                    Lifespan = 105,
                    MigrationDistance = 7575,
                    Population = 4143,
                    ConservationStatusId = 5,
                    IsInArcticOcean = false,
                    IsInAtlanticOcean = true,
                    IsInIndianOcean = true,
                    IsInPacificOcean = true,
                    IsInSouthernOcean = false
                },
                new Whale
                {
                    Id = 3,
                    CommonName = "Fin whale",
                    ScientificName = "Limosa haemastica",
                    Description = "aliquet maecenas leo odio condimentum id luctus nec molestie sed justo pellentesque viverra pede ac diam",
                    Lifespan = 379,
                    MigrationDistance = 9548,
                    Population = 2956,
                    ConservationStatusId = 3,
                    IsInArcticOcean = true,
                    IsInAtlanticOcean = true,
                    IsInIndianOcean = true,
                    IsInPacificOcean = false,
                    IsInSouthernOcean = false
                },
                new Whale
                {
                    Id = 4,
                    CommonName = "Beluga whale",
                    ScientificName = "Mycteria leucocephala",
                    Description = "aliquam lacus morbi quis tortor id nulla ultrices aliquet maecenas leo odio",
                    Lifespan = 624,
                    MigrationDistance = 9180,
                    Population = 8286,
                    ConservationStatusId = 3,
                    IsInArcticOcean = false,
                    IsInAtlanticOcean = true,
                    IsInIndianOcean = true,
                    IsInPacificOcean = false,
                    IsInSouthernOcean = true
                },
                new Whale
                {
                    Id = 5,
                    CommonName = "Sperm whale",
                    ScientificName = "Bassariscus astutus",
                    Description = "morbi a ipsum integer a nibh in quis justo maecenas rhoncus aliquam lacus morbi quis",
                    Lifespan = 957,
                    MigrationDistance = 5765,
                    Population = 831,
                    ConservationStatusId = 6,
                    IsInArcticOcean = false,
                    IsInAtlanticOcean = false,
                    IsInIndianOcean = false,
                    IsInPacificOcean = true,
                    IsInSouthernOcean = false
                }
            );
        }
    }
}
