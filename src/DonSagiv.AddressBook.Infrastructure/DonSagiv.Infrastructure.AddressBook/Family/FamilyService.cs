using DonSagiv.Appl.AddressBook.Family;
using DonSagiv.Appl.DataAccess.RepositorySets;
using DonSagiv.Domain.Standard.DependencyInjection;
using DonSagiv.Domain.Standard.ResultPattern;
using DonSagiv.Infrastructure.AddressBook.Services;

namespace DonSagiv.Infrastructure.AddressBook.Family
{
    [Export(typeof(IFamilyService))]
    internal class FamilyService : EntityServiceBase, IFamilyService
    {
        #region Fields
        private IRepositorySet<IFamilyEntity>? _repositorySet;
        #endregion

        #region Methods
        public Task<IResult> InitializeAsync()
        {
            
        }

        public IResult<IAsyncEnumerable<IFamilyEntity>> AsQueryable()
        {
            throw new NotImplementedException();
        }

        public Task<IResult> DeleteAsync(Ulid familyTokenInput)
        {
            throw new NotImplementedException();
        }

        public Task<IResult<IFamilyEntity>> ReadAsync(Ulid familyTokenInput)
        {
            throw new NotImplementedException();
        }

        public Task<IResult> UpsertAsync(IFamilyEntity familyEntityInput)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
