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

Set the environment variable `AZURE_AUTH_LOCATION` with the full path for an auth file. See [how to create an auth file](https://github.com/Azure/azure-libraries-for-net/blob/master/AUTH.md).

    git clone https://github.com/Azure-Samples/aci-dotnet-manage-container-instances-2.git

    cd aci-dotnet-manage-container-instances-2

    dotnet build

    bin\Debug\net452\ManageWithManualAzureFileShareMountCreation.exe

In addition to creating the auth file, the Azure.ContainerInstance provider may need to be [registered](https://docs.microsoft.com/en-us/azure/azure-resource-manager/troubleshooting/error-register-resource-provider?tabs=azure-cli). This can be achieved by running `az provider register --namespace Microsoft.ContainerInstance` on the Cloud Shell or Azure CLI.

If the provider is not registered, users may experience errors, such as 

`Microsoft.Rest.Azure.CloudException: The client '<clientID>' with object id '<objectID>' does not have authorization to perform action 'Microsoft.ContainerInstance/register/action' over scope '/subscriptions/<subscriptionID>' or the scope is invalid. If access was recently granted, please refresh your credentials.`

## More information ##
[Azure Resource Providers](https://docs.microsoft.com/en-us/azure/azure-resource-manager/management/resource-providers-and-types)

[Azure Management Libraries for C#](https://github.com/Azure/azure-sdk-for-net/tree/Fluent)

[Azure .Net Developer Center](https://azure.microsoft.com/en-us/develop/net/)

If you don't have a Microsoft Azure subscription you can get a FREE trial account [here](http://go.microsoft.com/fwlink/?LinkId=330212)

---

This project has adopted the [Microsoft Open Source Code of Conduct](https://opensource.microsoft.com/codeofconduct/). For more information see the [Code of Conduct FAQ](https://opensource.microsoft.com/codeofconduct/faq/) or contact [opencode@microsoft.com](mailto:opencode@microsoft.com) with any additional questions or comments.
