using GraphQL.Types;

namespace AspnetCore_GraphQL
{
  public class AppSchema : Schema
  {
    public AppSchema(IServiceProvider provider, AppQuery query) : base(provider)
    {
      Query = query;
    }
  }
 
}
