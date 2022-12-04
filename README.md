---
page_type: sample
languages:
- csharp
products:
- azure
extensions:
  services: Container-Instance
  platforms: dotnet
---

# Manage Azure Container Instances with an existing Azure File Share using C# #

 Azure Container Instance sample for managing container instances with Azure File Share mount.
    - Create a storage account and an Azure file share resource
    - Create an Azure container instance using Docker image "seanmckenna/aci-hellofiles" with a mount to the file share from above
    - Retrieve container log content
    - Delete the container group resource


## Running this Sample ##

To run this sample:

Set the environment variable `AZURE_AUTH_LOCATION` with the full path for an auth file. See [how to create an auth file](https://github.com/Azure/azure-libraries-for-net/blob/master/AUTH.md) and [Guide for migrating to azure-identity from azure-common](https://github.com/Azure/azure-sdk-for-python/blob/main/sdk/identity/azure-identity/migration_guide.md).
Example of the auth file:

~~~
{
       "clientId": "ad735158-65ca-11e7-ba4d-ecb1d756380e",
       "clientSecret": "****",
       "subscriptionId": "bfc42d3a-65ca-11e7-95cf-ecb1d756380e",
       "tenantId": "c81da1d8-65ca-11e7-b1d1-ecb1d756380e",
       "activeDirectoryEndpointUrl": "https://login.microsoftonline.com",
       "resourceManagerEndpointUrl": "https://management.azure.com/",
       "activeDirectoryGraphResourceId": "https://graph.windows.net/",
       "sqlManagementEndpointUrl": "https://management.core.windows.net:8443/",
       "galleryEndpointUrl": "https://gallery.azure.com/",
       "managementEndpointUrl": "https://management.core.windows.net/"
   }
~~~

Alternatively, you can explicitly set following environment variables. See method **GetEnvironment**.

~~~
    Environment.SetEnvironmentVariable("ClientId", "ad735158-65ca-11e7-ba4d-ecb1d756380e");
    Environment.SetEnvironmentVariable("ClientSecret", "****");
    Environment.SetEnvironmentVariable("TenantId", "c81da1d8-65ca-11e7-b1d1-ecb1d756380e");
    Environment.SetEnvironmentVariable("SubscriptionId", "bfc42d3a-65ca-11e7-95cf-ecb1d756380e");
~~~

~~~
    git clone https://github.com/Azure-Samples/aci-dotnet-manage-container-instances-2.git

    cd aci-dotnet-manage-container-instances-2

    dotnet build

    dotnet run
~~~

## More information ##

[Azure Management Libraries for C#](https://github.com/Azure/azure-sdk-for-net/tree/Fluent)
[Azure .Net Developer Center](https://azure.microsoft.com/en-us/develop/net/)
If you don't have a Microsoft Azure subscription you can get a FREE trial account [here](http://go.microsoft.com/fwlink/?LinkId=330212)

---

This project has adopted the [Microsoft Open Source Code of Conduct](https://opensource.microsoft.com/codeofconduct/). For more information see the [Code of Conduct FAQ](https://opensource.microsoft.com/codeofconduct/faq/) or contact [opencode@microsoft.com](mailto:opencode@microsoft.com) with any additional questions or comments.