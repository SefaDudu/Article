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
            //optionsBuilder.UseSqlServer(@"Server=.;Database=Article;Trusted_Connection=true");
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-5QK28QU\SQLEXPRESS;Database=Article;Trusted_Connection=true");
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
            modelBuilder.Entity<Product>()
               .HasData(
                   new Product
                   {
                       Id = 1,
                       Name = "Oppo",
                       CategoryId = 1
                   },
                    new Product
                    {
                        Id = 2,
                        Name = "Samsung",
                        CategoryId = 1
                    },
                      new Product
                      {
                          Id = 3,
                          Name = "Iphone",
                          CategoryId = 1
                      }
                      ,
                      new Product
                      {
                          Id = 4,
                          Name = "Huawei",
                          CategoryId = 2
                      },
                      new Product
                      {
                          Id = 5,
                          Name = "HP",
                          CategoryId = 2
                      }
                       ,
                      new Product
                      {
                          Id = 6,
                          Name = "Lenova",
                          CategoryId = 2
                      }
                         ,
                      new Product
                      {
                          Id = 7,
                          Name = "Samsung",
                          CategoryId = 3
                      },
                      new Product
                      {
                          Id = 8,
                          Name = "LG",
                          CategoryId = 3
                      },
                      new Product
                      {
                          Id = 9,
                          Name = "Grundig",
                          CategoryId = 3
                      }
                      ,
                      new Product
                      {
                          Id = 10,
                          Name = "makine 1",
                          CategoryId = 4
                      },
                      new Product
                      {
                          Id = 11,
                          Name = "makine 2",
                          CategoryId = 4
                      },
                      new Product
                      {
                          Id = 12,
                          Name = "makine 3",
                          CategoryId = 4
                      },
                      new Product
                      {
                          Id = 13,
                          Name = "Buzdolabı",
                          CategoryId = 5
                      },
                      new Product
                      {
                          Id = 14,
                          Name = "Çamaşır Makinası",
                          CategoryId = 5
                      },
                      new Product
                      {
                          Id = 15,
                          Name = "Fırın",
                          CategoryId = 5
                      }
                      ,
                      new Product
                      {
                          Id = 16,
                          Name = "Ev Aleti 1",
                          CategoryId = 6
                      },
                      new Product
                      {
                          Id = 17,
                          Name = "Ev Aleti 2",
                          CategoryId = 6
                      },
                      new Product
                      {
                          Id = 18,
                          Name = "Ev Aleti 3",
                          CategoryId = 6
                      }
                      ,
                      new Product
                      {
                          Id = 19,
                          Name = "Bakım Sağlık",
                          CategoryId = 7
                      }
                         ,
                      new Product
                      {
                          Id = 20,
                          Name = "Bakım Sağlık2",
                          CategoryId = 7
                      },
                      new Product
                      {
                          Id = 21,
                          Name = "Bakım Sağlık3",
                          CategoryId = 7
                      }
                      ,
                      new Product
                      {
                          Id = 22,
                          Name = "Spor",
                          CategoryId = 8
                      },
                      new Product
                      {
                          Id = 23,
                          Name = "Spor2",
                          CategoryId = 8
                      },
                      new Product
                      {
                          Id = 24,
                          Name = "Spor3",
                          CategoryId = 8
                      }

               );
        }


        // Modellerin tanıtılması
        public DbSet<Users> Users { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}
