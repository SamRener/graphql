namespace AspnetCore_GraphQL
{
  public class Categoria
  {
    public Categoria()
    {
      
    }
    public Categoria(string id, string name)
    {
      Id = id;
      Name = name;
    }

    public string Id { get; set; }
    public string Name { get; set; }
  }
}
