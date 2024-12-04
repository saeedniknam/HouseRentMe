using HouseRent.Core.Domain.Framework;

namespace HouseRent.Core.Domain.Users;

public class User : BaseEntity<int>
{
    private User(int id,
        FirstName firstName,
        LastName lastName,
        Mobile mobile,
        string nationalCode) : base(id)
    {
        FirstName = firstName;
        LastName = lastName;
        Mobile = mobile;
        NationalCode = nationalCode;
    }

    public FirstName FirstName { get; set; }
    public LastName LastName { get; set; }
    public Mobile Mobile { get; set; }
    public string NationalCode { get; set; }

    public User CreateUser(int id, FirstName firstName,
        LastName lastName,
        Mobile mobile,
        string nationalCode)
    {
        User user = new(id, firstName, lastName, mobile, nationalCode);
        user.AddDomainEvent(new CreateUserDomainEvent(id));
        return user;
    }
}
