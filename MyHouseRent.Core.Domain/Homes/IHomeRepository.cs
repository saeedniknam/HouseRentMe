namespace HouseRent.Core.Domain.Homes;

public interface IHomeRepository
{
    Task<Home?> GetHomeById(int id);

}
