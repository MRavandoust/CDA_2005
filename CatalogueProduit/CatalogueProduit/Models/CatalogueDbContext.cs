using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace CatalogueProduit.Models
{
    public class CatalogueDbContext : DbContext 
    {
        public DbSet<Produit> Produits { get; set; }
        public DbSet<Categorie> Categories { get; set; }


        public CatalogueDbContext(DbContextOptions<CatalogueDbContext> options): base(options)
        {

        }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder)
        //{
        //    if (optionBuilder.IsConfigured)
        //    {
        //        optionBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=CatalogueDB;Trusted_Connection=True;MultipleActiveResultSets=true", builder => builder.EnableRetryOnFailure());
        //    }
        //}

    }
}
