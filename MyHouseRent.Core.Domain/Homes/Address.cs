namespace HouseRent.Core.Domain.Homes;

//public record Address
//{
//    public Address(
//        string Phone,
//        string PostalCode,
//        string Address)
//    {
//        this.Phone = Phone;
//        this.Address = Address;
//        this.PostalCode = PostalCode;
//    }

//    public string Phone { get;  }
//    public string PostalCode { get; }
//    public string Address { get; }
//}

public record Address(
        string phone,
        string postalCode,
        string address);
    

