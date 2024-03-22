using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace RecipeWebMvc.Models;

    public class Recipe
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        [Display(Name = "Created In")]
        [DataType(DataType.Date)]
        public DateTime Createdin { get; set; }
        public string? Type { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
            public decimal Price { get; set; }
}

