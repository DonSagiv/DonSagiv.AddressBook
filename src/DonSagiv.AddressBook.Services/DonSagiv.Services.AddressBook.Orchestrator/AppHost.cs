using Aspire.Hosting;
using Projects;

var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<DonSagiv_UI_AddressBook_Blazor>("addressbook");

builder.Build().Run();
