namespace Bill_Print.Models.Dynamic
{
    public class ItemName
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.UtcNow;

    }
}
