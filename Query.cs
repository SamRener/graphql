namespace AspnetCore_GraphQL
{
  public class Query(ICategoriaRepository repository)
  {
    [UseProjection]
    [UseFiltering]
    [UseSorting]
    public List<Categoria> GetAll() => repository.GetAll();
  }

  public interface ICategoriaRepository
  {
    List<Categoria> GetAll();

    Categoria Add(Categoria categoria);
  }
  public class CategoriaRepository : ICategoriaRepository
  {
    List<Categoria> db = new List<Categoria>();
    public Categoria Add(Categoria categoria)
    {
      db.Add(categoria);

      return db.Last();
    }

    public List<Categoria> GetAll()
    {
      return db;
    }
  }
}
