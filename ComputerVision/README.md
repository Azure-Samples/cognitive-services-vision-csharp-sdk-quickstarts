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
* Extract handwritten or printed text from an image
* Generate a thumbnail of an image

 Two image input methods are demonstrated for each sample:

* Uploading a local image
* Specifying the URL of a remote image

## Getting Started

### Prerequisites

* A Computer Vision subscription key. You can get a free trial subscription key from [Try Cognitive Services](https://azure.microsoft.com/try/cognitive-services/?api=computer-vision). Or, follow the instructions in [Create a Cognitive Services account](https://docs.microsoft.com/azure/cognitive-services/cognitive-services-apis-create-account) to subscribe to Computer Vision and get your key. Then, [create environment variables](https://docs.microsoft.com/azure/cognitive-services/cognitive-services-apis-create-account#configure-an-environment-variable-for-authentication) for the key and service endpoint string, named `COMPUTER_VISION_SUBSCRIPTION_KEY` and `COMPUTER_VISION_ENDPOINT`, respectively.
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
1. Optionally, open the *Program.cs* file associated with the project and change project parameters:
   1. For ExtractText, optionally set `textRecognitionMode` to `TextRecognitionMode.Printed`.
   1. Optionally, replace <`LocalImage>` with the path and file name of a local image (will be ignored if not set).
   1. Optionally, set `remoteImageUrl` to a different image.
1. Run the program.

## Resources

* [Computer Vision service documentation](https://docs.microsoft.com/azure/cognitive-services/computer-vision/)
* [Computer Vision API - v2.0](https://westus.dev.cognitive.microsoft.com/docs/services/5adf991815e1060e6355ad44/operations/56f91f2e778daf14a499e1fa)
* [Microsoft.Azure.CognitiveServices.Vision.ComputerVision 3.2.0](https://www.nuget.org/packages/Microsoft.Azure.CognitiveServices.Vision.ComputerVision/3.2.0) NuGet package
