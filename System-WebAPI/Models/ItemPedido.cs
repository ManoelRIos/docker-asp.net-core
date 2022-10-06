namespace System_WebAPI.Models
{
    public class ItemPedido
    {
        public ItemPedido() {}

        public ItemPedido(int id, float price, string observation)
        {
            this.Id = id;
            this.Price = price;
            this.Observation = observation;
        }
        public int Id { get; set; }
        public float Price { get; set; }
        public string Observation { get; set; }
    }
}