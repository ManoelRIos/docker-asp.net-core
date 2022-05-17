namespace System_WebAPI.Models
{
    public class ItemCardapio
    {
        public ItemCardapio() { }
        public ItemCardapio(int id, string name, string desc, float price, string category)
        {
            this.Id = id;
            this.Name = name;
            this.Desc = desc;
            this.Price = price;
            this.Category = category;

        }   
        public int Id { get; set; }        
        public string Name { get; set; }
        public string Desc { get; set; }
        public float Price { get; set; }
        public string Category { get; set; }

    }
}