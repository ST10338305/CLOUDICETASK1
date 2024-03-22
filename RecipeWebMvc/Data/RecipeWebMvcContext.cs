using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RecipeWebMvc.Models;

namespace RecipeWebMvc.Data
{
    public class RecipeWebMvcContext : DbContext
    {
        public RecipeWebMvcContext (DbContextOptions<RecipeWebMvcContext> options)
            : base(options)
        {
        }

        public DbSet<RecipeWebMvc.Models.Recipe> Recipe { get; set; } = default!;
    }
}
