using System;

namespace DonSagiv.Domain.AddressBook.Person;

public interface IPerson
{
    public string Name { get; set; }
    public DateTime? DateOfBirth { get; set; }

    public int? Age();
}
