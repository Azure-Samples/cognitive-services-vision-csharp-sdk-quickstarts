---
services: cognitive-services, computer vision
platforms: dotnet, c#
author: easyj2j
---

# Computer Vision C# SDK quickstart samples

This repository provides the latest sample code for Cognitive Services Computer Vision SDK quickstarts. These samples target the [Microsoft.Azure.CognitiveServices.Vision.ComputerVision 3.2.0](https://www.nuget.org/packages/Microsoft.Azure.CognitiveServices.Vision.ComputerVision/3.2.0) client library.

## Features

These samples demonstrate how to use the Computer Vision client library for C# to perform the following actions:

* Analyze an image
* Generate a thumbnail of an image
* Extract handwritten text from an image

 Two image input methods are demonstrated for each sample:

* Uploading a local image
* Specifying the URL of a remote image

## Getting Started

### Prerequisites

* You need a **subscription key** for the Computer Vision service to run the samples.  You can get free trial subscription keys from [Try Cognitive Services](https://azure.microsoft.com/try/cognitive-services/). For more information, see [How to obtain subscription keys](https://docs.microsoft.com/azure/cognitive-services/Computer-vision/vision-api-how-to-topics/howtosubscribe).
* Any edition of [Visual Studio 2017](https://www.visualstudio.com/downloads/).

### Quickstart

1. Clone or download the repository.
1. Navigate to the *ComputerVision* folder.
1. Double-click the *ComputerVision.sln* file to open the solution in Visual Studio.
1. Install the Computer Vision client library NuGet package.
   1. On the top menu, click **Tools**, select **NuGet Package Manager**, then **Manage NuGet Packages for Solution**.
   1. Click the **Browse** tab, and in the **Search** box type "Microsoft.Azure.CognitiveServices.Vision.ComputerVision".
   1. Select **Microsoft.Azure.CognitiveServices.Vision.ComputerVision** when it displays, then click the checkbox next to your project name, and **Install**.
1. Select the project to run by doing one of the following actions:
    * Use the dropdown combobox in the top menu to select the project.
    * Right-click the project and select **Set as StartUp Project**.
1. Open the *Program.cs* file associated with the project.
1. Replace `<Subscription Key>` with your valid subscription key.
1. Change `computerVision.Endpoint` to the Azure region associated with your subscription keys, if necessary.
1. Optionally, replace <`LocalImage>` with the path and file name of a local image (will be ignored if not set).
1. Optionally, set `remoteImageUrl` to a different image.
1. Run the program.

## Resources

* [Computer Vision service documentation](https://docs.microsoft.com/azure/cognitive-services/computer-vision/)
* [Computer Vision API - v2.0](https://westus.dev.cognitive.microsoft.com/docs/services/5adf991815e1060e6355ad44/operations/56f91f2e778daf14a499e1fa)
* [Microsoft.Azure.CognitiveServices.Vision.ComputerVision 3.2.0](https://www.nuget.org/packages/Microsoft.Azure.CognitiveServices.Vision.ComputerVision/3.2.0) NuGet package
