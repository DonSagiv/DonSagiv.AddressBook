using DonSagiv.Domain.Standard.DependencyInjection;

namespace DonSagiv.Domain.AddressBook.Family;

[Export(typeof(IFamily))]
internal record Family : IFamily
{
    public string FamilyName { get; set; }
}
