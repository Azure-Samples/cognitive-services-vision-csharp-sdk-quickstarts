---
services: cognitive-services, custom vision
platforms: dotnet, c#
author: easyj2j
---

# Custom Vision C# SDK quickstart samples

See [Azure-Samples/cognitive-services-dotnet-sdk-samples](https://github.com/Azure-Samples/cognitive-services-dotnet-sdk-samples/tree/master/CustomVision) for up-to-date Custom Vision samples.

Notes:

* The samples linked to above use Microsoft.Azure.CognitiveServices.Vision.CustomVision.Training 0.10.0-preview. They also work when upgraded to CustomVision.Training 0.12.0-preview.
* ObjectDetection, ln 29: `var project = trainingApi.CreateProject("My New Project", null, objDetectionDomain.Id);`
  * If not using 'Limited trial' keys, an HttpOperationException: Forbidden is thrown.
  * When using 'Limited trial' keys and the number of projects = 2 (the max), an HttpOperationException: Bad Request is thrown.
  * See [Issue# 49](https://github.com/Azure-Samples/cognitive-services-dotnet-sdk-samples/issues/49)

## Getting Started

### Prerequisites

* You need Training and Prediction **subscription keys** for the Custom Vision service to run the samples. You can get free trial subscription keys from the [Custom Vision portal](https://customvision.ai/).
* Any edition of [Visual Studio 2017](https://www.visualstudio.com/downloads/).

### Quickstart

1. Clone or download the repository.
1. Navigate to the *CustomVision* folder.
1. Double-click the *CustomVision.sln* file to open the solution in Visual Studio.

## Resources

* [Custom Vision service documentation](https://docs.microsoft.com/azure/cognitive-services/Custom-Vision-Service/home)
* [Custom Vision Training API - v2.0](https://southcentralus.dev.cognitive.microsoft.com/docs/services/d0e77c63c39c4259a298830c15188310/operations/39b14cb5f7f34977a6e6a290)
* [Custom Vision Prediction API - v2.0](https://southcentralus.dev.cognitive.microsoft.com/docs/services/450e4ba4d72542e889d93fd7b8e960de/operations/5a6264bc40d86a0ef8b2c290)
* [Microsoft.Azure.CognitiveServices.Vision.CustomVision.Training 0.12.0-preview](https://www.nuget.org/packages/Microsoft.Azure.CognitiveServices.Vision.CustomVision.Training/0.12.0-preview) NuGet package
* [Microsoft.Azure.CognitiveServices.Vision.CustomVision.Prediction 0.10.0-preview](https://www.nuget.org/packages/Microsoft.Azure.CognitiveServices.Vision.CustomVision.Prediction/0.10.0-preview) NuGet package
