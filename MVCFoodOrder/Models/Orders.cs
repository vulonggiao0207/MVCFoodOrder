using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVCFoodOrder.Models
{
    [Table("Orders")]
    public class Orders
    {
        [Key]
        [Display(Name ="Order Number")]
        public int OrderID { get; set; }
        [Display(Name = "Order Name")]
        public string OrderName { get; set; }
        [Display(Name = "Order Date")]
        public string OrderDate { get; set; }
        [Display(Name = "Paid")]
        public bool Paid { get; set; }
        [Display(Name = "Amount Left")]
        public int AmountLeft { get; set; }
        [Display(Name = "Total")]
        public int Total { get; set; }
    }
    public class OrdersDBContext : DbContext
    {        public DbSet<Orders> OrdersList { get; set; }
    }
}