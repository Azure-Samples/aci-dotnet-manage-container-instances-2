---
services: Container-Instance
platforms: dotnet
author: milismsft
---

# Manage Azure Container Instances with an existing Azure File Share using C# #

          Azure Container Instance sample for managing container instances with Azure File Share mount.
             - Create a storage account and an Azure file share resource
             - Create an Azure container instance using Docker image "seanmckenna/aci-hellofiles" with a mount to the file share from above
             - Retrieve container log content
             - Delete the container group resource


## Running this Sample ##

To run this sample:

Set the environment variable `AZURE_AUTH_LOCATION` with the full path for an auth file. See [how to create an auth file](https://github.com/Azure/azure-libraries-for-java/blob/master/AUTH.md).

    git clone https://github.com/Azure-Samples/aci-dotnet-manage-container-instances-2.git

    cd aci-dotnet-manage-container-instances-2

    dotnet restore

    dotnet run

## More information ##

[Azure Management Libraries for C#](https://github.com/Azure/azure-sdk-for-net/tree/Fluent)
[Azure .Net Developer Center](https://azure.microsoft.com/en-us/develop/net/)
If you don't have a Microsoft Azure subscription you can get a FREE trial account [here](http://go.microsoft.com/fwlink/?LinkId=330212)

---

This project has adopted the [Microsoft Open Source Code of Conduct](https://opensource.microsoft.com/codeofconduct/). For more information see the [Code of Conduct FAQ](https://opensource.microsoft.com/codeofconduct/faq/) or contact [opencode@microsoft.com](mailto:opencode@microsoft.com) with any additional questions or comments.