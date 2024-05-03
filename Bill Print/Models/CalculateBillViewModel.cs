using Bill_Print.Models.Dynamic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bill_Print.Models
{
    public class CalculateBillViewModel
    {
        public int id { get; set; }
        public string name { get; set; }
        public string? Address { get; set; }
        public string? Pan_No { get; set; }
        public decimal Price { get; set; }
        public int ItemNameId { get; set; }
        [ForeignKey(nameof(ItemNameId))]
        public virtual ItemName Name { get; set; }
        public decimal? TotalPrice { get; set; }
        public int BillNo { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.UtcNow;

    }
}
