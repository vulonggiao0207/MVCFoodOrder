using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVCFoodOrder.Models
{
    [Table("Food")]
    public class Food
    {        
        [Key]
        [Display(Name = "Number")]
        public int FoodID { get; set; }
        [Display(Name = "Food name")]
        public string FoodName { get; set; }
        [Display(Name = "Price")]
        public int price { get; set; }
        [Display(Name = "Quantity")]
        public int quantity { get; set; }
        [Display(Name = "Image")]
        public string image { get; set; }
    }
    public class FoodDBContext : DbContext
    {
        public DbSet<Food> Foods { get; set; }

        public System.Data.Entity.DbSet<MVCFoodOrder.Models.Orders> Orders { get; set; }
    }
}
