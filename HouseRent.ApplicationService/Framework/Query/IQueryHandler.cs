using HouseRent.Core.Domain.Framework;
using MediatR;

namespace HouseRent.ApplicationService.Framework.Query;

public interface IQueryHandler<TQuery, TResponse> : IRequestHandler<TQuery, Result<TResponse>>
    where TQuery : IQuery<TResponse>
{
}
