using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Core.Models
{
    public class Pizza
    {
        [Key]
        public int Id { get; set; }
        [DisplayName("Pizza Name")]
        public string PizzaName { get; set; }
        [DisplayName("Pizza Description")]
        public string Description { get; set; }
        [DisplayName("Item Number")]
        public string ItemNumber { get; set; }
        [DisplayName("Item Size")]
        public string ItemSize { get; set; }

    }
}
