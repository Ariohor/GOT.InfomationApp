using GOT.Models;
using System;
using System.Data.Entity;

namespace GOT.DataAccess
{
    public class DataInitializer : DropCreateDatabaseIfModelChanges<GOTContext>
    {
        protected override void Seed(GOTContext context)
        {
            context.Characters.Add(new Character
            {
                Gender = "male",
                House = "Targarien",
                Id = "1",
                Name = "Jon Snow",
                Slug = "Bastard",
                Titles = new string[] { "You know nothing, Jon Snow", "Ha-ha" },
                DateLastUpdate = DateTime.Now
            });
        }
    }
}
