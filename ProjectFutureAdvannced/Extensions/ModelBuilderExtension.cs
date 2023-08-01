using Microsoft.EntityFrameworkCore;
using ProjectFutureAdvannced.Model;
using ProjectFutureAdvannced.Models.Enums;

namespace ProjectFutureAdvannced.Extensions
    {
    public static class ModelBuilderExtension
        {
        public static void SetCategory(this ModelBuilder modelBuilder) {
            modelBuilder.Entity<Category>().HasData(new Category
                {
                Id = 1,
                Name=Categorys.Cars,
                CategoryImg= "sedan.png",
                });
            modelBuilder.Entity<Category>().HasData(new Category
                {
                Id = 2,
                Name = Categorys.Elctronic,
                CategoryImg = "plug.png",
                });
            modelBuilder.Entity<Category>().HasData(new Category
                {
                Id = 3,
                Name = Categorys.Home_Garden,
                CategoryImg = "kitchen.png",
                });
            modelBuilder.Entity<Category>().HasData(new Category
                {
                Id = 4,
                Name = Categorys.Mother_Kids,
                CategoryImg = "baby-boy.png",
                });
            modelBuilder.Entity<Category>().HasData(new Category
                {
                Id = 5,
                Name = Categorys.Beauty,
                CategoryImg = "cosmetics.png",
                });
            modelBuilder.Entity<Category>().HasData(new Category
                {
                Id = 6,
                Name = Categorys.Clothes,
                CategoryImg = "fashion.png",
                });
            }
        }
    }
