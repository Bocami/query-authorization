using System;
using Bocami.Practices.Decorator;

namespace Bocami.Practices.Query.Authorization
{
    public abstract class AuthorizationQueryHandlerDecorator<TQuery, TQueryResult> : IQueryHandler<TQuery, TQueryResult>, IDecorator<IQueryHandler<TQuery, TQueryResult>>
        where TQuery : class, IQuery
        where TQueryResult : class, IQueryResult
    {
        private readonly IQueryHandler<TQuery, TQueryResult> queryHandler;
        private readonly IQueryAuthorizer<TQuery> queryAuthorizer;

        protected AuthorizationQueryHandlerDecorator(IQueryHandler<TQuery, TQueryResult> queryHandler, IQueryAuthorizer<TQuery> queryAuthorizer)
        {
            if (queryHandler == null)
                throw new ArgumentNullException("queryHandler");

            if (queryAuthorizer == null)
                throw new ArgumentNullException("queryAuthorizer");

            this.queryHandler = queryHandler;
            this.queryAuthorizer = queryAuthorizer;
        }

        public TQueryResult Handle(TQuery query)
        {
            queryAuthorizer.Authorize(query);

            return queryHandler.Handle(query);
        }
    }
}
