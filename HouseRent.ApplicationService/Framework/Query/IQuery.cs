using HouseRent.Core.Domain.Framework;
using MediatR;

namespace HouseRent.ApplicationService.Framework.Query;

public interface IQuery<T> : IRequest<Result<T>>
{
}
