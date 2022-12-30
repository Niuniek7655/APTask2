namespace APTask2.Migrations
{
    using APTask2.Entities;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<APTask2.DAL.APTaskDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(APTask2.DAL.APTaskDbContext context)
        {
            if(context.InventLocations.Count() == 0 && context.InventDims.Count() == 0)
            {
                for (int i = 1; i <= 10; i++)
                {
                    InventLocation inventLocation = InventLocation.Create(i);
                    context.InventLocations.Add(inventLocation);
                }
                context.SaveChanges();

                foreach (var inventLocation in context.InventLocations)
                {
                    for (int i = 1; i <= 1000; i++)
                    {
                        InventDim inventDim = InventDim.Create(inventLocation.InventLocationId);
                        context.InventDims.Add(inventDim);
                    }
                }
                context.SaveChanges();
            }
        }
    }
}
