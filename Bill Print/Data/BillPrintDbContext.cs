using Bill_Print.Models.Dynamic;
using Microsoft.EntityFrameworkCore;

namespace Bill_Print.Data
{
    public class BillPrintDbContext: DbContext
    {
        public BillPrintDbContext(DbContextOptions<BillPrintDbContext>options):base(options) 
        {
            
        }
        public DbSet<ItemName> ItemNames { get; set; }
        public DbSet<CalculateBill> CalculateBills { get; set; }
    }
}
