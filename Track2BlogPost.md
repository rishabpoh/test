---
title: Announcing the Azure Storage v12 client libraries
description: This blog post outlines information on the new Azure Storage v12 client libraries and explains how to get started.
author: ripohane
ms.author: ripohane
ms.date: 02/25/2020
---

# Announcing the Azure Storage v12 client libraries

For nearly two years now, there has been a big push within the Azure organization to build SDKs which are consistent across services and idiomatic to each programming language. With the goal being to ease the learning curve that programmers face when adopting our new services, we were able to create an architecture which is more resilient, performant, reliable, and robust. All while embracing the ecosystem native to each language. There will also be familiarity in that once you learn how to use features in one library, you will also know how to use them in others. This architecture has been applied to our v12 client libraries in .NET, Java, Python, and JavaScript.

The new Azure Storage client libraries offer full support of both synchronous and asynchronous APIs. All v12 libraries are thread safe and offer core functionalities like HTTP retries, logging, transport protocols, authentication protocols, etc. While in preview, we also made the necessary improvements to ensure parity with legacy versions for all major scenarios.

These client libraries are generally available now. Although breaking changes were introduced, this new architecture will stand the test of time. We are proud to announce the v12 client libraries.

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

The legacy versions of each library remain supported and will be updated on an exceptional basis, such as a security vulnerability. Versions being deprecated include .NET v11, Java v11, Python v2, JavaScript v10, and all other previous versions.

Note that we have officially moved off our old GitHub repo links. The table below shows the mapping from the old repos to the new repos.

| Old repo | New repo |
|----------|----------|
| github.com/azure/azure-storage-net | github.com/azure/azure-sdk-for-net |
| github.com/azure/azure-storage-java | github.com/azure/azure-sdk-for-java |
| github.com/azure/azure-storage-python | github.com/azure/azure-sdk-for-python |
| github.com/azure/azure-storage-js | github.com/azure/azure-sdk-for-js |
