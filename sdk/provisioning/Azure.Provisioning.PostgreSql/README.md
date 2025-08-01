# Azure Provisioning PostgreSql client library for .NET

Azure.Provisioning.PostgreSql simplifies declarative resource provisioning in .NET.

## Getting started

### Install the package

Install the client library for .NET with [NuGet](https://www.nuget.org/ ):

```dotnetcli
dotnet add package Azure.Provisioning.PostgreSql
```

### Prerequisites

> You must have an [Azure subscription](https://azure.microsoft.com/free/dotnet/).

### Authenticate the Client

## Key concepts

This library allows you to specify your infrastructure in a declarative style using dotnet.  You can then use azd to deploy your infrastructure to Azure directly without needing to write or maintain bicep or arm templates.

## Examples

### Create a PostgreSQL Flexible Server

This example demonstrates how to create a PostgreSQL Flexible Server with Azure Active Directory authentication, based on the [Azure quickstart template](https://github.com/Azure/azure-quickstart-templates/blob/master/quickstarts/microsoft.dbforpostgresql/flexible-postgresql-with-aad/main.bicep).

```C# Snippet:PostgreSqlBasic
Infrastructure infra = new();

ProvisioningParameter adminLogin =
    new(nameof(adminLogin), typeof(string))
    {
        Description = "The administrator username of the server."
    };
infra.Add(adminLogin);

ProvisioningParameter adminPass =
    new(nameof(adminPass), typeof(string))
    {
        Description = "The administrator password of the server.",
        IsSecure = true
    };
infra.Add(adminPass);

ProvisioningParameter aadAdminName =
    new(nameof(aadAdminName), typeof(string))
    {
        Description = "The AAD admin username."
    };
infra.Add(aadAdminName);

ProvisioningParameter aadAdminOid =
    new(nameof(aadAdminOid), typeof(string))
    {
        Description = "The AAD admin Object ID."
    };
infra.Add(aadAdminOid);

PostgreSqlFlexibleServer server =
    new(nameof(server), PostgreSqlFlexibleServer.ResourceVersions.V2022_12_01)
    {
        Sku =
            new PostgreSqlFlexibleServerSku
            {
                Name = "Standard_D2ds_v4",
                Tier = PostgreSqlFlexibleServerSkuTier.GeneralPurpose
            },
        CreateMode = PostgreSqlFlexibleServerCreateMode.Default,
        Version = PostgreSqlFlexibleServerVersion.Ver14,
        AdministratorLogin = adminLogin,
        AdministratorLoginPassword = adminPass,
        AuthConfig =
            new PostgreSqlFlexibleServerAuthConfig
            {
                ActiveDirectoryAuth = PostgreSqlFlexibleServerActiveDirectoryAuthEnum.Enabled,
                PasswordAuth = PostgreSqlFlexibleServerPasswordAuthEnum.Disabled,
                TenantId = BicepFunction.GetTenant().TenantId
            },
        Storage =
            new PostgreSqlFlexibleServerStorage
            {
                StorageSizeInGB = 32
            },
        Backup =
            new PostgreSqlFlexibleServerBackupProperties
            {
                BackupRetentionDays = 7,
                GeoRedundantBackup = PostgreSqlFlexibleServerGeoRedundantBackupEnum.Disabled
            },
        HighAvailability = new PostgreSqlFlexibleServerHighAvailability
        {
            Mode = PostgreSqlFlexibleServerHighAvailabilityMode.Disabled
        }
    };
infra.Add(server);

PostgreSqlFlexibleServerActiveDirectoryAdministrator admin =
    new(nameof(admin), PostgreSqlFlexibleServer.ResourceVersions.V2022_12_01)
    {
        Parent = server,
        Name = aadAdminOid,
        TenantId = BicepFunction.GetSubscription().TenantId,
        PrincipalName = aadAdminName,
        PrincipalType = PostgreSqlFlexibleServerPrincipalType.ServicePrincipal
    };
infra.Add(admin);
```

## Troubleshooting

-   File an issue via [GitHub Issues](https://github.com/Azure/azure-sdk-for-net/issues).
-   Check [previous questions](https://stackoverflow.com/questions/tagged/azure+.net) or ask new ones on Stack Overflow using Azure and .NET tags.

## Next steps

## Contributing

For details on contributing to this repository, see the [contributing
guide][cg].

This project welcomes contributions and suggestions. Most contributions
require you to agree to a Contributor License Agreement (CLA) declaring
that you have the right to, and actually do, grant us the rights to use
your contribution. For details, visit <https://cla.microsoft.com>.

When you submit a pull request, a CLA-bot will automatically determine
whether you need to provide a CLA and decorate the PR appropriately
(for example, label, comment). Follow the instructions provided by the
bot. You'll only need to do this action once across all repositories
using our CLA.

This project has adopted the [Microsoft Open Source Code of Conduct][coc]. For
more information, see the [Code of Conduct FAQ][coc_faq] or contact
<opencode@microsoft.com> with any other questions or comments.

<!-- LINKS -->
[cg]: https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/resourcemanager/Azure.ResourceManager/docs/CONTRIBUTING.md
[coc]: https://opensource.microsoft.com/codeofconduct/
[coc_faq]: https://opensource.microsoft.com/codeofconduct/faq/
