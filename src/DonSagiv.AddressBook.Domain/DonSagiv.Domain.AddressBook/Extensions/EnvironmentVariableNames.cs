using System;
using System.Collections.Generic;
using System.Text;

namespace DonSagiv.Domain.AddressBook.Extensions;

public static class EnvironmentVariableNames
{
    #region Statics
    public const string REPO_PLATFORM = nameof(REPO_PLATFORM);
    public const string REPO_CONNECTION_STRING = nameof(REPO_CONNECTION_STRING);
    public const string REPO_DATABASE_NAME = nameof(REPO_DATABASE_NAME);
    #endregion
}
