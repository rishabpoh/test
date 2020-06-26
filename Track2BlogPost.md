---
title: Announcing the Azure Storage v12 client libraries
description: This blog post outlines information on the new Azure Storage v12 client libraries and explains how to get started.
author: ripohane
ms.author: ripohane
ms.date: 05/018/2020
---

# Announcing the Azure Storage v12 SDKs

We are excited to broadcast the new Azure Storage v12 SDKs that were recently made Generally Available (GA). The Azure SDKs in .NET, Java, Python, and JavaScript/Node.js have been re-architected to better suit developer preferences.

## Benefits of v12

Our new libraries ensure thread safety and have improved performance. We support both synchronous and asynchronous APIs in all the libraries that are GA. The libraries are equipped with all core functionalities of the previous versions (HTTP retries, logging, various auth protocols, etc.).

You will notice a change in the experience using our libraries. In order to ease the learning curve that programmers face when adopting our services, we made our libraries more idiomatic to their language. The storage libraries are also consistent across Azure services, so learning one will make it easier to learn the others. These libraries are supported, fully documented, and open-sourced ([.NET](https://github.com/Azure/azure-sdk-for-net/tree/master/sdk/storage), [Java](https://github.com/Azure/azure-sdk-for-java/tree/master/sdk/storage), [Python](https://github.com/Azure/azure-sdk-for-python/tree/master/sdk/storage), [JS/Node](https://github.com/Azure/azure-sdk-for-js/tree/master/sdk/storagehttps://github.com/Azure/azure-sdk-for-js/tree/master/sdk/storage)).

Feel free to learn more about the guidelines followed to create these SDKs by visiting the [.NET guidelines](https://azure.github.io/azure-sdk/dotnet_introduction.html), [Java guidelines](https://azure.github.io/azure-sdk/java_introduction.html), [Python guidelines](https://azure.github.io/azure-sdk/python_design.html), and/or [JavaScript guidelines](https://azure.github.io/azure-sdk/typescript_design.html) pages.


## Getting started

If you are new to the Azure Storage client libraries, follow our quickstarts to get set up in minutes. From there, explore reference documentation and refer to code samples to master the libraries. With this new architecture comes breaking changes. For users interested in migrating their legacy code, visit our comprehensive guides\*.

| Quickstart | API reference | Samples |
|------------|---------------|---------|
| [.NET Quickstart](https://docs.microsoft.com/azure/storage/blobs/storage-quickstart-blobs-dotnet) | [.NET Reference](https://docs.microsoft.com/en-us/dotnet/api/overview/azure/storage?view=azure-dotnet) | [.NET Samples](https://docs.microsoft.com/azure/storage/common/storage-samples-dotnet?toc=%2fazure%2fstorage%2fblobs%2ftoc.json) |
| [Java Quickstart](https://docs.microsoft.com/azure/storage/blobs/storage-quickstart-blobs-java) | [Java Reference](https://azuresdkdocs.blob.core.windows.net/$web/java/azure-storage-blob/12.0.0/index.html) | [Java Samples](https://docs.microsoft.com/azure/storage/common/storage-samples-java?toc=%2fazure%2fstorage%2fblobs%2ftoc.json) |
| [Python Quickstart](https://docs.microsoft.com/azure/storage/blobs/storage-quickstart-blobs-python) | [Python Reference](https://docs.microsoft.com/en-us/python/api/overview/azure/storage-index?view=azure-python) | [Python Samples](https://docs.microsoft.com/azure/storage/common/storage-samples-python?toc=%2fazure%2fstorage%2fblobs%2ftoc.json) |
| [JavaScript Quickstart](https://docs.microsoft.com/azure/storage/blobs/storage-quickstart-blobs-nodejs) | [JavaScript Reference](https://docs.microsoft.com/en-us/javascript/api/overview/azure/storage-overview?view=azure-node-latest) | [JavaScript Samples](https://docs.microsoft.com/azure/storage/common/storage-samples-javascript?toc=%2fazure%2fstorage%2fblobs%2ftoc.json) |

\*In addition to the links above, we have published migration guides for a few popular libraries: [.NET blob](), [Java blob](https://github.com/Azure/azure-sdk-for-java/tree/master/sdk/storage/azure-storage-blob/migrationGuides).


## Announcing Deprecation

With the introduction of our new libraries come the deprecation of our old libraries. Now that our v12 libraries have feature parity for most major scenarios, all previous versions of the .NET, Java, Python, and JavaScript libraries will be deprecated. For the next 12 months, the deprecated libraries will be updated on exceptional bases; security vulnerabilities and major asks. We will continue providing documentation for the previous versions of the libraries and archive them only after a year. Refer to our [Lifecycle FAQ](https://support.microsoft.com/en-us/help/18486/lifecycle-faq-azure) page.

Deprecated libraries: .NET v11, Java v8, Python v2, Node.js v2.

> [!NOTE]
> We have officially moved off of our old GitHub repo links. The table below shows the mapping from the old repos to the new repos.

| Old repo | New repo |
|----------|----------|
| github.com/azure/azure-storage-net | github.com/azure/azure-sdk-for-net |
| github.com/azure/azure-storage-java | github.com/azure/azure-sdk-for-java |
| github.com/azure/azure-storage-python | github.com/azure/azure-sdk-for-python |
| github.com/azure/azure-storage-js | github.com/azure/azure-sdk-for-js |


## Building community

In order to better engage with the developer community and build an ecosystem around Azure services, all our libraries are open-sourced. The source code for each library can be found under the Azure organization in GitHub.

* [.NET Source Code](https://www.github.com/azure/azure-sdk-for-net)
* [Java Source Code](https://www.github.com/azure/azure-sdk-for-java)
* [Python Source Code](https://github.com/azure/azure-sdk-for-python)
* [JavaScript Source Code](https://github.com/azure/azure-sdk-for-js)

We urge developers to submit feature requests and bug fixes in the issues section of the corresponding GitHub repositories. Thank you for your continued feedback and looking forward to the continued partnership. 
