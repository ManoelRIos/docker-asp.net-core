namespace System_WebAPI.Models
{
    
    public class ItemAdicional
    {
        public ItemAdicional(int id, string name, float price)
        {
            this.Id = id;
            this.Name = name;
            this.Price = price;
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public float Price { get; set; }

    }
}