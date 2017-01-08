namespace SinglePageProject.EF
{
    using Microsoft.AspNet.Identity.EntityFramework;
    using System;
    using System.Data.Entity;

    public class SPPContext : IdentityDbContext<User, Role, Guid, UserLogin, UserRole, UserClaim>
    {
        // Your context has been configured to use a 'SPP' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'SinglePageProject.EF.SPP' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'SPP' 
        // connection string in the application configuration file.
        public SPPContext()
            : base("name=SPPContext")
        {
        }
        
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            ConfigureIdentityTables(modelBuilder);
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
        private void ConfigureIdentityTables(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Role>().ToTable("Roles");
            modelBuilder.Entity<UserRole>().ToTable("UserRoles");
            modelBuilder.Entity<UserLogin>().ToTable("UserLogins");
            modelBuilder.Entity<UserClaim>().ToTable("UserClaims");
        }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}