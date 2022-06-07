using Microsoft.Azure.CognitiveServices.Vision.ComputerVision;
using Microsoft.Azure.CognitiveServices.Vision.ComputerVision.Models;

namespace SigniSightBL
{
    public class OCRProcessor
    {
        public static ComputerVisionClient Authenticate(string endpoint, string key)
        {
            ComputerVisionClient client =
              new ComputerVisionClient(new ApiKeyServiceClientCredentials(key))
              { Endpoint = endpoint };
            return client;
        }
        public static async Task<string> ReadFileUrl(ComputerVisionClient client, string urlFile)
        {
            // Read text from URL
            var textHeaders = await client.ReadAsync(urlFile);
            // After the request, get the operation location (operation ID)
            string operationLocation = textHeaders.OperationLocation;
            Thread.Sleep(2000);

            // Retrieve the URI where the extracted text will be stored from the Operation-Location header.
            // We only need the ID and not the full URL
            const int numberOfCharsInOperationId = 36;
            string operationId = operationLocation.Substring(operationLocation.Length - numberOfCharsInOperationId);

            // Extract the text
            ReadOperationResult results;

            do
            {
                results = await client.GetReadResultAsync(Guid.Parse(operationId));
            }
            while ((results.Status == OperationStatusCodes.Running ||
                results.Status == OperationStatusCodes.NotStarted));

            // Display the found text.
            var list = "";
            var textUrlFileResults = results.AnalyzeResult.ReadResults;
            foreach (ReadResult page in textUrlFileResults)
            {
                foreach (Line line in page.Lines)
                {
                    list += line.Text + " ";
                }
            }
            return list.Trim();
        }
        public static async Task<string> RecognizePrintedTextLocal(ComputerVisionClient client)
        {
            var list = "";
            string localImage = @"C:\Users\shado\Desktop\Учло\albert-einstein-quotes-01-scaled.jpg";
            using (Stream stream = File.OpenRead(localImage))
            {
                // Get the recognized text
                OcrResult localFileOcrResult = await client.RecognizePrintedTextInStreamAsync(true, stream);

                foreach (var localRegion in localFileOcrResult.Regions)
                {
                    foreach (var line in localRegion.Lines)
                    {
                        foreach (var word in line.Words)
                        {
                            list += word.Text + " ";
                        }
                    }
                }
            }
            return list.Trim();
        }
        static byte[] GetImageAsByteArray(string imageFilePath)
        {
            using (FileStream fileStream =
                new FileStream(imageFilePath, FileMode.Open, FileAccess.Read))
            {
                BinaryReader binaryReader = new BinaryReader(fileStream);
                return binaryReader.ReadBytes((int)fileStream.Length);
            }
        }
    }
}
