using Microsoft.Azure.CognitiveServices.Vision.ComputerVision;
using Microsoft.Azure.CognitiveServices.Vision.ComputerVision.Models;

using System;
using System.IO;
using System.Threading.Tasks;

namespace ImageThumbnail
{
    class Program
    {
        // Download image and put in your bin/Debug/netcoreapp2.2 folder of your project:
        // https://github.com/Azure-Samples/cognitive-services-sample-data-files/tree/master/ComputerVision/Images
        // Or, you can just set the path to any appropriate image on your machine.
        private const string LOCAL_IMAGE = "objects.jpg";
        // URL image for detecting objects (image of man on skateboard)
        private const string URL_IMAGE = "https://moderatorsampleimages.blob.core.windows.net/samples/sample9.png";

        // Add your Computer Vision subscription key to your environment variables.
        static string SubscriptionKey = Environment.GetEnvironmentVariable("COMPUTER_VISION_SUBSCRIPTION_KEY");
		static string Endpoint = Environment.GetEnvironmentVariable("COMPUTER_VISION_ENDPOINT");

        private const int thumbnailWidth = 100;
        private const int thumbnailHeight = 100;

        static void Main(string[] args)
        {
			ComputerVisionClient client =
				new ComputerVisionClient(new ApiKeyServiceClientCredentials(SubscriptionKey))
				{ 
                    Endpoint = Endpoint; 
                };
            
            // Generate a thumbnail image from a URL and local image
            GenerateThumbnail(client, URL_IMAGE, LOCAL_IMAGE).Wait();
        }

      /*
       * GENERATE THUMBNAIL
       * Taking in a URL and local image, this example will generate a thumbnail image with specified width/height (pixels).
       * The thumbnail will be saved locally.
       */
      public static async Task GenerateThumbnail(ComputerVisionClient client, string urlImage, string localImage)
      {
          Console.WriteLine("----------------------------------------------------------");
          Console.WriteLine("GENERATE THUMBNAIL - URL & LOCAL IMAGE");
          Console.WriteLine();

          // Thumbnails will be saved locally in your bin\Debug\netcoreappx.x\ folder of this project.
          string localSavePath = @".";

          // URL
          Console.WriteLine("Generating thumbnail with URL image...");
          // Setting smartCropping to true enables the image to adjust its aspect ratio
          // to center on the area of interest in the image. Change the width/height, if desired.
          Stream thumbnailUrl = await client.GenerateThumbnailAsync(60, 60, urlImage, true);

          string imageNameUrl = Path.GetFileName(urlImage);
          string thumbnailFilePathUrl = Path.Combine(localSavePath, imageNameUrl.Insert(imageNameUrl.Length - 4, "_thumb"));


          Console.WriteLine("Saving thumbnail from URL image to " + thumbnailFilePathUrl);
          using (Stream file = File.Create(thumbnailFilePathUrl)) { thumbnailUrl.CopyTo(file); }

          Console.WriteLine();

          // LOCAL
          Console.WriteLine("Generating thumbnail with local image...");

          using (Stream imageStream = File.OpenRead(localImage))
          {

              Stream thumbnailLocal = await client.GenerateThumbnailInStreamAsync(100, 100, imageStream, smartCropping: true);

              string imageNameLocal = Path.GetFileName(localImage);
              string thumbnailFilePathLocal = Path.Combine(localSavePath,
                      imageNameLocal.Insert(imageNameLocal.Length - 4, "_thumb"));
              // Save to file
              Console.WriteLine("Saving thumbnail from local image to " + thumbnailFilePathLocal);
              using (Stream file = File.Create(thumbnailFilePathLocal)) { thumbnailLocal.CopyTo(file); }
          }
            Console.WriteLine();
        }
    }
}
