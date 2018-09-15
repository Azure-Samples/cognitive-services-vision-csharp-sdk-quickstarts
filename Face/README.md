---
services: cognitive-services, face
platforms: dotnet, c#
author: easyj2j
---

# Cognitive Services Face C# SDK quickstart samples

This repository provides the latest sample code for Cognitive Services Face SDK quickstarts. These samples target the [Microsoft.Azure.CognitiveServices.Vision.Face 2.2.0-preview](https://www.nuget.org/packages/Microsoft.Azure.CognitiveServices.Vision.Face/2.2.0-preview) client library.

## Features

These samples demonstrate how to use the Face client library for C# to perform the following actions

* Detect faces in an image
* Get age and gender of each face

 Two image input methods are demonstrated for each sample:

* Uploading a local image
* Specifying the URL of a remote image

## Getting Started

### Prerequisites

* You need a **subscription key** for the Face service to run the samples.  You can get free trial subscription keys from [Try Cognitive Services](https://azure.microsoft.com/try/cognitive-services/).
* Any edition of [Visual Studio 2017](https://www.visualstudio.com/downloads/).

### Quickstart

1. Clone or download the repository.
1. Navigate to the *Face* folder.
1. Double-click the *Face.sln* file to open the solution in Visual Studio.
1. Install the Face client library NuGet package.
   1. On the top menu, click **Tools**, select **NuGet Package Manager**, then **Manage NuGet Packages for Solution**.
   1. Click the **Browse** tab and then select **Include prerelease**.
   1. In the **Search** box type "Microsoft.Azure.CognitiveServices.Vision.Face".
   1. Select **Microsoft.Azure.CognitiveServices.Vision.Face** when it displays, then click the checkbox next to your project name, and **Install**.
1. Open *Program.cs*.
1. Replace `<Subscription Key>` with your valid subscription key.
1. Change `faceEndpoint` to the Azure region associated with your subscription keys, if necessary.
1. Optionally, replace <`LocalImage>` with the path and file name of a local image (will be ignored if not set).
1. Optionally, set `remoteImageUrl` to a different image.
1. Run the program.

## Resources

* [Face service documentation](https://docs.microsoft.com/azure/cognitive-services/face/)
* [Face API](https://docs.microsoft.com/azure/cognitive-services/face/apireference)
* [Microsoft.Azure.CognitiveServices.Vision.Face 2.2.0-preview](https://www.nuget.org/packages/Microsoft.Azure.CognitiveServices.Vision.Face/2.2.0-preview) NuGet package