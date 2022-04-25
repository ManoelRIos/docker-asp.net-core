namespace livraria.Models;

public class Livro
{
  public int Id {get;set}

  public string? Titulo {get;set;}
}
/opt/mssql-tools/bin/sqlcmd -S localhost -U SA -P StrongPass123456