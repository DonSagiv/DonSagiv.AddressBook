using DonSagiv.Appl.Standard.DataAccess;
using DonSagiv.Domain.Standard.Entities;
using DonSagiv.Domain.Standard.ResultPattern;

namespace DonSagiv.Infrastructure.AddressBook.Services
{
    public abstract class EntityServiceBase
    {

    }

    public abstract class EntityServiceBase<TEntityModel> : EntityServiceBase
        where TEntityModel : IEntityModel
    {
        #region Properties
        protected IRepositorySet<TEntityModel>? RepositorySet { get; set; }
        protected bool IsInitialized { get; set; }
        #endregion

        #region Methods
        public Task<IResult<IRepositorySet>> InitializeAsync()
        {

        }
        #endregion
    }
}
