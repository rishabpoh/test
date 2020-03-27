---
title: Announcing the Azure Storage v12 client libraries
description: This blog post outlines information on the new Azure Storage v12 client libraries and explains how to get started.
author: ripohane
ms.author: ripohane
ms.date: 02/25/2020
---

# Announcing the Azure Storage v12 client libraries

Azure SDK has spent the last year developing an architecture focused on easing the learning curve that programmers face when adopting our services. To achieve this, we prioritized embracing the ecosystem of each language, ensuring that naming conventions and syntax for methods are familiar with respect to language. We also maintained consistency across services, so developers will find that learning how to use one library will make it easier to pick up and take advantage of the other ones. The new Azure Storage client libraries offer full support of both synchronous and asynchronous APIs. All v12 libraries are thread safe and offer core functionalities like HTTP retries, logging, transport protocols, and authentication protocols. There is also feature parity, so all major scenarios covered by previous versions of the library can be done using the v12 equivalent. These libraries are more resilient, performant, reliable, and robust. After months of development and feedback, we are proud to announce the general availability of our v12 client libraries in [.NET](https://github.com/Azure/azure-sdk-for-net/tree/master/sdk/storage), [Java](https://github.com/Azure/azure-sdk-for-java/tree/master/sdk/storage), [Python](https://github.com/Azure/azure-sdk-for-python/tree/master/sdk/storage), and [JavaScript](https://github.com/Azure/azure-sdk-for-js/tree/master/sdk/storage).

Although breaking changes are introduced, this new architecture will stand the test of time. Upgrade your codebase to v12 to take advantage of the latest features. If you cannot update your codebase but would still like to utilize new features, note that v12 can be used side-by-side with a legacy version. Check out this [example]().
// Include side-by-side example
// Migration guidelines


## SDK guidelines

The v12 client libraries are approachable, dependable, idiomatic, and consistent. Check out the [.NET guidelines](https://azure.github.io/azure-sdk/dotnet_introduction.html), [Java guidelines](https://azure.github.io/azure-sdk/java_introduction.html), [Python guidelines](https://azure.github.io/azure-sdk/python_design.html), and [JavaScript guidelines](https://azure.github.io/azure-sdk/typescript_design.html).

### Approachable

* Open source libraries
* Channels to reach us include GitHub, Stack Overflow, and feedback.azure.com

### Dependable

* Visit our up-to-date reference documentation to learn more about the client libraries
* Each repository has a ChangeLog file to stay updated on feature additions, bug fixes, and breaking changes

### Idiomatic

* The v12 libraries embrace the ecosystem of each language
* Using the Python client library will feel more native to programming in Python, for example

### Consistent

* Our architecture is consistent across services, if you can use the Azure Storage client library in Python, then you won't have difficulty picking it up in .NET
* Once you learn how to use these features in one client library, you will know how to use them in other client libraries


## Getting started

If you are new to the Azure Storage client libraries, follow our quickstarts to get set up in minutes. From there, explore reference documentation and refer to code samples to master the libraries.

With this new architecture comes breaking changes. For users interested in migrating their legacy code, visit our comprehensive migration guides. If your existing code is functional and you aren't interested in new features, you don't have to migrate your old code, just start using the new v12 SDK for any additions.

| Quickstart | API reference | Samples |
|------------|---------------|---------|
| [.NET Quickstart](https://docs.microsoft.com/azure/storage/blobs/storage-quickstart-blobs-dotnet) | [.NET Reference](https://docs.microsoft.com/en-us/dotnet/api/overview/azure/storage?view=azure-dotnet) | [.NET Samples](https://docs.microsoft.com/azure/storage/common/storage-samples-dotnet?toc=%2fazure%2fstorage%2fblobs%2ftoc.json) |
| [Java Quickstart](https://docs.microsoft.com/azure/storage/blobs/storage-quickstart-blobs-java) | [Java Reference](https://azuresdkdocs.blob.core.windows.net/$web/java/azure-storage-blob/12.0.0/index.html) | [Java Samples](https://docs.microsoft.com/azure/storage/common/storage-samples-java?toc=%2fazure%2fstorage%2fblobs%2ftoc.json) |
| [Python Quickstart](https://docs.microsoft.com/azure/storage/blobs/storage-quickstart-blobs-python) | [Python Reference](https://docs.microsoft.com/en-us/python/api/overview/azure/storage-index?view=azure-python) | [Python Samples](https://docs.microsoft.com/azure/storage/common/storage-samples-python?toc=%2fazure%2fstorage%2fblobs%2ftoc.json) |
| [JavaScript Quickstart](https://docs.microsoft.com/azure/storage/blobs/storage-quickstart-blobs-nodejs) | [JavaScript Reference](https://docs.microsoft.com/en-us/javascript/api/overview/azure/storage-overview?view=azure-node-latest) | [JavaScript Samples](https://docs.microsoft.com/azure/storage/common/storage-samples-javascript?toc=%2fazure%2fstorage%2fblobs%2ftoc.json) |

## Building community

In order to better engage with the developer community and build an ecosystem around Azure services, all our libraries have been open-sourced. The source code for each library can be found under the Azure organization in GitHub.

* [.NET Source Code](https://www.github.com/azure/azure-sdk-for-net)
* [Java Source Code](https://www.github.com/azure/azure-sdk-for-java)
* [Python Source Code](https://github.com/azure/azure-sdk-for-python)
* [JavaScript Source Code](https://github.com/azure/azure-sdk-for-js)

We urge developers to submit feature requests and bug fixes in the issues section of the corresponding GitHub repositories. Thanks to preview users, we were able to address hundreds of issues with the client libraries before the public release of v12.

## Deprecation notice

The legacy versions of each client library in .NET, Java, Python, and JavaScript will be deprecated. They will only be updated on an exceptional basis, such as a security vulnerability.

Note that we have officially moved off our old GitHub repo links. The table below shows the mapping from the old repos to the new repos.

| Old repo | New repo |
|----------|----------|
| github.com/azure/azure-storage-net | github.com/azure/azure-sdk-for-net |
| github.com/azure/azure-storage-java | github.com/azure/azure-sdk-for-java |
| github.com/azure/azure-storage-python | github.com/azure/azure-sdk-for-python |
| github.com/azure/azure-storage-js | github.com/azure/azure-sdk-for-js |
