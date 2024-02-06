namespace PC_STORE.Models.Data
{
    public class Order
    {
        public Guid Id { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
    }
}
