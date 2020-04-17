---
title: Announcing the Azure Storage v12 client libraries
description: This blog post outlines information on the new Azure Storage v12 client libraries and explains how to get started.
author: ripohane
ms.author: ripohane
ms.date: 04/03/2020
---

# Announcing the Azure Storage v12 SDKs

We are excited to broadcast the new Azure Storage v12 SDKs that were recently made Generally Available (GA). The Azure SDKs in .NET, Java, Python, and JavaScript/Node.js have been re-architected to better suit developer preferences. Our new libraries ensure thread safety and improved performance. We support both synchronous and asynchronous APIs in all the libraries that are GA. Of course, the libraries are equipped with all the core functionalities of the previous versions (HTTP retries, logging, various auth protocols, etc.). After significant development and customer feedback during the preview phases, we have also reached feature parity for most major scenarios.


Above all, we have changed the experience of using our libraries. We wanted to ease the learning curve that programmers face when adopting our services, so we created libraries which are more idiomatic to their language. The storage libraries are also consistent across Azure services, so learning one will make it easier to learn the others. We will be fully supporting them by keeping them open sourced on GitHub ([.NET](https://github.com/Azure/azure-sdk-for-net/tree/master/sdk/storage), [Java](https://github.com/Azure/azure-sdk-for-java/tree/master/sdk/storage), [Python](https://github.com/Azure/azure-sdk-for-python/tree/master/sdk/storage), [JS/Node](https://github.com/Azure/azure-sdk-for-js/tree/master/sdk/storagehttps://github.com/Azure/azure-sdk-for-js/tree/master/sdk/storage)) and maintaining them with regularly updated documentation.

Feel free to learn more about the guidelines followed to create these SDKs by visiting the [.NET guidelines](https://azure.github.io/azure-sdk/dotnet_introduction.html), [Java guidelines](https://azure.github.io/azure-sdk/java_introduction.html), [Python guidelines](https://azure.github.io/azure-sdk/python_design.html), and/or [JavaScript guidelines](https://azure.github.io/azure-sdk/typescript_design.html) pages.


## Getting started

If you are new to the Azure Storage client libraries, follow our quickstarts to get set up in minutes. From there, explore reference documentation and refer to code samples to master the libraries.

With this new architecture comes breaking changes. For users interested in migrating their legacy code, visit our comprehensive guides.

| Quickstart | API reference | Samples |
|------------|---------------|---------|
| [.NET Quickstart](https://docs.microsoft.com/azure/storage/blobs/storage-quickstart-blobs-dotnet) | [.NET Reference](https://docs.microsoft.com/en-us/dotnet/api/overview/azure/storage?view=azure-dotnet) | [.NET Samples](https://docs.microsoft.com/azure/storage/common/storage-samples-dotnet?toc=%2fazure%2fstorage%2fblobs%2ftoc.json) |
| [Java Quickstart](https://docs.microsoft.com/azure/storage/blobs/storage-quickstart-blobs-java) | [Java Reference](https://azuresdkdocs.blob.core.windows.net/$web/java/azure-storage-blob/12.0.0/index.html) | [Java Samples](https://docs.microsoft.com/azure/storage/common/storage-samples-java?toc=%2fazure%2fstorage%2fblobs%2ftoc.json) |
| [Python Quickstart](https://docs.microsoft.com/azure/storage/blobs/storage-quickstart-blobs-python) | [Python Reference](https://docs.microsoft.com/en-us/python/api/overview/azure/storage-index?view=azure-python) | [Python Samples](https://docs.microsoft.com/azure/storage/common/storage-samples-python?toc=%2fazure%2fstorage%2fblobs%2ftoc.json) |
| [JavaScript Quickstart](https://docs.microsoft.com/azure/storage/blobs/storage-quickstart-blobs-nodejs) | [JavaScript Reference](https://docs.microsoft.com/en-us/javascript/api/overview/azure/storage-overview?view=azure-node-latest) | [JavaScript Samples](https://docs.microsoft.com/azure/storage/common/storage-samples-javascript?toc=%2fazure%2fstorage%2fblobs%2ftoc.json) |

## Announcing Deprecation

With the introduction of our new libraries come the deprecation of our old libraries. All previous versions of the .NET, Java, Python, and JavaScript libraries will be deprecated. For the next 12 months the legacy libraries will be updated on exceptional bases (security vulnerabilities, major asks, etc.) and we will continue providing documentation for the previous versions of the libraries. Refer to our [Lifecycle FAQ](https://support.microsoft.com/en-us/help/18486/lifecycle-faq-azure) page.

Note that we have officially moved off our old GitHub repo links. The table below shows the mapping from the old repos to the new repos.

| Old repo | New repo |
|----------|----------|
| github.com/azure/azure-storage-net | github.com/azure/azure-sdk-for-net |
| github.com/azure/azure-storage-java | github.com/azure/azure-sdk-for-java |
| github.com/azure/azure-storage-python | github.com/azure/azure-sdk-for-python |
| github.com/azure/azure-storage-js | github.com/azure/azure-sdk-for-js |


## Building community

In order to better engage with the developer community and build an ecosystem around Azure services, all our libraries have been open-sourced. The source code for each library can be found under the Azure organization in GitHub.

* [.NET Source Code](https://www.github.com/azure/azure-sdk-for-net)
* [Java Source Code](https://www.github.com/azure/azure-sdk-for-java)
* [Python Source Code](https://github.com/azure/azure-sdk-for-python)
* [JavaScript Source Code](https://github.com/azure/azure-sdk-for-js)

We urge developers to submit feature requests and bug fixes in the issues section of the corresponding GitHub repositories. Thanks to preview users, we were able to address hundreds of issues with the client libraries before the public release of v12.
