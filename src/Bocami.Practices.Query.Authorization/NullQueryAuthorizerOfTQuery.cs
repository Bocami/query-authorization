using Bocami.Practices.Authorization;

namespace Bocami.Practices.Query.Authorization
{
    public sealed class NullQueryAuthorizer<TQuery> : NullAuthorizer<TQuery>, IQueryAuthorizer<TQuery>
        where TQuery : class, IQuery
    {
    }
}
