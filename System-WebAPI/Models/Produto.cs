namespace System_WebAPI.Models
{
  public class Produto
  {
    public Produto() { }
    public Produto(int id, string name, int qtd, string undMed)
    {
      this.Id = id;
      this.Name = name;
      this.Qtd = qtd;
      this.UndMed = undMed;

    }
    public int Id { get; set; }
    public string Name { get; set; }
    public int Qtd { get; set; }
    public string UndMed { get; set; }
  }
}