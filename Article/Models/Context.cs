using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Article.Models
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.;Database=Article;Trusted_Connection=true");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Users>()
                .HasData(
                    new Users
                    {
                        Id = 1,
                        Email = "sefa@sefa",
                        password = "sefa"
                    }
                );
            modelBuilder.Entity<Category>()
                .HasData(
                    new Category
                    {
                        Id = 1,
                        Name = "TELEFON",
                        Icon = "fa-mobile-screen"
                    },
                      new Category
                      {
                          Id = 2,
                          Name = "BİLGİSAYAR",
                          Icon = "fa-computer"
                      },
                        new Category
                        {
                            Id = 3,
                            Name = "TELEVİZYON",
                            Icon = "fa-tv"
                        },
                          new Category
                          {
                              Id = 4,
                              Name = "KAMERA",
                              Icon = "fa-camera"
                          },
                            new Category
                            {
                                Id = 5,
                                Name = "BEYAZ EŞYA",
                                Icon = "fa-blender"
                            },
                              new Category
                              {
                                  Id = 6,
                                  Name = "EV ALETLERİ",
                                  Icon = "fa-chair"
                              },
                                new Category
                                {
                                    Id = 7,
                                    Name = "BAKIM",
                                    Icon = "fa-spray-can-sparkles"
                                },
                                  new Category
                                  {
                                      Id = 8,
                                      Name = "OYUN",
                                      Icon = "fa-gamepad"
                                  }

                );
        }


        // Modellerin tanıtılması
        public DbSet<Users> Users { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
