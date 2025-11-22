using DonSagiv.Appl.DataAccess.Repositories;
using DonSagiv.Appl.DataAccess.RepositoryHosts;
using DonSagiv.Domain.AddressBook.Extensions;
using DonSagiv.Domain.Standard.DependencyInjection;
using System;

namespace DonSagiv.Appl.AddressBook.RepoConfig;

[Export(typeof(IRepoConfigService), creationPolicy: CreationPolicy.Singleton)]
internal class RepoConfigService : IRepoConfigService
{
    #region Fields
    private readonly IRepositoryConfig _repoConfig;
    #endregion

    #region Constructor
    public RepoConfigService(Func<IRepositoryConfig> repoConfigFactory,
        Func<IRepositoryHostConfig> hostConfigFactory)
    {
        var repoPlatform = Environment.GetEnvironmentVariable(EnvironmentVariableNames.REPO_PLATFORM);
        var repoConnectionString = Environment.GetEnvironmentVariable(EnvironmentVariableNames.REPO_CONNECTION_STRING);
        var repoDatabaseName = Environment.GetEnvironmentVariable(EnvironmentVariableNames.REPO_DATABASE_NAME);

        var hostConfig = hostConfigFactory();

        hostConfig.DatabasePlatform = repoPlatform;
        hostConfig.ConnectionString = repoConnectionString;

        _repoConfig = repoConfigFactory();

        _repoConfig.HostConfig = hostConfig;
        _repoConfig.RepositoryName = repoDatabaseName;
    }
    #endregion

    #region Methods
    public IRepositoryConfig FetchRepositoryConfig()
    {
        return _repoConfig;
    }
    #endregion
}
