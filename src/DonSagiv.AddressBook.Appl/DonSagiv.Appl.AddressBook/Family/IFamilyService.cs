using DonSagiv.Domain.Standard.ResultPattern;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DonSagiv.Appl.AddressBook.Family;

public interface IFamilyService
{
    Task<IResult> UpsertAsync(IFamilyEntity familyEntityInput);
    Task<IResult<IFamilyEntity>> ReadAsync(Ulid familyTokenInput);
    Task<IResult> DeleteAsync(Ulid familyTokenInput);
    IResult<IAsyncEnumerable<IFamilyEntity>> AsQueryable();
}
