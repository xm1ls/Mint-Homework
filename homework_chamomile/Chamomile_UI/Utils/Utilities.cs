using System.IO;
using System.Text.Json;
using System.Threading.Tasks;
using System.Net.Http;
using Chamomile_Models.TableModels;

namespace Chamomile_UI.Utils
{
    public class Utilities
    {
        public static async Task<IEnumerable<Brand>> DeserializeBrandsAsync(HttpContent content)
        {
            using (Stream stream = await content.ReadAsStreamAsync())
            {
                return await JsonSerializer.DeserializeAsync<IEnumerable<Brand>>(stream);
            }
        }
    }
}
