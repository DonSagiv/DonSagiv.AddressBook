using DonSagiv.Domain.Standard.DependencyInjection;
using System;

namespace DonSagiv.Domain.AddressBook.Person;

[Export(typeof(IPerson))]
internal class Person : IPerson
{
    #region Properties
    public string Name { get; set; }
    public DateTime? DateOfBirth { get; set; }
    #endregion

    #region Methods
    public int? Age()
    {
        if (DateOfBirth is null)
        {
            return null;
        }

        var today = DateTime.Today;

        var age = today.Year - DateOfBirth.Value.Year;

        if (DateOfBirth.Value.Date > today.AddYears(-age))
        {
            age--;
        }

        return age;
    }
    #endregion
}
