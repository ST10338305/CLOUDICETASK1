using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using RecipeWebMvc.Data;
using System;
using System.Linq;

namespace RecipeWebMvc.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new RecipeWebMvcContext(
                serviceProvider.GetRequiredService<DbContextOptions<RecipeWebMvcContext>>()))
            {
                // Look for any recipes.
                if (context.Recipe.Any())
                {
                    return;   // DB has been seeded
                }
                context.Recipe.AddRange(
                    new Recipe
                    {
                        Name = "Chocolate Cake",
                        Createdin = DateTime.Parse("2023-05-15"),
                        Type = "Dessert",
                        Price = 12.99m
                    },
                    new Recipe
                    {
                        Name = "Spaghetti Carbonara",
                        Createdin = DateTime.Parse("2022-10-08"),
                        Type = "Main Course",
                        Price = 15.49m
                    },
                    new Recipe
                    {
                        Name = "Caesar Salad",
                        Createdin = DateTime.Parse("2023-02-20"),
                        Type = "Appetizer",
                        Price = 8.99m
                    },
                    new Recipe
                    {
                        Name = "Beef Tacos",
                        Createdin = DateTime.Parse("2023-05-18"),
                        Type = "Mexican",
                        Price = 14.50M
                    },
                    new Recipe
                    {
                        Name = "Shrimp Scampi",
                        Createdin = DateTime.Parse("2023-06-25"),
                        Type = "Seafood",
                        Price = 20.25M
                    },
                    new Recipe
                    {
                        Name = "Vegetable Lasagna",
                        Createdin = DateTime.Parse("2023-07-12"),
                        Type = "Vegetarian",
                        Price = 16.99M
                    },
                    new Recipe
                    {
                        Name = "Steak with Mushroom Sauce",
                        Createdin = DateTime.Parse("2023-08-08"),
                        Type = "American",
                        Price = 24.99M
                    },
                    new Recipe
                    {
                        Name = "Pad Thai",
                        Createdin = DateTime.Parse("2023-09-21"),
                        Type = "Asian",
                        Price = 17.50M
                    },
                    new Recipe
                    {
                        Name = "Lemon Herb Roasted Chicken",
                        Createdin = DateTime.Parse("2023-10-30"),
                        Type = "American",
                        Price = 19.99M
                    }
                    // Add more recipes as needed
                );
                context.SaveChanges();
            }
        }
    }
}
