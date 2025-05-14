namespace AspnetCore_GraphQL
{
  public class Mutation(ICategoriaRepository repository)
  {
    public Categoria CreateCategoria(string id, string name){
      return repository.Add(new Categoria(id, name));
    }
  }
}
