namespace DonSagiv.Domain.AddressBook.Address;

internal interface IAddress
{
    public string Street { get; set; }
    public string City { get; set; }
    public string State { get; set; }
    public string ZipCode { get; set; }
    public string Country { get; set; }
}
