using GOT.Models;
using System.Data.Entity;

namespace GOT.DataAccess
{

    public class GOTContext : DbContext
    {
        // Your context has been configured to use a 'GOTContext' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'GOT.DataAccess.GOTContext' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'GOTContext' 
        // connection string in the application configuration file.
        public GOTContext()
            : base("name=GOTContext")
        {
            Database.SetInitializer(new DataInitializer());
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        public virtual DbSet<Character> Characters { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}