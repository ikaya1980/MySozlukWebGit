using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Sozluk;


namespace MySozlukWebGit.Infrastructure
{
    
    public class KeyDb : DbContext, IKeyDataSource
    {
        // Your context has been configured to use a 'ModelSozluk' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'MySozlukWebGit.ModelSozluk' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'ModelSozluk' 
        // connection string in the application configuration file.
        public KeyDb()
            : base("name=ModelSozluk")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
        public virtual DbSet<Key> Keys { get; set; }

        IQueryable<Key> IKeyDataSource.Keys => Keys;

    }

    public interface IKeyDataSource
    {
        IQueryable<Key> Keys { get; }


    }
}