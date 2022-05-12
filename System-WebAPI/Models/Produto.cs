namespace System_WebAPI.Models
{
  public class Produto
  {
    public Produto() { }
    public Produto(int id, string name, int qtd, string undMed)
    {
      this.id = id;
      this.name = name;
      this.qtd = qtd;
      this.undMed = undMed;

    }
    public int id { get; set; }
    public string name { get; set; }
    public int qtd { get; set; }
    public string undMed { get; set; }

  }
}