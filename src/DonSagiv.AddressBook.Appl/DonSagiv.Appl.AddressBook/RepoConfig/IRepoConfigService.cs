using DonSagiv.Appl.DataAccess.Repositories;

namespace DonSagiv.Appl.AddressBook.RepoConfig;

public interface IRepoConfigService
{
    IRepositoryConfig FetchRepositoryConfig();
}
