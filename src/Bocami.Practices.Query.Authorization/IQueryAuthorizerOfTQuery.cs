using Bocami.Practices.Authorization;

namespace Bocami.Practices.Query.Authorization
{
    public interface IQueryAuthorizer<in TQuery> : IAuthorizer<TQuery>
        where TQuery : class, IQuery
    {
    }
}
