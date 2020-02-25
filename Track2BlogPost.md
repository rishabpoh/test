---
title: Announcing the Azure Storage v12 Client Libraries
description: This blog post outlines information surrounding our new v12 client libraries and explains how users can onboard.
author: ripohane
ms.author: ripohane
ms.date: 02/25/2020
---

# Announcing the Azure Storage v12 Client Libraries

We are excited to introduce the new and improved Azure Storage v12 client libraries. For nearly two years now, there has been a big push within the Azure organization to build SDKs which are consistent across services and idiomatic to each programming language. Our goal was to ease the learning curve that programmers inevitably face when adopting new services. The result, an architecture for the client libraries which is more resilient, performant, reliable, and robust. This architecture has been applied to our v12 client libraries in .NET, Java, Python, and JavaScript which are all now Generally Available. Although we introduce breaking changes with the new version, this architecture will stand against the test of time.  
Contrary to previous versions, this version embraces the ecosystem of each language. Once you learn how to use these features in one client library, you will know how to use them in other client libraries.

## SDK Guidelines
These libraries are idiomatic, consistent, approachable, and dependable. You can check out the [.NET guidelines](https://azure.github.io/azure-sdk/dotnet_introduction.html), [Java guidelines](https://azure.github.io/azure-sdk/java_introduction.html), [Python guidelines](https://azure.github.io/azure-sdk/python_design.html), and [JavaScript guidelines](https://azure.github.io/azure-sdk/typescript_design.html).  

### Approachable
- Open source libraries
- Channels to reach us include GitHub, feedback.azure.com, etc.

### Dependable
- Visit our up-to-date reference documentation to learn more about the client libraries
- Each repository has a ChangeLog file where you may stay updated on feature additions, bug fixes, and breaking changes  

### Idiomatic
- Contrary to previous versions, this version embraces the ecosystem of each language
- Using the python client library will feel more native to programming in Python, same goes for each other language

### Consistent
- Our architecture is consistent across services, if you can use the Azure Storage client library in Python, then you won’t have difficulty picking it up in .NET
- Once you learn how to use these features in one client library, you will know how to use them in other client libraries

## Improvements and Changes
The new Azure Storage client libraries offer full support of both synchronous and asynchronous APIs. Our Track 2 libraries are thread safe.

The Azure Blob Storage libraries offer three types of resources.
- The storage account: BlobServiceClient
- The container:  in the storage account via:
BlobContainerClient (.NET, Java)  
ContainerClient (Python, JS)
- The blob: in a container via BlobClient
Core functionalities like HTTP retries, logging, transport protocols, authentication protocols, etc.
The v12 SDKs feature side by side sync-over-async APIs

## Getting Started
If you are new to the Azure Storage client libraries, follow our Quickstarts to get set up in minutes. From there, you may explore reference documentation and/or refer to our code samples to master our libraries.
With this new architecture comes breaking changes. For users interested in migrating their legacy code, visit our comprehensive migration guides. If your existing code is functional and you aren’t interested in new features, you don’t have to migrate your old code, just start using the new v12 SDK for any additions.

| [.NET Quickstart](https://docs.microsoft.com/en-us/azure/storage/blobs/storage-quickstart-blobs-dotnet)  | [.NET Reference]()  | [.NET Samples](https://docs.microsoft.com/en-us/azure/storage/common/storage-samples-dotnet?toc=%2fazure%2fstorage%2fblobs%2ftoc.json) | [.NET Migration Guide]() |
| [Java Quickstart](https://docs.microsoft.com/en-us/azure/storage/blobs/storage-quickstart-blobs-java)  | [Java Reference]()  | [Java Samples](https://docs.microsoft.com/en-us/azure/storage/common/storage-samples-java?toc=%2fazure%2fstorage%2fblobs%2ftoc.json) | [Java Migration Guide]() |
| [Python Quickstart](https://docs.microsoft.com/en-us/azure/storage/blobs/storage-quickstart-blobs-python)  | [Python Reference]()  | [Python Samples](https://docs.microsoft.com/en-us/azure/storage/common/storage-samples-python?toc=%2fazure%2fstorage%2fblobs%2ftoc.json) | [Python Migration Guide]() |
| [JavaScript Quickstart](https://docs.microsoft.com/en-us/azure/storage/blobs/storage-quickstart-blobs-nodejs)  | [JavaScript Reference]()  | [JavaScript Samples](https://docs.microsoft.com/en-us/azure/storage/common/storage-samples-javascript?toc=%2fazure%2fstorage%2fblobs%2ftoc.json) | [JavaScript Migration Guide]() |

## Building a Community
In order to better engage with the developer community and build an ecosystem around Azure services, all our libraries have been open-sourced and can be found under the Azure organization in GitHub.

    www.github.com/Azure/Azure-sdk-for-[dotnet, java, python, js]

We urge developers to submit feature requests and bug fixes in the issues section of the corresponding repositories. Thanks to our preview users, we were able to address hundreds of issues with the client libraries before our public release. Our work is never over, and whether they be documentation issues, feature requests, or bug finds we encourage developers to submit issues in the respective GitHub repositories.

## Deprecation Notice

The legacy versions of each library remain supported and will be updated on an exceptional basis, such as any security vulnerabilities. Versions being deprecated include .NET v11, Java v11, Python v2, JavaScript v10, and all other previous versions.

NOTE: We have officially moved off our old GitHub repo links
Github.com/Azure/Azure-Storage-Net 	  ->   GitHub.com/Azure/Azure-SDK-for-Net
Github.com/Azure/Azure-Storage-Java 	->   GitHub.com/Azure/Azure-SDK-for-Java
Github.com/Azure/Azure-Storage-Python ->   GitHub.com/Azure/Azure-SDK-for-Python
Github.com/Azure/Azure-Storage-JS 	  ->   GitHub.com/Azure/Azure-SDK-for-JS
