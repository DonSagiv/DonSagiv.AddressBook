using DonSagiv.Domain.Standard.DependencyInjection;

namespace DonSagiv.Domain.AddressBook.Address;

[Export(typeof(IAddress))]
internal class Adderss : IAddress
{
    #region Properties
    public string Street { get; set; }
    public string City { get; set; }
    public string State { get; set; }
    public string ZipCode { get; set; }
    public string Country { get; set; }
    #endregion
}
