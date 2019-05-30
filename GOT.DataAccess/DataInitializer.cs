using GOT.Models;
using System.Data.Entity;

namespace GOT.DataAccess
{
    public class DataInitializer : CreateDatabaseIfNotExists<GOTContext>
    {
        protected override void Seed(GOTContext context)
        {
            context.Characters.Add(new Character
            {
                Gender = "male",
                House="Targarien",
                Id="1",
                Name= "Jon",
                Slug="Bastard",
                Titles = new string[] { "You know nothing, Jon Snow" }
            });
        }
    }
}
