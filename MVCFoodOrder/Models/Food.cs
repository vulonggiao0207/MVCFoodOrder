using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVCFoodOrder.Models
{
    [Table("Food")]
    public class Food
    {        
        [Key]
        public int FoodID { get; set; }
        public string FoodName { get; set; }
        public int price { get; set; }
        public int quantity { get; set; }
        public string image { get; set; }
    }
    public class FoodDBContext : DbContext
    {
        public DbSet<Food> Foods { get; set; }
    }
}
