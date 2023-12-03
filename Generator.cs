using Azure;
using Azure.AI.OpenAI;

namespace ImageGenerator
{
    public class Generator : IGenerator
    {
        private readonly OpenAIClient _openAIClient;

        public Generator(OpenAIClient openAIClient)
        {
            _openAIClient = openAIClient;
        }

        public async Task<string> GetUrl(string promt)
        {           
            var imageGenerations = await _openAIClient.GetImageGenerationsAsync(
               new ImageGenerationOptions()
               {
                   Prompt = promt,
                   Size = ImageSize.Size256x256,
               });

            var imageUri = imageGenerations.Value.Data[0].Url;

            return imageUri.OriginalString;
        }
    }
}
