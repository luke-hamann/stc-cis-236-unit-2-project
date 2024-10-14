//
// Title: Whale Database Context
// Purpose: This class provides a database context for storing whales. It also
//          populates the database with several sample whale species.
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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

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
                    ConservationStatus = 2,
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
                    Description = "integer ac leo pellentesque ultrices mattis odio donec vitae nisi nam\r\n",
                    Lifespan = 105,
                    MigrationDistance = 7575,
                    Population = 4143,
                    ConservationStatus = 5,
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
                    Description = "aliquet maecenas leo odio condimentum id luctus nec molestie sed justo pellentesque viverra pede ac diam\r\n",
                    Lifespan = 379,
                    MigrationDistance = 9548,
                    Population = 2956,
                    ConservationStatus = 3,
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
                    Description = "aliquam lacus morbi quis tortor id nulla ultrices aliquet maecenas leo odio\r\n",
                    Lifespan = 624,
                    MigrationDistance = 9180,
                    Population = 8286,
                    ConservationStatus = 3,
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
                    Description = "morbi a ipsum integer a nibh in quis justo maecenas rhoncus aliquam lacus morbi quis\r\n",
                    Lifespan = 957,
                    MigrationDistance = 5765,
                    Population = 831,
                    ConservationStatus = 6,
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
