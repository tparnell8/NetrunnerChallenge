using NetrunnerChallenge.Models;

namespace NetrunnerChallenge.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<NetrunnerChallenge.Data.DatabaseContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(NetrunnerChallenge.Data.DatabaseContext context)
        {
            context.FactionsDb.AddOrUpdate(new Faction[]
            {
                new Faction {Id = 1, FactionName = "Jinteki", Side = "Corp"},
                new Faction {Id = 2, FactionName = "Haas-Bioroid", Side = "Corp"},
                new Faction {Id = 3, FactionName = "NBN", Side = "Corp"},
                new Faction {Id = 4, FactionName = "Neutral", Side = "Corp"},
                new Faction {Id = 5, FactionName = "Neutral", Side = "Runner"},
                new Faction {Id = 6, FactionName = "Shaper", Side = "Runner"},
                new Faction {Id = 7, FactionName = "Criminal", Side = "Runner"},
                new Faction {Id = 8, FactionName = "Anarch", Side = "Runner"}
            });
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
        }
    }
}