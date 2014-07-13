using Bocami.Practices.Authorization;

namespace Bocami.Practices.Query.Authorization
{
    public interface IQueryAuthorizer<TQuery> : IAuthorizer<TQuery>
        where TQuery : class, IQuery
    {
    }
}
