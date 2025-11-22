using DonSagiv.Domain.AddressBook.Family;
using DonSagiv.Domain.Standard.DependencyInjection;
using DonSagiv.Domain.Standard.Entities;

namespace DonSagiv.Appl.AddressBook.Family;

[Export(typeof(IFamilyEntity))]
internal class FamilyEntity : EntityModel<IFamily>, IFamilyEntity
{

}
